using System;
using System.IO;
using System.Xml;

namespace smrtstm2decoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Check if the user has provided the correct number of arguments
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: SSDecode <input.smrtstm2> <output.xml>");
                return;
            }

            // Read the input file to an XMLDocument
            StreamReader streamReader = new StreamReader(args[0]);
            SmartStim2.SignalGenerator.Session session = SmartStim2.SignalGenerator.Session.Deserialize(streamReader.BaseStream);
            XmlDocument xmlDocument = (XmlDocument)session.GetNode();

            // Write the XMLDocument to the output file
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  ",
                NewLineChars = Environment.NewLine,
                NewLineHandling = NewLineHandling.Replace
            };
            XmlWriter xmlWriter = XmlWriter.Create(args[1], xmlWriterSettings);
            xmlDocument.Save(xmlWriter);
        }
    }
}
