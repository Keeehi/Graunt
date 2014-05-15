namespace graunt
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.fStatusStrip = new System.Windows.Forms.StatusStrip();
            this.fTopMenu = new System.Windows.Forms.MenuStrip();
            this.fTMFile = new System.Windows.Forms.ToolStripMenuItem();
            this.fTMOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fTMOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.fTMSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fTMSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.fTMImport = new System.Windows.Forms.ToolStripMenuItem();
            this.fTMAnalyse = new System.Windows.Forms.ToolStripMenuItem();
            this.fTMMean = new System.Windows.Forms.ToolStripMenuItem();
            this.fTMMedian = new System.Windows.Forms.ToolStripMenuItem();
            this.fTMVariance = new System.Windows.Forms.ToolStripMenuItem();
            this.fTMStandardDeviation = new System.Windows.Forms.ToolStripMenuItem();
            this.fTMResults = new System.Windows.Forms.ToolStripMenuItem();
            this.fTMSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.fTMHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.fTMUserGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.fTMAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.fAnalysePanel = new System.Windows.Forms.Panel();
            this.fBVariance = new System.Windows.Forms.Button();
            this.fBStandardDeviation = new System.Windows.Forms.Button();
            this.fBMedian = new System.Windows.Forms.Button();
            this.fBMean = new System.Windows.Forms.Button();
            this.fSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fWorkspace = new System.Windows.Forms.DataGridView();
            this.fTopMenu.SuspendLayout();
            this.fAnalysePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fWorkspace)).BeginInit();
            this.SuspendLayout();
            // 
            // fStatusStrip
            // 
            this.fStatusStrip.Location = new System.Drawing.Point(0, 477);
            this.fStatusStrip.Name = "fStatusStrip";
            this.fStatusStrip.Size = new System.Drawing.Size(647, 22);
            this.fStatusStrip.TabIndex = 8;
            this.fStatusStrip.Text = "statusStrip1";
            // 
            // fTopMenu
            // 
            this.fTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fTMFile,
            this.fTMAnalyse,
            this.fTMResults,
            this.fTMSettings,
            this.fTMHelp});
            this.fTopMenu.Location = new System.Drawing.Point(0, 0);
            this.fTopMenu.Name = "fTopMenu";
            this.fTopMenu.Size = new System.Drawing.Size(647, 24);
            this.fTopMenu.TabIndex = 9;
            this.fTopMenu.Text = "menuStrip1";
            // 
            // fTMFile
            // 
            this.fTMFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fTMOpen,
            this.fTMSave,
            this.fTMSaveAs,
            this.fTMImport});
            this.fTMFile.Name = "fTMFile";
            this.fTMFile.Size = new System.Drawing.Size(37, 20);
            this.fTMFile.Text = "File";
            // 
            // fTMOpen
            // 
            this.fTMOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fTMOpenFile});
            this.fTMOpen.Name = "fTMOpen";
            this.fTMOpen.Size = new System.Drawing.Size(124, 22);
            this.fTMOpen.Text = "Open";
            // 
            // fTMOpenFile
            // 
            this.fTMOpenFile.Name = "fTMOpenFile";
            this.fTMOpenFile.Size = new System.Drawing.Size(92, 22);
            this.fTMOpenFile.Text = "File";
            this.fTMOpenFile.Click += new System.EventHandler(this.fTMOpenFile_Click);
            // 
            // fTMSave
            // 
            this.fTMSave.Name = "fTMSave";
            this.fTMSave.Size = new System.Drawing.Size(124, 22);
            this.fTMSave.Text = "Save";
            this.fTMSave.Click += new System.EventHandler(this.fTMSave_Click);
            // 
            // fTMSaveAs
            // 
            this.fTMSaveAs.Name = "fTMSaveAs";
            this.fTMSaveAs.Size = new System.Drawing.Size(124, 22);
            this.fTMSaveAs.Text = "Save as ...";
            this.fTMSaveAs.Click += new System.EventHandler(this.fTMSaveAs_Click);
            // 
            // fTMImport
            // 
            this.fTMImport.Name = "fTMImport";
            this.fTMImport.Size = new System.Drawing.Size(124, 22);
            this.fTMImport.Text = "Import ...";
            this.fTMImport.Click += new System.EventHandler(this.fTMImport_Click);
            // 
            // fTMAnalyse
            // 
            this.fTMAnalyse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fTMMean,
            this.fTMMedian,
            this.fTMVariance,
            this.fTMStandardDeviation});
            this.fTMAnalyse.Name = "fTMAnalyse";
            this.fTMAnalyse.Size = new System.Drawing.Size(60, 20);
            this.fTMAnalyse.Text = "Analyse";
            // 
            // fTMMean
            // 
            this.fTMMean.Name = "fTMMean";
            this.fTMMean.Size = new System.Drawing.Size(173, 22);
            this.fTMMean.Text = "Mean";
            this.fTMMean.Click += new System.EventHandler(this.Mean_Click);
            // 
            // fTMMedian
            // 
            this.fTMMedian.Name = "fTMMedian";
            this.fTMMedian.Size = new System.Drawing.Size(173, 22);
            this.fTMMedian.Text = "Median";
            this.fTMMedian.Click += new System.EventHandler(this.Median_Click);
            // 
            // fTMVariance
            // 
            this.fTMVariance.Name = "fTMVariance";
            this.fTMVariance.Size = new System.Drawing.Size(173, 22);
            this.fTMVariance.Text = "Variance";
            this.fTMVariance.Click += new System.EventHandler(this.Variance_Click);
            // 
            // fTMStandardDeviation
            // 
            this.fTMStandardDeviation.Name = "fTMStandardDeviation";
            this.fTMStandardDeviation.Size = new System.Drawing.Size(173, 22);
            this.fTMStandardDeviation.Text = "Standard deviation";
            this.fTMStandardDeviation.Click += new System.EventHandler(this.StandardDeviation_Click);
            // 
            // fTMResults
            // 
            this.fTMResults.Name = "fTMResults";
            this.fTMResults.Size = new System.Drawing.Size(56, 20);
            this.fTMResults.Text = "Results";
            this.fTMResults.Click += new System.EventHandler(this.fTMResults_Click);
            // 
            // fTMSettings
            // 
            this.fTMSettings.Name = "fTMSettings";
            this.fTMSettings.Size = new System.Drawing.Size(61, 20);
            this.fTMSettings.Text = "Settings";
            this.fTMSettings.Click += new System.EventHandler(this.fTMSettings_Click);
            // 
            // fTMHelp
            // 
            this.fTMHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fTMUserGuide,
            this.fTMAbout});
            this.fTMHelp.Name = "fTMHelp";
            this.fTMHelp.Size = new System.Drawing.Size(44, 20);
            this.fTMHelp.Text = "Help";
            // 
            // fTMUserGuide
            // 
            this.fTMUserGuide.Name = "fTMUserGuide";
            this.fTMUserGuide.Size = new System.Drawing.Size(146, 22);
            this.fTMUserGuide.Text = "User guide";
            this.fTMUserGuide.Click += new System.EventHandler(this.fTMUserGuide_Click);
            // 
            // fTMAbout
            // 
            this.fTMAbout.Name = "fTMAbout";
            this.fTMAbout.Size = new System.Drawing.Size(146, 22);
            this.fTMAbout.Text = "About Graunt";
            this.fTMAbout.Click += new System.EventHandler(this.fTMAbout_Click);
            // 
            // fAnalysePanel
            // 
            this.fAnalysePanel.Controls.Add(this.fBVariance);
            this.fAnalysePanel.Controls.Add(this.fBStandardDeviation);
            this.fAnalysePanel.Controls.Add(this.fBMedian);
            this.fAnalysePanel.Controls.Add(this.fBMean);
            this.fAnalysePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fAnalysePanel.Location = new System.Drawing.Point(0, 24);
            this.fAnalysePanel.Name = "fAnalysePanel";
            this.fAnalysePanel.Size = new System.Drawing.Size(647, 64);
            this.fAnalysePanel.TabIndex = 10;
            // 
            // fBVariance
            // 
            this.fBVariance.Location = new System.Drawing.Point(168, 4);
            this.fBVariance.Name = "fBVariance";
            this.fBVariance.Size = new System.Drawing.Size(72, 55);
            this.fBVariance.TabIndex = 4;
            this.fBVariance.Text = "Variance";
            this.fBVariance.UseVisualStyleBackColor = true;
            this.fBVariance.Click += new System.EventHandler(this.Variance_Click);
            // 
            // fBStandardDeviation
            // 
            this.fBStandardDeviation.Location = new System.Drawing.Point(246, 4);
            this.fBStandardDeviation.Name = "fBStandardDeviation";
            this.fBStandardDeviation.Size = new System.Drawing.Size(72, 55);
            this.fBStandardDeviation.TabIndex = 3;
            this.fBStandardDeviation.Text = "Standard deviation";
            this.fBStandardDeviation.UseVisualStyleBackColor = true;
            this.fBStandardDeviation.Click += new System.EventHandler(this.StandardDeviation_Click);
            // 
            // fBMedian
            // 
            this.fBMedian.Location = new System.Drawing.Point(90, 4);
            this.fBMedian.Name = "fBMedian";
            this.fBMedian.Size = new System.Drawing.Size(72, 55);
            this.fBMedian.TabIndex = 2;
            this.fBMedian.Text = "Median";
            this.fBMedian.UseVisualStyleBackColor = true;
            this.fBMedian.Click += new System.EventHandler(this.Median_Click);
            // 
            // fBMean
            // 
            this.fBMean.Location = new System.Drawing.Point(12, 4);
            this.fBMean.Name = "fBMean";
            this.fBMean.Size = new System.Drawing.Size(72, 55);
            this.fBMean.TabIndex = 1;
            this.fBMean.Text = "Mean";
            this.fBMean.UseVisualStyleBackColor = true;
            this.fBMean.Click += new System.EventHandler(this.Mean_Click);
            // 
            // fSaveFileDialog
            // 
            this.fSaveFileDialog.DefaultExt = "gdf";
            this.fSaveFileDialog.Filter = "Graunt data file (*.gdf)|*.gdf|All files (*.*)|*.*";
            this.fSaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fSaveFileDialog_FileOk);
            // 
            // fOpenFileDialog
            // 
            this.fOpenFileDialog.DefaultExt = "gdf";
            this.fOpenFileDialog.Filter = "Graunt data file (*.gdf)|*.gdf|All files (*.*)|*.*";
            this.fOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fOpenFileDialog_FileOk);
            // 
            // fWorkspace
            // 
            this.fWorkspace.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.fWorkspace.BackgroundColor = System.Drawing.SystemColors.Window;
            this.fWorkspace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fWorkspace.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.fWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fWorkspace.Location = new System.Drawing.Point(0, 88);
            this.fWorkspace.MultiSelect = false;
            this.fWorkspace.Name = "fWorkspace";
            this.fWorkspace.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.fWorkspace.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fWorkspace.Size = new System.Drawing.Size(647, 389);
            this.fWorkspace.TabIndex = 11;
            this.fWorkspace.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.fWorkspace_CellLeave);
            this.fWorkspace.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.fWorkspace_CellValueChanged);
            this.fWorkspace.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.fWorkspace_DataError);
            this.fWorkspace.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.fWorkspace_RowsAdded);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 499);
            this.Controls.Add(this.fWorkspace);
            this.Controls.Add(this.fStatusStrip);
            this.Controls.Add(this.fAnalysePanel);
            this.Controls.Add(this.fTopMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.fTopMenu;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainWindow";
            this.Text = "Graunt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.fTopMenu.ResumeLayout(false);
            this.fTopMenu.PerformLayout();
            this.fAnalysePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fWorkspace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip fStatusStrip;
        private System.Windows.Forms.MenuStrip fTopMenu;
        private System.Windows.Forms.ToolStripMenuItem fTMFile;
        private System.Windows.Forms.ToolStripMenuItem fTMOpen;
        private System.Windows.Forms.ToolStripMenuItem fTMSave;
        private System.Windows.Forms.ToolStripMenuItem fTMImport;
        private System.Windows.Forms.ToolStripMenuItem fTMAnalyse;
        private System.Windows.Forms.ToolStripMenuItem fTMMean;
        private System.Windows.Forms.ToolStripMenuItem fTMMedian;
        private System.Windows.Forms.ToolStripMenuItem fTMSettings;
        private System.Windows.Forms.Panel fAnalysePanel;
        private System.Windows.Forms.Button fBStandardDeviation;
        private System.Windows.Forms.Button fBMedian;
        private System.Windows.Forms.Button fBMean;
        private System.Windows.Forms.ToolStripMenuItem fTMOpenFile;
        private System.Windows.Forms.ToolStripMenuItem fTMSaveAs;
        private System.Windows.Forms.ToolStripMenuItem fTMStandardDeviation;
        private System.Windows.Forms.SaveFileDialog fSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog fOpenFileDialog;
        private System.Windows.Forms.ToolStripMenuItem fTMResults;
        private System.Windows.Forms.DataGridView fWorkspace;
        private System.Windows.Forms.ToolStripMenuItem fTMHelp;
        private System.Windows.Forms.ToolStripMenuItem fTMUserGuide;
        private System.Windows.Forms.ToolStripMenuItem fTMAbout;
        private System.Windows.Forms.ToolStripMenuItem fTMVariance;
        private System.Windows.Forms.Button fBVariance;
    }
}