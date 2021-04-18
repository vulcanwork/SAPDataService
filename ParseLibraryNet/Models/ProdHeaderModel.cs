using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParseLibraryNet.DataTransactions;

namespace ParseLibraryNet.Models
{
    public class ProdHeaderModel
    {
        private int id;
        private string lineType;
        private string plant;
        private string orderNumber;
        private string orderType;
        private string materialNumber;
        private string materialDescription;
        private string revisionLevel;
        private string mRPcontroller;
        private string productionScheduler;
        private string plannerGroup;
        private decimal orderQuatity;
        private string baseUnitMeasure;
        private string orderUnitMeasure;
        private decimal scrapQuantity;
        private decimal scrapPercent;
        private string expectedYieldVariance;
        private DateTime basicStartDate;
        private DateTime basicfinishDate;
        private DateTime scheduledStartDate;
        private DateTime scheduledFinishDate;
        private DateTime schduledReleaseDate;
        private DateTime actualReleaseDate;
        private string schdulingMarginKey;
        private string floatBeforeProduction;
        private string floatAfterProduction;
        private string releasedPeriod;
        private string batchNumber;
        private string goodsReceipt;
        private string storageLocation;
        private string salesOrderNumber;
        private string salesOrderItem;
        private string createdBy;
        private DateTime creationDate;
        private string gRprocessingTime;
        private string underDeliveryTolerence;
        private string overDeliveryTolerence;
        private string unlimitedDelivery;
        private string productionSchedulingProfile;
        private string putInStockQuantity;
        private string priority;
        private string schedulingType;
        private DateTime basicFinishDate2;
        private DateTime basicStartDate3;
        private DateTime interfaceAcknowledgeDate;
        private DateTime originalSchedFinishDate;
        private DateTime originalSchedStartDate;
        private decimal originalOrderQuantity;
        private decimal originalOrderScrapQuantity;
        private string orderStatus;
        private decimal loadQuantity;
        private decimal quantityConfirmed;
        private decimal productionQuantity;
        private string orderText;
        private DateTime lastChangeDate;
        private string profitCenter;
        private string materialProfitCenter;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string LineType
        {
            get { return lineType; }
            set { lineType = value; }
        }
        public string Plant
        {
            get { return plant; }
            set { plant = value; }
        }
        public string OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }
        public string OrderType
        {
            get { return orderType; }
            set { orderType = value; }
        }
        public string MaterialNumber
        {
            get { return materialNumber; }
            set { materialNumber = value; }
        }
        public string MaterialDescription
        {
            get { return materialDescription; }
            set { materialDescription = value; }
        }
        public string RevisionLevel
        {
            get { return revisionLevel; }
            set { revisionLevel = value; }
        }
        public string MRPcontroller
        {
            get { return mRPcontroller; }
            set { mRPcontroller = value; }
        }
        public string ProductionScheduler
        {
            get { return productionScheduler; }
            set { productionScheduler = value; }
        }
        public string PlannerGroup
        {
            get { return plannerGroup; }
            set { plannerGroup = value; }
        }
        public decimal OrderQuatity
        {
            get { return orderQuatity; }
            set { orderQuatity = value; }
        }
        public string BaseUnitMeasure
        {
            get { return baseUnitMeasure; }
            set { baseUnitMeasure = value; }
        }
        public string OrderUnitMeasure

        {
            get { return orderUnitMeasure; }
            set { orderUnitMeasure = value; }
        }
        public decimal ScrapQuantity
        {
            get { return scrapQuantity; }
            set { scrapQuantity = value; }
        }
        public decimal ScrapPercent
        {
            get { return scrapPercent; }
            set { scrapPercent = value; }
        }
        public string ExpectedYieldVariance
        {
            get { return expectedYieldVariance; }
            set { expectedYieldVariance = value; }
        }
        public DateTime BasicStartDate
        {
            get { return basicStartDate; }
            set { basicStartDate = value; }
        }
        public DateTime BasicfinishDate
        {
            get { return basicfinishDate; }
            set { basicfinishDate = value; }
        }
        public DateTime ScheduledStartDate
        {
            get { return scheduledStartDate; }
            set { scheduledStartDate = value; }
        }
        public DateTime ScheduledFinishDate
        {
            get { return scheduledFinishDate; }
            set { scheduledFinishDate = value; }
        }
        public DateTime SchduledReleaseDate
        {
            get { return schduledReleaseDate; }
            set { schduledReleaseDate = value; }
        }
        public DateTime ActualReleaseDate
        {
            get { return actualReleaseDate; }
            set { actualReleaseDate = value; }
        }
        public string SchdulingMarginKey
        {
            get { return schdulingMarginKey; }
            set { schdulingMarginKey = value; }
        }
        public string FloatBeforeProduction
        {
            get { return floatBeforeProduction; }
            set { floatBeforeProduction = value; }
        }
        public string FloatAfterProduction
        {
            get { return floatAfterProduction; }
            set { floatAfterProduction = value; }
        }
        public string ReleasedPeriod
        {
            get { return releasedPeriod; }
            set { releasedPeriod = value; }
        }
        public string BatchNumber
        {
            get { return batchNumber; }
            set { batchNumber = value; }
        }
        public string GoodsReceipt
        {
            get { return goodsReceipt; }
            set { goodsReceipt = value; }
        }
        public string StorageLocation
        {
            get { return storageLocation; }
            set { storageLocation = value; }
        }
        public string SalesOrderNumber
        {
            get { return salesOrderNumber; }
            set { salesOrderNumber = value; }
        }
        public string SalesOrderItem
        {
            get { return salesOrderItem; }
            set { salesOrderItem = value; }
        }
        public string CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }
        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }
        public string GRprocessingTime
        {
            get { return gRprocessingTime; }
            set { gRprocessingTime = value; }
        }
        public string UnderDeliveryTolerence
        {
            get { return underDeliveryTolerence; }
            set { underDeliveryTolerence = value; }
        }
        public string OverDeliveryTolerence
        {
            get { return overDeliveryTolerence; }
            set { overDeliveryTolerence = value; }
        }
        public string UnlimitedDelivery
        {
            get { return unlimitedDelivery; }
            set { unlimitedDelivery = value; }
        }
        public string ProductionSchedulingProfile
        {
            get { return productionSchedulingProfile; }
            set { productionSchedulingProfile = value; }
        }
        public string PutInStockQuantity
        {
            get { return putInStockQuantity; }
            set { putInStockQuantity = value; }
        }
        public string Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        public string SchedulingType
        {
            get { return schedulingType; }
            set { schedulingType = value; }
        }
        public DateTime BasicFinishDate2
        {
            get { return basicFinishDate2; }
            set { basicFinishDate2 = value; }
        }
        public DateTime BasicStartDate3
        {
            get { return basicStartDate3; }
            set { basicStartDate3 = value; }
        }
        public DateTime InterfaceAcknowledgeDate
        {
            get { return interfaceAcknowledgeDate; }
            set { interfaceAcknowledgeDate = value; }
        }
        public DateTime OriginalSchedFinishDate
        {
            get { return originalSchedFinishDate; }
            set { originalSchedFinishDate = value; }
        }
        public DateTime OriginalSchedStartDate
        {
            get { return originalSchedStartDate; }
            set { originalSchedStartDate = value; }
        }
        public decimal OriginalOrderQuantity
        {
            get { return originalOrderQuantity; }
            set { originalOrderQuantity = value; }
        }
        public decimal OriginalOrderScrapQuantity
        {
            get { return originalOrderScrapQuantity; }
            set { originalOrderScrapQuantity = value; }
        }
        public string OrderStatus
        {
            get { return orderStatus; }
            set { orderStatus = value; }
        }
        public decimal LoadQuantity
        {
            get { return loadQuantity; }
            set { loadQuantity = value; }
        }
        public decimal QuantityConfirmed
        {
            get { return quantityConfirmed; }
            set { quantityConfirmed = value; }
        }
        public decimal ProductionQuantity
        {
            get { return productionQuantity; }
            set { productionQuantity = value; }
        }
        public string OrderText
        {
            get { return orderText; }
            set { orderText = value; }
        }
        public DateTime LastChangeDate
        {
            get { return lastChangeDate; }
            set { lastChangeDate = value; }
        }
        public string ProfitCenter
        {
            get { return profitCenter; }
            set { profitCenter = value; }
        }
        public string MaterialProfitCenter
        {
            get { return materialProfitCenter; }
            set { materialProfitCenter = value; }
        }
        /// <summary>
        /// parse a line of text(one instance of a ProdHeaderModel) by index
        /// </summary>
        /// <param name="line">one line from tesxt extract</param>
        public void ParseProdHeader(string line)
        {
            int length = line.Length;
            LineType = line.Substring(0, 1);
            Plant = line.Substring(1, 4);
            OrderNumber = line.Substring(5, 12);
            OrderType = line.Substring(17, 4);
            MaterialNumber = line.Substring(21, 18);
            MaterialDescription = line.Substring(39, 40);
            RevisionLevel = line.Substring(79, 2);
            MRPcontroller = line.Substring(81, 3);
            ProductionScheduler = line.Substring(84, 3);
            PlannerGroup = line.Substring(87, 3);
            OrderQuatity = Convert.ToDecimal(line.Substring(90, 17));
            BaseUnitMeasure = line.Substring(107, 3);
            OrderUnitMeasure = line.Substring(110, 3);
            ScrapQuantity = Convert.ToDecimal(line.Substring(113, 17));
            ScrapPercent = Convert.ToDecimal(line.Substring(130, 6));
            ExpectedYieldVariance = line.Substring(136, 17);
            string strBasicStartDate = line.Substring(153, 8);
            BasicStartDate = txtWriter.convDate(strBasicStartDate);
            string strBasicfinishDate = line.Substring(161, 8);
            BasicfinishDate = txtWriter.convDate(strBasicfinishDate);
            string strScheduledStartDate = line.Substring(169, 8);
            ScheduledStartDate = txtWriter.convDate(strScheduledStartDate);
            string strScheduledFinishDate = line.Substring(177, 8);
            ScheduledFinishDate = txtWriter.convDate(strScheduledFinishDate);
            string strSchduledReleaseDate = line.Substring(185, 8);
            SchduledReleaseDate = txtWriter.convDate(strSchduledReleaseDate);
            string strActualReleaseDate = line.Substring(193, 8);
            ActualReleaseDate = txtWriter.convDate(strActualReleaseDate);
            SchdulingMarginKey = line.Substring(201, 3);
            FloatBeforeProduction = line.Substring(204, 3);
            FloatAfterProduction = line.Substring(207, 3);
            ReleasedPeriod = line.Substring(210, 3);
            BatchNumber = line.Substring(213, 10);
            GoodsReceipt = line.Substring(223, 12);
            StorageLocation = line.Substring(235, 4);
            SalesOrderNumber = line.Substring(239, 10);
            SalesOrderItem = line.Substring(249, 6);
            CreatedBy = line.Substring(255, 8);
            string strCreationDate = line.Substring(263, 8);
            CreationDate = txtWriter.convDate(strCreationDate);
            GRprocessingTime = line.Substring(271, 3);
            UnderDeliveryTolerence = line.Substring(274, 4);
            OverDeliveryTolerence = line.Substring(278, 4);
            UnlimitedDelivery = line.Substring(282, 1);
            ProductionSchedulingProfile = line.Substring(283, 6);
            PutInStockQuantity = line.Substring(289, 17);
            Priority = line.Substring(306, 1);
            SchedulingType = line.Substring(307, 1);
            string strBasicFinishDate2 = line.Substring(308, 8);
            BasicFinishDate2 = txtWriter.convDate(strBasicFinishDate2);
            string strBasicStartDate3 = line.Substring(316, 8);
            BasicStartDate3 = txtWriter.convDate(strBasicStartDate3);
            string strInterfaceAcknowledgeDate = line.Substring(324, 8);
            InterfaceAcknowledgeDate = txtWriter.convDate(strInterfaceAcknowledgeDate);
            string strOriginalSchedFinishDate = line.Substring(332, 8);
            OriginalSchedFinishDate = txtWriter.convDate(strOriginalSchedFinishDate);
            string strOriginalSchedStartDate = line.Substring(340, 8);
            OriginalSchedStartDate = txtWriter.convDate(strOriginalSchedStartDate);
            OriginalOrderQuantity = Convert.ToDecimal(line.Substring(348, 17));
            OriginalOrderScrapQuantity = Convert.ToDecimal(line.Substring(365, 17));
            OrderStatus = line.Substring(382, 40);
            LoadQuantity = Convert.ToDecimal(line.Substring(422, 17));
            if (string.IsNullOrWhiteSpace(line.Substring(439, 17)))
                QuantityConfirmed = 0;
            else
            QuantityConfirmed = Convert.ToDecimal(line.Substring(439, 17));
            ProductionQuantity = Convert.ToDecimal(line.Substring(456, 17));
            OrderText = line.Substring(473, 75);
            string strLastChangeDate = line.Substring(548, 8);
            LastChangeDate = txtWriter.convDate(strLastChangeDate);
            if (length >= 562)
                ProfitCenter = line.Substring(556, 7);
            else
                profitCenter = null;
            if(length>=568)
               MaterialProfitCenter = line.Substring(563, 6);            
            else           
               MaterialProfitCenter = null;            
        }
    }
   
}
