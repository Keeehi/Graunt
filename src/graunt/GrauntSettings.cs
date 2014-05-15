using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace graunt
{
    public static class GrauntSettings
    {
        public static string LanguageFile;
        public static List<string> RecentProjects { get; private set; }

        //tries to load settings from settings.xml
        public static void Initialize()
        {
            LanguageFile = null;
            RecentProjects = new List<string>();

            if (File.Exists("settings.xml"))
            {
                try
                {
                    XDocument xmlFile = XDocument.Load("settings.xml");

                    if (xmlFile.Root.Element("LanguageFile") != null)
                    {
                        LanguageFile = xmlFile.Root.Element("LanguageFile").Value;
                    }

                    if (xmlFile.Root.Element("RecentProjects") != null && xmlFile.Root.Element("RecentProjects").Elements("File") != null)
                    {
                        foreach (XElement node in xmlFile.Root.Element("RecentProjects").Elements("File"))
                        {
                            if (!File.Exists(node.Value))
                            {
                                continue;
                            }

                            RecentProjects.Add(node.Value);
                        }
                    }
                }
                catch { }

            }
        }

        //Add the given project to the List property. Takes care of number and order. Newest last
        public static void AddRecentProject(string project)
        {
            if (!File.Exists(project))
            {
                return;
            }

            while (RecentProjects.Contains(project))
            {
                RecentProjects.Remove(project);
            }

            if (RecentProjects.Count > 7)
            {
                RecentProjects.RemoveRange(0, RecentProjects.Count - 7);
            }

            RecentProjects.Add(project);
        }

        //saves settings to file settings.xml
        public static void Save()
        {
            XDocument xmlFile = new XDocument();
            XElement root = new XElement("root");

            if (LanguageFile != null)
            {
                root.Add(new XElement("LanguageFile", LanguageFile));
            }

            XElement recentProjects = new XElement("RecentProjects");
            foreach (string project in RecentProjects)
            {
                recentProjects.Add(new XElement("File", project));
            }
            root.Add(recentProjects);

            xmlFile.Add(root);

            xmlFile.Save("settings.xml");
        }
    }
}
