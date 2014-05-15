namespace graunt
{
    partial class ColumnsSelectWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnsSelectWindow));
            this.fInclude = new System.Windows.Forms.ListBox();
            this.fExclude = new System.Windows.Forms.ListBox();
            this.fMoveRight = new System.Windows.Forms.Button();
            this.fMoveLeft = new System.Windows.Forms.Button();
            this.fImport = new System.Windows.Forms.Label();
            this.fIgnore = new System.Windows.Forms.Label();
            this.fNext = new System.Windows.Forms.Button();
            this.fHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fInclude
            // 
            this.fInclude.FormattingEnabled = true;
            this.fInclude.HorizontalScrollbar = true;
            this.fInclude.Location = new System.Drawing.Point(12, 62);
            this.fInclude.Name = "fInclude";
            this.fInclude.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.fInclude.Size = new System.Drawing.Size(150, 238);
            this.fInclude.TabIndex = 0;
            // 
            // fExclude
            // 
            this.fExclude.FormattingEnabled = true;
            this.fExclude.HorizontalScrollbar = true;
            this.fExclude.Location = new System.Drawing.Point(245, 62);
            this.fExclude.Name = "fExclude";
            this.fExclude.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.fExclude.Size = new System.Drawing.Size(150, 238);
            this.fExclude.TabIndex = 1;
            // 
            // fMoveRight
            // 
            this.fMoveRight.Location = new System.Drawing.Point(183, 135);
            this.fMoveRight.Name = "fMoveRight";
            this.fMoveRight.Size = new System.Drawing.Size(41, 28);
            this.fMoveRight.TabIndex = 2;
            this.fMoveRight.Text = ">";
            this.fMoveRight.UseVisualStyleBackColor = true;
            this.fMoveRight.Click += new System.EventHandler(this.fMoveRight_Click);
            // 
            // fMoveLeft
            // 
            this.fMoveLeft.Location = new System.Drawing.Point(183, 188);
            this.fMoveLeft.Name = "fMoveLeft";
            this.fMoveLeft.Size = new System.Drawing.Size(41, 28);
            this.fMoveLeft.TabIndex = 3;
            this.fMoveLeft.Text = "<";
            this.fMoveLeft.UseVisualStyleBackColor = true;
            this.fMoveLeft.Click += new System.EventHandler(this.fMoveLeft_Click);
            // 
            // fImport
            // 
            this.fImport.AutoSize = true;
            this.fImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fImport.Location = new System.Drawing.Point(13, 42);
            this.fImport.Name = "fImport";
            this.fImport.Size = new System.Drawing.Size(47, 17);
            this.fImport.TabIndex = 4;
            this.fImport.Text = "import";
            // 
            // fIgnore
            // 
            this.fIgnore.AutoSize = true;
            this.fIgnore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fIgnore.Location = new System.Drawing.Point(246, 42);
            this.fIgnore.Name = "fIgnore";
            this.fIgnore.Size = new System.Drawing.Size(91, 17);
            this.fIgnore.TabIndex = 5;
            this.fIgnore.Text = "do not import";
            // 
            // fNext
            // 
            this.fNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fNext.Location = new System.Drawing.Point(259, 306);
            this.fNext.Name = "fNext";
            this.fNext.Size = new System.Drawing.Size(136, 34);
            this.fNext.TabIndex = 0;
            this.fNext.Text = "Next";
            this.fNext.UseVisualStyleBackColor = true;
            this.fNext.Click += new System.EventHandler(this.fNext_Click);
            // 
            // fHeader
            // 
            this.fHeader.AutoSize = true;
            this.fHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fHeader.Location = new System.Drawing.Point(12, 9);
            this.fHeader.Name = "fHeader";
            this.fHeader.Size = new System.Drawing.Size(304, 20);
            this.fHeader.TabIndex = 7;
            this.fHeader.Text = "Select columns which should be imported.";
            // 
            // ColumnsSelectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 349);
            this.ControlBox = false;
            this.Controls.Add(this.fNext);
            this.Controls.Add(this.fHeader);
            this.Controls.Add(this.fIgnore);
            this.Controls.Add(this.fImport);
            this.Controls.Add(this.fMoveLeft);
            this.Controls.Add(this.fMoveRight);
            this.Controls.Add(this.fExclude);
            this.Controls.Add(this.fInclude);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColumnsSelectWindow";
            this.Text = "Graunt - Import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fInclude;
        private System.Windows.Forms.ListBox fExclude;
        private System.Windows.Forms.Button fMoveRight;
        private System.Windows.Forms.Button fMoveLeft;
        private System.Windows.Forms.Label fImport;
        private System.Windows.Forms.Label fIgnore;
        private System.Windows.Forms.Button fNext;
        private System.Windows.Forms.Label fHeader;
    }
}