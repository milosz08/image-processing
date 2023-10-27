namespace ImageCompression
{
    partial class BigImageWindow
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
            this.bigImagePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bigImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bigImagePictureBox
            // 
            this.bigImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bigImagePictureBox.Location = new System.Drawing.Point(12, 12);
            this.bigImagePictureBox.Name = "bigImagePictureBox";
            this.bigImagePictureBox.Size = new System.Drawing.Size(700, 700);
            this.bigImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bigImagePictureBox.TabIndex = 21;
            this.bigImagePictureBox.TabStop = false;
            // 
            // BigImageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 724);
            this.Controls.Add(this.bigImagePictureBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(739, 763);
            this.MinimumSize = new System.Drawing.Size(739, 763);
            this.Name = "BigImageWindow";
            this.Load += new System.EventHandler(this.onLoadImageContainer);
            ((System.ComponentModel.ISupportInitialize)(this.bigImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bigImagePictureBox;
    }
}