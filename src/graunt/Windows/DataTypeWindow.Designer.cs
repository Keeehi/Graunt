namespace graunt
{
    partial class DataTypeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataTypeWindow));
            this.fRowsWrapper = new System.Windows.Forms.Panel();
            this.fNextWrapper = new System.Windows.Forms.Panel();
            this.fNext = new System.Windows.Forms.Button();
            this.fRowHeader = new System.Windows.Forms.Panel();
            this.fBadValue = new System.Windows.Forms.Label();
            this.fType = new System.Windows.Forms.Label();
            this.fColumn = new System.Windows.Forms.Label();
            this.fRowsWrapper.SuspendLayout();
            this.fNextWrapper.SuspendLayout();
            this.fRowHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // fRowsWrapper
            // 
            this.fRowsWrapper.AutoScroll = true;
            this.fRowsWrapper.Controls.Add(this.fNextWrapper);
            this.fRowsWrapper.Location = new System.Drawing.Point(0, 42);
            this.fRowsWrapper.Name = "fRowsWrapper";
            this.fRowsWrapper.Size = new System.Drawing.Size(971, 549);
            this.fRowsWrapper.TabIndex = 0;
            // 
            // fNextWrapper
            // 
            this.fNextWrapper.Controls.Add(this.fNext);
            this.fNextWrapper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fNextWrapper.Location = new System.Drawing.Point(0, 491);
            this.fNextWrapper.Name = "fNextWrapper";
            this.fNextWrapper.Size = new System.Drawing.Size(971, 58);
            this.fNextWrapper.TabIndex = 0;
            // 
            // fNext
            // 
            this.fNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fNext.Location = new System.Drawing.Point(823, 12);
            this.fNext.Name = "fNext";
            this.fNext.Size = new System.Drawing.Size(136, 34);
            this.fNext.TabIndex = 1;
            this.fNext.Text = "Next";
            this.fNext.UseVisualStyleBackColor = true;
            this.fNext.Click += new System.EventHandler(this.fNext_Click);
            // 
            // fRowHeader
            // 
            this.fRowHeader.BackColor = System.Drawing.Color.Black;
            this.fRowHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fRowHeader.Controls.Add(this.fBadValue);
            this.fRowHeader.Controls.Add(this.fType);
            this.fRowHeader.Controls.Add(this.fColumn);
            this.fRowHeader.Location = new System.Drawing.Point(0, 0);
            this.fRowHeader.Name = "fRowHeader";
            this.fRowHeader.Size = new System.Drawing.Size(970, 43);
            this.fRowHeader.TabIndex = 6;
            // 
            // fBadValue
            // 
            this.fBadValue.AutoSize = true;
            this.fBadValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fBadValue.ForeColor = System.Drawing.Color.White;
            this.fBadValue.Location = new System.Drawing.Point(267, 11);
            this.fBadValue.Name = "fBadValue";
            this.fBadValue.Size = new System.Drawing.Size(152, 20);
            this.fBadValue.TabIndex = 2;
            this.fBadValue.Text = "Bad value treatment";
            // 
            // fType
            // 
            this.fType.AutoSize = true;
            this.fType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fType.ForeColor = System.Drawing.Color.White;
            this.fType.Location = new System.Drawing.Point(150, 11);
            this.fType.Name = "fType";
            this.fType.Size = new System.Drawing.Size(43, 20);
            this.fType.TabIndex = 1;
            this.fType.Text = "Type";
            // 
            // fColumn
            // 
            this.fColumn.AutoSize = true;
            this.fColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fColumn.ForeColor = System.Drawing.Color.White;
            this.fColumn.Location = new System.Drawing.Point(11, 11);
            this.fColumn.Name = "fColumn";
            this.fColumn.Size = new System.Drawing.Size(63, 20);
            this.fColumn.TabIndex = 0;
            this.fColumn.Text = "Column";
            // 
            // DataTypeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 591);
            this.ControlBox = false;
            this.Controls.Add(this.fRowHeader);
            this.Controls.Add(this.fRowsWrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataTypeWindow";
            this.Text = "DataTypeWindow";
            this.fRowsWrapper.ResumeLayout(false);
            this.fNextWrapper.ResumeLayout(false);
            this.fRowHeader.ResumeLayout(false);
            this.fRowHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fRowsWrapper;
        private System.Windows.Forms.Panel fRowHeader;
        private System.Windows.Forms.Label fBadValue;
        private System.Windows.Forms.Label fType;
        private System.Windows.Forms.Label fColumn;
        private System.Windows.Forms.Panel fNextWrapper;
        private System.Windows.Forms.Button fNext;


    }
}