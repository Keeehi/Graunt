namespace graunt
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.fSettings = new System.Windows.Forms.Label();
            this.fLanguage = new System.Windows.Forms.Label();
            this.fLanguageSelect = new System.Windows.Forms.ComboBox();
            this.fCancel = new System.Windows.Forms.Button();
            this.fSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fSettings
            // 
            this.fSettings.AutoSize = true;
            this.fSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fSettings.Location = new System.Drawing.Point(12, 9);
            this.fSettings.Name = "fSettings";
            this.fSettings.Size = new System.Drawing.Size(68, 20);
            this.fSettings.TabIndex = 0;
            this.fSettings.Text = "Settings";
            // 
            // fLanguage
            // 
            this.fLanguage.AutoSize = true;
            this.fLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fLanguage.Location = new System.Drawing.Point(13, 41);
            this.fLanguage.Name = "fLanguage";
            this.fLanguage.Size = new System.Drawing.Size(76, 17);
            this.fLanguage.TabIndex = 1;
            this.fLanguage.Text = "Language:";
            // 
            // fLanuageSelect
            // 
            this.fLanguageSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fLanguageSelect.FormattingEnabled = true;
            this.fLanguageSelect.Location = new System.Drawing.Point(140, 40);
            this.fLanguageSelect.Name = "fLanuageSelect";
            this.fLanguageSelect.Size = new System.Drawing.Size(198, 21);
            this.fLanguageSelect.TabIndex = 2;
            // 
            // fCancel
            // 
            this.fCancel.Location = new System.Drawing.Point(182, 227);
            this.fCancel.Name = "fCancel";
            this.fCancel.Size = new System.Drawing.Size(75, 23);
            this.fCancel.TabIndex = 3;
            this.fCancel.Text = "Cancel";
            this.fCancel.UseVisualStyleBackColor = true;
            this.fCancel.Click += new System.EventHandler(this.fCancel_Click);
            // 
            // fSave
            // 
            this.fSave.Location = new System.Drawing.Point(263, 227);
            this.fSave.Name = "fSave";
            this.fSave.Size = new System.Drawing.Size(75, 23);
            this.fSave.TabIndex = 0;
            this.fSave.Text = "Save";
            this.fSave.UseVisualStyleBackColor = true;
            this.fSave.Click += new System.EventHandler(this.fSave_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 262);
            this.Controls.Add(this.fSave);
            this.Controls.Add(this.fCancel);
            this.Controls.Add(this.fLanguageSelect);
            this.Controls.Add(this.fLanguage);
            this.Controls.Add(this.fSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.Text = "SettingsWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fSettings;
        private System.Windows.Forms.Label fLanguage;
        private System.Windows.Forms.ComboBox fLanguageSelect;
        private System.Windows.Forms.Button fCancel;
        private System.Windows.Forms.Button fSave;
    }
}