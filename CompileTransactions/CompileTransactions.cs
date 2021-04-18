///////////////////////////////////////////////////////////////////////////
//           Liquid XML Objects GENERATED CODE - DO NOT MODIFY           //
//            https://www.liquid-technologies.com/xml-objects            //
//=======================================================================//
// Dependencies                                                          //
//     Nuget : LiquidTechnologies.XmlObjects.Runtime                     //
//           : MUST BE VERSION 18.0.21                                   //
//=======================================================================//
// Online Help                                                           //
//     https://www.liquid-technologies.com/xml-objects-quick-start-guide //
//=======================================================================//
// Licensing Information                                                 //
//     https://www.liquid-technologies.com/eula                          //
///////////////////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Numerics;
using LiquidTechnologies.XmlObjects;
using LiquidTechnologies.XmlObjects.Attribution;

// ------------------------------------------------------
// |                      Settings                      |
// ------------------------------------------------------
// GenerateCommonBaseClass                  = False
// GenerateUnprocessedNodeHandlers          = True
// RaiseChangeEvents                        = False
// CollectionNaming                         = Pluralize
// Language                                 = CS
// OutputNamespace                          = LiquidXmlObjects.CompileTransactions
// WriteDefaultValuesForOptionalAttributes  = True
// WriteDefaultValuesForOptionalElements    = False
// GenerationModel                          = Simple
//                                            *WARNING* this simplified model that is very easy to work with
//                                            but may cause the XML to be produced without regard for element
//                                            cardinality or order. Where very high compliance with the XML Schema
//                                            standard is required use GenerationModelType.Conformant
// XSD Schema Files
//    C:\MyApps\SAPDataNet\CompileTransactions.xsd


namespace LiquidXmlObjects.CompileTransactions
{
    #region Global Settings
    /// <summary>Contains library level properties, and ensures the version of the runtime used matches the version used to generate it.</summary>
    [LxRuntimeRequirements("18.0.21.10416", "Trial for Non-Commercial Use Expiry [2021-03-13]", "BLGRYQ1QNBN8LV8A", LiquidTechnologies.XmlObjects.LicenseTermsType.Trial)]
    public partial class LxRuntimeRequirementsWritten
    {
    }

    #endregion

    #region Global Base Class
    /// <summary>All generated Lx classes derive from this base class.</summary>
    /// <remarks>Notes to implementers. The class is declared partial, so additional members and properties can be added that will be available in all Lx generated classes.</remarks>
    public partial class LxBase
    {
        #region Unprocessed Node Handlers
        /// <summary>Any child elements that do not belong in this element are added to the UnprocessedElements collection.</summary>
        [LxElementUnprocessed()]
        public List<XElement> UnprocessedElements { get; } = new List<XElement>();

        /// <summary>Any attributes that do not belong in this element are added to the UnprocessedAttributes collection.</summary>
        [LxAttributeUnprocessed()]
        public List<XAttribute> UnprocessedAttributes { get; } = new List<XAttribute>();

        #endregion

    }

    #endregion

}

namespace LiquidXmlObjects.CompileTransactions.Xs
{
    #region Complex Types
    /// <summary>A class representing the root XSD complexType anyType@http://www.w3.org/2001/XMLSchema</summary>
    /// <XsdPath>schema:.../www.w3.org/2001/XMLSchema/complexType:anyType</XsdPath>
    /// <XsdFile>http://www.w3.org/2001/XMLSchema</XsdFile>
    /// <XsdLocation>Empty</XsdLocation>
    [LxSimpleComplexTypeDefinition("anyType", "http://www.w3.org/2001/XMLSchema")]
    public partial class AnyTypeCt : XElement
    {
        /// <summary>Constructor : create a <see cref="AnyTypeCt" /> element &lt;anyType xmlns='http://www.w3.org/2001/XMLSchema'&gt;</summary>
        public AnyTypeCt()  : base(XName.Get("anyType", "http://www.w3.org/2001/XMLSchema")) { }

    }

    #endregion

}

namespace LiquidXmlObjects.CompileTransactions.Ns
{
    #region Elements
    /// <summary>A class representing the root XSD element winService</summary>
    /// <XsdPath>schema:CompileTransactions.xsd/element:winService</XsdPath>
    /// <XsdFile>C:\MyApps\SAPDataNet\CompileTransactions.xsd</XsdFile>
    /// <XsdLocation>4:5-36:18</XsdLocation>
    [LxSimpleElementDefinition("winService", "", ElementScopeType.GlobalElement)]
    public partial class WinServiceElm : LiquidXmlObjects.CompileTransactions.LxBase
    {
        /// <summary>A collection of <see cref="LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm" /></summary>
        [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm> WinServices { get; } = new List<LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm>();

        /// <summary>A collection of <see cref="LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm.CompileAllElm" /></summary>
        [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm.CompileAllElm> CompileAlls { get; } = new List<LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm.CompileAllElm>();

        /// <summary>Represent the inline xs:element compileAll.</summary>
        /// <XsdPath>schema:CompileTransactions.xsd/element:winService/sequence/choice/element:compileAll</XsdPath>
        /// <XsdFile>C:\MyApps\SAPDataNet\CompileTransactions.xsd</XsdFile>
        /// <XsdLocation>9:21-32:34</XsdLocation>
        [LxSimpleElementDefinition("compileAll", "", ElementScopeType.InlineElement)]
        public partial class CompileAllElm : LiquidXmlObjects.CompileTransactions.LxBase
        {
            /// <summary>A collection of <see cref="LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm.CompileAllElm.TransactionElm" /></summary>
            [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm.CompileAllElm.TransactionElm> Transactions { get; } = new List<LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm.CompileAllElm.TransactionElm>();

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
            [LxElementValue("compileTime", "", LxValueType.Value, XsdType.XsdTime, MinOccurs = 0, MaxOccurs = 1)]
            public LiquidTechnologies.XmlObjects.LxDateTime? CompileTime { get; set; }

            /// <summary>Represent the inline xs:element transaction.</summary>
            /// <XsdPath>schema:CompileTransactions.xsd/element:winService/sequence/choice/element:compileAll/sequence/element:transaction</XsdPath>
            /// <XsdFile>C:\MyApps\SAPDataNet\CompileTransactions.xsd</XsdFile>
            /// <XsdLocation>12:33-28:46</XsdLocation>
            [LxSimpleElementDefinition("transaction", "", ElementScopeType.InlineElement)]
            public partial class TransactionElm : LiquidXmlObjects.CompileTransactions.LxBase
            {
                /// <summary>A <see cref="LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm.CompileAllElm.TransactionElm.DataTableElm" />, Optional : null when not set</summary>
                [LxElementRef(MinOccurs = 0, MaxOccurs = 1)]
                public LiquidXmlObjects.CompileTransactions.Ns.WinServiceElm.CompileAllElm.TransactionElm.DataTableElm DataTable { get; set; }

                /// <summary>Represent the inline xs:element dataTable.</summary>
                /// <XsdPath>schema:CompileTransactions.xsd/element:winService/sequence/choice/element:compileAll/sequence/element:transaction/sequence/element:dataTable</XsdPath>
                /// <XsdFile>C:\MyApps\SAPDataNet\CompileTransactions.xsd</XsdFile>
                /// <XsdLocation>15:45-25:58</XsdLocation>
                [LxSimpleElementDefinition("dataTable", "", ElementScopeType.InlineElement)]
                public partial class DataTableElm : LiquidXmlObjects.CompileTransactions.LxBase
                {
                }

            }

        }

    }

    #endregion

}

namespace LiquidXmlObjects.CompileTransactions
{
    /// <summary>
    /// Provides a validator based on the original XSD schema files. 
    /// </summary>
    public partial class CompileTransactionsValidator : LiquidTechnologies.XmlObjects.XsdValidator
    {
        /// <summary>
        /// Initializes the validator, loads and compiles the XSD schemas.
        /// </summary>
        /// <remarks>
        /// This is an expensive operation so consider caching this object.
        /// </remarks>
        public CompileTransactionsValidator()
            : base(typeof(CompileTransactionsValidator).Assembly, "LiquidXmlObjects.CompileTransactions.CompileTransactionsResources.SchemaData")
        {
        }
    }
}
