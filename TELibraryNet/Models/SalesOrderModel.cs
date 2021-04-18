using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParseLibraryNet.DataTransactions;
namespace ParseLibraryNet.Models
{
    public class SalesOrderModel
    {


        private int id;
        private string saleOrder;
        private int salesOrderItem;
        private string materialNumber;
        private string materialDescription;
        private string customerMaterialNmb;
        private decimal quantity;
        private DateTime plannedShipDate;
        private DateTime availabilityDate;
        private string soldTo;
        private string soldToName;
        private string shipTo;
        private String shipToName;
        private string mRPController;

        #region Public Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string SalesOrder
        {
            get { return saleOrder; }
            set { saleOrder = value; }
        }

        public int SalesOrderItem
        {
            get { return salesOrderItem; }
            set { salesOrderItem = value; }
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

        public string CustomerMaterialNmb
        {
            get { return customerMaterialNmb; }
            set { customerMaterialNmb = value; }
        }

        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public DateTime PlannedShipDate
        {
            get { return plannedShipDate; }
            set { plannedShipDate = value; }
        }

        public DateTime AvailabilityDate
        {
            get { return availabilityDate; }
            set { availabilityDate = value; }
        }

        public string SoldTo
        {
            get { return soldTo; }
            set { soldTo = value; }
        }

        public string SoldToName
        {
            get { return soldToName; }
            set { soldToName = value; }
        }

        public string ShipTo
        {
            get { return shipTo; }
            set { shipTo = value; }
        }

        public String ShipToName
        {
            get { return shipToName; }
            set { shipToName = value; }
        }

        public string MRPController
        {
            get { return mRPController; }
            set { mRPController = value; }

        }
        #endregion
        public void ParseSalesOrder(string line)
        {
            int stringLength = line.Length;

            SalesOrder = line.Substring(0, 10);
            SalesOrderItem = Convert.ToInt32(line.Substring(12, 6).Trim());
            MaterialNumber = line.Substring(22, 18).Trim();
            MaterialDescription = line.Substring(43, 40);
            CustomerMaterialNmb = "Customer"; line.Substring(78, 25);
            string strQuantity = txtWriter.CleanString(line.Substring(99, 11));
            Quantity = Convert.ToDecimal(strQuantity);
            string pldate = line.Substring(111, 10);
            try
            {
                PlannedShipDate = Convert.ToDateTime(pldate);
            }
            catch (Exception)
            {
                PlannedShipDate = Convert.ToDateTime("01/01/1911");

            }
            string availDate = line.Substring(127, 8);
            try
            {
                AvailabilityDate = txtWriter.convDate(availDate);
            }
            catch (Exception)
            {
                AvailabilityDate = Convert.ToDateTime("3999/01/01");
            }
            SoldTo = line.Substring(141, 10);
            SoldToName = line.Substring(152, 30);
            ShipTo = line.Substring(182, 10);
            ShipToName = null;//line.Substring(197, 29);

            if (stringLength >= 257)
                MRPController = line.Substring(225, 2);
            else
                MRPController = null;
        }
    }
 }
