using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TELibraryNet.DataTransactions;
namespace TELibraryNet.Models
{
    public class MaterialModel
    {
        private int id;
        private string recordType;
        private string materialNumber;
        private DateTime creationDate;
        private string materialType;
        private string materialDescription;
        private string baseUoM;
        private string materialGrooup;
        private string productionHierarchy;
        private string crossPlant;
        private bool batchManage;
        private string authorizationGroup;
        private decimal netWeight;
        private decimal grossWeight;
        private string weightUoM;
        private string competencyBusinessCode;
        private string productLine;
        private string revisionLevel;
        private string catalogNumber;
        private string productBrandName;
        private string engineeringPartNumber;
        private string acquisitionFormat;
        private DateTime dateLastChange;
        #region Public Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string RecordType
        {
            get { return recordType; }
            set { recordType = value; }
        }

        public string MaterialNumber
        {
            get { return materialNumber; }
            set { materialNumber = value; }
        }

        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }

        public string MaterialType
        {
            get { return materialType; }
            set { materialType = value; }
        }

        public string MaterialDescription
        {
            get { return materialDescription; }
            set { materialDescription = value; }
        }

        public string BaseUoM
        {
            get { return baseUoM; }
            set { baseUoM = value; }
        }

        public string MaterialGrooup
        {
            get { return materialGrooup; }
            set { materialGrooup = value; }
        }

        public string ProductionHierarchy
        {
            get { return productionHierarchy; }
            set { productionHierarchy = value; }
        }

        public string CrossPlant
        {
            get { return crossPlant; }
            set { crossPlant = value; }
        }

        public bool BatchManage
        {
            get { return batchManage; }
            set { batchManage = value; }
        }

        public string AuthorizationGroup
        {
            get { return authorizationGroup; }
            set { authorizationGroup = value; }
        }

        public decimal NetWeight
        {
            get { return netWeight; }
            set { netWeight = value; }
        }

        public decimal GrossWeight
        {
            get { return grossWeight; }
            set { grossWeight = value; }
        }

        public string WeightUoM
        {
            get { return weightUoM; }
            set { weightUoM = value; }
        }

        public string CompetencyBusinessCode
        {
            get { return competencyBusinessCode; }
            set { competencyBusinessCode = value; }
        }

        public string ProductLine
        {
            get { return productLine; }
            set { productLine = value; }
        }

        public string RevisionLevel
        {
            get { return revisionLevel; }
            set { revisionLevel = value; }
        }

        public string CatalogNumber
        {
            get { return catalogNumber; }
            set { catalogNumber = value; }
        }

        public string ProductBrandName
        {
            get { return productBrandName; }
            set { productBrandName = value; }
        }

        public string EngineeringPartNumber
        {
            get { return engineeringPartNumber; }
            set { engineeringPartNumber = value; }
        }

        public string AcquisitionFormat
        {
            get { return acquisitionFormat; }
            set { acquisitionFormat = value; }
        }

        public DateTime DateLastChange
        {
            get { return dateLastChange; }
            set { dateLastChange = value; }
        }
        #endregion
        public void ParseMaterial(string line)
        {
            MaterialNumber = line.Substring(4, 18).Trim();
            CreationDate = txtWriter.convDate(line.Substring(22, 8).Trim());
            MaterialType = line.Substring(30, 4).Trim();
            MaterialDescription = line.Substring(36, 40).Trim();
            BaseUoM = line.Substring(76, 3).Trim();
            MaterialGrooup = line.Substring(79, 9).Trim();
            ProductionHierarchy = line.Substring(106, 18).Trim();
            CrossPlant = line.Substring(124, 2).Trim();
            string strBatch = line.Substring(127, 1).Trim();
            if (strBatch == "0")
                BatchManage = false;
            else
                batchManage = true;
            AuthorizationGroup = line.Substring(127, 4).Trim();
            NetWeight = decimal.Parse( line.Substring(131, 17).Trim());
            GrossWeight = decimal.Parse(line.Substring(148, 17).Trim());
            WeightUoM = line.Substring(165, 3).Trim();
            CompetencyBusinessCode = line.Substring(168, 5).Trim();
            ProductLine = line.Substring(173, 3).Trim();
            RevisionLevel = line.Substring(196, 2).Trim();
            CatalogNumber = line.Substring(242, 35).Trim();
            ProductBrandName = line.Substring(277, 25).Trim();
            EngineeringPartNumber = line.Substring(302, 30).Trim();
            AcquisitionFormat = line.Substring(381, 4).Trim();
            DateLastChange = txtWriter.convDate( line.Substring(397, 8).Trim());
        }
    }

}
