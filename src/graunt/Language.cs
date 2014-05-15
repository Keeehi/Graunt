using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace graunt
{
    // this class takes care of translating all displayable text
    public static class Language
    {
        private static Dictionary<string, string> strings;

        //indicates, whether internal language was used or not
        private static bool complete;

        public static void Initialize()
        {
            if (strings != null)
            {
                return;
            }

            strings = new Dictionary<string, string>();
            complete = false;

            if (GrauntSettings.LanguageFile == "")
            {
                return;
            }

            string langDirectory = Properties.Resources.LanguageDirectory;

            //tries to load language file. Priorities: User defined > According to windows enwiroment > en.xml
            if (Directory.Exists(langDirectory))
            {
                if (GrauntSettings.LanguageFile != null && File.Exists(GrauntSettings.LanguageFile))
                {
                    if (!LoadFromXmlFile(GrauntSettings.LanguageFile))
                    {
                        strings = new Dictionary<string, string>();
                    }
                }
                else if (!String.IsNullOrEmpty(Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName) && File.Exists(langDirectory + Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName + ".xml"))
                {
                    if (!LoadFromXmlFile(langDirectory + Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName + ".xml"))
                    {
                        strings = new Dictionary<string, string>();
                    }
                }
                else if (!String.IsNullOrEmpty(Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName) && File.Exists(langDirectory + Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName + ".xml"))
                {
                    if (!LoadFromXmlFile(langDirectory + Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName + ".xml"))
                    {
                        strings = new Dictionary<string, string>();
                    }
                }
                else if (File.Exists(langDirectory + "en.xml"))
                {
                    if (!LoadFromXmlFile(langDirectory + "en.xml"))
                    {
                        strings = new Dictionary<string, string>();
                    }
                }
            }
        }

        //tries to load language data from given file
        private static bool LoadFromXmlFile(string fileName)
        {
            try
            {
                XDocument xmlFile = XDocument.Load(fileName);

                var data = from s in xmlFile.Descendants("section")
                               from d in s.Descendants("string")
                                      select new
                                      {
                                          Section = s.Attribute("name").Value,
                                          Key = d.Attribute("name").Value,
                                          Value = d.Attribute("value").Value
                                      };

                foreach (var languageString in data)
                {
                    strings.Add(languageString.Section + "." + languageString.Key, languageString.Value);
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        //returns appropriate language specific text according to given key
        public static string GetString(string key)
        {
            if (strings == null)
            {
                return "";
            }

            if (strings.ContainsKey(key))
            {
                return strings[key];
            }
            else if (!complete)
            {
                complete = true;

                ResourceSet resourceSet = Resources.LanguageDefault.ResourceManager.GetResourceSet(CultureInfo.InvariantCulture, true, false);

                if (resourceSet != null)
                {
                    var languageStrings = from data in resourceSet.Cast<DictionaryEntry>()
                                          select new
                                          {
                                              Key = (string)data.Key,
                                              Value = (string)data.Value
                                          };

                    foreach (var languageString in languageStrings)
                    {
                        if (!strings.ContainsKey(languageString.Key))
                        {
                            strings.Add(languageString.Key, languageString.Value);
                        }
                    }
                }

                if (strings.ContainsKey(key))
                {
                    return strings[key];
                }
            }

            return "";
        }
    }
}
