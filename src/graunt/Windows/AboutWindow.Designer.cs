namespace graunt
{
    partial class AboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.fGraunt = new System.Windows.Forms.Label();
            this.fLogo = new System.Windows.Forms.PictureBox();
            this.fClose = new System.Windows.Forms.Button();
            this.fVersion = new System.Windows.Forms.Label();
            this.fVersionValue = new System.Windows.Forms.Label();
            this.fLicense = new System.Windows.Forms.Label();
            this.fLicenseValue = new System.Windows.Forms.Label();
            this.fAuthor = new System.Windows.Forms.Label();
            this.fAuthorValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // fGraunt
            // 
            this.fGraunt.AutoSize = true;
            this.fGraunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F);
            this.fGraunt.Location = new System.Drawing.Point(125, 35);
            this.fGraunt.Name = "fGraunt";
            this.fGraunt.Size = new System.Drawing.Size(180, 59);
            this.fGraunt.TabIndex = 0;
            this.fGraunt.Text = "Graunt";
            // 
            // fLogo
            // 
            this.fLogo.Image = global::graunt.Properties.Resources.logo;
            this.fLogo.Location = new System.Drawing.Point(12, 12);
            this.fLogo.Name = "fLogo";
            this.fLogo.Size = new System.Drawing.Size(96, 96);
            this.fLogo.TabIndex = 1;
            this.fLogo.TabStop = false;
            // 
            // fClose
            // 
            this.fClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fClose.Location = new System.Drawing.Point(182, 205);
            this.fClose.Name = "fClose";
            this.fClose.Size = new System.Drawing.Size(136, 34);
            this.fClose.TabIndex = 4;
            this.fClose.Text = "Close";
            this.fClose.UseVisualStyleBackColor = true;
            this.fClose.Click += new System.EventHandler(this.fClose_Click);
            // 
            // fVersion
            // 
            this.fVersion.AutoSize = true;
            this.fVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fVersion.Location = new System.Drawing.Point(12, 148);
            this.fVersion.Name = "fVersion";
            this.fVersion.Size = new System.Drawing.Size(67, 20);
            this.fVersion.TabIndex = 5;
            this.fVersion.Text = "Version:";
            // 
            // fVersionValue
            // 
            this.fVersionValue.AutoSize = true;
            this.fVersionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fVersionValue.Location = new System.Drawing.Point(131, 148);
            this.fVersionValue.Name = "fVersionValue";
            this.fVersionValue.Size = new System.Drawing.Size(44, 20);
            this.fVersionValue.TabIndex = 6;
            this.fVersionValue.Text = "1.0.0";
            // 
            // fLicense
            // 
            this.fLicense.AutoSize = true;
            this.fLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fLicense.Location = new System.Drawing.Point(12, 170);
            this.fLicense.Name = "fLicense";
            this.fLicense.Size = new System.Drawing.Size(68, 20);
            this.fLicense.TabIndex = 7;
            this.fLicense.Text = "License:";
            // 
            // fLicenseValue
            // 
            this.fLicenseValue.AutoSize = true;
            this.fLicenseValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fLicenseValue.Location = new System.Drawing.Point(131, 170);
            this.fLicenseValue.Name = "fLicenseValue";
            this.fLicenseValue.Size = new System.Drawing.Size(57, 20);
            this.fLicenseValue.TabIndex = 8;
            this.fLicenseValue.Text = "GPLv3";
            // 
            // fAuthor
            // 
            this.fAuthor.AutoSize = true;
            this.fAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fAuthor.Location = new System.Drawing.Point(12, 126);
            this.fAuthor.Name = "fAuthor";
            this.fAuthor.Size = new System.Drawing.Size(61, 20);
            this.fAuthor.TabIndex = 9;
            this.fAuthor.Text = "Author:";
            // 
            // fAuthorValue
            // 
            this.fAuthorValue.AutoSize = true;
            this.fAuthorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fAuthorValue.Location = new System.Drawing.Point(131, 126);
            this.fAuthorValue.Name = "fAuthorValue";
            this.fAuthorValue.Size = new System.Drawing.Size(89, 20);
            this.fAuthorValue.TabIndex = 10;
            this.fAuthorValue.Text = "Jan Cejhon";
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 251);
            this.Controls.Add(this.fAuthorValue);
            this.Controls.Add(this.fAuthor);
            this.Controls.Add(this.fLicenseValue);
            this.Controls.Add(this.fLicense);
            this.Controls.Add(this.fVersionValue);
            this.Controls.Add(this.fVersion);
            this.Controls.Add(this.fClose);
            this.Controls.Add(this.fLogo);
            this.Controls.Add(this.fGraunt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutWindow";
            this.Text = "Graunt - About";
            ((System.ComponentModel.ISupportInitialize)(this.fLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fGraunt;
        private System.Windows.Forms.PictureBox fLogo;
        private System.Windows.Forms.Button fClose;
        private System.Windows.Forms.Label fVersion;
        private System.Windows.Forms.Label fVersionValue;
        private System.Windows.Forms.Label fLicense;
        private System.Windows.Forms.Label fLicenseValue;
        private System.Windows.Forms.Label fAuthor;
        private System.Windows.Forms.Label fAuthorValue;
    }
}