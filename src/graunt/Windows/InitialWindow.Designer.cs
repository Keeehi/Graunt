namespace graunt
{
    partial class InitialWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialWindow));
            this.fStart = new System.Windows.Forms.Label();
            this.fRecent = new System.Windows.Forms.Label();
            this.fOpen = new System.Windows.Forms.Button();
            this.fImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fStart
            // 
            this.fStart.AutoSize = true;
            this.fStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fStart.Location = new System.Drawing.Point(12, 9);
            this.fStart.Name = "fStart";
            this.fStart.Size = new System.Drawing.Size(44, 20);
            this.fStart.TabIndex = 0;
            this.fStart.Text = "Start";
            // 
            // fRecent
            // 
            this.fRecent.AutoSize = true;
            this.fRecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fRecent.Location = new System.Drawing.Point(163, 9);
            this.fRecent.Name = "fRecent";
            this.fRecent.Size = new System.Drawing.Size(61, 20);
            this.fRecent.TabIndex = 3;
            this.fRecent.Text = "Recent";
            // 
            // fOpen
            // 
            this.fOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fOpen.Location = new System.Drawing.Point(16, 39);
            this.fOpen.Name = "fOpen";
            this.fOpen.Size = new System.Drawing.Size(96, 96);
            this.fOpen.TabIndex = 6;
            this.fOpen.Text = "Open";
            this.fOpen.UseVisualStyleBackColor = true;
            this.fOpen.Click += new System.EventHandler(this.fOpen_Click);
            // 
            // fImport
            // 
            this.fImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fImport.Location = new System.Drawing.Point(16, 145);
            this.fImport.Name = "fImport";
            this.fImport.Size = new System.Drawing.Size(96, 96);
            this.fImport.TabIndex = 7;
            this.fImport.Text = "Import";
            this.fImport.UseVisualStyleBackColor = true;
            this.fImport.Click += new System.EventHandler(this.fImport_Click);
            // 
            // InitialWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 255);
            this.Controls.Add(this.fImport);
            this.Controls.Add(this.fOpen);
            this.Controls.Add(this.fRecent);
            this.Controls.Add(this.fStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InitialWindow";
            this.Text = "Graunt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fStart;
        private System.Windows.Forms.Label fRecent;
        private System.Windows.Forms.Button fOpen;
        private System.Windows.Forms.Button fImport;

    }
}