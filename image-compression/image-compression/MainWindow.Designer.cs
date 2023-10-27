namespace ImageCompression
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
            this.tiffConvertAlgCombobox = new System.Windows.Forms.ComboBox();
            this.insertDataButton = new System.Windows.Forms.Button();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.imageToConvertTextbox = new System.Windows.Forms.TextBox();
            this.insertPathButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveDirPathTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.jpegPictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pngPictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tiffPictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bmpPictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gifPictureBox = new System.Windows.Forms.PictureBox();
            this.selectOutputDirectoryControl = new System.Windows.Forms.FolderBrowserDialog();
            this.deleteSaveImagesPathButton = new System.Windows.Forms.Button();
            this.deleteInputImagePathButton = new System.Windows.Forms.Button();
            this.openInputFileImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.clearImageButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.jpegQualityPictureBox = new System.Windows.Forms.PictureBox();
            this.qualityTrackBar = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.tiffAlgorithmPictureBox = new System.Windows.Forms.PictureBox();
            this.jpegSelectedAlgLabel = new System.Windows.Forms.Label();
            this.tiffDensityAlgLabel = new System.Windows.Forms.Label();
            this.resultsGridView = new System.Windows.Forms.DataGridView();
            this.PNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JPEG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIFF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JPEGC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIFFA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.jpegShowAllFormButton = new System.Windows.Forms.Button();
            this.tiffShowAllFormButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jpegPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pngPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiffPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmpPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jpegQualityPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiffAlgorithmPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tiffConvertAlgCombobox
            // 
            this.tiffConvertAlgCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tiffConvertAlgCombobox.Enabled = false;
            this.tiffConvertAlgCombobox.FormattingEnabled = true;
            this.tiffConvertAlgCombobox.Items.AddRange(new object[] {
            "NONE",
            "LZW",
            "CCITT3",
            "CCITT4",
            "RLE"});
            this.tiffConvertAlgCombobox.Location = new System.Drawing.Point(1049, 388);
            this.tiffConvertAlgCombobox.Name = "tiffConvertAlgCombobox";
            this.tiffConvertAlgCombobox.Size = new System.Drawing.Size(240, 21);
            this.tiffConvertAlgCombobox.TabIndex = 39;
            this.tiffConvertAlgCombobox.SelectedIndexChanged += new System.EventHandler(this.onChangeTiffAlgorithm);
            // 
            // insertDataButton
            // 
            this.insertDataButton.Enabled = false;
            this.insertDataButton.Location = new System.Drawing.Point(931, 6);
            this.insertDataButton.Name = "insertDataButton";
            this.insertDataButton.Size = new System.Drawing.Size(358, 36);
            this.insertDataButton.TabIndex = 14;
            this.insertDataButton.Text = "Insert  and load data";
            this.insertDataButton.UseVisualStyleBackColor = true;
            this.insertDataButton.Click += new System.EventHandler(this.onInsertImagesAndConvert);
            // 
            // selectImageButton
            // 
            this.selectImageButton.Location = new System.Drawing.Point(479, 58);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(378, 23);
            this.selectImageButton.TabIndex = 13;
            this.selectImageButton.Text = "Pick converting file";
            this.selectImageButton.UseVisualStyleBackColor = true;
            this.selectImageButton.Click += new System.EventHandler(this.onSelectImageToConvert);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Path to converting file";
            // 
            // imageToConvertTextbox
            // 
            this.imageToConvertTextbox.Enabled = false;
            this.imageToConvertTextbox.Location = new System.Drawing.Point(128, 6);
            this.imageToConvertTextbox.Name = "imageToConvertTextbox";
            this.imageToConvertTextbox.Size = new System.Drawing.Size(797, 20);
            this.imageToConvertTextbox.TabIndex = 11;
            // 
            // insertPathButton
            // 
            this.insertPathButton.Location = new System.Drawing.Point(10, 58);
            this.insertPathButton.Name = "insertPathButton";
            this.insertPathButton.Size = new System.Drawing.Size(385, 23);
            this.insertPathButton.TabIndex = 10;
            this.insertPathButton.Text = "Pick convert path";
            this.insertPathButton.UseVisualStyleBackColor = true;
            this.insertPathButton.Click += new System.EventHandler(this.onSelectSavePathDir);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Path to saved converted files";
            // 
            // saveDirPathTextbox
            // 
            this.saveDirPathTextbox.Enabled = false;
            this.saveDirPathTextbox.Location = new System.Drawing.Point(163, 34);
            this.saveDirPathTextbox.Name = "saveDirPathTextbox";
            this.saveDirPathTextbox.Size = new System.Drawing.Size(762, 20);
            this.saveDirPathTextbox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "JPEG";
            // 
            // jpegPictureBox
            // 
            this.jpegPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jpegPictureBox.Location = new System.Drawing.Point(530, 106);
            this.jpegPictureBox.Name = "jpegPictureBox";
            this.jpegPictureBox.Size = new System.Drawing.Size(240, 240);
            this.jpegPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jpegPictureBox.TabIndex = 20;
            this.jpegPictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "PNG";
            // 
            // pngPictureBox
            // 
            this.pngPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pngPictureBox.Location = new System.Drawing.Point(271, 106);
            this.pngPictureBox.Name = "pngPictureBox";
            this.pngPictureBox.Size = new System.Drawing.Size(240, 240);
            this.pngPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pngPictureBox.TabIndex = 18;
            this.pngPictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Original";
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalPictureBox.Location = new System.Drawing.Point(10, 106);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(240, 240);
            this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalPictureBox.TabIndex = 16;
            this.originalPictureBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "TIFF";
            // 
            // tiffPictureBox
            // 
            this.tiffPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tiffPictureBox.Location = new System.Drawing.Point(10, 406);
            this.tiffPictureBox.Name = "tiffPictureBox";
            this.tiffPictureBox.Size = new System.Drawing.Size(240, 240);
            this.tiffPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tiffPictureBox.TabIndex = 22;
            this.tiffPictureBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "BMP";
            // 
            // bmpPictureBox
            // 
            this.bmpPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bmpPictureBox.Location = new System.Drawing.Point(271, 406);
            this.bmpPictureBox.Name = "bmpPictureBox";
            this.bmpPictureBox.Size = new System.Drawing.Size(240, 240);
            this.bmpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bmpPictureBox.TabIndex = 24;
            this.bmpPictureBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(529, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "GIF";
            // 
            // gifPictureBox
            // 
            this.gifPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gifPictureBox.Location = new System.Drawing.Point(530, 406);
            this.gifPictureBox.Name = "gifPictureBox";
            this.gifPictureBox.Size = new System.Drawing.Size(240, 240);
            this.gifPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gifPictureBox.TabIndex = 26;
            this.gifPictureBox.TabStop = false;
            // 
            // selectOutputDirectoryControl
            // 
            this.selectOutputDirectoryControl.ShowNewFolderButton = false;
            // 
            // deleteSaveImagesPathButton
            // 
            this.deleteSaveImagesPathButton.Location = new System.Drawing.Point(401, 58);
            this.deleteSaveImagesPathButton.Name = "deleteSaveImagesPathButton";
            this.deleteSaveImagesPathButton.Size = new System.Drawing.Size(62, 23);
            this.deleteSaveImagesPathButton.TabIndex = 28;
            this.deleteSaveImagesPathButton.Text = "Delete";
            this.deleteSaveImagesPathButton.UseVisualStyleBackColor = true;
            this.deleteSaveImagesPathButton.Click += new System.EventHandler(this.onDeleteSelectedOutputDir);
            // 
            // deleteInputImagePathButton
            // 
            this.deleteInputImagePathButton.Location = new System.Drawing.Point(863, 58);
            this.deleteInputImagePathButton.Name = "deleteInputImagePathButton";
            this.deleteInputImagePathButton.Size = new System.Drawing.Size(62, 23);
            this.deleteInputImagePathButton.TabIndex = 29;
            this.deleteInputImagePathButton.Text = "Delete";
            this.deleteInputImagePathButton.UseVisualStyleBackColor = true;
            this.deleteInputImagePathButton.Click += new System.EventHandler(this.onDeleteSelectInputImage);
            // 
            // openInputFileImageDialog
            // 
            this.openInputFileImageDialog.Filter = "Image Files (*.tiff;*.bmp;*.jpg;*.jpeg,*.png)|*.TIFF;**.BMP;*.JPG;*.JPEG;*.PNG";
            // 
            // clearImageButton
            // 
            this.clearImageButton.Enabled = false;
            this.clearImageButton.Location = new System.Drawing.Point(931, 48);
            this.clearImageButton.Name = "clearImageButton";
            this.clearImageButton.Size = new System.Drawing.Size(358, 33);
            this.clearImageButton.TabIndex = 30;
            this.clearImageButton.Text = "Clear";
            this.clearImageButton.UseVisualStyleBackColor = true;
            this.clearImageButton.Click += new System.EventHandler(this.onClearImagesData);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(788, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "JPEG - quality level";
            // 
            // jpegQualityPictureBox
            // 
            this.jpegQualityPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jpegQualityPictureBox.Location = new System.Drawing.Point(789, 106);
            this.jpegQualityPictureBox.Name = "jpegQualityPictureBox";
            this.jpegQualityPictureBox.Size = new System.Drawing.Size(240, 240);
            this.jpegQualityPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jpegQualityPictureBox.TabIndex = 34;
            this.jpegQualityPictureBox.TabStop = false;
            // 
            // qualityTrackBar
            // 
            this.qualityTrackBar.Enabled = false;
            this.qualityTrackBar.Location = new System.Drawing.Point(789, 383);
            this.qualityTrackBar.Maximum = 100;
            this.qualityTrackBar.Minimum = 1;
            this.qualityTrackBar.Name = "qualityTrackBar";
            this.qualityTrackBar.Size = new System.Drawing.Size(240, 45);
            this.qualityTrackBar.SmallChange = 5;
            this.qualityTrackBar.TabIndex = 36;
            this.qualityTrackBar.TickFrequency = 5;
            this.qualityTrackBar.Value = 100;
            this.qualityTrackBar.ValueChanged += new System.EventHandler(this.onChangeJpegQuality);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1048, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "TIFF - compression algorithm";
            // 
            // tiffAlgorithmPictureBox
            // 
            this.tiffAlgorithmPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tiffAlgorithmPictureBox.Location = new System.Drawing.Point(1049, 106);
            this.tiffAlgorithmPictureBox.Name = "tiffAlgorithmPictureBox";
            this.tiffAlgorithmPictureBox.Size = new System.Drawing.Size(240, 240);
            this.tiffAlgorithmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tiffAlgorithmPictureBox.TabIndex = 37;
            this.tiffAlgorithmPictureBox.TabStop = false;
            // 
            // jpegSelectedAlgLabel
            // 
            this.jpegSelectedAlgLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jpegSelectedAlgLabel.Location = new System.Drawing.Point(908, 88);
            this.jpegSelectedAlgLabel.Name = "jpegSelectedAlgLabel";
            this.jpegSelectedAlgLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.jpegSelectedAlgLabel.Size = new System.Drawing.Size(123, 13);
            this.jpegSelectedAlgLabel.TabIndex = 40;
            this.jpegSelectedAlgLabel.Text = "100 %";
            this.jpegSelectedAlgLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tiffDensityAlgLabel
            // 
            this.tiffDensityAlgLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tiffDensityAlgLabel.Location = new System.Drawing.Point(1198, 90);
            this.tiffDensityAlgLabel.Name = "tiffDensityAlgLabel";
            this.tiffDensityAlgLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tiffDensityAlgLabel.Size = new System.Drawing.Size(91, 13);
            this.tiffDensityAlgLabel.TabIndex = 41;
            this.tiffDensityAlgLabel.Text = "BRAK";
            this.tiffDensityAlgLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // resultsGridView
            // 
            this.resultsGridView.AllowUserToAddRows = false;
            this.resultsGridView.AllowUserToDeleteRows = false;
            this.resultsGridView.AllowUserToResizeColumns = false;
            this.resultsGridView.AllowUserToResizeRows = false;
            this.resultsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PNG,
            this.JPEG,
            this.TIFF,
            this.BMP,
            this.GIF,
            this.JPEGC,
            this.TIFFA});
            this.resultsGridView.Location = new System.Drawing.Point(789, 473);
            this.resultsGridView.MultiSelect = false;
            this.resultsGridView.Name = "resultsGridView";
            this.resultsGridView.ReadOnly = true;
            this.resultsGridView.RowHeadersWidth = 60;
            this.resultsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.resultsGridView.Size = new System.Drawing.Size(498, 80);
            this.resultsGridView.TabIndex = 44;
            // 
            // PNG
            // 
            this.PNG.HeaderText = "PNG";
            this.PNG.Name = "PNG";
            this.PNG.ReadOnly = true;
            // 
            // JPEG
            // 
            this.JPEG.HeaderText = "JPEG";
            this.JPEG.Name = "JPEG";
            this.JPEG.ReadOnly = true;
            // 
            // TIFF
            // 
            this.TIFF.HeaderText = "TIFF";
            this.TIFF.Name = "TIFF";
            this.TIFF.ReadOnly = true;
            // 
            // BMP
            // 
            this.BMP.HeaderText = "BMP";
            this.BMP.Name = "BMP";
            this.BMP.ReadOnly = true;
            // 
            // GIF
            // 
            this.GIF.HeaderText = "GIF";
            this.GIF.Name = "GIF";
            this.GIF.ReadOnly = true;
            // 
            // JPEGC
            // 
            this.JPEGC.HeaderText = "JPEG QLT";
            this.JPEGC.Name = "JPEGC";
            this.JPEGC.ReadOnly = true;
            // 
            // TIFFA
            // 
            this.TIFFA.HeaderText = "TIFF ALG";
            this.TIFFA.Name = "TIFFA";
            this.TIFFA.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(788, 452);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Results";
            // 
            // jpegShowAllFormButton
            // 
            this.jpegShowAllFormButton.Enabled = false;
            this.jpegShowAllFormButton.Location = new System.Drawing.Point(789, 418);
            this.jpegShowAllFormButton.Name = "jpegShowAllFormButton";
            this.jpegShowAllFormButton.Size = new System.Drawing.Size(240, 23);
            this.jpegShowAllFormButton.TabIndex = 50;
            this.jpegShowAllFormButton.Text = "Show all";
            this.jpegShowAllFormButton.UseVisualStyleBackColor = true;
            this.jpegShowAllFormButton.Click += new System.EventHandler(this.onShowAllJpegQualities);
            // 
            // tiffShowAllFormButton
            // 
            this.tiffShowAllFormButton.Enabled = false;
            this.tiffShowAllFormButton.Location = new System.Drawing.Point(1049, 418);
            this.tiffShowAllFormButton.Name = "tiffShowAllFormButton";
            this.tiffShowAllFormButton.Size = new System.Drawing.Size(240, 23);
            this.tiffShowAllFormButton.TabIndex = 51;
            this.tiffShowAllFormButton.Text = "Show all";
            this.tiffShowAllFormButton.UseVisualStyleBackColor = true;
            this.tiffShowAllFormButton.Click += new System.EventHandler(this.onShowAllTiffAlgorithms);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 23);
            this.button1.TabIndex = 52;
            this.button1.Tag = "original";
            this.button1.Text = "Show detailed image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onOpenBigImage);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 23);
            this.button2.TabIndex = 53;
            this.button2.Tag = "png";
            this.button2.Text = "Show detailed image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.onOpenBigImage);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(530, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 23);
            this.button3.TabIndex = 54;
            this.button3.Tag = "jpeg";
            this.button3.Text = "Show detailed image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.onOpenBigImage);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(789, 352);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 23);
            this.button4.TabIndex = 55;
            this.button4.Tag = "jpegQ";
            this.button4.Text = "Show detailed image";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.onOpenBigImage);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1049, 352);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(240, 23);
            this.button5.TabIndex = 56;
            this.button5.Tag = "tiffA";
            this.button5.Text = "Show detailed image";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.onOpenBigImage);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(10, 652);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(240, 23);
            this.button6.TabIndex = 57;
            this.button6.Tag = "tiff";
            this.button6.Text = "Show detailed image";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.onOpenBigImage);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(271, 652);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(240, 23);
            this.button7.TabIndex = 58;
            this.button7.Tag = "bmp";
            this.button7.Text = "Show detailed image";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.onOpenBigImage);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(530, 652);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(240, 23);
            this.button8.TabIndex = 59;
            this.button8.Tag = "gif";
            this.button8.Text = "Show detailed image";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.onOpenBigImage);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 686);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tiffShowAllFormButton);
            this.Controls.Add(this.jpegShowAllFormButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.resultsGridView);
            this.Controls.Add(this.tiffDensityAlgLabel);
            this.Controls.Add(this.jpegSelectedAlgLabel);
            this.Controls.Add(this.tiffConvertAlgCombobox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tiffAlgorithmPictureBox);
            this.Controls.Add(this.qualityTrackBar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.jpegQualityPictureBox);
            this.Controls.Add(this.clearImageButton);
            this.Controls.Add(this.deleteInputImagePathButton);
            this.Controls.Add(this.deleteSaveImagesPathButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gifPictureBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bmpPictureBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tiffPictureBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.jpegPictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pngPictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.originalPictureBox);
            this.Controls.Add(this.insertDataButton);
            this.Controls.Add(this.selectImageButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imageToConvertTextbox);
            this.Controls.Add(this.insertPathButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveDirPathTextbox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1315, 725);
            this.MinimumSize = new System.Drawing.Size(1315, 725);
            this.Name = "MainWindow";
            this.Text = "Image compression";
            ((System.ComponentModel.ISupportInitialize)(this.jpegPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pngPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiffPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmpPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jpegQualityPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiffAlgorithmPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button insertDataButton;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox imageToConvertTextbox;
        private System.Windows.Forms.Button insertPathButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox saveDirPathTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox jpegPictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pngPictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox tiffPictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox bmpPictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox gifPictureBox;
        private System.Windows.Forms.FolderBrowserDialog selectOutputDirectoryControl;
        private System.Windows.Forms.Button deleteSaveImagesPathButton;
        private System.Windows.Forms.Button deleteInputImagePathButton;
        private System.Windows.Forms.OpenFileDialog openInputFileImageDialog;
        private System.Windows.Forms.Button clearImageButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox jpegQualityPictureBox;
        private System.Windows.Forms.TrackBar qualityTrackBar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox tiffAlgorithmPictureBox;
        private System.Windows.Forms.Label jpegSelectedAlgLabel;
        private System.Windows.Forms.Label tiffDensityAlgLabel;
        private System.Windows.Forms.DataGridView resultsGridView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn PNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn JPEG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIFF;
        private System.Windows.Forms.DataGridViewTextBoxColumn BMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn JPEGC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIFFA;
        private System.Windows.Forms.Button jpegShowAllFormButton;
        private System.Windows.Forms.Button tiffShowAllFormButton;
        private System.Windows.Forms.ComboBox tiffConvertAlgCombobox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

