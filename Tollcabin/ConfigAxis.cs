using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace Tollcabin
{
    public class ConfigAxis
    {
        private string ConfigFileName = "AxisManager.cfg";

        public string CameraIp { set; get; }
        public bool IsAutoRun { set; get; }
        public ConfigAxis(string configFileName = "AxisManager.cfg")
        {
            ConfigFileName = configFileName;
            CameraIp = "";
            IsAutoRun = false;
            Load();
        }
        public void Load()
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                if (File.Exists(ConfigFileName))
                {
                    xmlDocument.LoadXml(File.ReadAllText(ConfigFileName));
                    XmlElement root = xmlDocument.DocumentElement;
                    var axisManager = root.GetElementsByTagName("AxisManagerConfig")[0];
                    CameraIp = axisManager.Attributes["CameraIp"].Value;
                    IsAutoRun = bool.Parse(axisManager.Attributes["IsAutoRun"].Value);
                }
                else
                {
                    CreateDefaultFile();
                }
            }
            catch (Exception ex)
            {
                CreateDefaultFile();
            }
        }
        public void Save()
        {
            try
            {
                string path = ConfigFileName.LastIndexOf("/") == 0 ? Directory.GetCurrentDirectory() :
                                                     ConfigFileName.Substring(0, ConfigFileName.LastIndexOf("/"));
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                XmlDocument xmlDocument = new XmlDocument();
                XmlElement root = xmlDocument.CreateElement("root");
                xmlDocument.AppendChild(root);
                XmlElement axisManager = xmlDocument.CreateElement("AxisManagerConfig");
                axisManager.SetAttribute("CameraIp", CameraIp);
                axisManager.SetAttribute("IsAutoRun", IsAutoRun.ToString());
                root.AppendChild(axisManager);

                File.WriteAllText(ConfigFileName, xmlDocument.InnerXml);
            }
            catch { }
        }
        private void CreateDefaultFile()
        {
            string path = ConfigFileName.LastIndexOf("/") == 0 ? Directory.GetCurrentDirectory() : 
                                                                 ConfigFileName.Substring(0, ConfigFileName.LastIndexOf("/"));
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("root");
            xmlDocument.AppendChild(root);
            XmlElement axisManager = xmlDocument.CreateElement("AxisManagerConfig");
            axisManager.SetAttribute("CameraIp", string.Empty);
            axisManager.SetAttribute("IsAutoRun", false.ToString());
            root.AppendChild(axisManager);

            File.WriteAllText(ConfigFileName, xmlDocument.InnerXml);
        }
    }
}
