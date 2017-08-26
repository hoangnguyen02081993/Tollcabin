using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Tollcabin
{
    public class ProcessXML
    {
        private XmlDocument xml_document;

        private string _errMessage;

        private string PathConfig;

        public string ErrMessage
        {
            get
            {
                return this._errMessage;
            }
        }

        public ProcessXML()
        {
            this._errMessage = "";
            this.PathConfig = "";
            try
            {
                this.xml_document = new XmlDocument();
                this.xml_document.Load("Config.xml");
                this.PathConfig = "Config.xml";
            }
            catch (Exception arg_44_0)
            {
                ProjectData.SetProjectError(arg_44_0);
                this._errMessage = Information.Err().Description;
                ProjectData.ClearProjectError();
            }
        }

        public ProcessXML(string xPath)
        {
            this._errMessage = "";
            this.PathConfig = "";
            try
            {
                this.xml_document = new XmlDocument();
                this.xml_document.Load(xPath);
                this.PathConfig = xPath;
            }
            catch (Exception arg_3C_0)
            {
                ProjectData.SetProjectError(arg_3C_0);
                this._errMessage = Information.Err().Description;
                ProjectData.ClearProjectError();
            }
        }

        public string XmlNodeValue(string sNode, string sParentNode, string default_value = "")
        {
            string xpath;
            if (Operators.CompareString(sParentNode, "", false) == 0)
            {
                xpath = "//" + sParentNode + "//" + sNode;
            }
            else
            {
                xpath = "//" + sNode;
            }
            XmlNode xmlNode = this.xml_document.SelectSingleNode(xpath);
            if (xmlNode == null)
            {
                return default_value;
            }
            return xmlNode.InnerText;
        }

        public void WriteNode(string sNode, string sParentNode, string sValues)
        {
            string xpath;
            if (Operators.CompareString(sParentNode, "", false) == 0)
            {
                xpath = "//" + sParentNode + "//" + sNode;
            }
            else
            {
                xpath = "//" + sNode;
            }
            XmlNode xmlNode = this.xml_document.SelectSingleNode(xpath);
            if (xmlNode == null)
            {
                XmlElement xmlElement = this.xml_document.DocumentElement;
                if (Operators.CompareString(sParentNode, "", false) != 0)
                {
                    xmlNode = this.xml_document.CreateNode(XmlNodeType.Element, sParentNode, "");
                    xmlElement.AppendChild(xmlNode);
                    xmlElement = xmlElement[sParentNode];
                }
                xmlNode = this.xml_document.CreateNode(XmlNodeType.Element, sNode, "");
                xmlElement.AppendChild(xmlNode);
                xmlNode.InnerText = sValues;
                this.xml_document.Save(this.PathConfig);
            }
            else
            {
                xmlNode.InnerText = sValues;
                this.xml_document.Save(this.PathConfig);
            }
        }
    }
}
