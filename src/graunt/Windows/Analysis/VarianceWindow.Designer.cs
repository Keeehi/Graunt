namespace graunt
{
    partial class VarianceWnindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VarianceWnindow));
            this.fCalculate = new System.Windows.Forms.Button();
            this.fHeader = new System.Windows.Forms.Label();
            this.fSelectedColumnsLabel = new System.Windows.Forms.Label();
            this.fPossibleColumnsLabel = new System.Windows.Forms.Label();
            this.fMoveLeft = new System.Windows.Forms.Button();
            this.fMoveRight = new System.Windows.Forms.Button();
            this.fSelectedColumns = new System.Windows.Forms.ListBox();
            this.fPossibleColumns = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // fCalculate
            // 
            this.fCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fCalculate.Location = new System.Drawing.Point(304, 306);
            this.fCalculate.Name = "fCalculate";
            this.fCalculate.Size = new System.Drawing.Size(136, 34);
            this.fCalculate.TabIndex = 1;
            this.fCalculate.Text = "Calculate";
            this.fCalculate.UseVisualStyleBackColor = true;
            this.fCalculate.Click += new System.EventHandler(this.fNext_Click);
            // 
            // fHeader
            // 
            this.fHeader.AutoSize = true;
            this.fHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fHeader.Location = new System.Drawing.Point(8, 9);
            this.fHeader.Name = "fHeader";
            this.fHeader.Size = new System.Drawing.Size(413, 20);
            this.fHeader.TabIndex = 15;
            this.fHeader.Text = "Select columns from which should be variance calculated.";
            // 
            // fSelectedColumnsLabel
            // 
            this.fSelectedColumnsLabel.AutoSize = true;
            this.fSelectedColumnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fSelectedColumnsLabel.Location = new System.Drawing.Point(275, 42);
            this.fSelectedColumnsLabel.Name = "fSelectedColumnsLabel";
            this.fSelectedColumnsLabel.Size = new System.Drawing.Size(98, 17);
            this.fSelectedColumnsLabel.TabIndex = 14;
            this.fSelectedColumnsLabel.Text = "Calculate from";
            // 
            // fPossibleColumnsLabel
            // 
            this.fPossibleColumnsLabel.AutoSize = true;
            this.fPossibleColumnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fPossibleColumnsLabel.Location = new System.Drawing.Point(12, 42);
            this.fPossibleColumnsLabel.Name = "fPossibleColumnsLabel";
            this.fPossibleColumnsLabel.Size = new System.Drawing.Size(117, 17);
            this.fPossibleColumnsLabel.TabIndex = 13;
            this.fPossibleColumnsLabel.Text = "Possible columns";
            // 
            // fMoveLeft
            // 
            this.fMoveLeft.Location = new System.Drawing.Point(207, 188);
            this.fMoveLeft.Name = "fMoveLeft";
            this.fMoveLeft.Size = new System.Drawing.Size(41, 28);
            this.fMoveLeft.TabIndex = 12;
            this.fMoveLeft.Text = "<";
            this.fMoveLeft.UseVisualStyleBackColor = true;
            this.fMoveLeft.Click += new System.EventHandler(this.fMoveLeft_Click);
            // 
            // fMoveRight
            // 
            this.fMoveRight.Location = new System.Drawing.Point(207, 135);
            this.fMoveRight.Name = "fMoveRight";
            this.fMoveRight.Size = new System.Drawing.Size(41, 28);
            this.fMoveRight.TabIndex = 11;
            this.fMoveRight.Text = ">";
            this.fMoveRight.UseVisualStyleBackColor = true;
            this.fMoveRight.Click += new System.EventHandler(this.fMoveRight_Click);
            // 
            // fSelectedColumns
            // 
            this.fSelectedColumns.FormattingEnabled = true;
            this.fSelectedColumns.HorizontalScrollbar = true;
            this.fSelectedColumns.Location = new System.Drawing.Point(276, 62);
            this.fSelectedColumns.Name = "fSelectedColumns";
            this.fSelectedColumns.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.fSelectedColumns.Size = new System.Drawing.Size(164, 238);
            this.fSelectedColumns.TabIndex = 10;
            // 
            // fPossibleColumns
            // 
            this.fPossibleColumns.FormattingEnabled = true;
            this.fPossibleColumns.HorizontalScrollbar = true;
            this.fPossibleColumns.Location = new System.Drawing.Point(12, 62);
            this.fPossibleColumns.Name = "fPossibleColumns";
            this.fPossibleColumns.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.fPossibleColumns.Size = new System.Drawing.Size(164, 238);
            this.fPossibleColumns.TabIndex = 9;
            // 
            // VarianceWnindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 353);
            this.Controls.Add(this.fHeader);
            this.Controls.Add(this.fSelectedColumnsLabel);
            this.Controls.Add(this.fPossibleColumnsLabel);
            this.Controls.Add(this.fMoveLeft);
            this.Controls.Add(this.fMoveRight);
            this.Controls.Add(this.fSelectedColumns);
            this.Controls.Add(this.fPossibleColumns);
            this.Controls.Add(this.fCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VarianceWnindow";
            this.Text = "Graunt - Variance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fCalculate;
        private System.Windows.Forms.Label fHeader;
        private System.Windows.Forms.Label fSelectedColumnsLabel;
        private System.Windows.Forms.Label fPossibleColumnsLabel;
        private System.Windows.Forms.Button fMoveLeft;
        private System.Windows.Forms.Button fMoveRight;
        private System.Windows.Forms.ListBox fSelectedColumns;
        private System.Windows.Forms.ListBox fPossibleColumns;
    }
}