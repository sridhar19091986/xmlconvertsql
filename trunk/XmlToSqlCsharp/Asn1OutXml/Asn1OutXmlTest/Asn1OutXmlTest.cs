//
// Asn1OutXmlTest.cs
//
// This file was generated by XMLSpy 2008r2sp2 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using System;
using Altova.Types;

namespace Asn1OutXml
{
    /// <summary>
    /// Summary description for Asn1OutXmlTest.
    /// </summary>
    class Asn1OutXmlTest
    {
        protected static void Example()
        {
            //
            // TODO:
            //   Insert your code here...
            //
            // Example code to create and save a structure:
            //   Asn1OutXml.Asn1OutXml2 doc = Asn1OutXml.Asn1OutXml2.CreateDocument();			
            //   Asn1OutXml.messageType root = doc.message.Append();
            //   ...
            //   doc.SaveToFile("Asn1OutXml1.xml", true);
            //
            // Example code to load and save a structure:
              Asn1OutXml.Asn1OutXml2 doc = Asn1OutXml.Asn1OutXml2.LoadFromFile("Asn1OutXml1.xml");
              Asn1OutXml.messageType root = doc.message.First;
              Asn1OutXml.CONTEXT_21Type c21 = root.CONTEXT_21.i
              Console.WriteLine(root.CONTEXT_21.Count);
              Console.WriteLine(root.CONTEXT_28.Count);
           
              //root.CONTEXT_21.Count;
            //   ...
            //   doc.SaveToFile("Asn1OutXml1.xml", true);

        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static int Main(string[] args)
        {
            try
            {
                Console.WriteLine("Asn1OutXml Test Application");
                Example();
                Console.WriteLine("OK");
               // t();
                Console.ReadKey();
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 1;
            }
        }

        private static void t()
        {
            //System.IO.StreamReader str = new System.IO.StreamReader(@"G:\xmlconvertsql\XmlToSqlCsharp\Asn1OutXml.xml");
            //System.Xml.Serialization.XmlSerializer xSerializer = new System.Xml.Serialization.XmlSerializer(typeof(Asn1OutXml.Asn1OutXml2));
            //Asn1OutXml.Asn1OutXml2 res = (Asn1OutXml.Asn1OutXml2)xSerializer.Deserialize(str);
            //foreach (Asn1OutXml.Asn1OutXml2 r in res.CONTEXT_28)
            //{
            //    Console.WriteLine(r.CONTEXT_0.First.Value);
            //    Console.WriteLine(r.CONTEXT_1.First.Value);
            //    Console.WriteLine(r.CONTEXT_10.First.CONTEXT_0.First.CONTEXT_0.First.CONTEXT_0.First.CONTEXT_0.First.CONTEXT_0.First.Value);
            //}
            //str.Close();

            //Console.ReadLine();

        }
    }
}