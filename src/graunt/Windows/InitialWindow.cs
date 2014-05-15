using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graunt
{
    public partial class InitialWindow : Form
    {
        public Action SelectedAction { get; private set; }
        public enum Action {Import, Open, OpenRecent, None};
        public string Data { get; private set; }

        public InitialWindow()
        {
            InitializeComponent();

            fImport.Text = Language.GetString("initial.buttonImport");
            fOpen.Text = Language.GetString("initial.buttonOpen");
            fStart.Text = Language.GetString("initial.labelStart");
            fRecent.Text = Language.GetString("initial.labelRecent");
            SelectedAction = Action.None;

            int i = 0;
            foreach (string file in GrauntSettings.RecentProjects.AsEnumerable().Reverse())
            {
                if (!File.Exists(file))
                {
                    continue;
                }

                LinkLabel linkLabel = new LinkLabel();
                linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                linkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(122)))), ((int)(((byte)(212)))));
                linkLabel.Location = new System.Drawing.Point(164, 39 + (26* i++));
                linkLabel.Size = new System.Drawing.Size(308, 20);
                linkLabel.TabStop = true;
                linkLabel.Text = Path.GetFileNameWithoutExtension(file);
                linkLabel.Links.Add(0, file.Length, file);
                linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);

                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(linkLabel, file);

                this.Controls.Add(linkLabel);
            }
        }

        private void fOpen_Click(object sender, EventArgs e)
        {
            SelectedAction = Action.Open;
            Close();
        }

        private void fImport_Click(object sender, EventArgs e)
        {
            SelectedAction = Action.Import;
            Close();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectedAction = Action.OpenRecent;
            Data = (string)e.Link.LinkData;
            Close();
        }
    }
}
