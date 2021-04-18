using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using ParseLibraryNet.Models;

using System.Data;

namespace ParseLibraryNet.DataTransactions
{
    public class sqlTransactions
    {
        private static string sapConnect = "Data Source=xxx";
        public static void InsertCTO(CTOModel ctoModel)
        {

            string procedure = "[dbo].[InsertCTO]";
            object values = new { @material = ctoModel.Material, @materialDescrition = ctoModel.MaterialDescription, @CatalogNumber = ctoModel.CatalogNumber };
            executeProcedure(procedure, values);

        }
        public static void InsertProdOrderHeader(ProdHeaderModel headerModel)
        {
            string procedure = "[dbo].[InsertProdOrderHeader]";
            object values = new
            {
                @LineType = headerModel.LineType,
                @Plant = headerModel.Plant,
                @OrderNumber = headerModel.OrderNumber,
                @MaterialNumber = headerModel.MaterialNumber,
                @MaterialDescription = headerModel.MaterialDescription,
                @RevisionLevel = headerModel.RevisionLevel,
                @MRPcontroller = headerModel.MRPcontroller,
                @ProductionScheduler = headerModel.ProductionScheduler,
                @PlannerGroup = headerModel.PlannerGroup,
                @OrderQuatity = headerModel.OrderQuatity,
                @BaseUnitMeasure = headerModel.BaseUnitMeasure,
                @OrderUnitMeasure = headerModel.OrderUnitMeasure,
                @ScrapQuantity = headerModel.ScrapQuantity,
                @ScrapPercent = headerModel.ScrapPercent,
                @ExpectedYieldVariance = headerModel.ExpectedYieldVariance,
                @BasicStartDate = headerModel.BasicStartDate,
                @BasicfinishDate = headerModel.BasicfinishDate,
                @ScheduledStartDate = headerModel.OriginalSchedStartDate,
                @ScheduledFinishDate = headerModel.OriginalSchedFinishDate,
                @ActualReleaseDate = headerModel.ActualReleaseDate,
                @SchdulingMarginKey = headerModel.SchdulingMarginKey,
                @FloatBeforeProduction = headerModel.FloatBeforeProduction,
                @FloatAfterProduction = headerModel.FloatAfterProduction,
                @ReleasedPeriod = headerModel.ReleasedPeriod,
                @BatchNumber = headerModel.BatchNumber,
                @GoodsReceipt = headerModel.GoodsReceipt,
                @StorageLocation = headerModel.StorageLocation,
                @salesOrderNumber = headerModel.SalesOrderNumber,
                @SalesOrderItem = headerModel.SalesOrderItem,
                @CreatedBy = headerModel.CreatedBy,
                @CreationDate = headerModel.CreationDate,
                @GRprocessingTime = headerModel.GRprocessingTime,
                @UnderDeliveryTolerence = headerModel.UnderDeliveryTolerence,
                @OverDeliveryTolerence = headerModel.OverDeliveryTolerence,
                @UnlimitedDelivery = headerModel.UnlimitedDelivery,
                @ProductionSchedulingProfile = headerModel.ProductionSchedulingProfile,
                @PutInStockQuantity = headerModel.PutInStockQuantity,
                @Priority = headerModel.Priority,
                @SchedulingType = headerModel.SchedulingType,
                @BasicFinishDate2 = headerModel.BasicFinishDate2,
                @BasicStartDate3 = headerModel.BasicStartDate3,
                @InterfaceAcknowledgeDate = headerModel.InterfaceAcknowledgeDate,
                @OriginalSchedFinishDate = headerModel.OriginalSchedFinishDate,
                @OriginalSchedStartDate = headerModel.OriginalSchedStartDate,
                @OriginalOrderQuantity = headerModel.OriginalOrderQuantity,
                @OriginalOrderScrapQuantity = headerModel.OriginalOrderScrapQuantity,
                @OrderStatus = headerModel.OrderStatus,
                @LoadQuantity = headerModel.LoadQuantity,
                @QuantityConfirmed = headerModel.QuantityConfirmed,
                @ProductionQuantity = headerModel.ProductionQuantity,
                @OrderText = headerModel.OrderText,
                @LastChangeDate = headerModel.LastChangeDate,
                @ProfitCenter = headerModel.ProfitCenter,
                @MaterialProfitCenter = headerModel.MaterialProfitCenter
            };    
            executeProcedure(procedure, values);
        }
        public static void InsertProdOrderMaterial(ProdMaterialModel materialModel)
        {
            string procedure = "[dbo].[InsertProdOrderMaterial]";
            object values = new
            {
                @OrderNumber = materialModel.OrderNumber,
                @ItemNumber = materialModel.ItemNumber,
                @ComponentNumber = materialModel.ComponentNumber,
                @ComponentDescription = materialModel.ComponentDescription,
                @ItemCategory = materialModel.ItemCategory,
                @BatchNumber = materialModel.BatchNumber,
                @BulkMaterialIndicator = materialModel.BulkMaterialIndicator,
                @BackflushIndicator = materialModel.BackFlushIndicator,
                @AllocatedOperationNumber = materialModel.Allocated,
                @CoProductIndicator = materialModel.CoproductIndicator,
                @PhantomIndicator = materialModel.PhantomIndicator,
                @QtyWithdrawn = materialModel.QtyWithdrawn,
                @RequirementDate = materialModel.RequirementDate,
                @ReservationNumber = materialModel.ReservationNumber,
                @ReservationItem = materialModel.ReservationItem,
                @FixedQtyIndicator = materialModel.FixedQtyIndicator,
                @ComponentScrap = materialModel.ComponentScrap,
                @OperationScrapPercent = materialModel.OperationScrapPercent,
                @RevisionLevel = materialModel.RevisionLevel

            };
            executeProcedure(procedure, values);
        }

        //public static bool SelectMatersomething(MaterialModel materialModel)
        //{
        //    throw new NotImplementedException();
        //}

        //public static void UpdateMaterial(MaterialModel materialModel)
        //{
        //    throw new NotImplementedException();
        //}

        public static void InsertMaterial(MaterialModel materialModel)
        {

            string procedure = "[dbo].[InsertMaterial]";
            object values = new
            {
                @MaterialNumber = materialModel.MaterialNumber,
                @CreationDate = materialModel.CreationDate,
                @MaterialType = materialModel.MaterialType,
                @MaterialDescription = materialModel.MaterialDescription,
                @BaseUoM = materialModel.BaseUoM,
                @MaterialGrooup = materialModel.MaterialGrooup,
                @ProductionHierarchy = materialModel.ProductionHierarchy,
                @CrossPlant = materialModel.CrossPlant,
                @BatchManage = materialModel.BatchManage,
                @AuthorizationGroup = materialModel.AuthorizationGroup,
                @NetWeight = materialModel.NetWeight,
                @GrossWeight = materialModel.GrossWeight,
                @WeightUoM = materialModel.WeightUoM,
                @CompetencyBusinessCode = materialModel.CompetencyBusinessCode,
                @ProductLine = materialModel.ProductLine,
                @RevisionLevel = materialModel.RevisionLevel,
                @CatalogNumber = materialModel.CatalogNumber,
                @ProductBrandName = materialModel.ProductBrandName,
                @EngineeringPartNumber = materialModel.EngineeringPartNumber,
                @AcquisitionFormat = materialModel.AcquisitionFormat,
                @DateLastChange = materialModel.DateLastChange,
            };
                executeProcedure(procedure, values);
        }
        public static void InsertProdOrderRout(ProdRouteModel routeModel)
        {
            string procedure = "[dbo].[InsertProdOrderRout]";
            var p = new DynamicParameters();

          //  p.Add("@id", routeModel.ID);
            p.Add("@OrderNumber", routeModel.OrderNumber);
            p.Add("@Sequence", routeModel.Sequence);
            p.Add("@OperationNumber", routeModel.OperationNumber);
            p.Add("@WorkCenterNumber", routeModel.WorkCenterNumber);
            p.Add("@BaseQty", routeModel.BaseQty);
            p.Add("@StdValue1", routeModel.StdValue1);
            p.Add("@StdValueUOM1", routeModel.StdValueUOM1);
            p.Add("@StdValue2", routeModel.StdValue2);
            p.Add("@StdValueUOM2", routeModel.StdValueUOM2);
            p.Add("@StdValue3", routeModel.StdValue3);
            p.Add("@StdValueUOM3", routeModel.StdValueUOM3);
            p.Add("@StdValue4", routeModel.StdValue4);
            p.Add("@StdValueUOM4", routeModel.StdValueUOM4);
            p.Add("@StdValue5", routeModel.StdValue5);
            p.Add("@StdValueUOM5", routeModel.StdValueUOM5);
            p.Add("@StdValue6", routeModel.StdValue6);
            p.Add("@StdValueUOM6", routeModel.StdValueUOM6);
            p.Add("@StdValue7", routeModel.StdValue7);
            p.Add("@StdValueUOM7", routeModel.StdValueUOM7);
            p.Add("@ScheduledStartDate", routeModel.ScheduledStartDate);
            p.Add("@ScheduledEndDate", routeModel.ScheduledEndDate);
            p.Add("@OperationQty", routeModel.OperationQty);
            p.Add("@OperationUOM", routeModel.OperationUOM);
            p.Add("@ConfirmedQty", routeModel.ConfirmedQty);
            p.Add("@ConfirmedScrap", routeModel.ConfirmedScrap);
            p.Add("@ReworkQty", routeModel.ReworkQty);
            p.Add("@OperationLongText1", routeModel.OperationLongTextLine1);
            p.Add("@OperationLongText2 ", routeModel.OperationLongTextLine2);
            p.Add("@OperationLongText3 ", routeModel.OperationLongTextLine3);
            p.Add("@OperationLongText4", routeModel.OperationLongTextLine4);
            p.Add("@OperationLongText5", routeModel.OperationLongTextLine5);
            p.Add("@OperationSystemStatus", routeModel.Operationsystemstatus);

            using (IDbConnection connection = new SqlConnection(sapConnect))
            {
                try
                {
                    connection.Query(procedure, p, commandType: CommandType.StoredProcedure);
                }
                catch (Exception e)
                {
                    txtWriter.writeInfo($"{routeModel.ConfirmedQty}-{routeModel.ConfirmedScrap}, {e}");
                    throw;
                }
            }
        }
        public static void InsertSalesOrder(SalesOrderModel salesOrder)
        {
            string procedure = "[dbo].[InsertSalesOrder]";
            object values = new
            {
                @SalesOrder = salesOrder.SalesOrder,
                @LineItem = salesOrder.SalesOrderItem,
                @MaterialNumber = salesOrder.MaterialNumber,
                @MaterialDescription = salesOrder.MaterialDescription,
                @CustomerMateria = salesOrder.CustomerMaterialNmb,
                @Quantity = salesOrder.Quantity,
                @PlannedShipDate = salesOrder.PlannedShipDate,
                @MaterialAvailabilityDate = salesOrder.AvailabilityDate,
                @SoldToParty = salesOrder.SoldTo,
                @SoldToName = salesOrder.SoldToName,
                @ShipTo = salesOrder.ShipTo,
                @ShipToName = salesOrder.ShipToName,
                @MRPController = salesOrder.MRPController

            };
            executeProcedure(procedure, values);
        }
        public static void InsertScrap(ScrapModel scrapModel)
        {
            string procedure = "[dbo].[InsertScrap]";
            object values = new
            {
                @WorkCenter = scrapModel.WorkCenter,
                @OperationActivityNumber = scrapModel.OperationActivityNumber,
                @Scrapcode = scrapModel.Scrapcode,
                @ScrapDescription = scrapModel.ScrapDescription,
                @OprnGoodsQty = scrapModel.OprnGoodsQty,
                @OprnScrapqty = scrapModel.OprnScrapqty,
                @uom = scrapModel.UOM,
                @DatePosted = scrapModel.DatePosted,
                @PostedBy = scrapModel.PostedBy,
                @DateEntered = scrapModel.DateEntered,
                @ProdOrderNumb = scrapModel.ProdOrderNumb,
                @MaterialNumber = scrapModel.MaterialNumber,
                @MaterialDescription = scrapModel.MaterialDescription,
                @QtyInOrderUnit = scrapModel.QtyInOrderUnit,
                @ScrapinOrderUnit = scrapModel.ScrapinOrderUnit,
                @OrderUnit = scrapModel.OrderUnit,
                @stdcost = scrapModel.StdCost,
                @valuatedstock = scrapModel.Valuatedstock,
                @OperScrapCost = scrapModel.OperScrapCost,
                @Totoperscrapcost = scrapModel.Totoperscrapcost,
                @Prodhierarchy = scrapModel.Prodhierarchy,
                @MRPcontroller = scrapModel.MRPcontroller,
                @OrderType = scrapModel.OrderType,
                @ControlKey = scrapModel.ControlKey,
                @ProductLine = scrapModel.ProductLine,
                @plant = scrapModel.Plant,
                @ConfirmationNumber = scrapModel.ConfirmationNumber,
                @ConfirmationCounter = scrapModel.ConfirmationCounter,
                @ActualOperator = scrapModel.ActualOperator,
                @Productionscheduler = scrapModel.Productionscheduler,
                @YieldtoBeConfirmed = scrapModel.YieldtoBeConfirmed,
                @ScraptoBeConfirmed = scrapModel.ScraptoBeConfirmed
            };
            executeProcedure(procedure, values);
        }
        public static int SelectCTOID(CTOModel ctoModel)
        {
            string procedure = "[dbo].[SelectCTOid]";
            var p = new DynamicParameters();
            p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            p.Add("@material", ctoModel.Material);
            int i;
            using (IDbConnection connection = new SqlConnection(sapConnect))
            {
                try
                {
                    var retrun = connection.Query(procedure, p, commandType: CommandType.StoredProcedure);
                    i = p.Get<int>("@id");
                }
                catch (Exception e)
                {
                    txtWriter.writeInfo($"{ctoModel.Material}, {e}");
                    throw;
                }
            }
            return i;
        }
        public static int SelectMaterialID(MaterialModel material)
        {
            string procedure = "[dbo].[SelectMaterialID]";
            var p = new DynamicParameters();
            p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            p.Add("@material", material.MaterialNumber);
            int i;
            using (IDbConnection connection = new SqlConnection(sapConnect))
            {
                try
                {
                    var retrun = connection.Query(procedure, p, commandType: CommandType.StoredProcedure);
                    i = p.Get<int>("@id");
                }
                catch (Exception e)
                {
                    txtWriter.writeInfo($"{material.MaterialNumber}, {e}");
                    throw;
                }
            }
            return i;
        }
        public static int SelectProdHeaderID(ProdHeaderModel headerModel)
        { 
            string procedure = "[dbo].[SelectProdHeaderID]";
            var p = new DynamicParameters();

            p.Add("@OrderNumber", headerModel.OrderNumber);
            p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            int i;
            using (IDbConnection connection = new SqlConnection(sapConnect))
            {      
                try
                {
                   var retrun = connection.Query(procedure, p, commandType: CommandType.StoredProcedure);
                   i = p.Get<int>("@id");
                }
                catch (Exception e)
                {
                    txtWriter.writeInfo($"{headerModel.OrderNumber}, {e}");
                    throw;
                }              
            }
            return i;
        }
        public static bool SelectProdHeaderChangeDate(ProdHeaderModel headerModel)
        {
            string procedure = "[dbo].[SelectProdOrderHeadLastChangeDate]";
            var p = new DynamicParameters();

            p.Add("@id", headerModel.ID);
            p.Add("@LastChangeDate", dbType: DbType.Date, direction: ParameterDirection.Output);
            DateTime d;
            using (IDbConnection connection = new SqlConnection(sapConnect))
            {
                try
                {
                    var retrun = connection.Query(procedure, p, commandType: CommandType.StoredProcedure);
                    d = p.Get<DateTime>("@LastChangeDate");
                  //  d = DateTime.Parse(i.ToString());
                }
                catch (Exception )
                {
                    throw;
                }
            }
            if (d.Date == headerModel.LastChangeDate.Date)
                return true;
            else
                return false;
        }
        public static int SelectProdMaterialID(ProdMaterialModel materialModel)
        {
            string procedure = "[dbo].[SelectProdMaterialID]";
            var p = new DynamicParameters();
            p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            p.Add("@ReservationNumber", materialModel.ReservationNumber);
            p.Add("@ReservationItem", materialModel.ReservationItem);
            int i;
            using (IDbConnection connection = new SqlConnection(sapConnect))
            {
                try
                {
                    var retrun = connection.Query(procedure, p, commandType: CommandType.StoredProcedure);
                    i = p.Get<int>("@id");
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return i;
        }
        public static bool SelectProdMaterialWithdrawn(ProdMaterialModel prodMaterialModel)
        {
            string procedure = "[dbo].[SelectProdMaterialQty]";
            var p = new DynamicParameters();

            p.Add("@id", prodMaterialModel.ID);
            p.Add("@QtyWithdrawn", dbType: DbType.Decimal, direction: ParameterDirection.Output);
            decimal     q;
 
            using (IDbConnection connection = new SqlConnection(sapConnect))
            {
                try
                {
                    var retrun = connection.Query(procedure, p, commandType: CommandType.StoredProcedure);
                    q = p.Get<decimal>("@QtyWithdrawn");

                }
                catch (Exception)
                {
                    throw;
                }
            }
            if (q == prodMaterialModel.QtyWithdrawn)
                return true;
            else
                return false;
        }
        public static int SelectProdRoutID(ProdRouteModel routeModel)
        {
            string procedure = "[dbo].[SelectProdRouteID]";
            var p = new DynamicParameters();
            p.Add("@OrderNumber", routeModel.OrderNumber);
            p.Add("@OperationNumber", routeModel.OperationNumber);
            p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            int i;
            using (IDbConnection connection = new SqlConnection(sapConnect))
            {
                try
                {
                    var retrun = connection.Query(procedure, p, commandType: CommandType.StoredProcedure);
                    i = p.Get<int>("@id");
                }
                catch (Exception e)
                {
                    txtWriter.writeInfo($"{routeModel.OrderNumber}, {e}");
                    throw;
                }
            }
                return i;
        }
        public static bool SelectProdRouteQty(ProdRouteModel routeModel)
        {
            string procedure = "[dbo].[SelectProdOrderRouteQty]";
            var p = new DynamicParameters();

            p.Add("@id", routeModel.ID);
            p.Add("@ConfirmedQty", dbType: DbType.Decimal, direction: ParameterDirection.Output);
            p.Add("@ConfirmedScrap", dbType: DbType.Decimal, direction: ParameterDirection.Output);

            decimal good;
            decimal scrap;
            using (IDbConnection connection = new SqlConnection(sapConnect))
            {
                try
                {
                    var retrun = connection.Query(procedure, p, commandType: CommandType.StoredProcedure);
                    good = p.Get<decimal>("@ConfirmedQty");
                    scrap = p.Get<decimal>("@ConfirmedScrap");
                }
                catch (Exception)
                {
                    throw;
                }
            }
            if (good == routeModel.ConfirmedQty && scrap == routeModel.ConfirmedScrap)
                return true;
            else
                return false;
        }
        public static int SelectSalesOrderID(SalesOrderModel salesOrderModel)
        {
            string procedure = "[dbo].[SelectSalesOrderID]";
            var p = new DynamicParameters();
            p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            p.Add("@SalesOrder", salesOrderModel.SalesOrder);
            p.Add("@LineItem", salesOrderModel.SalesOrderItem);
            int i;
            using (IDbConnection connection = new SqlConnection(sapConnect))
            {
                try
                {
                    var retrun = connection.Query(procedure, p, commandType: CommandType.StoredProcedure);
                    i = p.Get<int>("@id");
                }
                catch (Exception e)
                {
                    txtWriter.writeInfo($"{salesOrderModel.SalesOrder}, {e}");
                    throw;
                }
            }
            return i;
        }
        public static int SelectScrapID(ScrapModel scrapModel)
        {
            string procedure = "[dbo].[SelectScrapID]";
            var p = new DynamicParameters();
            p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            p.Add("@ConfirmationNumber", scrapModel.ConfirmationNumber);
            p.Add("@ConfirmationCounter", scrapModel.ConfirmationCounter);

            int i;
            using (IDbConnection connection = new SqlConnection(sapConnect))
            {
                try
                {
                    var retrun = connection.Query(procedure, p, commandType: CommandType.StoredProcedure);
                    i = p.Get<int>("@id");
                }
                catch (Exception e)
                {
                    txtWriter.writeInfo($"{scrapModel.ConfirmationNumber}, {e}");
                    throw;
                }
            }
            return i;
        }
        private static void executeProcedure(string procedure, object values)
        {
            using (var connection = new SqlConnection(sapConnect))
            {
                // var returned = connection.Query(procedure, values, commandType: System.Data.CommandType.StoredProcedure);
                try
                {
                    connection.Query(procedure, values, commandType: System.Data.CommandType.StoredProcedure);
                    //returned.ToString();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public static void UpdateProdOrderHeader(ProdHeaderModel headerModel)
        {
            string procedure = "[dbo].[UpdateProdOrderHeader]";
            object values = new
            {
                @id = headerModel.ID,
                @LineType = headerModel.LineType,
                @Plant = headerModel.Plant,
                @OrderNumber = headerModel.OrderNumber,
                @MaterialNumber = headerModel.MaterialNumber,
                @MaterialDescription = headerModel.MaterialDescription,
                @RevisionLevel = headerModel.RevisionLevel,
                @MRPcontroller = headerModel.MRPcontroller,
                @ProductionScheduler = headerModel.ProductionScheduler,
                @PlannerGroup = headerModel.PlannerGroup,
                @OrderQuatity = headerModel.OrderQuatity,
                @BaseUnitMeasure = headerModel.BaseUnitMeasure,
                @OrderUnitMeasure = headerModel.OrderUnitMeasure,
                @ScrapQuantity = headerModel.ScrapQuantity,
                @ScrapPercent = headerModel.ScrapPercent,
                @ExpectedYieldVariance = headerModel.ExpectedYieldVariance,
                @BasicStartDate = headerModel.BasicStartDate,
                @BasicfinishDate = headerModel.BasicfinishDate,
                @ScheduledStartDate = headerModel.OriginalSchedStartDate,
                @ScheduledFinishDate = headerModel.OriginalSchedFinishDate,
                @ActualReleaseDate = headerModel.ActualReleaseDate,
                @SchdulingMarginKey = headerModel.SchdulingMarginKey,
                @FloatBeforeProduction = headerModel.FloatBeforeProduction,
                @FloatAfterProduction = headerModel.FloatAfterProduction,
                @ReleasedPeriod = headerModel.ReleasedPeriod,
                @BatchNumber = headerModel.BatchNumber,
                @GoodsReceipt = headerModel.GoodsReceipt,
                @StorageLocation = headerModel.StorageLocation,
                @salesOrderNumber = headerModel.SalesOrderNumber,
                @SalesOrderItem = headerModel.SalesOrderItem,
                @CreatedBy = headerModel.CreatedBy,
                @CreationDate = headerModel.CreationDate,
                @GRprocessingTime = headerModel.GRprocessingTime,
                @UnderDeliveryTolerence = headerModel.UnderDeliveryTolerence,
                @OverDeliveryTolerence = headerModel.OverDeliveryTolerence,
                @UnlimitedDelivery = headerModel.UnlimitedDelivery,
                @ProductionSchedulingProfile = headerModel.ProductionSchedulingProfile,
                @PutInStockQuantity = headerModel.PutInStockQuantity,
                @Priority = headerModel.Priority,
                @SchedulingType = headerModel.SchedulingType,
                @BasicFinishDate2 = headerModel.BasicFinishDate2,
                @BasicStartDate3 = headerModel.BasicStartDate3,
                @InterfaceAcknowledgeDate = headerModel.InterfaceAcknowledgeDate,
                @OriginalSchedFinishDate = headerModel.OriginalSchedFinishDate,
                @OriginalSchedStartDate = headerModel.OriginalSchedStartDate,
                @OriginalOrderQuantity = headerModel.OriginalOrderQuantity,
                @OriginalOrderScrapQuantity = headerModel.OriginalOrderScrapQuantity,
                @OrderStatus = headerModel.OrderStatus,
                @LoadQuantity = headerModel.LoadQuantity,
                @QuantityConfirmed = headerModel.QuantityConfirmed,
                @ProductionQuantity = headerModel.ProductionQuantity,
                @OrderText = headerModel.OrderText,
                @LastChangeDate = headerModel.LastChangeDate,
                @ProfitCenter = headerModel.ProfitCenter,
                @MaterialProfitCenter = headerModel.MaterialProfitCenter
            };
            executeProcedure(procedure, values);
        }
        public static void UpdateProdOrderMaterial(ProdMaterialModel materialModel)
        {
            string procedure = "[dbo].[UpdateProdOrderMaterial]";
            object values = new
            {
                @OrderNumber = materialModel.OrderNumber,
                @ItemNumber = materialModel.ItemNumber,
                @ComponentNumber = materialModel.ComponentNumber,
                @ComponentDescription = materialModel.ComponentDescription,
                @ItemCategory = materialModel.ItemCategory,
                @BatchNumber = materialModel.BatchNumber,
                @BulkMaterialIndicator = materialModel.BulkMaterialIndicator,
                @BackflushIndicator = materialModel.BackFlushIndicator,
                @AllocatedOperationNumber = materialModel.Allocated,
                @CoProductIndicator = materialModel.CoproductIndicator,
                @PhantomIndicator = materialModel.PhantomIndicator,
                @QtyWithdrawn = materialModel.QtyWithdrawn,
                @RequirementDate = materialModel.RequirementDate,
                @ReservationNumber = materialModel.ReservationNumber,
                @ReservationItem = materialModel.ReservationItem,
                @FixedQtyIndicator = materialModel.FixedQtyIndicator,
                @ComponentScrap = materialModel.ComponentScrap,
                @OperationScrapPercent = materialModel.OperationScrapPercent,
                @RevisionLevel = materialModel.RevisionLevel

            };
            executeProcedure(procedure, values);
        }
        public static void UpdateProdOrderRoute(ProdRouteModel routeModel)
        {
            string procedure = "[dbo].[UpdateProdOrderRout]";
            var p = new DynamicParameters();

            p.Add("@id", routeModel.ID);
            p.Add("@OrderNumber", routeModel.OrderNumber);
            p.Add("@Sequence", routeModel.Sequence);
            p.Add("@OperationNumber", routeModel.OperationNumber);
            p.Add("@WorkCenterNumber", routeModel.WorkCenterNumber);
            p.Add("@BaseQty", routeModel.BaseQty);
            p.Add("@StdValue1", routeModel.StdValue1);
            p.Add("@StdValueUOM1", routeModel.StdValueUOM1);
            p.Add("@StdValue2", routeModel.StdValue2);
            p.Add("@StdValueUOM2", routeModel.StdValueUOM2);
            p.Add("@StdValue3", routeModel.StdValue3);
            p.Add("@StdValueUOM3", routeModel.StdValueUOM3);
            p.Add("@StdValue4", routeModel.StdValue4);
            p.Add("@StdValueUOM4", routeModel.StdValueUOM4);
            p.Add("@StdValue5", routeModel.StdValue5);
            p.Add("@StdValueUOM5", routeModel.StdValueUOM5);
            p.Add("@StdValue6", routeModel.StdValue6);
            p.Add("@StdValueUOM6", routeModel.StdValueUOM6);
            p.Add("@StdValue7", routeModel.StdValue7);
            p.Add("@StdValueUOM7", routeModel.StdValueUOM7);
            p.Add("@ScheduledStartDate", routeModel.ScheduledStartDate);
            p.Add("@ScheduledEndDate", routeModel.ScheduledEndDate);
            p.Add("@OperationQty", routeModel.OperationQty);
            p.Add("@OperationUOM", routeModel.OperationUOM);
            p.Add("@ConfirmedQty", routeModel.ConfirmedQty);
            p.Add("@ConfirmedScrap", routeModel.ConfirmedScrap);
            p.Add("@ReworkQty", routeModel.ReworkQty);
            p.Add("@OperationLongText1", routeModel.OperationLongTextLine1);
            p.Add("@OperationLongText2 ", routeModel.OperationLongTextLine2);
            p.Add("@OperationLongText3 ", routeModel.OperationLongTextLine3);
            p.Add("@OperationLongText4", routeModel.OperationLongTextLine4);
            p.Add("@OperationLongText5", routeModel.OperationLongTextLine5);
            p.Add("@OperationSystemStatus", routeModel.Operationsystemstatus);
            
            using (IDbConnection connection = new SqlConnection(sapConnect))
            {

                try
                {
                    connection.Query(procedure, p, commandType: CommandType.StoredProcedure);
                }
                catch (Exception e)
                {
                      txtWriter.writeInfo($"{routeModel.ConfirmedQty}-{routeModel.ConfirmedScrap}, {e}");
                    throw;
                }

            }
        }
        public static void UpdateScrap(ScrapModel scrapModel)
        {
            string procedure = "[dbo].[UpdateScrap]";
            var p = new DynamicParameters();

            p.Add("@DatePosted",scrapModel.DatePosted);
            p.Add("@ScrapinOrderUnit", scrapModel.ScrapinOrderUnit);
            p.Add("@OrderUnit", scrapModel.OrderUnit);
            p.Add(" @stdcost", scrapModel.StdCost);
            p.Add("   @valuatedstock", scrapModel.Valuatedstock);
            p.Add("@OperScrapCost", scrapModel.OperScrapCost);
            p.Add("@Totoperscrapcost", scrapModel.Totoperscrapcost);
            p.Add("@YieldtoBeConfirmed", scrapModel.YieldtoBeConfirmed);
            p.Add(" @ScraptoBeConfirmed", scrapModel.ScraptoBeConfirmed);
          
            using (IDbConnection connection = new SqlConnection(sapConnect))
            {
              
                try
                {
                    connection.Query(procedure, p, commandType: CommandType.StoredProcedure);
                }
                catch (Exception e)
                {
                  txtWriter.writeInfo($"{scrapModel.ConfirmationNumber}-{scrapModel.ConfirmationNumber}, {e}");
                    throw;
                }

            }
            
        }

    }
}
