using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graunt
{
    public partial class MainWindow : Form
    {
        private ResultWindow resultWindow;
        public string FileName { get; private set; }
        public string FullFileName { get; private set; }
        private bool edited = false;
        private bool isNewFile = false;
        private bool forceClose = false;
        
        public MainWindow()
        {
            InitializeComponent();

            ShowInitialForm();

            resultWindow = new ResultWindow();

            this.Text = "Graunt";

            fTMFile.Text = Language.GetString("menu.file");
            fTMOpen.Text = Language.GetString("menu.open");
            fTMOpenFile.Text = Language.GetString("menu.openFile");
            fTMSave.Text = Language.GetString("menu.save");
            fTMSaveAs.Text = Language.GetString("menu.saveAs");
            fTMImport.Text = Language.GetString("menu.import");

            fTMAnalyse.Text = Language.GetString("menu.analyse");
            fTMMean.Text = Language.GetString("analyse.mean");
            fTMMedian.Text = Language.GetString("analyse.median");
            fTMVariance.Text = Language.GetString("analyse.variance");
            fTMStandardDeviation.Text = Language.GetString("analyse.standardDeviation");

            fTMResults.Text = Language.GetString("menu.results");

            fTMSettings.Text = Language.GetString("menu.settings");

            fTMHelp.Text = Language.GetString("menu.help");
            fTMUserGuide.Text = Language.GetString("menu.userGuide");
            fTMAbout.Text = Language.GetString("menu.about") + " Graunt";

            fBMean.Text = Language.GetString("analyse.mean");
            fBMedian.Text = Language.GetString("analyse.median");
            fBVariance.Text = Language.GetString("analyse.variance");
            fBStandardDeviation.Text = Language.GetString("analyse.standardDeviation");

            fOpenFileDialog.Title = Language.GetString("main.openDialog");
            fSaveFileDialog.Title = Language.GetString("main.saveDialog");

            ReloadRecent();
        }

        //refresh entries in file > open
        private void ReloadRecent()
        {
            while (fTMOpen.DropDownItems.Count > 1) {
                fTMOpen.DropDownItems.RemoveAt(1);
            }

            foreach (string file in GrauntSettings.RecentProjects.AsEnumerable().Reverse())
            {
                if (!File.Exists(file))
                {
                    continue;
                }

                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();

                toolStripMenuItem.Size = new System.Drawing.Size(56, 20);
                toolStripMenuItem.Text = Path.GetFileNameWithoutExtension(file);
                toolStripMenuItem.ToolTipText = file;
                toolStripMenuItem.Click += new System.EventHandler(this.fTMOpenRecent);

                fTMOpen.DropDownItems.Add(toolStripMenuItem);
            }
        }

        private void fTMOpenRecent(object sender, EventArgs e)
        {
            if (SafeCloseFile() != 1)
            {
                return;
            }

            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;

            if (!OpenFile(toolStripMenuItem.ToolTipText))
            {
                MessageBox.Show(Language.GetString("error.openErrorMessage") + " " + toolStripMenuItem.ToolTipText, Language.GetString("error.openErrorTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool OpenFile(string fileName)
        {
            if (LoadState(fileName))
            {
                FileName = Path.GetFileNameWithoutExtension(fileName);
                FullFileName = fileName;
                GrauntSettings.AddRecentProject(FullFileName);
                ReloadRecent();
                edited = false;
                isNewFile = false;
                Text = "Graunt - " + FileName;

                if (this.Visible)
                {
                    NewDataLoaded();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool SaveFile()
        {
            if (fWorkspace.DataSource == null)
            {
                MessageBox.Show(Language.GetString("error.saveNothinMessage"), Language.GetString("error.saveNothinTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            if (edited)
            {
                if (isNewFile)
                {
                    fSaveFileDialog.FileName = FileName + ".gdf";
                    fSaveFileDialog.ShowDialog();
                    
                    if (!edited)
                    {
                        GrauntSettings.AddRecentProject(FullFileName);
                        ReloadRecent();
                        edited = false;
                        isNewFile = false;
                        Text = "Graunt - " + FileName;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (SaveState(FullFileName))
                    {
                        GrauntSettings.AddRecentProject(FullFileName);
                        ReloadRecent();
                        edited = false;
                        isNewFile = false;
                        Text = "Graunt - " + FileName;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show(Language.GetString("error.saveErrorTitle") + " " + FullFileName, Language.GetString("error.saveErrorTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            GrauntSettings.AddRecentProject(FullFileName);
            ReloadRecent();
            edited = false;
            isNewFile = false;
            Text = "Graunt - " + FileName;
            return true;
        }

        //ask, if user wansts to save file
        private int SafeCloseFile()
        {
            if (edited)
            {
                DialogResult dialogResult = MessageBox.Show(Language.GetString("error.saveConfirmMessage") + " " + FullFileName + "?", Language.GetString("error.saveConfirmTitle"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    if (SaveFile())
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else if (dialogResult == System.Windows.Forms.DialogResult.No)
                {
                    return 1;
                }

                return 0;
            }
            else
            {
                return 1;
            }
        }


        //ask, if user wansts to save file, forceSave = no cancel option
        private int SafeCloseFile(bool forceSave)
        {
            if (edited)
            {
                MessageBoxButtons messageBoxButtons;
                if (forceSave)
                {
                    messageBoxButtons = MessageBoxButtons.YesNo;
                }
                else
                {
                    messageBoxButtons = MessageBoxButtons.YesNoCancel;
                }
                DialogResult dialogResult = MessageBox.Show(Language.GetString("error.saveConfirmMessage") + " " + FullFileName + "?", Language.GetString("error.saveConfirmTitle"), messageBoxButtons, MessageBoxIcon.Question);

                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    if (SaveFile())
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else if (dialogResult == System.Windows.Forms.DialogResult.No)
                {
                    return 1;
                }

                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void ShowInitialForm()
        {
            InitialWindow initialWindow = new InitialWindow();
            initialWindow.Show();

            initialWindow.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InitialWindow_FormClosing);
        }

        private void CsvImport_Finished(object sender, EventArgs e)
        {
            if (SafeCloseFile() != 1)
            {
                return;
            }

            CsvImport csvImport = (CsvImport)sender;

            FileName = Path.GetFileNameWithoutExtension(csvImport.FileName);
            FullFileName = csvImport.FileName;
            edited = true;
            isNewFile = true;
            Text = "Graunt - " + FileName + "*";

            fWorkspace.DataSource = csvImport.Data;
            this.Show();
            NewDataLoaded();
        }

        private void InitialWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            InitialWindow initialWindow = (InitialWindow)sender;

            if (initialWindow.SelectedAction == InitialWindow.Action.Open)
            {
                fOpenFileDialog.ShowDialog();
                this.Show();
                NewDataLoaded();
            }
            else if (initialWindow.SelectedAction == InitialWindow.Action.Import)
            {
                CsvImport csvImport = new CsvImport();
                csvImport.Finished += new FinishedEventHandler(this.CsvImport_Finished);
                csvImport.Import();
            }
            else if (initialWindow.SelectedAction == InitialWindow.Action.OpenRecent)
            {
                this.Show();
                if (!OpenFile(initialWindow.Data))
                {
                    MessageBox.Show(Language.GetString("error.openErrorMessage") + " " + initialWindow.Data, Language.GetString("error.openErrorTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.Show();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (forceClose)
            {
                Application.Exit();
                return;
            }

            int result = SafeCloseFile(e.CloseReason != CloseReason.UserClosing);
            if ( result == 1)
            {
                forceClose = true;
                Application.Exit();
                return;
            }
            else
            {
                if (result == 2)
                {
                    forceClose = true;
                    Application.Exit();
                }
                else if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                }
            }
        }

        //checking for empty cels -> red color
        private void fWorkspace_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0 || e.ColumnIndex > fWorkspace.Columns.Count - 1 || e.RowIndex > fWorkspace.Rows.Count)
            {
                return;
            }

            if (fWorkspace[e.ColumnIndex, e.RowIndex].Value == DBNull.Value)
            {
                fWorkspace[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.FromArgb(255, 192, 192);
            }
            else
            {
                fWorkspace[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
            }

            if (!edited)
            {
                Text += "*";
            }
            edited = true;
        }

        private void fTMOpenFile_Click(object sender, EventArgs e)
        {
            if (SafeCloseFile() != 1)
            {
                return;
            }

            fOpenFileDialog.ShowDialog();
        }

        private void fTMSaveAs_Click(object sender, EventArgs e)
        {
            if (isNewFile && edited)
            {
                SaveFile();
            }
            else
            {
                bool oldIsNewFile = isNewFile;
                bool oldEdited = edited;
                isNewFile = true;
                edited = true;
                if (!SaveFile())
                {
                    isNewFile = oldIsNewFile;
                    edited = oldEdited;
                }
            }            
        }

        private void fSaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = ((SaveFileDialog)sender).FileName;

            string oldFileName = FileName;
            string oldFullFileName = FullFileName;
            bool oldIsNewFile = isNewFile;

            FileName = Path.GetFileNameWithoutExtension(fileName);
            FullFileName = fileName;
            isNewFile = false;

            if (!SaveFile())
            {
                FileName = oldFileName;
                FullFileName = oldFullFileName;
                isNewFile = oldIsNewFile;
            }
        }
        private void fOpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (!OpenFile(((OpenFileDialog)sender).FileName))
            {
                MessageBox.Show(Language.GetString("error.openErrorMessage") + " " + ((OpenFileDialog)sender).FileName, Language.GetString("error.openErrorTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //checking for empty cells -> color red, after change source of data
        private void NewDataLoaded()
        {
            AutoSizeColums();

            for (int rowIndex = 0; rowIndex < fWorkspace.Rows.Count; ++rowIndex)
            {
                for (int columnIndex = 0; columnIndex < fWorkspace.Columns.Count; ++columnIndex)
                {
                    if (fWorkspace[columnIndex, rowIndex].Value == DBNull.Value)
                    {
                        fWorkspace[columnIndex, rowIndex].Style.BackColor = Color.FromArgb(255, 192, 192);
                    }
                }
            }
        }

        private void AutoSizeColums()
        {
            fWorkspace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            for (int i = 0; i < fWorkspace.Columns.Count; i++)
            {
                int width = fWorkspace.Columns[i].Width;
                fWorkspace.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                fWorkspace.Columns[i].Width = width;
                fWorkspace.Columns[i].MinimumWidth = 30;
            }
        }


        private bool LoadState(string fileName)
        {
            DataFile dataFile;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                dataFile = (DataFile)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (Exception)
            {
                return false;
            }
            
            try
            {
                fWorkspace.DataSource = dataFile.Data;
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private bool SaveState(string fileName)
        {
            DataFile dataFile = new DataFile();

            try
            {
                dataFile.Data = (DataTable)fWorkspace.DataSource;
                dataFile.Settings = new Dictionary<string, string>();
            } catch (Exception)
            {
                return false;
            }


            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, dataFile);
                stream.Close();
            } catch (Exception)
            {
                return false;
            }

            return true;
        }

        private void fTMSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void fTMImport_Click(object sender, EventArgs e)
        {
            if (SafeCloseFile() != 1)
            {
                return;
            }

            CsvImport csvImport = new CsvImport();
            csvImport.Finished += new FinishedEventHandler(this.CsvImport_Finished);
            csvImport.Import();
        }

        private void fTMSettings_Click(object sender, EventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            if (settingsWindow.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(Language.GetString("error.settingsSavedMessage"), Language.GetString("error.settingsSavedTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void Mean_Click(object sender, EventArgs e)
        {
            if (fWorkspace.DataSource == null)
            {
                MessageBox.Show(Language.GetString("error.analyseNothingMessage"), Language.GetString("error.analyseNothingTitle"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Analyse(new MeanWindow((DataTable)fWorkspace.DataSource));
            }
        }

        private void Median_Click(object sender, EventArgs e)
        {
            if (fWorkspace.DataSource == null)
            {
                MessageBox.Show(Language.GetString("error.analyseNothingMessage"), Language.GetString("error.analyseNothingTitle"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Analyse(new MedianWindow((DataTable)fWorkspace.DataSource));
            }
        }


        private void Variance_Click(object sender, EventArgs e)
        {
            if (fWorkspace.DataSource == null)
            {
                MessageBox.Show(Language.GetString("error.analyseNothingMessage"), Language.GetString("error.analyseNothingTitle"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Analyse(new VarianceWnindow((DataTable)fWorkspace.DataSource));
            }
        }


        private void StandardDeviation_Click(object sender, EventArgs e)
        {
            if (fWorkspace.DataSource == null)
            {
                MessageBox.Show(Language.GetString("error.analyseNothingMessage"), Language.GetString("error.analyseNothingTitle"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Analyse(new StandardDeviationWnindow((DataTable)fWorkspace.DataSource));
            }
        }


        private void Analyse(BaseAnalysisWindow analysisWindow)
        {
            if (analysisWindow.ShowDialog() == DialogResult.OK)
            {
                resultWindow.Add(analysisWindow.Data);
                resultWindow.ShowDialog(this);
            }
        }

        private void fWorkspace_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            if (MessageBox.Show(Language.GetString("error.badFormatMessage"), Language.GetString("error.badFormatTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                var ctl = fWorkspace.EditingControl as DataGridViewTextBoxEditingControl;

                if (ctl != null)
                {
                    ctl.Text = "";
                }
            }
        }

        private void fTMResults_Click(object sender, EventArgs e)
        {
            resultWindow.ShowDialog(this);
        }

        private void fTMUserGuide_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://github.com/Keeehi/Graunt/tree/master/User%20Guide");
            }
            catch {}
        }

        private void fTMAbout_Click(object sender, EventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog(this);
        }

        //coloring newly added rows to red (empty cells)
        private void fWorkspace_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (((DataTable)fWorkspace.DataSource).Rows.Count < e.RowIndex)
            {
                for (int columnIndex = 0; columnIndex < fWorkspace.Columns.Count; ++columnIndex)
                {
                    if (fWorkspace.CurrentCell.ColumnIndex != columnIndex && fWorkspace[columnIndex, e.RowIndex-1].Value == DBNull.Value)
                    {
                        fWorkspace[columnIndex, e.RowIndex-1].Style.BackColor = Color.FromArgb(255, 192, 192);
                    }
                }
                
            }

        }

        private void fWorkspace_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (fWorkspace.CurrentCell.IsInEditMode && string.IsNullOrEmpty((string)fWorkspace.CurrentCell.EditedFormattedValue))
            {
                fWorkspace[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.FromArgb(255, 192, 192);
            }
        }
    }
}
