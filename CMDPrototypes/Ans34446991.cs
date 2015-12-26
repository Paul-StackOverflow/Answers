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
    public class Ans34446991
    {
        public Ans34446991()
        {

        }

        public void Execute(string[] args)
        {
            //Should produce the results you are looking for:
            XmlDocument xDoc = new XmlDocument();
            XmlReaderSettings xrs = new XmlReaderSettings();
            xrs.DtdProcessing = DtdProcessing.Parse;

            String stuff = "<Names><Name><FirstName> John </FirstName><LastName> Smith </LastName></Name><Name><FirstName> James </FirstName><LastName> White </LastName></Name></Names>";
            //using (XmlReader reader2 = XmlReader.Create("Ans34446991.xml"))
            //{
            //xDoc.Load(reader2);
            xDoc.LoadXml(stuff);
            XmlNodeList xnList = xDoc.SelectNodes("/Names/Name");
                foreach (XmlNode xn in xnList)
                {
                    string firstName = xn["FirstName"].InnerText;
                    string lastName = xn["LastName"].InnerText;
                    Console.WriteLine("Name: {0} {1}", firstName, lastName);
                }
            //}


            ////Get Authors from XML Source
            //using (XmlReader reader2 = XmlReader.Create("Ans34446991.xml"))
            //{
            //    xDoc.Load(reader2);
            //    xmlNodeList = xDoc.SelectNodes("records/record/contributors/authors/author");
            //}
            //foreach (XmlNode node in xmlNodeList)
            //{
            //    Console.WriteLine("Display: " + node.InnerText);
            //};
        }
    }
}
