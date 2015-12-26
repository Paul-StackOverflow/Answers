using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Serialization;
using System.Xml;

namespace CMDPrototypes
{
    public class Ans33716142
    {
        public Ans33716142()
        {

        }

        public void Execute(string[] args)
        {
            //Should produce the results you are looking for:
            XmlNodeList xmlNodeList;
            XmlDocument xDoc = new XmlDocument();
            XmlReaderSettings xrs = new XmlReaderSettings();
            xrs.DtdProcessing = DtdProcessing.Parse;

            //Get Authors from XML Source
            using (XmlReader reader2 = XmlReader.Create("C:\\Users\\Public\\ile_xml.xml"))
            {
                xDoc.Load(reader2);
                xmlNodeList = xDoc.SelectNodes("records/record/contributors/authors/author");
            }
            foreach (XmlNode node in xmlNodeList)
            {
                Console.WriteLine("Display: " + node.InnerText);//.InnerXML to include style tags.
            };

            //Your snippet, which didn't work on my machine:
            XmlReader reader = XmlReader.Create("C:\\Users\\Public\\ile_xml.xml");
            while (reader.Read())
            {
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "author"))
                {
                    reader.Read();
                    reader.Read();
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "style") && reader.HasAttributes)
                    {
                        var val = reader.ReadInnerXml();
                        Console.WriteLine("Display: " + reader.GetAttribute("author"));
                    }
                }
            }


        }
    }
}
