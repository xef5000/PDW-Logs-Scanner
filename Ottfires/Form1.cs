using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ottfires
{
    public partial class Form1 : Form
    {
        private string logFile;
        private int lastSize = 0;

        private static readonly HttpClient client = new HttpClient();
        private const string PushoverApiUrl = "https://api.pushover.net/1/messages.json";
        private int scans, notifications = 0;
        private string appToken = "";
        private string groupToken = "";
        VariableManager manager = new VariableManager("tokens.txt");


        /// <summary>
        /// Sends a notification message via the Pushover API.
        /// </summary>
        /// <param name="apiToken">Your Pushover application's API token.</param>
        /// <param name="userKey">The recipient user or group key.</param>
        /// <param name="message">The message content to send.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public static async Task SendPushoverNotificationAsync(string apiToken, string userKey, string message)
        {
            // Basic input validation
            if (string.IsNullOrWhiteSpace(apiToken) || string.IsNullOrWhiteSpace(userKey) || string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine("Error: API Token, User Key, and Message cannot be empty.");
                // Consider throwing an ArgumentException here in a real application
                return;
            }

            // 1. Create the dictionary of parameters
            var parameters = new Dictionary<string, string>
        {
            { "token", apiToken },
            { "user", userKey },
            { "message", message }
            // Add other optional Pushover parameters here if needed
            // e.g., { "title", "My App Notification" }, { "priority", "1" }
        };

            // 2. Create the HttpContent using FormUrlEncodedContent
            // This automatically handles URL encoding the values and sets the
            // Content-Type header to "application/x-www-form-urlencoded".
            var encodedContent = new FormUrlEncodedContent(parameters);

            Console.WriteLine($"Sending POST request to {PushoverApiUrl}...");
            Console.WriteLine($" - Token: {apiToken.Substring(0, Math.Min(apiToken.Length, 5))}..."); // Don't log full token usually
            Console.WriteLine($" - User: {userKey}");
            Console.WriteLine($" - Message: {message}");

            try
            {
                // 3. Send the POST request
                HttpResponseMessage response = await client.PostAsync(PushoverApiUrl, encodedContent);

                // 4. Read the response content (useful for debugging or getting request ID)
                string responseBody = await response.Content.ReadAsStringAsync();

                // 5. Check if the request was successful
                if (response.IsSuccessStatusCode) // Status code 200-299
                {
                    Console.WriteLine("--- Success ---");
                    Console.WriteLine($"Status Code: {response.StatusCode}");
                    Console.WriteLine("Response Body:");
                    Console.WriteLine(responseBody); // Pushover returns JSON with status and request ID
                }
                else
                {
                    Console.WriteLine("--- Error ---");
                    Console.WriteLine($"Status Code: {response.StatusCode} ({response.ReasonPhrase})");
                    Console.WriteLine("Response Body:");
                    Console.WriteLine(responseBody); // Pushover often returns JSON with error details
                }

                // Optionally, you could use response.EnsureSuccessStatusCode();
                // which will throw an HttpRequestException if the status code is not successful.
                // response.EnsureSuccessStatusCode();
                // Console.WriteLine("Notification sent successfully!"); // Only reached if successful

            }
            catch (HttpRequestException e)
            {
                // Handle network errors, DNS errors, server unreachable, etc.
                Console.WriteLine($"HTTP Request Error: {e.Message}");
                // e.InnerException might contain more details
            }
            catch (TaskCanceledException ex) // Handle timeouts
            {
                Console.WriteLine($"Request timed out: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle other potential errors
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
        public Form1()
        {
            InitializeComponent();
            updateScanLabel();
            loadTokens();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            sendPushOver("test");
        }

        private async void sendPushOver(string message)
        {
            notifications++;
            await SendPushoverNotificationAsync(this.appToken, this.groupToken, message);
        }

        private void buttonFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Log file: select your log file...";
            openFileDialog1.FileName = "";
            openFileDialog1.DefaultExt = "log";
            openFileDialog1.Filter = "Log file (*.log)|*.log|All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (openFileDialog1.FileName == "") return;
            logFileLabel.Text = "Log file \"" + openFileDialog1.FileName + "\""; // Mise a jour du label du fichier ouvert
            this.logFile = openFileDialog1.FileName;
        }

        private void scanStartButton_Click(object sender, EventArgs e)
        {
            if (this.logFile == null)
            {
                MessageBox.Show("Please select a log file to scan first!");
                return;
            }
            lastSize = File.ReadAllText(logFile, Encoding.Default).Length;
            timerScan.Start();
            updateScanLabel();
            timerDelay_ValueChanged(null, null);
        }

        private void timerDelay_ValueChanged(object sender, EventArgs e)
        {
            timerScan.Interval = Convert.ToInt32(timerDelay.Value * 1000);
        }

        private void updateScanLabel()
        {
            scanLabel.Text = "Status: " + (timerScan.Enabled ? "Enabled" : "Disabled") + "\n" +
                "Scans: " + scans + "\n" +
                "Notifications sent: " + notifications;
        }

        private void appTokenTextBox_TextChanged(object sender, EventArgs e)
        {
            this.appToken = appTokenTextBox.Text;
            saveTokens();
        }

        private void loadTokens()
        {
            manager.GetVariables();
            this.appToken = manager.FirstVariable;
            this.groupToken = manager.SecondVariable;
            appTokenTextBox.Text = this.appToken;
            groupTokenTextBox.Text = this.groupToken;
        }

        private void saveTokens()
        {
            manager.SaveVariables(this.appToken, this.groupToken);
        }

        private void groupTokenTextBox_TextChanged(object sender, EventArgs e)
        {
            this.groupToken = groupTokenTextBox.Text;
            saveTokens();
        }

        private void timerScan_Tick(object sender, EventArgs e)
        {
            scans++;
            updateScanLabel();
            string logs = File.ReadAllText(logFile, Encoding.Default);
            int size = File.ReadAllText(logFile, Encoding.Default).Length;
            if (size > lastSize)
            {
                string newText = logs.Substring(lastSize - 1);
                if (newText.Contains("POCSAG-3"))
                {
                    string pattern = @"512\s+(.*)$";
                    Match match = Regex.Match(newText, pattern);
                    if (match.Success)
                    {
                        // Group 1 contains all the text after "512"
                        string result = match.Groups[1].Value;
                        sendPushOver(result);
                    }
                }
                lastSize = size;
            }
        }
    }

    public class VariableManager
    {
        // --- Private Fields ---
        // These will hold the variables in memory after loading
        private string _firstVariable; // Using nullable reference types (string?) is good practice in modern .NET
        private string _secondVariable;

        // Path to the file used for storage
        private readonly string _filePath;

        // --- Public Properties ---
        // Provide read-only access to the loaded variables
        public string FirstVariable => _firstVariable;
        public string SecondVariable => _secondVariable;

        // --- Constructor ---
        /// <summary>
        /// Initializes the VariableManager, setting the path for the data file.
        /// </summary>
        /// <param name="fileName">The name of the file to use for storing variables (e.g., "settings.txt").
        /// The file will be created/accessed in the application's current directory unless a full path is provided.
        /// </param>
        public VariableManager(string fileName = "app_variables.txt") // Default filename if none provided
        {
            // --- File Path Determination ---
            // For simplicity, this uses the application's current working directory.
            // CONSIDER: For robust applications, use a dedicated location like AppData:
            // string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            // string appFolderPath = Path.Combine(appDataPath, "YourAppName"); // Use your actual app name
            // Directory.CreateDirectory(appFolderPath); // Ensure the directory exists
            // _filePath = Path.Combine(appFolderPath, fileName);

            _filePath = Path.GetFullPath(fileName); // Gets the full path relative to the current directory

            Console.WriteLine($"[VariableManager] Using data file: {_filePath}"); // Helpful for debugging
        }

        // --- Public Methods ---

        /// <summary>
        /// Loads the two variables from the specified file into the private fields.
        /// If the file doesn't exist or has incorrect format, the fields might remain null or only partially loaded.
        /// </summary>
        public void GetVariables() // Renamed to follow C# conventions (PascalCase)
        {
            // Reset/default values before attempting to read
            _firstVariable = null;
            _secondVariable = null;
            Console.WriteLine($"[VariableManager] Attempting to load variables from '{_filePath}'...");

            try
            {
                if (!File.Exists(_filePath))
                {
                    Console.WriteLine($"[VariableManager] File not found. Variables will use default values (null).");
                    return; // Nothing to load, exit the method
                }

                // Read all lines from the file. This is simple but loads the whole file into memory.
                // For very large files, consider using a StreamReader line by line.
                string[] lines = File.ReadAllLines(_filePath);

                // Assign lines to variables if they exist in the file
                if (lines.Length >= 1)
                {
                    _firstVariable = lines[0];
                    Console.WriteLine($"[VariableManager] Loaded FirstVariable.");
                }
                else
                {
                    Console.WriteLine($"[VariableManager] Warning: File is empty or missing first line. FirstVariable remains null.");
                }

                if (lines.Length >= 2)
                {
                    _secondVariable = lines[1];
                    Console.WriteLine($"[VariableManager] Loaded SecondVariable.");
                }
                else if (lines.Length == 1) // Only print warning if second line specifically is missing
                {
                    Console.WriteLine($"[VariableManager] Warning: File has only one line. SecondVariable remains null.");
                }
                // Ignore any lines beyond the second one in this simple implementation
            }
            // Catch specific exceptions related to file access
            catch (IOException ex)
            {
                Console.WriteLine($"[VariableManager] Error reading file '{_filePath}': {ex.Message}");
                // Variables remain at their default (null) values
            }
            // Catch other potential errors (permissions, etc.)
            catch (Exception ex)
            {
                Console.WriteLine($"[VariableManager] An unexpected error occurred loading variables: {ex.Message}");
                // Variables remain at their default (null) values
            }
        }

        /// <summary>
        /// Saves the two provided string variables to the specified file,
        /// overwriting its current content. Creates the file if it doesn't exist.
        /// </summary>
        /// <param name="firstVar">The first string variable to save.</param>
        /// <param name="secondVar">The second string variable to save.</param>
        public void SaveVariables(string firstVar, string secondVar) // Corrected typo, using PascalCase and nullable types
        {
            Console.WriteLine($"[VariableManager] Attempting to save variables to '{_filePath}'...");
            try
            {
                // Prepare the lines to write. Use empty string if null is passed.
                string[] lines = { firstVar ?? string.Empty, secondVar ?? string.Empty };

                // Write the lines to the file.
                // This will create the file if it doesn't exist,
                // and overwrite it completely if it does.
                File.WriteAllLines(_filePath, lines);

                Console.WriteLine($"[VariableManager] Variables saved successfully.");

                // Optional: Update the internal state immediately after saving if desired
                // _firstVariable = firstVar;
                // _secondVariable = secondVar;
            }
            // Catch specific exceptions related to file access
            catch (IOException ex)
            {
                Console.WriteLine($"[VariableManager] Error writing file '{_filePath}': {ex.Message}");
                // Decide how to handle: Log, re-throw, notify user, etc.
                // throw; // Re-throwing might be appropriate depending on your app's error handling strategy
            }
            // Catch other potential errors (permissions, disk full, etc.)
            catch (Exception ex)
            {
                Console.WriteLine($"[VariableManager] An unexpected error occurred saving variables: {ex.Message}");
                // Decide how to handle
                // throw;
            }
        }
    }

}

