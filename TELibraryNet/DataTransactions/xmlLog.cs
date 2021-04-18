using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace TELibraryNet.DataTransactions
{
    public class xmlLog
    {
        private static string file = @"E:\Shares\SAPdata\SAPdataService_Log\SAPtoSQL.xml";

        public static void WriteServiceStart()
        {
            if (!File.Exists(file))
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;
                using (XmlWriter xmlWriter = XmlWriter.Create(file, xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("winService");
                    xmlWriter.WriteStartElement("Service","begin");

                   
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }
            }
            else
            {
                XDocument xDocument = XDocument.Load(file);
                XElement root = xDocument.Element("winService");
                IEnumerable<XElement> rows = root.Descendants("winService");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("service","start"));
                xDocument.Save(file);
            }
        }
        public static void WriteCompilleStart()
        {
            XDocument xDocument = XDocument.Load(file);
            XElement root = xDocument.Element("winService");
            IEnumerable<XElement> rows = root.Descendants("Service");
            XElement firstRow = rows.First();
            firstRow.AddBeforeSelf(
               new XElement("compileAll")
               );
            xDocument.Save(file);
        }
        public static void WriteTransaction(List<string> transactionDetails)
        {
            
                XDocument xDocument = XDocument.Load(file);
                XElement root = xDocument.Element("winService");
                IEnumerable<XElement> rows = root.Descendants("compileAll");
                XElement firstRow = rows.First();
            firstRow.AddBeforeSelf(
                new XElement("dataTable", transactionDetails[0]),
                new XElement("startTime", transactionDetails[1]),
                new XElement("insert", transactionDetails[2]),
                new XElement("update", transactionDetails[3]),
                new XElement("noTransaction", transactionDetails[4]),
                new XElement("endTime", transactionDetails[5])
                );
                xDocument.Save(file);
            }
        public static void WriteCompileEnd()
        {

        }
        public static void WriteServiceStop()
        { 
        
        }

    }
}
