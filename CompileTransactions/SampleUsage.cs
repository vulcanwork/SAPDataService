using LiquidTechnologies.XmlObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LiquidXmlObjects.CompileTransactions
{
    /// <summary>
    /// The following code is intended to demonstrate the basics of using the 
    /// Liquid XML Objects code you have just generated.
    /// 
    /// The creation of the sample code is an option within the XML Data Binder
    /// Wizard and can be turned off.
    /// </summary>
    internal class SampleUsage
    {
        /// <summary>
        /// Demonstrates how to read XML data into a generated object.
        /// In this case the first element in your schema was selected.
        /// </summary>
        /// <remarks>
        /// LxSerializer.Deserialize has a number of other overloads
        /// allowing data to be read from a file/Stream/TextReader/XmlReader 
        /// </remarks>
        /// <exception cref="LxSerializationException">LxSerializer.Deserialize will throw if the XML data contains errors</exception>
        public void SimpleXmlReader()
        {
            string sampleXml = @"<winService>
                                    <!-- Place your own XML code here -->
                               </winService>";

            // A LxSerializer is required to de-serialize the XML data into a 
            // generated Liquid XML Objects class.
            LxSerializer<LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm> serializer = new LxSerializer<LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm>();

            using (TextReader textReader = new StringReader(sampleXml))
            {
                // reads XML data from a TextReader, which it uses to 
                // create and populate a LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm
                LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm winServiceElm = serializer.Deserialize(textReader);

                // TODO use the winServiceElm object ...
            }
}






        /// <summary>
        /// Demonstrates how to read XML data into a generated object, and take
        /// control of the error handling.
        /// </summary>
        public void XmlReaderWithErrorHandling()
        {
            string sampleXml = @"<winService>
                                    <!-- Place your own XML code here -->
                               </winService>";

            // A LxSerializer is required to de-serialize the XML data into a 
            // generated Liquid XML Objects class.
            LxSerializer<LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm> serializer = new LxSerializer<LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm>();

            using (TextReader textReader = new StringReader(sampleXml))
            {
                // The settings in LxReaderSettings govern the behaviour of the De-serialization
                // in this example we will provide our own error handler.
                LxReaderSettings readerSettings = new LxReaderSettings();
                readerSettings.ErrorHandler = XmlReaderWithErrorHandling_ErrorHandler;
                // reads XML data from a TextReader, which it uses to 
                // create and populate a LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm
                LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm winServiceElm = serializer.Deserialize(textReader);

                // TODO use the winServiceElm object ...
            }
        }

        /// <summary>
        /// This method is called when an error or warning is reported during
        /// the de-serialization process. 
        /// The method must throw an Exception in order to stop the de-serialization 
        /// process. If it returns, the error/warning is ignored.
        /// </summary>
        /// <param name="msg">The error message describing the issue</param>
        /// <param name="severity">The severity of the error</param>
        /// <param name="errorCode">The error code providing detail about the issue</param>
        /// <param name="location">The location of the issue in the source XML document</param>
        /// <param name="targetObject">The object the data is being de-serialized into (a Liquid XML Objects generated class)</param>
        private void XmlReaderWithErrorHandling_ErrorHandler(string msg, LxErrorSeverity severity, LxErrorCode errorCode, TextLocation location, object targetObject)
        {
            Console.WriteLine($"{severity}:{errorCode}:{location} {msg}");

            // throwing an exception will stop de-serialization
            if (severity == LxErrorSeverity.Error)
                throw new LxSerializationException(msg, severity, errorCode, location, targetObject);

            // returning will cause the warning/error to be ignored and serialization will continue
        }






        /// <summary>
        /// Demonstrates how to serialize a generated Liquid XML object to XML.
        /// In this case the first element in your schema was selected.
        /// </summary>
        /// <remarks>
        /// LxSerializer.Serialize has a number of other overloads
        /// allowing data to be written to a file/Stream/TextWriter/XmlWriter
        /// </remarks>
        /// <exception cref="LxSerializationException">LxSerializer.Serialize will throw if the object being serialized contains errors</exception>
        public void SimpleXmlWriter()
        {
            // A LxSerializer is required to serialize the XML data into a 
            // generated Liquid XML Objects class.
            LxSerializer<LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm> serializer = new LxSerializer<LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm>();

            LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm winServiceElm = new LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm();
            // TODO populate the object
            // winServiceElm.xyz = value;

            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, winServiceElm);

                Console.Write(writer.ToString());
            }
        }






        /// <summary>
        /// Demonstrates how to serialize a generated Liquid XML object to XML.
        /// In this case the first element in your schema was selected.
        /// </summary>
        /// <remarks>
        /// LxSerializer.Serialize has a number of other overloads
        /// allowing data to be written to a file/Stream/TextWriter/XmlWriter
        /// </remarks>
        /// <exception cref="LxSerializationException">LxSerializer.Serialize will throw if the object being serialized contains errors</exception>
        public void XmlWriterWithErrorHandling()
        {
            // A LxSerializer is required to serialize the XML data into a 
            // generated Liquid XML Objects class.
            LxSerializer<LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm> serializer = new LxSerializer<LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm>();

            LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm winServiceElm = new LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm();
            // TODO populate the object
            // winServiceElm.xyz = value;

            using (StringWriter writer = new StringWriter())
            {
                LxWriterSettings writerSettings = new LxWriterSettings();
                writerSettings.ErrorHandler = XmlWriterWithErrorHandling_ErrorHandler;

                serializer.Serialize(writer, winServiceElm, writerSettings);

                Console.Write(writer.ToString());
            }
        }
        /// <summary>
        /// This method is called when an error or warning is reported during
        /// the serialization process. 
        /// The method must throw an Exception in order to stop the serialization 
        /// process. If it returns, the error/warning is ignored.
        /// </summary>
        /// <param name="msg">The error message describing the issue</param>
        /// <param name="severity">The severity of the error</param>
        /// <param name="errorCode">The error code providing detail about the issue</param>
        /// <param name="targetObject">The object the data is being de-serialized into (a Liquid XML Objects generated class)</param>
        private void XmlWriterWithErrorHandling_ErrorHandler(string msg, LxErrorSeverity severity, LxErrorCode errorCode, object targetObject)
        {
            Console.WriteLine($"{severity}:{errorCode} {msg}");

            // throwing an exception will stop Serialization
            if (severity == LxErrorSeverity.Error)
                throw new LxSerializationException(msg, severity, errorCode, null, targetObject);

            // returning will cause the warning/error to be ignored and serialization will continue
        }






        /// <summary>
        /// Typically when you read an XML document you know what the root element 
        /// should be, however in some instances the root element may not be known at 
        /// design time. This sample demonstrates how to deal with this.
        /// </summary>
        /// <exception cref="LxException">LxSerializer.Deserialize will throw if the generated 
        /// Liquid XML Objects library does not contain an object capable of having the XML data 
        /// de-serialized into it.</exception>
        public void ReadingXmlOfUnknownType()
        {
            string sampleXml = @"<winService>
                                    <!-- Place your own XML code here -->
                               </winService>";

            // Note we use the un-templated version
            LxSerializer serializer = new LxSerializer();

            using (TextReader textReader = new StringReader(sampleXml))
            {
                // reads XML data from a TextReader, which it uses to 
                // create and populate a LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm
                XmlQualifiedName rootElementName;
                Object rootObject = serializer.Deserialize(textReader, out rootElementName);

                if (rootObject is LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm)
                {
                    LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm winServiceElm = (LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm)rootObject;
                    // TODO use winServiceElm object
                    // Debug.WriteLine(winServiceElm.value);
                }
                else
                {
                    throw new NotImplementedException($"No handler provided for the root element {rootElementName}");
                }
            }
        }





        /// <summary>
        /// Uses the original XML Schemas to build a validator that can be used to
        /// validate the XML data directly or create a validating reader.
        /// </summary>
        /// <remarks>
        /// Note:
        /// CompileTransactionsValidator.Validate and CompileTransactionsValidator.CreateValidatingReader 
        /// has a number of other overloads allowing data to be read from a file/Stream/TextReader/XmlReader 
        /// </remarks>
        public void ValidateUsingOriginalXmlSchema()
        {
            CompileTransactionsValidator validator = new CompileTransactionsValidator();

            // validating an XML document directly
            validator.Validate("PathOfXmlDocument.xml", ValidateUsingOriginalXmlSchema_ValidationEventHandler);

            // creating a validating XML reader 
            XmlReader validatingXmlReader = validator.CreateValidatingReader("PathOfXmlDocument.xml", ValidateUsingOriginalXmlSchema_ValidationEventHandler);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(validatingXmlReader);
        }

        /// <summary>
        /// Called back when the CompileTransactionsValidator encounters validation errors and warnings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateUsingOriginalXmlSchema_ValidationEventHandler(object sender, System.Xml.Schema.ValidationEventArgs e)
        {
            Console.WriteLine($"{e.Severity}:{e.Message}");
        }
    }
}
