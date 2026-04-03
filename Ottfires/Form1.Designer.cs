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
            this.pocsag1CheckBox = new System.Windows.Forms.CheckBox();
            this.pocsag2CheckBox = new System.Windows.Forms.CheckBox();
            this.pocsag3CheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.timerDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 34);
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
            this.buttonFileDialog.Location = new System.Drawing.Point(6, 40);
            this.buttonFileDialog.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFileDialog.Name = "buttonFileDialog";
            this.buttonFileDialog.Size = new System.Drawing.Size(210, 34);
            this.buttonFileDialog.TabIndex = 1;
            this.buttonFileDialog.Text = "Select log file";
            this.buttonFileDialog.UseVisualStyleBackColor = true;
            this.buttonFileDialog.Click += new System.EventHandler(this.buttonFileDialog_Click);
            // 
            // logFileLabel
            // 
            this.logFileLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logFileLabel.Location = new System.Drawing.Point(0, 0);
            this.logFileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logFileLabel.Name = "logFileLabel";
            this.logFileLabel.Size = new System.Drawing.Size(598, 13);
            this.logFileLabel.TabIndex = 4;
            this.logFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scanStartButton
            // 
            this.scanStartButton.Location = new System.Drawing.Point(6, 77);
            this.scanStartButton.Margin = new System.Windows.Forms.Padding(2);
            this.scanStartButton.Name = "scanStartButton";
            this.scanStartButton.Size = new System.Drawing.Size(210, 34);
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
            this.timerDelay.Location = new System.Drawing.Point(280, 119);
            this.timerDelay.Margin = new System.Windows.Forms.Padding(2);
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
            this.timerDelay.Size = new System.Drawing.Size(62, 26);
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
            this.label1.Location = new System.Drawing.Point(6, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Delay between each scan (in seconds)";
            // 
            // scanLabel
            // 
            this.scanLabel.AutoSize = true;
            this.scanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanLabel.Location = new System.Drawing.Point(44, 172);
            this.scanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scanLabel.Name = "scanLabel";
            this.scanLabel.Size = new System.Drawing.Size(151, 60);
            this.scanLabel.TabIndex = 7;
            this.scanLabel.Text = "Status: Disabled\r\nScans: 0\r\nNotifications Sent: 0";
            // 
            // appTokenTextBox
            // 
            this.appTokenTextBox.Location = new System.Drawing.Point(352, 175);
            this.appTokenTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.appTokenTextBox.Name = "appTokenTextBox";
            this.appTokenTextBox.Size = new System.Drawing.Size(212, 20);
            this.appTokenTextBox.TabIndex = 8;
            this.appTokenTextBox.TextChanged += new System.EventHandler(this.appTokenTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "App Token";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Group Token";
            // 
            // groupTokenTextBox
            // 
            this.groupTokenTextBox.Location = new System.Drawing.Point(352, 206);
            this.groupTokenTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupTokenTextBox.Name = "groupTokenTextBox";
            this.groupTokenTextBox.Size = new System.Drawing.Size(212, 20);
            this.groupTokenTextBox.TabIndex = 10;
            this.groupTokenTextBox.TextChanged += new System.EventHandler(this.groupTokenTextBox_TextChanged);
            // 
            // pocsag1CheckBox
            // 
            this.pocsag1CheckBox.AutoSize = true;
            this.pocsag1CheckBox.Location = new System.Drawing.Point(463, 40);
            this.pocsag1CheckBox.Name = "pocsag1CheckBox";
            this.pocsag1CheckBox.Size = new System.Drawing.Size(79, 17);
            this.pocsag1CheckBox.TabIndex = 12;
            this.pocsag1CheckBox.Text = "POCSAG 1";
            this.pocsag1CheckBox.UseVisualStyleBackColor = true;
            this.pocsag1CheckBox.CheckedChanged += new System.EventHandler(this.pocsagCheckBox_CheckedChanged);
            // 
            // pocsag2CheckBox
            // 
            this.pocsag2CheckBox.AutoSize = true;
            this.pocsag2CheckBox.Location = new System.Drawing.Point(463, 63);
            this.pocsag2CheckBox.Name = "pocsag2CheckBox";
            this.pocsag2CheckBox.Size = new System.Drawing.Size(79, 17);
            this.pocsag2CheckBox.TabIndex = 13;
            this.pocsag2CheckBox.Text = "POCSAG 2";
            this.pocsag2CheckBox.UseVisualStyleBackColor = true;
            this.pocsag2CheckBox.CheckedChanged += new System.EventHandler(this.pocsagCheckBox_CheckedChanged);
            // 
            // pocsag3CheckBox
            // 
            this.pocsag3CheckBox.AutoSize = true;
            this.pocsag3CheckBox.Location = new System.Drawing.Point(463, 86);
            this.pocsag3CheckBox.Name = "pocsag3CheckBox";
            this.pocsag3CheckBox.Size = new System.Drawing.Size(79, 17);
            this.pocsag3CheckBox.TabIndex = 14;
            this.pocsag3CheckBox.Text = "POCSAG 3";
            this.pocsag3CheckBox.UseVisualStyleBackColor = true;
            this.pocsag3CheckBox.CheckedChanged += new System.EventHandler(this.pocsagCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 265);
            this.Controls.Add(this.pocsag3CheckBox);
            this.Controls.Add(this.pocsag2CheckBox);
            this.Controls.Add(this.pocsag1CheckBox);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.CheckBox pocsag1CheckBox;
        private System.Windows.Forms.CheckBox pocsag2CheckBox;
        private System.Windows.Forms.CheckBox pocsag3CheckBox;
    }
}

