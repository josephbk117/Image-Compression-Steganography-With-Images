namespace ImageCompressionTest
{
    partial class MainMenuForm
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
            this.BW_compressionBtn = new System.Windows.Forms.Button();
            this.stenographyBtn = new System.Windows.Forms.Button();
            this.jbk_compressionBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BW_compressionBtn
            // 
            this.BW_compressionBtn.Location = new System.Drawing.Point(28, 78);
            this.BW_compressionBtn.Name = "BW_compressionBtn";
            this.BW_compressionBtn.Size = new System.Drawing.Size(162, 23);
            this.BW_compressionBtn.TabIndex = 0;
            this.BW_compressionBtn.Text = "Black White Compression";
            this.BW_compressionBtn.UseVisualStyleBackColor = true;
            this.BW_compressionBtn.Click += new System.EventHandler(this.BW_compressionBtn_Click);
            // 
            // stenographyBtn
            // 
            this.stenographyBtn.Location = new System.Drawing.Point(196, 78);
            this.stenographyBtn.Name = "stenographyBtn";
            this.stenographyBtn.Size = new System.Drawing.Size(203, 23);
            this.stenographyBtn.TabIndex = 1;
            this.stenographyBtn.Text = "Stenography With Files In Images";
            this.stenographyBtn.UseVisualStyleBackColor = true;
            this.stenographyBtn.Click += new System.EventHandler(this.stenographyBtn_Click);
            // 
            // jbk_compressionBtn
            // 
            this.jbk_compressionBtn.Location = new System.Drawing.Point(405, 78);
            this.jbk_compressionBtn.Name = "jbk_compressionBtn";
            this.jbk_compressionBtn.Size = new System.Drawing.Size(140, 23);
            this.jbk_compressionBtn.TabIndex = 2;
            this.jbk_compressionBtn.Text = "JBK Compression";
            this.jbk_compressionBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose What Encryption You Want To Perform";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 118);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jbk_compressionBtn);
            this.Controls.Add(this.stenographyBtn);
            this.Controls.Add(this.BW_compressionBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BW_compressionBtn;
        private System.Windows.Forms.Button stenographyBtn;
        private System.Windows.Forms.Button jbk_compressionBtn;
        private System.Windows.Forms.Label label1;
    }
}