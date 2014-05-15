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
    public partial class ColumnsSelectWindow : Form
    {
        public ReadOnlyCollection<string> SelectedColumns { get; private set; }

        public ColumnsSelectWindow(string[] columnNames)
        {
            InitializeComponent();

            this.Text = "Graunt - " + Language.GetString("columnSelect.title");
            fHeader.Text = Language.GetString("columnSelect.header");
            fImport.Text = Language.GetString("columnSelect.import");
            fIgnore.Text = Language.GetString("columnSelect.ignore");
            fNext.Text = Language.GetString("columnSelect.next");
            
            fInclude.Items.AddRange(columnNames);

        }

        private void fMoveRight_Click(object sender, EventArgs e)
        {
            if (fInclude.SelectedItem != null)
            {
                var y = fInclude.SelectedItems.Cast<string>().ToArray();
                foreach (string item in y)
                {
                    fExclude.Items.Add(item);
                    fInclude.Items.Remove(item);
                }
            }
        }

        private void fMoveLeft_Click(object sender, EventArgs e)
        {
            if (fExclude.SelectedItem != null)
            {
                var y = fExclude.SelectedItems.Cast<string>().ToArray();
                foreach (string item in y)
                {
                    fInclude.Items.Add(item);
                    fExclude.Items.Remove(item);
                }
            }
        }

        private void fNext_Click(object sender, EventArgs e)
        {
            SelectedColumns = new ReadOnlyCollection<string>(new List<string>(fExclude.Items.Cast<string>()));
            Close();
        }
    }
}
