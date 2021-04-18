using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TELibraryNet.DataTransactions;

namespace TELibraryNet.Models
{
    public class ProdMaterialModel
    {
        private int id;
        private string orderNumber;
        private string itemNumber;
        private string componentNumber;
        private string componentDescription;
        private decimal requiredQty;
        private string componentUOM;
        private string itemCategory;
        private string batchNumber;
        private string bulkMaterialIndicator;
        private string backFluchIndicator;

        private string allocated;
        private string coproductIndicator;
        private string phantomIndicator;
        private decimal qtyWithdrawn;
        private DateTime requirementDate;
        private string reservationNumber;
        private string reservationItem;
        private string fixedQtyIndicator;
        private decimal componentScrap;
        private decimal operationScrapPercent;
        private string revisionLevel;
        #region Public Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }

        public string ItemNumber
        {
            get { return itemNumber; }
            set { itemNumber = value; }
        }

        public string ComponentNumber
        {
            get { return componentNumber; }
            set { componentNumber = value; }
        }

        public string ComponentDescription
        {
            get { return componentDescription; }
            set { componentDescription = value; }
        }

        public decimal RequiredQty
        {
            get { return requiredQty; }
            set { requiredQty = value; }
        }

        public string ComponentUOM
        {
            get { return componentUOM; }
            set { componentUOM = value; }
        }

        public string ItemCategory
        {
            get { return itemCategory; }
            set { itemCategory = value; }
        }

        public string BatchNumber
        {
            get { return batchNumber; }
            set { batchNumber = value; }
        }

        public string BulkMaterialIndicator
        {
            get { return bulkMaterialIndicator; }
            set { bulkMaterialIndicator = value; }
        }

        public string BackFlushIndicator
        {
            get { return backFluchIndicator; }
            set { backFluchIndicator = value; }
        }

        public string Allocated
        {
            get { return allocated; }
            set { allocated = value; }
        }

        public string CoproductIndicator
        {
            get { return coproductIndicator; }
            set { coproductIndicator = value; }
        }

        public string PhantomIndicator
        {
            get { return phantomIndicator; }
            set { phantomIndicator = value; }
        }

        public decimal QtyWithdrawn
        {
            get { return qtyWithdrawn; }
            set { qtyWithdrawn = value; }
        }

        public DateTime RequirementDate
        {
            get { return requirementDate; }
            set { requirementDate = value; }
        }

        public string ReservationNumber
        {
            get { return reservationNumber; }
            set { reservationNumber = value; }
        }

        public string ReservationItem
        {
            get { return reservationItem; }
            set { reservationItem = value; }
        }

        public string FixedQtyIndicator
        {
            get { return fixedQtyIndicator; }
            set { fixedQtyIndicator = value; }
        }

        public decimal ComponentScrap
        {
            get { return componentScrap; }
            set { componentScrap = value; }
        }

        public decimal OperationScrapPercent
        {
            get { return operationScrapPercent; }
            set { operationScrapPercent = value; }
        }

        public string RevisionLevel
        {
            get { return revisionLevel; }
            set { revisionLevel = value; }
        }
        #endregion

        public void ParseProdMaterial(string line)
        {
            int stringLenght = line.Length;
           OrderNumber = line.Substring(5, 12);
           ItemNumber = line.Substring(17, 4);
            ComponentNumber = txtWriter.CleanString(line.Substring(21, 18));
            ComponentDescription = line.Substring(39, 40);
            RequiredQty = Convert.ToDecimal(line.Substring(79, 17));
            ComponentUOM = line.Substring(96, 3);
            ItemCategory = line.Substring(99, 1);
            BatchNumber = line.Substring(108, 10);
            BulkMaterialIndicator = line.Substring(118, 1);
            BackFlushIndicator = line.Substring(119, 1);
            Allocated = line.Substring(120, 4);
            CoproductIndicator = line.Substring(124, 1);
            PhantomIndicator = line.Substring(125, 1);
            QtyWithdrawn = Convert.ToDecimal(line.Substring(126, 17));
            string strRequirementDate = line.Substring(143, 8);
            RequirementDate = txtWriter.convDate(strRequirementDate);
            ReservationNumber = line.Substring(151, 10);
            ReservationItem = line.Substring(161, 4);
            FixedQtyIndicator = line.Substring(165, 1);
            ComponentScrap = Convert.ToDecimal(line.Substring(166, 6));
            OperationScrapPercent = 0;
            if (stringLenght > 190)
                RevisionLevel = line.Substring(188, 2);
            else if (stringLenght == 190)
                RevisionLevel = line.Substring(188, 1);
            else
                RevisionLevel = "-";
        }

    }
}
