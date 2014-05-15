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
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();

            Version version = typeof(Program).Assembly.GetName().Version;
            fVersionValue.Text = version.Major + "." + version.Minor + "." + version.Build;

            Text = "Graunt - " + Language.GetString("about.title");
            fAuthor.Text = Language.GetString("about.author")+":";
            fVersion.Text = Language.GetString("about.version") + ":";
            fLicense.Text = Language.GetString("about.license") + ":";
            fClose.Text = Language.GetString("about.close");
        }

        private void fClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
