namespace ImageCompressionTest
{
    partial class StegnographyForm
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
            this.InputImagePictureBox = new System.Windows.Forms.PictureBox();
            this.OutputImagePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileAdressTextBox = new System.Windows.Forms.TextBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InputImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InputImagePictureBox
            // 
            this.InputImagePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InputImagePictureBox.Location = new System.Drawing.Point(12, 126);
            this.InputImagePictureBox.Name = "InputImagePictureBox";
            this.InputImagePictureBox.Size = new System.Drawing.Size(280, 280);
            this.InputImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InputImagePictureBox.TabIndex = 0;
            this.InputImagePictureBox.TabStop = false;
            this.InputImagePictureBox.DoubleClick += new System.EventHandler(this.InputImagePictureBox_DoubleClick);
            // 
            // OutputImagePictureBox
            // 
            this.OutputImagePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OutputImagePictureBox.Location = new System.Drawing.Point(617, 126);
            this.OutputImagePictureBox.Name = "OutputImagePictureBox";
            this.OutputImagePictureBox.Size = new System.Drawing.Size(280, 280);
            this.OutputImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OutputImagePictureBox.TabIndex = 1;
            this.OutputImagePictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "File To Use :";
            // 
            // fileAdressTextBox
            // 
            this.fileAdressTextBox.Location = new System.Drawing.Point(138, 18);
            this.fileAdressTextBox.Name = "fileAdressTextBox";
            this.fileAdressTextBox.Size = new System.Drawing.Size(476, 20);
            this.fileAdressTextBox.TabIndex = 3;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(621, 18);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 4;
            this.OpenFileButton.Text = "OPEN FILE";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(379, 126);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(159, 23);
            this.encryptButton.TabIndex = 5;
            this.encryptButton.Text = "Encrypt File Into Image";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(379, 155);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(159, 23);
            this.decryptButton.TabIndex = 6;
            this.decryptButton.Text = "Decrypt File Into Image";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // StegnographyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 418);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.fileAdressTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputImagePictureBox);
            this.Controls.Add(this.InputImagePictureBox);
            this.Name = "StegnographyForm";
            this.Text = "StegnographyForm";
            ((System.ComponentModel.ISupportInitialize)(this.InputImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox InputImagePictureBox;
        private System.Windows.Forms.PictureBox OutputImagePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileAdressTextBox;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
    }
}