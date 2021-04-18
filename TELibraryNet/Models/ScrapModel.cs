using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TELibraryNet.DataTransactions;

namespace TELibraryNet.Models
{
    public class ScrapModel
    {
          private int id;
        private string workCenter;
        private string operationActivityNumber;
        private string scrapcode;
        private string scrapDescription;
        private decimal oprnGoodsQty;
        private decimal oprnScrapqty;
        private string uom;
        private DateTime datePosted;
        private string postedBy;
        private DateTime dateEntered;
        private string prodOrderNumb;
        private string materialNumber;
        private string materialDescription;
        private decimal qtyInOrderUnit;
        private decimal scrapinOrderUnit;
        private string orderUnit;
        private decimal stdcost;
        private decimal valuatedstock;
        private decimal operScrapCost;
        private decimal totoperscrapcost;
        private string prodhierarchy;
        private string mRPcontroller;
        private string orderType;
        private string controlKey;
        private string productLine;
        private string plant;
        private string confirmationNumber;
        private string confirmationCounter;
        private string actualOperator;
        private string productionscheduler;
        private decimal yieldtoBeConfirmed;
        private decimal scraptoBeConfirmed;
        #region Public Poperties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string    WorkCenter
        {
            get { return workCenter; }
            set { workCenter = value; }
        }

        public string OperationActivityNumber
        {
            get { return operationActivityNumber; }
            set { operationActivityNumber = value; }
        }

        public string Scrapcode
        {
            get { return scrapcode; }
            set { scrapcode = value; }
        }

        public string ScrapDescription
        {
            get { return scrapDescription; }
            set { scrapDescription = value; }
        }

        public decimal OprnGoodsQty
        {
            get { return oprnGoodsQty; }
            set { oprnGoodsQty = value; }
        }

        public decimal OprnScrapqty
        {
            get { return oprnScrapqty; }
            set { oprnScrapqty = value; }
        }

        public string UOM
        {
            get { return uom; }
            set { uom = value; }
        }

        public DateTime DatePosted
        {
            get { return datePosted; }
            set { datePosted = value; }
        }


        public string PostedBy
        {
            get { return postedBy; }
            set { postedBy = value; }
        }

        public DateTime DateEntered
        {
            get { return dateEntered; }
            set { dateEntered = value; }
        }

        public string ProdOrderNumb
        {
            get { return prodOrderNumb; }
            set { prodOrderNumb = value; }
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

        public decimal QtyInOrderUnit
        {
            get { return qtyInOrderUnit; }
            set { qtyInOrderUnit = value; }
        }

        public decimal ScrapinOrderUnit
        {
            get { return scrapinOrderUnit; }
            set { scrapinOrderUnit = value; }
        }

        public string OrderUnit
        {
            get { return orderUnit; }
            set { orderUnit = value; }
        }

        public decimal StdCost
        {
            get { return stdcost; }
            set { stdcost = value; }
        }

        public decimal Valuatedstock
        {
            get { return valuatedstock; }
            set { valuatedstock = value; }
        }

        public decimal OperScrapCost
        {
            get { return operScrapCost; }
            set { operScrapCost = value; }
        }

        public decimal Totoperscrapcost
        {
            get { return totoperscrapcost; }
            set { totoperscrapcost = value; }
        }

        public string Prodhierarchy
        {
            get { return prodhierarchy; }
            set { prodhierarchy = value; }
        }

        public string MRPcontroller
        {
            get { return mRPcontroller; }
            set { mRPcontroller = value; }
        }

        public string OrderType
        {
            get { return orderType; }
            set { orderType = value; }
        }

        public string ControlKey
        {
            get { return controlKey; }
            set { controlKey = value; }
        }

        public string ProductLine
        {
            get { return productLine; }
            set { productLine = value; }
        }

        public string Plant
        {
            get { return plant; }
            set { plant = value; }
        }

        public string ConfirmationNumber
        {
            get { return confirmationNumber; }
            set { confirmationNumber = value; }
        }

        public string ConfirmationCounter
        {
            get { return confirmationCounter; }
            set { confirmationCounter = value; }
        }

        public string ActualOperator
        {
            get { return actualOperator; }
            set { actualOperator = value; }
        }

        public string Productionscheduler
        {
            get { return productionscheduler; }
            set { productionscheduler = value; }
        }


        public decimal YieldtoBeConfirmed
        {
            get { return yieldtoBeConfirmed; }
            set { yieldtoBeConfirmed = value; }
        }

        public decimal ScraptoBeConfirmed
        {
            get { return scraptoBeConfirmed; }
            set { scraptoBeConfirmed = value; }
        }
#endregion

        public void ParseScrap(string line)
        {
            WorkCenter = line.Substring(0, 8);
            OperationActivityNumber = line.Substring(8, 4);
            Scrapcode = line.Substring(12, 4);
            ScrapDescription = line.Substring(16, 30);
            OprnGoodsQty = decimal.Parse(line.Substring(86, 19));
            OprnScrapqty = decimal.Parse(line.Substring(105, 19));
            UOM = line.Substring(124, 3);
            DatePosted = txtWriter.convDate(line.Substring(144, 8));
            PostedBy = line.Substring(152, 12);
            DateEntered = txtWriter.convDate(line.Substring(164, 8));
            ProdOrderNumb = line.Substring(178, 12);
            MaterialNumber = line.Substring(190, 18);
            MaterialDescription = line.Substring(208, 40);
            QtyInOrderUnit = decimal.Parse(line.Substring(248, 19));
            ScrapinOrderUnit = decimal.Parse(line.Substring(267, 19));
            OrderUnit = line.Substring(286, 3);
            StdCost = decimal.Parse(line.Substring(289, 16));
            Valuatedstock = decimal.Parse(line.Substring(310, 16));
            OperScrapCost = decimal.Parse(line.Substring(326, 16));
            Totoperscrapcost = decimal.Parse(line.Substring(342, 16));
            Prodhierarchy = line.Substring(358, 18);
            MRPcontroller = line.Substring(376, 3);
            OrderType = line.Substring(379, 4);
            ControlKey = line.Substring(383, 4);
            ProductLine = line.Substring(395, 3);
            Plant = line.Substring(398, 4);
            ConfirmationNumber = line.Substring(402, 10);
            ConfirmationCounter = line.Substring(412, 8);
            ActualOperator = line.Substring(420, 8);
            Productionscheduler = line.Substring(432, 3);
            YieldtoBeConfirmed = decimal.Parse(line.Substring(435, 17));
            ScraptoBeConfirmed = decimal.Parse(line.Substring(452, 17));
        }
    }
}
