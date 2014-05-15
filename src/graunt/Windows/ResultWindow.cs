using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graunt
{
    public partial class ResultWindow : Form
    {
        public ResultWindow()
        {
            InitializeComponent();
            this.Text = "Graunt - " + Language.GetString("result.title");
            fSave.Text = Language.GetString("result.save");
            fClear.Text = Language.GetString("result.clear");
            fHide.Text = Language.GetString("result.hide");
        }

        public void Add(string data)
        {
            if (!string.IsNullOrEmpty(fTextBox.Text))
            {
                fTextBox.Text += "\r\n\r\n";
            }
            fTextBox.AppendText("------------------------- [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] -------------------------\r\n" + data);
        }

        private void fClear_Click(object sender, EventArgs e)
        {
            fTextBox.Text = "";
        }

        private void fSaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            SaveFileDialog saveFileDialog = (SaveFileDialog)sender;

            try
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, fTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(Language.GetString("error.saveErrorMessage") + " " + saveFileDialog.FileName, Language.GetString("error.saveErrorTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fSave_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Owner;
            fSaveFileDialog.Title = Language.GetString("result.saveDialog");
            fSaveFileDialog.FileName = mainWindow.FileName + ".txt";
            fSaveFileDialog.ShowDialog();
        }

        private void fTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                fTextBox.SelectAll();
            }
        }

        private void fHide_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ResultWindow_Shown(object sender, EventArgs e)
        {
            fTextBox.SelectionStart = fTextBox.TextLength;
            fTextBox.ScrollToCaret();
        }
    }
}
