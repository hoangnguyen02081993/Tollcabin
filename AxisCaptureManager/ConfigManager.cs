using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AxisCaptureManager
{
    public class ConfigManager
    {
        private const string ConfigFileName = "AxisManager.cfg";

        public string CameraIp { set; get; }
        public bool IsAutoRun { set; get; }
        public ConfigManager()
        {
            CameraIp = "";
            IsAutoRun = false;
            Load();
        }
        public void Load()
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                if(File.Exists(ConfigFileName))
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
            catch(Exception ex)
            {
                CreateDefaultFile();
            }
        }
        public void Save()
        {
            try
            {
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
