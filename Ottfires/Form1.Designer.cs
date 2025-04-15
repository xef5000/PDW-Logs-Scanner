namespace Ottfires
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonFileDialog = new System.Windows.Forms.Button();
            this.logFileLabel = new System.Windows.Forms.Label();
            this.scanStartButton = new System.Windows.Forms.Button();
            this.timerScan = new System.Windows.Forms.Timer(this.components);
            this.timerDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.scanLabel = new System.Windows.Forms.Label();
            this.appTokenTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupTokenTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.timerDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "test pushover";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // buttonFileDialog
            // 
            this.buttonFileDialog.Location = new System.Drawing.Point(12, 76);
            this.buttonFileDialog.Name = "buttonFileDialog";
            this.buttonFileDialog.Size = new System.Drawing.Size(421, 66);
            this.buttonFileDialog.TabIndex = 1;
            this.buttonFileDialog.Text = "Select log file";
            this.buttonFileDialog.UseVisualStyleBackColor = true;
            this.buttonFileDialog.Click += new System.EventHandler(this.buttonFileDialog_Click);
            // 
            // logFileLabel
            // 
            this.logFileLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logFileLabel.Location = new System.Drawing.Point(0, 0);
            this.logFileLabel.Name = "logFileLabel";
            this.logFileLabel.Size = new System.Drawing.Size(1195, 25);
            this.logFileLabel.TabIndex = 4;
            this.logFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scanStartButton
            // 
            this.scanStartButton.Location = new System.Drawing.Point(12, 148);
            this.scanStartButton.Name = "scanStartButton";
            this.scanStartButton.Size = new System.Drawing.Size(421, 66);
            this.scanStartButton.TabIndex = 1;
            this.scanStartButton.Text = "Start scanning";
            this.scanStartButton.UseVisualStyleBackColor = true;
            this.scanStartButton.Click += new System.EventHandler(this.scanStartButton_Click);
            // 
            // timerScan
            // 
            this.timerScan.Tick += new System.EventHandler(this.timerScan_Tick);
            // 
            // timerDelay
            // 
            this.timerDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerDelay.Location = new System.Drawing.Point(560, 229);
            this.timerDelay.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.timerDelay.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.timerDelay.Name = "timerDelay";
            this.timerDelay.Size = new System.Drawing.Size(125, 44);
            this.timerDelay.TabIndex = 5;
            this.timerDelay.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.timerDelay.ValueChanged += new System.EventHandler(this.timerDelay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Delay between each scan (in seconds)";
            // 
            // scanLabel
            // 
            this.scanLabel.AutoSize = true;
            this.scanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanLabel.Location = new System.Drawing.Point(88, 330);
            this.scanLabel.Name = "scanLabel";
            this.scanLabel.Size = new System.Drawing.Size(303, 111);
            this.scanLabel.TabIndex = 7;
            this.scanLabel.Text = "Status: Disabled\r\nScans: 0\r\nNotifications Sent: 0";
            // 
            // appTokenTextBox
            // 
            this.appTokenTextBox.Location = new System.Drawing.Point(705, 336);
            this.appTokenTextBox.Name = "appTokenTextBox";
            this.appTokenTextBox.Size = new System.Drawing.Size(421, 31);
            this.appTokenTextBox.TabIndex = 8;
            this.appTokenTextBox.TextChanged += new System.EventHandler(this.appTokenTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "App Token";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Group Token";
            // 
            // groupTokenTextBox
            // 
            this.groupTokenTextBox.Location = new System.Drawing.Point(705, 396);
            this.groupTokenTextBox.Name = "groupTokenTextBox";
            this.groupTokenTextBox.Size = new System.Drawing.Size(421, 31);
            this.groupTokenTextBox.TabIndex = 10;
            this.groupTokenTextBox.TextChanged += new System.EventHandler(this.groupTokenTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 509);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupTokenTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appTokenTextBox);
            this.Controls.Add(this.scanLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timerDelay);
            this.Controls.Add(this.logFileLabel);
            this.Controls.Add(this.scanStartButton);
            this.Controls.Add(this.buttonFileDialog);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "PDW Logs scanner";
            ((System.ComponentModel.ISupportInitialize)(this.timerDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonFileDialog;
        private System.Windows.Forms.Label logFileLabel;
        private System.Windows.Forms.Button scanStartButton;
        private System.Windows.Forms.Timer timerScan;
        private System.Windows.Forms.NumericUpDown timerDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scanLabel;
        private System.Windows.Forms.TextBox appTokenTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox groupTokenTextBox;
    }
}

