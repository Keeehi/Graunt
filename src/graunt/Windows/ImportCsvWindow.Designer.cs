namespace graunt
{
    partial class ImportCsvWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportCsvWindow));
            this.fNext = new System.Windows.Forms.Button();
            this.fRow1 = new System.Windows.Forms.Panel();
            this.fDoubleQuote1 = new System.Windows.Forms.Label();
            this.fSemicolon = new System.Windows.Forms.Label();
            this.fNewline1 = new System.Windows.Forms.Label();
            this.fSemicolonSeparatedValues = new graunt.GroupableRadioButton();
            this.fComma = new System.Windows.Forms.Label();
            this.fRow2 = new System.Windows.Forms.Panel();
            this.fDoubleQuote2 = new System.Windows.Forms.Label();
            this.fNewline2 = new System.Windows.Forms.Label();
            this.fCommaSeparatedValues = new graunt.GroupableRadioButton();
            this.fRow3 = new System.Windows.Forms.Panel();
            this.fNone = new System.Windows.Forms.Label();
            this.fTab = new System.Windows.Forms.Label();
            this.fNewline3 = new System.Windows.Forms.Label();
            this.fTabSeparatedValues = new graunt.GroupableRadioButton();
            this.fRow4 = new System.Windows.Forms.Panel();
            this.fCustomTextDelimiter = new System.Windows.Forms.TextBox();
            this.fCustomFieldSeparator = new System.Windows.Forms.TextBox();
            this.fCustomRecordSeparator = new System.Windows.Forms.TextBox();
            this.fCustomFormat = new graunt.GroupableRadioButton();
            this.fRowHeader = new System.Windows.Forms.Panel();
            this.fTextDelimiter = new System.Windows.Forms.Label();
            this.fFieldSeparator = new System.Windows.Forms.Label();
            this.fRecordSeparator = new System.Windows.Forms.Label();
            this.fFileFormat = new System.Windows.Forms.Label();
            this.fHasHeader = new System.Windows.Forms.CheckBox();
            this.fDataPreview = new System.Windows.Forms.DataGridView();
            this.fError = new System.Windows.Forms.Label();
            this.fPartial = new System.Windows.Forms.Label();
            this.fEncoding = new System.Windows.Forms.Label();
            this.fEncodingSelect = new System.Windows.Forms.ComboBox();
            this.fRow1.SuspendLayout();
            this.fRow2.SuspendLayout();
            this.fRow3.SuspendLayout();
            this.fRow4.SuspendLayout();
            this.fRowHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fDataPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // fNext
            // 
            this.fNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fNext.Location = new System.Drawing.Point(601, 525);
            this.fNext.Name = "fNext";
            this.fNext.Size = new System.Drawing.Size(136, 34);
            this.fNext.TabIndex = 0;
            this.fNext.Text = "Next";
            this.fNext.UseVisualStyleBackColor = true;
            this.fNext.Click += new System.EventHandler(this.fNext_Click);
            // 
            // fRow1
            // 
            this.fRow1.BackColor = System.Drawing.Color.Silver;
            this.fRow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fRow1.Controls.Add(this.fDoubleQuote1);
            this.fRow1.Controls.Add(this.fSemicolon);
            this.fRow1.Controls.Add(this.fNewline1);
            this.fRow1.Controls.Add(this.fSemicolonSeparatedValues);
            this.fRow1.Location = new System.Drawing.Point(12, 54);
            this.fRow1.Name = "fRow1";
            this.fRow1.Size = new System.Drawing.Size(725, 36);
            this.fRow1.TabIndex = 1;
            // 
            // fDoubleQuote1
            // 
            this.fDoubleQuote1.AutoSize = true;
            this.fDoubleQuote1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fDoubleQuote1.Location = new System.Drawing.Point(575, 7);
            this.fDoubleQuote1.Name = "fDoubleQuote1";
            this.fDoubleQuote1.Size = new System.Drawing.Size(112, 17);
            this.fDoubleQuote1.TabIndex = 9;
            this.fDoubleQuote1.Text = "Double quote (\")";
            // 
            // fSemicolon
            // 
            this.fSemicolon.AutoSize = true;
            this.fSemicolon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fSemicolon.Location = new System.Drawing.Point(418, 7);
            this.fSemicolon.Name = "fSemicolon";
            this.fSemicolon.Size = new System.Drawing.Size(91, 17);
            this.fSemicolon.TabIndex = 9;
            this.fSemicolon.Text = "Semicolon (;)";
            // 
            // fNewline1
            // 
            this.fNewline1.AutoSize = true;
            this.fNewline1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fNewline1.Location = new System.Drawing.Point(246, 7);
            this.fNewline1.Name = "fNewline1";
            this.fNewline1.Size = new System.Drawing.Size(57, 17);
            this.fNewline1.TabIndex = 5;
            this.fNewline1.Text = "Newline";
            // 
            // fSemicolonSeparatedValues
            // 
            this.fSemicolonSeparatedValues.AutoSize = true;
            this.fSemicolonSeparatedValues.Checked = true;
            this.fSemicolonSeparatedValues.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fSemicolonSeparatedValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fSemicolonSeparatedValues.GroupName = "fileFormat";
            this.fSemicolonSeparatedValues.GroupNameLevel = graunt.GroupableRadioButton.Level.Form;
            this.fSemicolonSeparatedValues.Location = new System.Drawing.Point(16, 6);
            this.fSemicolonSeparatedValues.Name = "fSemicolonSeparatedValues";
            this.fSemicolonSeparatedValues.Size = new System.Drawing.Size(209, 21);
            this.fSemicolonSeparatedValues.TabIndex = 5;
            this.fSemicolonSeparatedValues.Text = "Semicolon Separated Values";
            this.fSemicolonSeparatedValues.UseVisualStyleBackColor = true;
            this.fSemicolonSeparatedValues.CheckedChanged += new System.EventHandler(this.refreshPreview);
            // 
            // fComma
            // 
            this.fComma.AutoSize = true;
            this.fComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fComma.Location = new System.Drawing.Point(418, 7);
            this.fComma.Name = "fComma";
            this.fComma.Size = new System.Drawing.Size(73, 17);
            this.fComma.TabIndex = 8;
            this.fComma.Text = "Comma (,)";
            // 
            // fRow2
            // 
            this.fRow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fRow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fRow2.Controls.Add(this.fDoubleQuote2);
            this.fRow2.Controls.Add(this.fComma);
            this.fRow2.Controls.Add(this.fNewline2);
            this.fRow2.Controls.Add(this.fCommaSeparatedValues);
            this.fRow2.Location = new System.Drawing.Point(12, 89);
            this.fRow2.Name = "fRow2";
            this.fRow2.Size = new System.Drawing.Size(725, 36);
            this.fRow2.TabIndex = 2;
            // 
            // fDoubleQuote2
            // 
            this.fDoubleQuote2.AutoSize = true;
            this.fDoubleQuote2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fDoubleQuote2.Location = new System.Drawing.Point(575, 7);
            this.fDoubleQuote2.Name = "fDoubleQuote2";
            this.fDoubleQuote2.Size = new System.Drawing.Size(112, 17);
            this.fDoubleQuote2.TabIndex = 10;
            this.fDoubleQuote2.Text = "Double quote (\")";
            // 
            // fNewline2
            // 
            this.fNewline2.AutoSize = true;
            this.fNewline2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fNewline2.Location = new System.Drawing.Point(246, 7);
            this.fNewline2.Name = "fNewline2";
            this.fNewline2.Size = new System.Drawing.Size(57, 17);
            this.fNewline2.TabIndex = 6;
            this.fNewline2.Text = "Newline";
            // 
            // fCommaSeparatedValues
            // 
            this.fCommaSeparatedValues.AutoSize = true;
            this.fCommaSeparatedValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fCommaSeparatedValues.GroupName = "fileFormat";
            this.fCommaSeparatedValues.GroupNameLevel = graunt.GroupableRadioButton.Level.Form;
            this.fCommaSeparatedValues.Location = new System.Drawing.Point(16, 6);
            this.fCommaSeparatedValues.Name = "fCommaSeparatedValues";
            this.fCommaSeparatedValues.Size = new System.Drawing.Size(191, 21);
            this.fCommaSeparatedValues.TabIndex = 4;
            this.fCommaSeparatedValues.Text = "Comma Separated Values";
            this.fCommaSeparatedValues.UseVisualStyleBackColor = true;
            this.fCommaSeparatedValues.CheckedChanged += new System.EventHandler(this.refreshPreview);
            // 
            // fRow3
            // 
            this.fRow3.BackColor = System.Drawing.Color.Silver;
            this.fRow3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fRow3.Controls.Add(this.fNone);
            this.fRow3.Controls.Add(this.fTab);
            this.fRow3.Controls.Add(this.fNewline3);
            this.fRow3.Controls.Add(this.fTabSeparatedValues);
            this.fRow3.Location = new System.Drawing.Point(12, 124);
            this.fRow3.Name = "fRow3";
            this.fRow3.Size = new System.Drawing.Size(725, 36);
            this.fRow3.TabIndex = 2;
            // 
            // fNone
            // 
            this.fNone.AutoSize = true;
            this.fNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fNone.Location = new System.Drawing.Point(575, 7);
            this.fNone.Name = "fNone";
            this.fNone.Size = new System.Drawing.Size(42, 17);
            this.fNone.TabIndex = 13;
            this.fNone.Text = "None";
            // 
            // fTab
            // 
            this.fTab.AutoSize = true;
            this.fTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fTab.Location = new System.Drawing.Point(418, 7);
            this.fTab.Name = "fTab";
            this.fTab.Size = new System.Drawing.Size(33, 17);
            this.fTab.TabIndex = 10;
            this.fTab.Text = "Tab";
            // 
            // fNewline3
            // 
            this.fNewline3.AutoSize = true;
            this.fNewline3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fNewline3.Location = new System.Drawing.Point(246, 7);
            this.fNewline3.Name = "fNewline3";
            this.fNewline3.Size = new System.Drawing.Size(57, 17);
            this.fNewline3.TabIndex = 7;
            this.fNewline3.Text = "Newline";
            // 
            // fTabSeparatedValues
            // 
            this.fTabSeparatedValues.AutoSize = true;
            this.fTabSeparatedValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fTabSeparatedValues.GroupName = "fileFormat";
            this.fTabSeparatedValues.GroupNameLevel = graunt.GroupableRadioButton.Level.Form;
            this.fTabSeparatedValues.Location = new System.Drawing.Point(16, 6);
            this.fTabSeparatedValues.Name = "fTabSeparatedValues";
            this.fTabSeparatedValues.Size = new System.Drawing.Size(169, 21);
            this.fTabSeparatedValues.TabIndex = 6;
            this.fTabSeparatedValues.Text = "Tab Separated Values";
            this.fTabSeparatedValues.UseVisualStyleBackColor = true;
            this.fTabSeparatedValues.CheckedChanged += new System.EventHandler(this.refreshPreview);
            // 
            // fRow4
            // 
            this.fRow4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fRow4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fRow4.Controls.Add(this.fCustomTextDelimiter);
            this.fRow4.Controls.Add(this.fCustomFieldSeparator);
            this.fRow4.Controls.Add(this.fCustomRecordSeparator);
            this.fRow4.Controls.Add(this.fCustomFormat);
            this.fRow4.Location = new System.Drawing.Point(12, 159);
            this.fRow4.Name = "fRow4";
            this.fRow4.Size = new System.Drawing.Size(725, 36);
            this.fRow4.TabIndex = 2;
            // 
            // fCustomTextDelimiter
            // 
            this.fCustomTextDelimiter.Location = new System.Drawing.Point(578, 6);
            this.fCustomTextDelimiter.MaxLength = 2;
            this.fCustomTextDelimiter.Name = "fCustomTextDelimiter";
            this.fCustomTextDelimiter.Size = new System.Drawing.Size(129, 20);
            this.fCustomTextDelimiter.TabIndex = 10;
            this.fCustomTextDelimiter.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // fCustomFieldSeparator
            // 
            this.fCustomFieldSeparator.Location = new System.Drawing.Point(421, 6);
            this.fCustomFieldSeparator.MaxLength = 2;
            this.fCustomFieldSeparator.Name = "fCustomFieldSeparator";
            this.fCustomFieldSeparator.Size = new System.Drawing.Size(129, 20);
            this.fCustomFieldSeparator.TabIndex = 9;
            this.fCustomFieldSeparator.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // fCustomRecordSeparator
            // 
            this.fCustomRecordSeparator.Location = new System.Drawing.Point(249, 6);
            this.fCustomRecordSeparator.MaxLength = 2;
            this.fCustomRecordSeparator.Name = "fCustomRecordSeparator";
            this.fCustomRecordSeparator.Size = new System.Drawing.Size(129, 20);
            this.fCustomRecordSeparator.TabIndex = 8;
            this.fCustomRecordSeparator.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // fCustomFormat
            // 
            this.fCustomFormat.AutoSize = true;
            this.fCustomFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fCustomFormat.GroupName = "fileFormat";
            this.fCustomFormat.GroupNameLevel = graunt.GroupableRadioButton.Level.Form;
            this.fCustomFormat.Location = new System.Drawing.Point(16, 6);
            this.fCustomFormat.Name = "fCustomFormat";
            this.fCustomFormat.Size = new System.Drawing.Size(122, 21);
            this.fCustomFormat.TabIndex = 7;
            this.fCustomFormat.Text = "Custom Format";
            this.fCustomFormat.UseVisualStyleBackColor = true;
            this.fCustomFormat.CheckedChanged += new System.EventHandler(this.refreshPreview);
            // 
            // fRowHeader
            // 
            this.fRowHeader.BackColor = System.Drawing.Color.Black;
            this.fRowHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fRowHeader.Controls.Add(this.fTextDelimiter);
            this.fRowHeader.Controls.Add(this.fFieldSeparator);
            this.fRowHeader.Controls.Add(this.fRecordSeparator);
            this.fRowHeader.Controls.Add(this.fFileFormat);
            this.fRowHeader.Location = new System.Drawing.Point(12, 12);
            this.fRowHeader.Name = "fRowHeader";
            this.fRowHeader.Size = new System.Drawing.Size(725, 43);
            this.fRowHeader.TabIndex = 3;
            // 
            // fTextDelimiter
            // 
            this.fTextDelimiter.AutoSize = true;
            this.fTextDelimiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fTextDelimiter.ForeColor = System.Drawing.Color.White;
            this.fTextDelimiter.Location = new System.Drawing.Point(574, 11);
            this.fTextDelimiter.Name = "fTextDelimiter";
            this.fTextDelimiter.Size = new System.Drawing.Size(102, 20);
            this.fTextDelimiter.TabIndex = 3;
            this.fTextDelimiter.Text = "Text delimiter";
            // 
            // fFieldSeparator
            // 
            this.fFieldSeparator.AutoSize = true;
            this.fFieldSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fFieldSeparator.ForeColor = System.Drawing.Color.White;
            this.fFieldSeparator.Location = new System.Drawing.Point(417, 11);
            this.fFieldSeparator.Name = "fFieldSeparator";
            this.fFieldSeparator.Size = new System.Drawing.Size(115, 20);
            this.fFieldSeparator.TabIndex = 2;
            this.fFieldSeparator.Text = "Field separator";
            // 
            // fRecordSeparator
            // 
            this.fRecordSeparator.AutoSize = true;
            this.fRecordSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fRecordSeparator.ForeColor = System.Drawing.Color.White;
            this.fRecordSeparator.Location = new System.Drawing.Point(245, 11);
            this.fRecordSeparator.Name = "fRecordSeparator";
            this.fRecordSeparator.Size = new System.Drawing.Size(133, 20);
            this.fRecordSeparator.TabIndex = 1;
            this.fRecordSeparator.Text = "Record separator";
            // 
            // fFileFormat
            // 
            this.fFileFormat.AutoSize = true;
            this.fFileFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fFileFormat.ForeColor = System.Drawing.Color.White;
            this.fFileFormat.Location = new System.Drawing.Point(12, 11);
            this.fFileFormat.Name = "fFileFormat";
            this.fFileFormat.Size = new System.Drawing.Size(84, 20);
            this.fFileFormat.TabIndex = 0;
            this.fFileFormat.Text = "File format";
            // 
            // fHasHeader
            // 
            this.fHasHeader.AutoSize = true;
            this.fHasHeader.Checked = true;
            this.fHasHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fHasHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fHasHeader.Location = new System.Drawing.Point(13, 201);
            this.fHasHeader.Name = "fHasHeader";
            this.fHasHeader.Size = new System.Drawing.Size(232, 21);
            this.fHasHeader.TabIndex = 4;
            this.fHasHeader.Text = "First row contains column names";
            this.fHasHeader.UseVisualStyleBackColor = true;
            this.fHasHeader.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fDataPreview
            // 
            this.fDataPreview.AllowUserToAddRows = false;
            this.fDataPreview.AllowUserToDeleteRows = false;
            this.fDataPreview.AllowUserToResizeRows = false;
            this.fDataPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.fDataPreview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.fDataPreview.Location = new System.Drawing.Point(12, 274);
            this.fDataPreview.Name = "fDataPreview";
            this.fDataPreview.ReadOnly = true;
            this.fDataPreview.ShowEditingIcon = false;
            this.fDataPreview.Size = new System.Drawing.Size(725, 245);
            this.fDataPreview.TabIndex = 5;
            this.fDataPreview.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.fDataPreview_ColumnWidthChanged);
            // 
            // fError
            // 
            this.fError.AutoSize = true;
            this.fError.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.fError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fError.Location = new System.Drawing.Point(26, 286);
            this.fError.Name = "fError";
            this.fError.Size = new System.Drawing.Size(0, 17);
            this.fError.TabIndex = 6;
            // 
            // fPartial
            // 
            this.fPartial.AutoSize = true;
            this.fPartial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fPartial.Location = new System.Drawing.Point(10, 522);
            this.fPartial.Name = "fPartial";
            this.fPartial.Size = new System.Drawing.Size(543, 17);
            this.fPartial.TabIndex = 7;
            this.fPartial.Text = "Notice: This is preview of the first 10 records. The rest does not have to be rea" +
    "dable.";
            // 
            // fEncoding
            // 
            this.fEncoding.AutoSize = true;
            this.fEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fEncoding.Location = new System.Drawing.Point(9, 228);
            this.fEncoding.Name = "fEncoding";
            this.fEncoding.Size = new System.Drawing.Size(92, 17);
            this.fEncoding.TabIndex = 8;
            this.fEncoding.Text = "File encoding";
            // 
            // fEncodingSelect
            // 
            this.fEncodingSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fEncodingSelect.FormattingEnabled = true;
            this.fEncodingSelect.Location = new System.Drawing.Point(134, 227);
            this.fEncodingSelect.Name = "fEncodingSelect";
            this.fEncodingSelect.Size = new System.Drawing.Size(121, 21);
            this.fEncodingSelect.TabIndex = 9;
            // 
            // ImportCsvWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 569);
            this.ControlBox = false;
            this.Controls.Add(this.fEncodingSelect);
            this.Controls.Add(this.fEncoding);
            this.Controls.Add(this.fPartial);
            this.Controls.Add(this.fError);
            this.Controls.Add(this.fDataPreview);
            this.Controls.Add(this.fHasHeader);
            this.Controls.Add(this.fRowHeader);
            this.Controls.Add(this.fRow2);
            this.Controls.Add(this.fRow3);
            this.Controls.Add(this.fRow4);
            this.Controls.Add(this.fRow1);
            this.Controls.Add(this.fNext);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportCsvWindow";
            this.Text = "Graunt - Import";
            this.Load += new System.EventHandler(this.ImportCsvWindow_Load);
            this.fRow1.ResumeLayout(false);
            this.fRow1.PerformLayout();
            this.fRow2.ResumeLayout(false);
            this.fRow2.PerformLayout();
            this.fRow3.ResumeLayout(false);
            this.fRow3.PerformLayout();
            this.fRow4.ResumeLayout(false);
            this.fRow4.PerformLayout();
            this.fRowHeader.ResumeLayout(false);
            this.fRowHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fDataPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fNext;
        private System.Windows.Forms.Panel fRow1;
        private System.Windows.Forms.Panel fRow2;
        private System.Windows.Forms.Panel fRow3;
        private System.Windows.Forms.Panel fRow4;
        private System.Windows.Forms.Panel fRowHeader;
        private System.Windows.Forms.Label fFileFormat;
        private GroupableRadioButton fCommaSeparatedValues;
        private GroupableRadioButton fSemicolonSeparatedValues;
        private GroupableRadioButton fTabSeparatedValues;
        private GroupableRadioButton fCustomFormat;
        private System.Windows.Forms.Label fDoubleQuote1;
        private System.Windows.Forms.Label fComma;
        private System.Windows.Forms.Label fNewline1;
        private System.Windows.Forms.Label fDoubleQuote2;
        private System.Windows.Forms.Label fSemicolon;
        private System.Windows.Forms.Label fNewline2;
        private System.Windows.Forms.Label fNone;
        private System.Windows.Forms.Label fTab;
        private System.Windows.Forms.Label fNewline3;
        private System.Windows.Forms.Label fTextDelimiter;
        private System.Windows.Forms.Label fFieldSeparator;
        private System.Windows.Forms.Label fRecordSeparator;
        private System.Windows.Forms.CheckBox fHasHeader;
        private System.Windows.Forms.DataGridView fDataPreview;
        private System.Windows.Forms.TextBox fCustomTextDelimiter;
        private System.Windows.Forms.TextBox fCustomFieldSeparator;
        private System.Windows.Forms.TextBox fCustomRecordSeparator;
        private System.Windows.Forms.Label fError;
        private System.Windows.Forms.Label fPartial;
        private System.Windows.Forms.Label fEncoding;
        private System.Windows.Forms.ComboBox fEncodingSelect;
    }
}