using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace graunt
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();

            this.Text = "Graunt - " + Language.GetString("settings.title");
            fSettings.Text = Language.GetString("settings.settings");
            fLanguage.Text = Language.GetString("settings.language")+":";
            fSave.Text = Language.GetString("settings.save");
            fCancel.Text = Language.GetString("settings.cancel");


                        
            string langDirectory = "lang/";

            Dictionary<string,string> languages = new Dictionary<string,string>();
            languages.Add("default","English (built in)");

            int selectedIndex = 0;
            int index = 0;
            if (Directory.Exists(langDirectory))
            {
                string[] fileNames = Directory.GetFiles(langDirectory, "*.xml");

                foreach (string fileName in fileNames)
                {
                    try
                    {
                        XDocument xmlFile = XDocument.Load(fileName);
                        string language = xmlFile.Root.Element("language").Value;
                        languages.Add(fileName, language);
                        index++;

                        if (fileName == GrauntSettings.LanguageFile)
                        {
                            selectedIndex = index;
                        }
                    }
                    catch { }
                }
            }

            fLanguageSelect.DataSource = new BindingSource(languages, null);
            fLanguageSelect.DisplayMember = "Value";
            fLanguageSelect.ValueMember = "Key";
            fLanguageSelect.SelectedIndex = selectedIndex;
        }

        private void fSave_Click(object sender, EventArgs e)
        {
            if ((string)fLanguageSelect.SelectedValue == "default")
            {
                GrauntSettings.LanguageFile = "";
            }
            else
            {
                GrauntSettings.LanguageFile = (string)fLanguageSelect.SelectedValue;
            }
            
            GrauntSettings.Save();

            DialogResult = DialogResult.OK;
        }

        private void fCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
