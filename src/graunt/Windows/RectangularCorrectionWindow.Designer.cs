namespace graunt
{
    partial class RectangularCorrectionWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectangularCorrectionWindow));
            this.fHeader = new System.Windows.Forms.Label();
            this.fColumnSelect = new System.Windows.Forms.ComboBox();
            this.fValidColumn = new System.Windows.Forms.Label();
            this.fLonger = new System.Windows.Forms.GroupBox();
            this.fIgnore1 = new System.Windows.Forms.RadioButton();
            this.fCrop = new System.Windows.Forms.RadioButton();
            this.fShorter = new System.Windows.Forms.GroupBox();
            this.fIgnore2 = new System.Windows.Forms.RadioButton();
            this.fAppend = new System.Windows.Forms.RadioButton();
            this.fNext = new System.Windows.Forms.Button();
            this.fLonger.SuspendLayout();
            this.fShorter.SuspendLayout();
            this.SuspendLayout();
            // 
            // fHeader
            // 
            this.fHeader.AutoSize = true;
            this.fHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fHeader.Location = new System.Drawing.Point(12, 9);
            this.fHeader.Name = "fHeader";
            this.fHeader.Size = new System.Drawing.Size(275, 20);
            this.fHeader.TabIndex = 0;
            this.fHeader.Text = "Records are not in rectangular shape.";
            // 
            // fColumnSelect
            // 
            this.fColumnSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fColumnSelect.FormattingEnabled = true;
            this.fColumnSelect.Location = new System.Drawing.Point(136, 43);
            this.fColumnSelect.Name = "fColumnSelect";
            this.fColumnSelect.Size = new System.Drawing.Size(121, 21);
            this.fColumnSelect.TabIndex = 2;
            // 
            // fValidColumn
            // 
            this.fValidColumn.AutoSize = true;
            this.fValidColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fValidColumn.Location = new System.Drawing.Point(13, 44);
            this.fValidColumn.Name = "fValidColumn";
            this.fValidColumn.Size = new System.Drawing.Size(117, 17);
            this.fValidColumn.TabIndex = 3;
            this.fValidColumn.Text = "Last valid column";
            // 
            // fLonger
            // 
            this.fLonger.Controls.Add(this.fIgnore1);
            this.fLonger.Controls.Add(this.fCrop);
            this.fLonger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fLonger.Location = new System.Drawing.Point(16, 70);
            this.fLonger.Name = "fLonger";
            this.fLonger.Size = new System.Drawing.Size(212, 69);
            this.fLonger.TabIndex = 4;
            this.fLonger.TabStop = false;
            this.fLonger.Text = "Longer records";
            // 
            // fIgnore1
            // 
            this.fIgnore1.AutoSize = true;
            this.fIgnore1.Location = new System.Drawing.Point(6, 42);
            this.fIgnore1.Name = "fIgnore1";
            this.fIgnore1.Size = new System.Drawing.Size(109, 21);
            this.fIgnore1.TabIndex = 1;
            this.fIgnore1.Text = "do not import";
            this.fIgnore1.UseVisualStyleBackColor = true;
            // 
            // fCrop
            // 
            this.fCrop.AutoSize = true;
            this.fCrop.Checked = true;
            this.fCrop.Location = new System.Drawing.Point(6, 19);
            this.fCrop.Name = "fCrop";
            this.fCrop.Size = new System.Drawing.Size(54, 21);
            this.fCrop.TabIndex = 0;
            this.fCrop.TabStop = true;
            this.fCrop.Text = "crop";
            this.fCrop.UseVisualStyleBackColor = true;
            // 
            // fShorter
            // 
            this.fShorter.Controls.Add(this.fIgnore2);
            this.fShorter.Controls.Add(this.fAppend);
            this.fShorter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fShorter.Location = new System.Drawing.Point(234, 70);
            this.fShorter.Name = "fShorter";
            this.fShorter.Size = new System.Drawing.Size(211, 69);
            this.fShorter.TabIndex = 5;
            this.fShorter.TabStop = false;
            this.fShorter.Text = "Shorter records";
            // 
            // fIgnore2
            // 
            this.fIgnore2.AutoSize = true;
            this.fIgnore2.Location = new System.Drawing.Point(6, 42);
            this.fIgnore2.Name = "fIgnore2";
            this.fIgnore2.Size = new System.Drawing.Size(109, 21);
            this.fIgnore2.TabIndex = 1;
            this.fIgnore2.Text = "do not import";
            this.fIgnore2.UseVisualStyleBackColor = true;
            // 
            // fAppend
            // 
            this.fAppend.AutoSize = true;
            this.fAppend.Checked = true;
            this.fAppend.Location = new System.Drawing.Point(6, 19);
            this.fAppend.Name = "fAppend";
            this.fAppend.Size = new System.Drawing.Size(148, 21);
            this.fAppend.TabIndex = 0;
            this.fAppend.TabStop = true;
            this.fAppend.Text = "append empty cells";
            this.fAppend.UseVisualStyleBackColor = true;
            // 
            // fNext
            // 
            this.fNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fNext.Location = new System.Drawing.Point(309, 145);
            this.fNext.Name = "fNext";
            this.fNext.Size = new System.Drawing.Size(136, 34);
            this.fNext.TabIndex = 0;
            this.fNext.Text = "Next";
            this.fNext.UseVisualStyleBackColor = true;
            this.fNext.Click += new System.EventHandler(this.fNext_Click);
            // 
            // RectangularCorrectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 187);
            this.ControlBox = false;
            this.Controls.Add(this.fNext);
            this.Controls.Add(this.fShorter);
            this.Controls.Add(this.fLonger);
            this.Controls.Add(this.fValidColumn);
            this.Controls.Add(this.fColumnSelect);
            this.Controls.Add(this.fHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RectangularCorrectionWindow";
            this.Text = "Graunt - Import";
            this.fLonger.ResumeLayout(false);
            this.fLonger.PerformLayout();
            this.fShorter.ResumeLayout(false);
            this.fShorter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fHeader;
        private System.Windows.Forms.ComboBox fColumnSelect;
        private System.Windows.Forms.Label fValidColumn;
        private System.Windows.Forms.GroupBox fLonger;
        private System.Windows.Forms.RadioButton fIgnore1;
        private System.Windows.Forms.RadioButton fCrop;
        private System.Windows.Forms.GroupBox fShorter;
        private System.Windows.Forms.RadioButton fIgnore2;
        private System.Windows.Forms.RadioButton fAppend;
        private System.Windows.Forms.Button fNext;
    }
}