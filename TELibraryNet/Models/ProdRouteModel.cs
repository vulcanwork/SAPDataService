using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TELibraryNet.DataTransactions;

namespace TELibraryNet.Models
{
    public class ProdRouteModel
    {
        private int id;


        private string orderNumber;
        private string sequence;
        private string operationNumber;
        private string workCenterNumber;
        private decimal baseQty;
        private decimal stdValue1;
        private string stdValueUOM1;
        private decimal stdValue2;
        private string stdValueUOM2;
        private decimal stdValue3;
        private string stdValueUOM3;
        private decimal stdValue4;
        private string stdValueUOM4;
        private decimal stdValue5;
        private string stdValueUOM5;
        private decimal stdValue6;
        private string stdValueUOM6;
        private decimal stdValue7;
        private string stdValueUOM7;
        private DateTime scheduledStartDate;
        private DateTime scheduledEndDate;
        private decimal operationQty;
        private string operationUOM;
        private decimal confirmedQty;
        private decimal confirmedScrap;
        private decimal reworkQty;
        private string operationLongTextLine1;
        private string operationLongTextLine2;
        private string operationLongTextLine3;
        private string operationLongTextLine4;
        private string operationLongTextLine5;
        private string operationsystemstatus;
        #region Public Properies
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

        public string Sequence
        {
            get { return sequence; }
            set { sequence = value; }
        }

        public string OperationNumber
        {
            get { return operationNumber; }
            set { operationNumber = value; }
        }

        public string WorkCenterNumber
        {
            get { return workCenterNumber; }
            set { workCenterNumber = value; }
        }

        public decimal BaseQty
        {
            get { return baseQty; }
            set { baseQty = value; }
        }

        public decimal StdValue1
        {
            get { return stdValue1; }
            set { stdValue1 = value; }
        }

        public string StdValueUOM1
        {
            get { return stdValueUOM1; }
            set { stdValueUOM1 = value; }
        }

        public decimal StdValue2
        {
            get { return stdValue2; }
            set { stdValue2 = value; }
        }

        public string StdValueUOM2
        {
            get { return stdValueUOM2; }
            set { stdValueUOM2 = value; }
        }

        public decimal StdValue3
        {
            get { return stdValue3; }
            set { stdValue3 = value; }
        }

        public string StdValueUOM3
        {
            get { return stdValueUOM3; }
            set { stdValueUOM3 = value; }
        }

        public decimal StdValue4
        {
            get { return stdValue4; }
            set { stdValue4 = value; }
        }

        public string StdValueUOM4
        {
            get { return stdValueUOM4; }
            set { stdValueUOM4 = value; }
        }

        public decimal StdValue5
        {
            get { return stdValue5; }
            set { stdValue5 = value; }
        }

        public string StdValueUOM5
        {
            get { return stdValueUOM5; }
            set { stdValueUOM5 = value; }
        }

        public decimal StdValue6
        {
            get { return stdValue6; }
            set { stdValue6 = value; }
        }

        public string StdValueUOM6
        {
            get { return stdValueUOM6; }
            set { stdValueUOM6 = value; }
        }

        public decimal StdValue7
        {
            get { return stdValue7; }
            set { stdValue7 = value; }
        }

        public string StdValueUOM7
        {
            get { return stdValueUOM7; }
            set { stdValueUOM7 = value; }
        }

        public DateTime ScheduledStartDate
        {
            get { return scheduledStartDate; }
            set { scheduledStartDate = value; }
        }

        public DateTime ScheduledEndDate
        {
            get { return scheduledEndDate; }
            set { scheduledEndDate = value; }
        }

        public decimal OperationQty
        {
            get { return operationQty; }
            set { operationQty = value; }
        }

        public string OperationUOM
        {
            get { return operationUOM; }
            set { operationUOM = value; }
        }

        public decimal ConfirmedQty
        {
            get { return confirmedQty; }
            set { confirmedQty = value; }
        }

        public decimal ConfirmedScrap
        {
            get { return confirmedScrap; }
            set { confirmedScrap = value; }
        }

        public decimal ReworkQty
        {
            get { return reworkQty; }
            set { reworkQty = value; }
        }

        public string OperationLongTextLine1
        {
            get { return operationLongTextLine1; }
            set { operationLongTextLine1 = value; }
        }

        public string OperationLongTextLine2
        {
            get { return operationLongTextLine2; }
            set { operationLongTextLine2 = value; }
        }

        public string OperationLongTextLine3
        {
            get { return operationLongTextLine3; }
            set { operationLongTextLine3 = value; }
        }

        public string OperationLongTextLine4
        {
            get { return operationLongTextLine4; }
            set { operationLongTextLine4 = value; }
        }

        public string OperationLongTextLine5
        {
            get { return operationLongTextLine5; }
            set { operationLongTextLine5 = value; }
        }

        public string Operationsystemstatus
        {
            get { return operationsystemstatus; }
            set { operationsystemstatus = value; }
        }
        #endregion

        public void ParseProdRoutes(string line)
        {
            OrderNumber = line.Substring(5, 12);
            Sequence = line.Substring(17, 6);
            OperationNumber = line.Substring(23, 4);
            WorkCenterNumber = line.Substring(31, 8);
            BaseQty = Convert.ToDecimal(line.Substring(54, 17));
            StdValue1 = Convert.ToDecimal(line.Substring(75, 10));
            StdValueUOM1 = line.Substring(86, 3);
            StdValue2 = Convert.ToDecimal(line.Substring(89, 11));
            StdValueUOM2 = line.Substring(100, 3);
            StdValue3 = Convert.ToDecimal(line.Substring(103, 11));
            StdValueUOM3 = line.Substring(114, 3);
            StdValue4 = Convert.ToDecimal(line.Substring(117, 11));
            StdValueUOM4 = line.Substring(128, 3);
            StdValue5 = Convert.ToDecimal(line.Substring(131, 11));
            StdValueUOM5 = line.Substring(142, 3);
            StdValue6 = Convert.ToDecimal(line.Substring(145, 11));
            StdValueUOM6 = line.Substring(156, 3);
            StdValue7 = 0;//Convert.ToDecimal(line.Substring(159, 11));
            StdValueUOM7 = "HR";// line.Substring(170, 3);
            string strScheduledStartDate = line.Substring(173, 8);
            ScheduledStartDate = txtWriter.convDate(strScheduledStartDate);
            string strScheduledEndDate = line.Substring(181, 8);
            ScheduledEndDate = txtWriter.convDate(strScheduledEndDate);
            OperationQty = Convert.ToDecimal(line.Substring(189, 17));
            OperationUOM = line.Substring(206, 3);
            ConfirmedQty = Convert.ToDecimal(line.Substring(209, 17));
            ConfirmedScrap = Convert.ToDecimal(line.Substring(226, 17));
            ReworkQty = Convert.ToDecimal(line.Substring(243, 17));
            OperationLongTextLine1 = line.Substring(565, 79);
            OperationLongTextLine2 = line.Substring(644, 79);
            OperationLongTextLine3 = line.Substring(723, 79);
            OperationLongTextLine4 = line.Substring(802, 79);
            OperationLongTextLine5 = line.Substring(881, 79);
            Operationsystemstatus = line.Substring(959, 4);
        }

    }
}
