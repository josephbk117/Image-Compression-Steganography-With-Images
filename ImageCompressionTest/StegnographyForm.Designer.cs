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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOpenDecrypt = new System.Windows.Forms.Button();
            this.textBoxDecryption = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InputImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InputImagePictureBox
            // 
            this.InputImagePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InputImagePictureBox.Location = new System.Drawing.Point(18, 76);
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
            this.OutputImagePictureBox.Location = new System.Drawing.Point(469, 75);
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
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "File To Use :";
            // 
            // fileAdressTextBox
            // 
            this.fileAdressTextBox.Location = new System.Drawing.Point(137, 49);
            this.fileAdressTextBox.Name = "fileAdressTextBox";
            this.fileAdressTextBox.Size = new System.Drawing.Size(612, 20);
            this.fileAdressTextBox.TabIndex = 3;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(304, 76);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(159, 23);
            this.OpenFileButton.TabIndex = 4;
            this.OpenFileButton.Text = "OPEN FILE TO ENCRYPT";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(304, 105);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(159, 23);
            this.encryptButton.TabIndex = 5;
            this.encryptButton.Text = "Encrypt File Into Image";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(589, 423);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(159, 23);
            this.decryptButton.TabIndex = 6;
            this.decryptButton.Text = "Decrypt File Into Image";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Encryption";
            // 
            // buttonOpenDecrypt
            // 
            this.buttonOpenDecrypt.Location = new System.Drawing.Point(590, 388);
            this.buttonOpenDecrypt.Name = "buttonOpenDecrypt";
            this.buttonOpenDecrypt.Size = new System.Drawing.Size(159, 23);
            this.buttonOpenDecrypt.TabIndex = 11;
            this.buttonOpenDecrypt.Text = "OPEN FILE TO DECRYPT";
            this.buttonOpenDecrypt.UseVisualStyleBackColor = true;
            this.buttonOpenDecrypt.Click += new System.EventHandler(this.buttonOpenDecrypt_Click);
            // 
            // textBoxDecryption
            // 
            this.textBoxDecryption.Location = new System.Drawing.Point(138, 388);
            this.textBoxDecryption.Name = "textBoxDecryption";
            this.textBoxDecryption.Size = new System.Drawing.Size(446, 20);
            this.textBoxDecryption.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "File To Use :";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(170, 425);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(413, 20);
            this.textBoxOutput.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "File Output To  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(325, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Decryption";
            // 
            // StegnographyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(768, 453);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonOpenDecrypt);
            this.Controls.Add(this.textBoxDecryption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.fileAdressTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputImagePictureBox);
            this.Controls.Add(this.InputImagePictureBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StegnographyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StegnographyForm";
            this.TopMost = true;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOpenDecrypt;
        private System.Windows.Forms.TextBox textBoxDecryption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}