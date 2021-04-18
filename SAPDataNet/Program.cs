using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using TELibraryNet.DataTransactions;
using TELibraryNet.Models;
using System.Diagnostics;

namespace SAPDataNetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseWindowsService()
                .ConfigureServices((hostContext, services) =>
                {                    
                    services.AddHostedService<Worker>();
                });


        private static string filePOHeader = @"E:\Shares\SAPdata\\ProductionOrdersProductionOrders1.txt";
        private static string filePORoute = @"E:\Shares\SAPdata\ProductionOrdersProductionOrders2.txt";
        private static string filePOMaterial = @"E:\Shares\SAPdata\ProductionOrdersProductionOrders3.txt";
        private static string fileCTOCatalog = @"E:\Shares\SAPdata\ProductionOrdersMatCat.txt";
        private static string fileSO = @"E:\Shares\SAPdata\ProductionOrderssalesorders_1134.txt";
        private static string fileScrap = @"E:\Shares\SAPdata\ProductionOrdersallexport.txt";

        /// <summary> command to start all transactions.</summary>
        /// <returns></returns>
        public static void CompileALL()
        {
            string transaction = "Compile All";
            var sw = Stopwatch.StartNew();

            Thread scrapThread = new Thread(scrap);
            scrapThread.Start();
            Thread headerThread = new Thread(productionHeader);
            headerThread.Start();
            Thread routeThread = new Thread(productionRoutes);
            routeThread.Start();
            Thread prodMaterialThread = new Thread(productionMaterial);
            prodMaterialThread.Start();

            salesOrder();  
            material();
            routeThread.Join();
            prodMaterialThread.Join();
            headerThread.Join();
            scrapThread.Join();
            txtWriter.Log($"All threasds complete in : {sw.Elapsed}\nheader complete :  \t", transaction);//{complete}

        }
        /// <summary>
        /// parse CTO data and insert data into SQL
        /// </summary>
        private static void CTO()
        {
             bool success = true;
             int errorCount = 0;
            int newLineCount = 0;

        List<string> errors = new List<string>();
            string[] lines;
            string transaction = "CTO";
            try
            {
                lines = File.ReadAllLines(fileCTOCatalog);
            }
            catch (Exception e)
            {
                success = false;
                lines = null;
                string buildError = "No file found: \n\t" + e.ToString();
                errorCount++;
                txtWriter.Log(buildError, transaction, errorCount,newLineCount);
            }
            //define counters for info tracker to count each pass in the foreach function
            int countPassedUpdate = 0;
            int countInserCommand = 0;

            if (success)
            {
                CTOModel ctoModel;
                foreach (string line in lines)
                {
                    ctoModel = new CTOModel();
                    ctoModel.ParseCTO(line);
                    ctoModel.ID = sqlTransactions.SelectCTOID(ctoModel);
                    if (ctoModel.ID < 1)
                    {
                        try
                        { 
                        sqlTransactions.InsertCTO(ctoModel);
                        newLineCount++;
                        countInserCommand++;
                    }
                        catch (Exception ee)
                    {

                        txtWriter.Log(ee.ToString(), ctoModel.CatalogNumber);
                    }

                }
                    else
                        countPassedUpdate++;
                }
                string strgInfo = $"{transaction} had: \n \tInserts:{countInserCommand}\n\tUpdates:NA\n\tNo Transaction: {countPassedUpdate}\n\n";
                txtWriter.writeInfo(strgInfo);
                    //define streams and send to log writer
                    txtWriter.Log(errors, transaction, errorCount, newLineCount);
           
            success = true;
        }
    }
        /// <summary>
        /// parse material master data and insert data into SQL
        /// </summary>
        private static void material()
        {            
            string timeStart = DateTime.Now.ToString();

            bool success = true;
            int errorCount = 0;
            int newLineCount = 0;
            List<string> errors = new List<string>();
            string[] lines;
            string transaction = "Material";
            try
            {
                lines = File.ReadAllLines(fileCTOCatalog);
            }
            catch (Exception e)
            {
                success = false;
                lines = null;
                string buildError = "No file found: \n\t" + e.ToString();
                errorCount++;
                txtWriter.Log(buildError, transaction, errorCount, newLineCount);
            }
            //define counters for info tracker to count each pass in the foreach function

            int countPassedUpdate = 0;
            int countInserCommand = 0;
            if (success)
            {
                MaterialModel materialModel;
                foreach (string line in lines)
                {
                    materialModel = new MaterialModel();
                    materialModel.ParseMaterial(line);
                    materialModel.ID = sqlTransactions.SelectMaterialID(materialModel);
                    if (materialModel.ID < 1)
                    {
                        try
                        {
                            sqlTransactions.InsertMaterial(materialModel);
                            newLineCount++;
                            countInserCommand++;
                        }
                        catch (Exception ee)
                        {

                            txtWriter.Log(ee.ToString(), materialModel.MaterialNumber);
                        }
                    }
                    else
                        countPassedUpdate++;

                }
                string strgInfo = $"{transaction} started at {timeStart}: \n \tInserts:{countInserCommand}\n\tUpdates:NA\n\tNo Transaction: {countPassedUpdate}\n\n";

                txtWriter.writeInfo(strgInfo);
                    //define streams and send to log writer
                    if(errorCount > 0)
                    txtWriter.Log(errors, transaction, errorCount, newLineCount);            
            }
            success = true;
        }
        /// <summary>
        /// parse Production Header Data and insert data into SQL
        /// </summary>
        private static void productionHeader()
        {
            string timeStart = DateTime.Now.ToString();

            bool success = true;
            int errorCount = 0;
            int newLineCount = 0;
            List<string> errors = new List<string>();
            string[] lines;
            string transaction = "Production Header";
            try
            {
                lines = File.ReadAllLines(filePOHeader);
            }
            catch (Exception e)
            {
                success = false;
                lines = null;
                string buildError = "No file found: \n\t" + e.ToString();
                //string buildError = string.Format(, "Nofile found:", e.ToString());                
                errorCount++;
                txtWriter.Log(buildError, transaction,errorCount, newLineCount);
            }
            //define counters for info tracker to count each pass in the foreach function
            int countUpdateCommand = 0;
            int countPassedUpdate = 0;
            int countInserCommand = 0;

            if (success)
            {
                ProdHeaderModel headerModel;
                foreach (string line in lines)
                {
                    headerModel = new ProdHeaderModel();
                    try
                    {
                        headerModel.ParseProdHeader(line);
                    }
                    catch (Exception ee)
                    {
                        errors.Add($"Error parse Prod Header: \n {ee}");
                        success = false;

                    }
                    headerModel.ID = sqlTransactions.SelectProdHeaderID(headerModel);
                    if (headerModel.ID < 1 && success)
                    {
                        try
                        {
                            sqlTransactions.InsertProdOrderHeader(headerModel);
                            newLineCount++;
                            countInserCommand++;
                        }
                        catch (Exception ee)
                        {

                            txtWriter.Log(ee.ToString(), headerModel.OrderNumber);
                        }
                    }
                    else
                    {
                        try
                        {
                            if (sqlTransactions.SelectProdHeaderChangeDate(headerModel))
                                countPassedUpdate++;
                            else
                            {
                                sqlTransactions.UpdateProdOrderHeader(headerModel);
                                countUpdateCommand++;
                            }
                        }
                        catch (Exception ee)
                        {
                            errorCount++;
                            errors.Add($"Error at ChangeDate or Update prod headre: \n {ee}");
                        }
                    }
                    success = true;
                }
                    string strgInfo = $"{transaction} had: \n \tInserts:{countInserCommand}\n\tUpdates:{countUpdateCommand}\n\tNo Transaction: {countPassedUpdate}\n\n";

                    txtWriter.writeInfo(strgInfo);
                //define streams and send to txtWriter.Log writer
                if (errorCount > 0)
                    txtWriter.Log(errors, transaction, errorCount, newLineCount);              
            }
            success = true;
        }
        /// <summary>
        /// parse Parse Production Material data and insert data into SQL
        /// </summary>
        private static void productionMaterial()
        {
            string timeStart = DateTime.Now.ToString();
            bool success = true;
            int errorCount = 0;
            int newLineCount = 0;
            List<string> errors = new List<string>();
            string[] lines;
            string transaction = "Production Order Material";

            try
            {
                lines = File.ReadAllLines(filePOMaterial);
            }
            catch (Exception e)
            {
                success = false;
                lines = null;
                string buildError = "No file found: \n\t" + e.ToString();
                errorCount++;
                txtWriter.Log(buildError, transaction, errorCount, newLineCount);
            }
            //define counters for info tracker to count each pass in the foreach function
            //int countUpdateCommand = 0;
            int countPassedUpdate = 0;
            int countInserCommand = 0;

            if (success)
            {
                ProdMaterialModel materialModel;
                foreach (string line in lines)
                {
                    materialModel = new ProdMaterialModel();
                    try
                    {
                        materialModel.ParseProdMaterial(line);
                    }
                    catch (Exception ee)
                    {
                        errors.Add($"Error parse Prod Material: \n {ee}");
                        success = false;

                    }
                    materialModel.ID = sqlTransactions.SelectProdMaterialID(materialModel);
                    string poNumber = materialModel.OrderNumber.Substring(0, 2);
                    if (materialModel.ID < 1 && poNumber != "-D" && poNumber != "00")
                    {
                        try
                        {
                            sqlTransactions.InsertProdOrderMaterial(materialModel);
                            newLineCount++;
                            countInserCommand++;
                        }
                        catch (Exception ee)
                        {
                            txtWriter.Log(ee.ToString(), materialModel.OrderNumber);

                        }
                    }
                    else
                        countPassedUpdate++;
                    success = true;
                }


                string strgInfo = $"{transaction} started at {timeStart}: \n \tInserts:{countInserCommand}\n\tUpdates:NA\n\tNo Transaction: {countPassedUpdate}\n\n";

                txtWriter.writeInfo(strgInfo);
                //define streams and send to txtWriter.Log writer
                if (errorCount > 0)
                    txtWriter.Log(errors, transaction, errorCount, newLineCount);               
            }
            success = true;

        }
        /// <summary>
        /// parse Production Routes data and insert data into SQL
        /// </summary>
        private static void productionRoutes()
        {            
            string timeStart = DateTime.Now.ToString();
            bool success = true;
            int errorCount = 0;
            int newLineCount = 0;
            List<string> errors = new List<string>();
            string[] lines;
            string transaction = "Production Order Routes";

            try
            {
                lines = File.ReadAllLines(filePORoute);
            }
            catch (Exception e)
            {
                success = false;
                lines = null;
                string buildError = "No file found: \n\t" + e.ToString();
                //string buildError = string.Format(, "Nofile found:", e.ToString());                
                errorCount++;
                txtWriter.Log(buildError, transaction, errorCount, newLineCount);
            }
            //define counters for info tracker to count each pass in the foreach function
            int countUpdateCommand = 0;
            int countPassedUpdate = 0;
            int countInserCommand = 0;

            if (success)
            {
                ProdRouteModel prodRoute;
                foreach (string line in lines)
                {
                    prodRoute = new ProdRouteModel();
                    try
                    {

                        prodRoute.ParseProdRoutes(line);
                    }
                        catch (Exception ee)
                    {
                        errors.Add($"Error parse Prod Header: \n {ee}");
                        success = false;

                    }
                prodRoute.ID = sqlTransactions.SelectProdRoutID(prodRoute);
                    if (prodRoute.ID < 1)
                    {
                        try
                        {
                            sqlTransactions.InsertProdOrderRout(prodRoute);
                            newLineCount++;
                            countInserCommand++;
                        }
                        catch ( Exception ee)
                        {

                            txtWriter.Log(ee.ToString(), prodRoute.OrderNumber);
                        }
                    }
                    else
                    {
                        try
                        {
                            if (sqlTransactions.SelectProdRouteQty(prodRoute))
                                countPassedUpdate++;
                            else
                            {
                                sqlTransactions.UpdateProdOrderRoute(prodRoute);
                                countUpdateCommand++;
                            }
                        }
                        catch (Exception ee)
                        {
                            errorCount++;
                            errors.Add($"Error at Route Quantity: \n {ee}");
                        }
                    }
                    success = true;
                }
                string strgInfo = $"{transaction} started at {timeStart}:\n \tInserts:{countInserCommand}\n\tUpdates:{countUpdateCommand}\n\tNo Transaction: {countPassedUpdate}\n\n";

                txtWriter.writeInfo(strgInfo);
                //define streams and send to txtWriter.Log writer
                if (errorCount > 0)
                    txtWriter.Log(errors, transaction, errorCount, newLineCount);
            }
            success = true;

        }
        /// <summary>
        /// parse Sales Orders and insert data into SQL
        /// </summary>
        private static void salesOrder()
        {
            bool success = true;
            int errorCount = 0;
            int newLineCount = 0;
            List<string> errors = new List<string>();
            string[] lines;
            string transaction = "Sales Orders";
            string timeStart = DateTime.Now.ToString();

            try
            {
                lines = File.ReadAllLines(fileSO);
            }
            catch (Exception e)
            {
                success = false;
                lines = null;
                string buildError = "No file found: \n\t" + e.ToString();
                //string buildError = string.Format(, "Nofile found:", e.ToString());                
                errorCount++;
                txtWriter.Log(buildError, transaction, errorCount, newLineCount);
            }
            //define counters for info tracker to count each pass in the foreach function

            int countPassedUpdate = 0;
            int countInserCommand = 0;

            if (success)
            {
                SalesOrderModel soModel;
                foreach (string line in lines)
                {
                    soModel = new SalesOrderModel();
                    soModel.ParseSalesOrder(line);
                    soModel.ID = sqlTransactions.SelectSalesOrderID(soModel);
                    if (soModel.ID < 1)
                    {
                        try
                        {
                            sqlTransactions.InsertSalesOrder(soModel);
                            newLineCount++;
                            countInserCommand++;
                        }
                        catch (Exception ee )
                        {

                            txtWriter.Log(ee.ToString(), soModel.SalesOrder);

                        }
                    }
                    else
                        countPassedUpdate++;

                }
                string strgInfo = $"{transaction} started at {timeStart}: \n \tInserts:{countInserCommand}\n\tUpdates:NA\n\tNo Transaction: {countPassedUpdate}\n\n";

                txtWriter.writeInfo(strgInfo);
                //define streams and send to txtWriter.Log writer
                if (errorCount > 0)
                    txtWriter.Log(errors, transaction, errorCount, newLineCount);
                
            }
            success = true;
        }
        /// <summary>
        /// parse Scrap data and insert data into SQL
        /// </summary>
        private static void scrap()
        {
            bool success = true;
            int errorCount = 0;
            int newLineCount = 0;
            string timeStart = DateTime.Now.ToString();
            List<string> errors = new List<string>();
            string[] lines;
            string transaction = "Scrap";

            try
            {
                lines = File.ReadAllLines(fileScrap);
            }
            catch (Exception e)
            {
                success = false;
                lines = null;
                string buildError = "No file found: \n\t" + e.ToString();
                errorCount++;
                txtWriter.Log(buildError, transaction, errorCount, newLineCount);
            }
            //define counters for info tracker to count each pass in the foreach function
            int countPassedUpdate = 0;
            int countInserCommand = 0;

            if (success)
            {
                ScrapModel scrapModel;
                foreach (string line in lines)
                {
                    scrapModel = new ScrapModel();
                    scrapModel.ParseScrap(line);
                    scrapModel.ID = sqlTransactions.SelectScrapID(scrapModel);
                    if (scrapModel.ID < 1)
                    {
                        try
                        {
                            sqlTransactions.InsertScrap(scrapModel);
                            newLineCount++;
                            countInserCommand++;
                        }
                        catch (Exception ee)
                        {

                            txtWriter.Log(ee.ToString(), scrapModel.MaterialNumber);

                        }
                    }
                    else
                    countPassedUpdate++;

                }
                string strgInfo = $"{transaction} started at {timeStart}: \n \tInserts:{countInserCommand}\n\tUpdates:NA\n\tNo Transaction: {countPassedUpdate}\n\n";

                txtWriter.writeInfo(strgInfo);
                //define streams and send to txtWriter.Log writer
                if (errorCount > 0)
                    txtWriter.Log(errors, transaction, errorCount, newLineCount);
            }
            success = true;
        }  

    }
}

