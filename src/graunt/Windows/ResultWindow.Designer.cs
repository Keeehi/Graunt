namespace graunt
{
    partial class ResultWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultWindow));
            this.fTextBox = new System.Windows.Forms.TextBox();
            this.fHide = new System.Windows.Forms.Button();
            this.fClear = new System.Windows.Forms.Button();
            this.fSave = new System.Windows.Forms.Button();
            this.fSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fPanelBottom = new System.Windows.Forms.Panel();
            this.fPanelButtonsLeft = new System.Windows.Forms.Panel();
            this.fPanelButtonsRight = new System.Windows.Forms.Panel();
            this.fPanelLeft = new System.Windows.Forms.Panel();
            this.fPanelRight = new System.Windows.Forms.Panel();
            this.fPanelTop = new System.Windows.Forms.Panel();
            this.fPanelBottom.SuspendLayout();
            this.fPanelButtonsLeft.SuspendLayout();
            this.fPanelButtonsRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // fTextBox
            // 
            this.fTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fTextBox.Location = new System.Drawing.Point(12, 12);
            this.fTextBox.Margin = new System.Windows.Forms.Padding(30);
            this.fTextBox.Multiline = true;
            this.fTextBox.Name = "fTextBox";
            this.fTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fTextBox.Size = new System.Drawing.Size(610, 343);
            this.fTextBox.TabIndex = 0;
            this.fTextBox.WordWrap = false;
            this.fTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fTextBox_KeyDown);
            // 
            // fHide
            // 
            this.fHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fHide.Location = new System.Drawing.Point(15, 11);
            this.fHide.Name = "fHide";
            this.fHide.Size = new System.Drawing.Size(136, 34);
            this.fHide.TabIndex = 3;
            this.fHide.Text = "Hide";
            this.fHide.UseVisualStyleBackColor = true;
            this.fHide.Click += new System.EventHandler(this.fHide_Click);
            // 
            // fClear
            // 
            this.fClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fClear.Location = new System.Drawing.Point(154, 11);
            this.fClear.Name = "fClear";
            this.fClear.Size = new System.Drawing.Size(136, 34);
            this.fClear.TabIndex = 2;
            this.fClear.Text = "Clear";
            this.fClear.UseVisualStyleBackColor = true;
            this.fClear.Click += new System.EventHandler(this.fClear_Click);
            // 
            // fSave
            // 
            this.fSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fSave.Location = new System.Drawing.Point(12, 11);
            this.fSave.Name = "fSave";
            this.fSave.Size = new System.Drawing.Size(136, 34);
            this.fSave.TabIndex = 1;
            this.fSave.Text = "Save";
            this.fSave.UseVisualStyleBackColor = true;
            this.fSave.Click += new System.EventHandler(this.fSave_Click);
            // 
            // fSaveFileDialog
            // 
            this.fSaveFileDialog.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            this.fSaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fSaveFileDialog_FileOk);
            // 
            // fPanelBottom
            // 
            this.fPanelBottom.Controls.Add(this.fPanelButtonsLeft);
            this.fPanelBottom.Controls.Add(this.fPanelButtonsRight);
            this.fPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fPanelBottom.Location = new System.Drawing.Point(0, 355);
            this.fPanelBottom.Name = "fPanelBottom";
            this.fPanelBottom.Size = new System.Drawing.Size(634, 57);
            this.fPanelBottom.TabIndex = 5;
            // 
            // fPanelButtonsLeft
            // 
            this.fPanelButtonsLeft.Controls.Add(this.fSave);
            this.fPanelButtonsLeft.Controls.Add(this.fClear);
            this.fPanelButtonsLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.fPanelButtonsLeft.Location = new System.Drawing.Point(0, 0);
            this.fPanelButtonsLeft.Name = "fPanelButtonsLeft";
            this.fPanelButtonsLeft.Size = new System.Drawing.Size(300, 57);
            this.fPanelButtonsLeft.TabIndex = 5;
            // 
            // fPanelButtonsRight
            // 
            this.fPanelButtonsRight.Controls.Add(this.fHide);
            this.fPanelButtonsRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.fPanelButtonsRight.Location = new System.Drawing.Point(471, 0);
            this.fPanelButtonsRight.Name = "fPanelButtonsRight";
            this.fPanelButtonsRight.Size = new System.Drawing.Size(163, 57);
            this.fPanelButtonsRight.TabIndex = 6;
            // 
            // fPanelLeft
            // 
            this.fPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.fPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.fPanelLeft.Name = "fPanelLeft";
            this.fPanelLeft.Size = new System.Drawing.Size(12, 355);
            this.fPanelLeft.TabIndex = 7;
            // 
            // fPanelRight
            // 
            this.fPanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.fPanelRight.Location = new System.Drawing.Point(622, 0);
            this.fPanelRight.Name = "fPanelRight";
            this.fPanelRight.Size = new System.Drawing.Size(12, 355);
            this.fPanelRight.TabIndex = 8;
            // 
            // fPanelTop
            // 
            this.fPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.fPanelTop.Location = new System.Drawing.Point(12, 0);
            this.fPanelTop.Name = "fPanelTop";
            this.fPanelTop.Size = new System.Drawing.Size(610, 12);
            this.fPanelTop.TabIndex = 9;
            // 
            // ResultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.Controls.Add(this.fTextBox);
            this.Controls.Add(this.fPanelTop);
            this.Controls.Add(this.fPanelRight);
            this.Controls.Add(this.fPanelLeft);
            this.Controls.Add(this.fPanelBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 450);
            this.Name = "ResultWindow";
            this.Text = "ResultWindow";
            this.Shown += new System.EventHandler(this.ResultWindow_Shown);
            this.fPanelBottom.ResumeLayout(false);
            this.fPanelButtonsLeft.ResumeLayout(false);
            this.fPanelButtonsRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fTextBox;
        private System.Windows.Forms.Button fHide;
        private System.Windows.Forms.Button fClear;
        private System.Windows.Forms.Button fSave;
        private System.Windows.Forms.SaveFileDialog fSaveFileDialog;
        private System.Windows.Forms.Panel fPanelBottom;
        private System.Windows.Forms.Panel fPanelLeft;
        private System.Windows.Forms.Panel fPanelRight;
        private System.Windows.Forms.Panel fPanelButtonsLeft;
        private System.Windows.Forms.Panel fPanelButtonsRight;
        private System.Windows.Forms.Panel fPanelTop;
    }
}