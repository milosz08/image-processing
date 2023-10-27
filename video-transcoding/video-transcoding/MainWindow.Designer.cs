namespace VideoTranscoding
{
    partial class MainWindow
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
            this.selectVideoFileTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectOutputVideoFileTextbox = new System.Windows.Forms.TextBox();
            this.selectOutputVideoFileButton = new System.Windows.Forms.Button();
            this.deleteOutputVideoFileButton = new System.Windows.Forms.Button();
            this.deleteVideoFileButton = new System.Windows.Forms.Button();
            this.selectVideoFileButton = new System.Windows.Forms.Button();
            this.openOutputDirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openVideoFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.videoCodecCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.audioCodecCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.heightResNumericbox = new System.Windows.Forms.NumericUpDown();
            this.widthResNumericbox = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.framesPerSecondNumericbox = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.videoBitrateNumericbox = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.audioBitrateNumericbox = new System.Windows.Forms.NumericUpDown();
            this.vlcExecutablePathTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.removeVlcExecutableButton = new System.Windows.Forms.Button();
            this.selectVlcExecutableButton = new System.Windows.Forms.Button();
            this.openVlcExecutableFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.convertAndSaveToFileButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightResNumericbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthResNumericbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framesPerSecondNumericbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBitrateNumericbox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audioBitrateNumericbox)).BeginInit();
            this.SuspendLayout();
            // 
            // selectVideoFileTextbox
            // 
            this.selectVideoFileTextbox.Enabled = false;
            this.selectVideoFileTextbox.Location = new System.Drawing.Point(12, 33);
            this.selectVideoFileTextbox.Name = "selectVideoFileTextbox";
            this.selectVideoFileTextbox.Size = new System.Drawing.Size(655, 20);
            this.selectVideoFileTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path to video file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output transcoded file path";
            // 
            // selectOutputVideoFileTextbox
            // 
            this.selectOutputVideoFileTextbox.Enabled = false;
            this.selectOutputVideoFileTextbox.Location = new System.Drawing.Point(12, 85);
            this.selectOutputVideoFileTextbox.Name = "selectOutputVideoFileTextbox";
            this.selectOutputVideoFileTextbox.Size = new System.Drawing.Size(655, 20);
            this.selectOutputVideoFileTextbox.TabIndex = 2;
            // 
            // selectOutputVideoFileButton
            // 
            this.selectOutputVideoFileButton.Location = new System.Drawing.Point(354, 59);
            this.selectOutputVideoFileButton.Name = "selectOutputVideoFileButton";
            this.selectOutputVideoFileButton.Size = new System.Drawing.Size(237, 23);
            this.selectOutputVideoFileButton.TabIndex = 4;
            this.selectOutputVideoFileButton.Text = "Choose path";
            this.selectOutputVideoFileButton.UseVisualStyleBackColor = true;
            this.selectOutputVideoFileButton.Click += new System.EventHandler(this.onSelectPathForOutputVideoFile);
            // 
            // deleteOutputVideoFileButton
            // 
            this.deleteOutputVideoFileButton.Enabled = false;
            this.deleteOutputVideoFileButton.Location = new System.Drawing.Point(597, 59);
            this.deleteOutputVideoFileButton.Name = "deleteOutputVideoFileButton";
            this.deleteOutputVideoFileButton.Size = new System.Drawing.Size(71, 23);
            this.deleteOutputVideoFileButton.TabIndex = 5;
            this.deleteOutputVideoFileButton.Text = "Delete";
            this.deleteOutputVideoFileButton.UseVisualStyleBackColor = true;
            this.deleteOutputVideoFileButton.Click += new System.EventHandler(this.onDeletePathForOutputVideoFile);
            // 
            // deleteVideoFileButton
            // 
            this.deleteVideoFileButton.Enabled = false;
            this.deleteVideoFileButton.Location = new System.Drawing.Point(597, 7);
            this.deleteVideoFileButton.Name = "deleteVideoFileButton";
            this.deleteVideoFileButton.Size = new System.Drawing.Size(71, 23);
            this.deleteVideoFileButton.TabIndex = 7;
            this.deleteVideoFileButton.Text = "Delete";
            this.deleteVideoFileButton.UseVisualStyleBackColor = true;
            this.deleteVideoFileButton.Click += new System.EventHandler(this.onDeletePathForVideoFile);
            // 
            // selectVideoFileButton
            // 
            this.selectVideoFileButton.Location = new System.Drawing.Point(354, 7);
            this.selectVideoFileButton.Name = "selectVideoFileButton";
            this.selectVideoFileButton.Size = new System.Drawing.Size(237, 23);
            this.selectVideoFileButton.TabIndex = 6;
            this.selectVideoFileButton.Text = "Choose file";
            this.selectVideoFileButton.UseVisualStyleBackColor = true;
            this.selectVideoFileButton.Click += new System.EventHandler(this.onSelectPathToVideoFile);
            // 
            // videoCodecCombobox
            // 
            this.videoCodecCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoCodecCombobox.FormattingEnabled = true;
            this.videoCodecCombobox.Items.AddRange(new object[] {
            "mp4v",
            "h264",
            "WMV1",
            "mp2v"});
            this.videoCodecCombobox.Location = new System.Drawing.Point(10, 39);
            this.videoCodecCombobox.Name = "videoCodecCombobox";
            this.videoCodecCombobox.Size = new System.Drawing.Size(121, 21);
            this.videoCodecCombobox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Video codec";
            // 
            // audioCodecCombobox
            // 
            this.audioCodecCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.audioCodecCombobox.FormattingEnabled = true;
            this.audioCodecCombobox.Items.AddRange(new object[] {
            "mp3",
            "vorb"});
            this.audioCodecCombobox.Location = new System.Drawing.Point(9, 41);
            this.audioCodecCombobox.Name = "audioCodecCombobox";
            this.audioCodecCombobox.Size = new System.Drawing.Size(121, 21);
            this.audioCodecCombobox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Audio codec";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.heightResNumericbox);
            this.groupBox1.Controls.Add(this.widthResNumericbox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.framesPerSecondNumericbox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.videoBitrateNumericbox);
            this.groupBox1.Controls.Add(this.videoCodecCombobox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 73);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(390, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "X";
            // 
            // heightResNumericbox
            // 
            this.heightResNumericbox.Location = new System.Drawing.Point(405, 39);
            this.heightResNumericbox.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.heightResNumericbox.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.heightResNumericbox.Name = "heightResNumericbox";
            this.heightResNumericbox.Size = new System.Drawing.Size(100, 20);
            this.heightResNumericbox.TabIndex = 18;
            this.heightResNumericbox.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            // 
            // widthResNumericbox
            // 
            this.widthResNumericbox.Location = new System.Drawing.Point(288, 39);
            this.widthResNumericbox.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.widthResNumericbox.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.widthResNumericbox.Name = "widthResNumericbox";
            this.widthResNumericbox.Size = new System.Drawing.Size(100, 20);
            this.widthResNumericbox.TabIndex = 17;
            this.widthResNumericbox.Value = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(525, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Frames per second";
            // 
            // framesPerSecondNumericbox
            // 
            this.framesPerSecondNumericbox.Location = new System.Drawing.Point(528, 39);
            this.framesPerSecondNumericbox.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.framesPerSecondNumericbox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.framesPerSecondNumericbox.Name = "framesPerSecondNumericbox";
            this.framesPerSecondNumericbox.Size = new System.Drawing.Size(117, 20);
            this.framesPerSecondNumericbox.TabIndex = 15;
            this.framesPerSecondNumericbox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dimensions (width x height)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bitrate";
            // 
            // videoBitrateNumericbox
            // 
            this.videoBitrateNumericbox.Location = new System.Drawing.Point(150, 39);
            this.videoBitrateNumericbox.Maximum = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            this.videoBitrateNumericbox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.videoBitrateNumericbox.Name = "videoBitrateNumericbox";
            this.videoBitrateNumericbox.Size = new System.Drawing.Size(117, 20);
            this.videoBitrateNumericbox.TabIndex = 10;
            this.videoBitrateNumericbox.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.audioCodecCombobox);
            this.groupBox2.Controls.Add(this.audioBitrateNumericbox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 76);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audio settings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bitrate";
            // 
            // audioBitrateNumericbox
            // 
            this.audioBitrateNumericbox.Location = new System.Drawing.Point(149, 41);
            this.audioBitrateNumericbox.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.audioBitrateNumericbox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.audioBitrateNumericbox.Name = "audioBitrateNumericbox";
            this.audioBitrateNumericbox.Size = new System.Drawing.Size(117, 20);
            this.audioBitrateNumericbox.TabIndex = 12;
            this.audioBitrateNumericbox.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // vlcExecutablePathTextbox
            // 
            this.vlcExecutablePathTextbox.Enabled = false;
            this.vlcExecutablePathTextbox.Location = new System.Drawing.Point(12, 136);
            this.vlcExecutablePathTextbox.Name = "vlcExecutablePathTextbox";
            this.vlcExecutablePathTextbox.Size = new System.Drawing.Size(655, 20);
            this.vlcExecutablePathTextbox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Path to VLC .exe file";
            // 
            // removeVlcExecutableButton
            // 
            this.removeVlcExecutableButton.Enabled = false;
            this.removeVlcExecutableButton.Location = new System.Drawing.Point(597, 110);
            this.removeVlcExecutableButton.Name = "removeVlcExecutableButton";
            this.removeVlcExecutableButton.Size = new System.Drawing.Size(71, 23);
            this.removeVlcExecutableButton.TabIndex = 17;
            this.removeVlcExecutableButton.Text = "Delete";
            this.removeVlcExecutableButton.UseVisualStyleBackColor = true;
            this.removeVlcExecutableButton.Click += new System.EventHandler(this.onDeleteVlcExecutablePath);
            // 
            // selectVlcExecutableButton
            // 
            this.selectVlcExecutableButton.Location = new System.Drawing.Point(354, 110);
            this.selectVlcExecutableButton.Name = "selectVlcExecutableButton";
            this.selectVlcExecutableButton.Size = new System.Drawing.Size(237, 23);
            this.selectVlcExecutableButton.TabIndex = 16;
            this.selectVlcExecutableButton.Text = "Choose .exe file";
            this.selectVlcExecutableButton.UseVisualStyleBackColor = true;
            this.selectVlcExecutableButton.Click += new System.EventHandler(this.onSelectVlcExecutablePath);
            // 
            // openVlcExecutableFileDialog
            // 
            this.openVlcExecutableFileDialog.Filter = "Executable (*.exe)|*.exe";
            // 
            // convertAndSaveToFileButton
            // 
            this.convertAndSaveToFileButton.Enabled = false;
            this.convertAndSaveToFileButton.Location = new System.Drawing.Point(12, 332);
            this.convertAndSaveToFileButton.Name = "convertAndSaveToFileButton";
            this.convertAndSaveToFileButton.Size = new System.Drawing.Size(654, 32);
            this.convertAndSaveToFileButton.TabIndex = 18;
            this.convertAndSaveToFileButton.Text = "Convert and save to file";
            this.convertAndSaveToFileButton.UseVisualStyleBackColor = true;
            this.convertAndSaveToFileButton.Click += new System.EventHandler(this.onConvertAndSaveToFile);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 374);
            this.Controls.Add(this.convertAndSaveToFileButton);
            this.Controls.Add(this.removeVlcExecutableButton);
            this.Controls.Add(this.selectVlcExecutableButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vlcExecutablePathTextbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteVideoFileButton);
            this.Controls.Add(this.selectVideoFileButton);
            this.Controls.Add(this.deleteOutputVideoFileButton);
            this.Controls.Add(this.selectOutputVideoFileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectOutputVideoFileTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectVideoFileTextbox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(695, 413);
            this.MinimumSize = new System.Drawing.Size(695, 413);
            this.Name = "MainWindow";
            this.Text = "Video transcoding";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightResNumericbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthResNumericbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framesPerSecondNumericbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBitrateNumericbox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audioBitrateNumericbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox selectVideoFileTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox selectOutputVideoFileTextbox;
        private System.Windows.Forms.Button selectOutputVideoFileButton;
        private System.Windows.Forms.Button deleteOutputVideoFileButton;
        private System.Windows.Forms.Button deleteVideoFileButton;
        private System.Windows.Forms.Button selectVideoFileButton;
        private System.Windows.Forms.FolderBrowserDialog openOutputDirDialog;
        private System.Windows.Forms.OpenFileDialog openVideoFileDialog;
        private System.Windows.Forms.ComboBox videoCodecCombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox audioCodecCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox vlcExecutablePathTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button removeVlcExecutableButton;
        private System.Windows.Forms.Button selectVlcExecutableButton;
        private System.Windows.Forms.OpenFileDialog openVlcExecutableFileDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown videoBitrateNumericbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown audioBitrateNumericbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown framesPerSecondNumericbox;
        private System.Windows.Forms.Button convertAndSaveToFileButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown heightResNumericbox;
        private System.Windows.Forms.NumericUpDown widthResNumericbox;
    }
}

