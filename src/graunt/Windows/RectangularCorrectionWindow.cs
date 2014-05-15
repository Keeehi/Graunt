using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graunt
{
    public partial class RectangularCorrectionWindow : Form
    {
        public int SelectedColumn { get; private set; }
        public int LongerRecords { get; private set; }
        public int ShorterRecords { get; private set; }


        public RectangularCorrectionWindow(ReadOnlyCollection<string> columnNames, int preselectedColumn)
        {
            InitializeComponent();
            fColumnSelect.Items.AddRange(columnNames.ToArray());
            fColumnSelect.SelectedIndex = preselectedColumn;

            this.Text = "Graunt - " + Language.GetString("rectangular.title");
            fHeader.Text = Language.GetString("rectangular.header");
            fValidColumn.Text = Language.GetString("rectangular.validColumn");
            fLonger.Text = Language.GetString("rectangular.longer");
            fCrop.Text = Language.GetString("rectangular.crop");
            fIgnore1.Text = Language.GetString("rectangular.ignore");
            fShorter.Text = Language.GetString("rectangular.shorter");
            fAppend.Text = Language.GetString("rectangular.append");
            fIgnore2.Text = Language.GetString("rectangular.ignore");
            fNext.Text = Language.GetString("rectangular.next");
        }

        private void fNext_Click(object sender, EventArgs e)
        {
            if (fCrop.Checked)
            {
                LongerRecords = 0;
            }
            else
            {
                LongerRecords = 1;
            }

            if (fAppend.Checked)
            {
                ShorterRecords = 0;
            }
            else
            {
                ShorterRecords = 1;
            }

            SelectedColumn = fColumnSelect.SelectedIndex;
            Close();
        }
    }
}
