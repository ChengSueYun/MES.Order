using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using MES.Order.Adapter;
using MES.Order.BLL.Mapper;
using MES.Order.DAL.EntityFramework;
using MES.Order.Infrastructure.NewViewModel;

namespace MES.Order.BLL
{
    public static class TransferDataUCO
    {
        private static List<Areas>              oldArea;
        static         List<Custom>             oldCustomer;
        static         List<ProductsGroupID>    oldFactory;
        static         List<ProductsInfomation> oldProducts;
        static         List<ProductsOrder>      oldOrder;

        public static void StartTransfer()
        {
            try
            {
                GetOldDbData();
                OldMapToNew();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        private static void GetOldDbData()
        {
            oldArea     = BasicOldUtlity.AreaAdapter.QueryAll();
            oldCustomer = BasicOldUtlity.CustomerAdapter.QueryAll();
            oldFactory  = BasicOldUtlity.ProductGroupIdAdapter.QueryAll();
            oldProducts = BasicOldUtlity.ProductsInformationAdapter.QueryAllProducts("*ALL", "*ALL");
            oldOrder    = BasicOldUtlity.IProductsOrderAdapter.QueryAll();
        }

        private static void OldMapToNew()
        {
            List<AreaInfoViewModel> areaInfoViewModel =
                oldArea.Select(areas => new AreaInfoViewModel() { Area = areas.AreaName }).ToList();
            var result1 = BasicUtility.AreaInfoAdapter.AddOrUpdateAsync(areaInfoViewModel).Result;
            List<CustomInfoViewModel> customInfoViewModel = oldCustomer.GroupBy(x => new { x.Address, x.CustomName }
                                                                                  , (arg1, customs) =>
                                                                                            new CustomInfoViewModel
                                                                                            {
                                                                                                Area = arg1.Address
                                                                                              , Customer =
                                                                                                    arg1.CustomName
                                                                                              , FaceBookId   = ""
                                                                                              , FaceBookLink = ""
                                                                                              , Remark       = ""
                                                                                              , CreateDate =
                                                                                                    DateTime.Today
                                                                                              , CreateUser = "Transfer"
                                                                                              , UpdateDate =
                                                                                                    DateTime.Today
                                                                                              , UpdateUser = ""
                                                                                            }).ToList();
            
            // var b = BasicUtility.CustomerInfoAdapter.AddOrUpdate(customInfoViewModel).Result;
            List<FactoryInfoViewModel> factoryInfoViewModel = oldFactory.Select(x => new FactoryInfoViewModel
                                                                                            {
                                                                                                Factory = x
                                                                                                    .ProductGroupName
                                                                                              , FactoryWebSit = ""
                                                                                            }).ToList();
            // var result = BasicUtility.FactoryInfoAdapter.AddOrUpdate(factoryInfoViewModel).Result;

            List<ProductsInfoViewModel> productsInfoViewModel = oldProducts.GroupBy(
                 x => new { x.ProductGroupID, x.ProductName }
               , ((arg1, enumerable) => new ProductsInfoViewModel
                                        {
                                            Factory     = arg1.ProductGroupID
                                          , Product     = enumerable.FirstOrDefault().ProductName
                                          , ProductType = "",
                                            Price = enumerable.FirstOrDefault().Price
                                          , Cost        = enumerable.FirstOrDefault().Cost
                                          , Profit      = enumerable.FirstOrDefault().Profit
                                          , Image       = "", ProductWebSite = ""
                                        })).ToList();
            var b1 = BasicUtility.ProductsInfoAdapter.AddOrUpdate(productsInfoViewModel).Result;
            List<OrderInfoViewModel> orderInfoViewModel = oldOrder.GroupBy(
                                                                           x => new
                                                                               {
                                                                                   x.Area, x.CustomName
                                                                                 , x.ProductGroupID, x.ProductName
                                                                                 , x.OrderDate
                                                                               }, ((arg1, enumerable) =>
                                                                                           new OrderInfoViewModel
                                                                                           {
                                                                                               Area = arg1.Area
                                                                                             , Customer =
                                                                                                   arg1.CustomName
                                                                                             , Factory = arg1
                                                                                                   .ProductGroupID
                                                                                             , Product = arg1
                                                                                                   .ProductName
                                                                                             , OrderDate =
                                                                                                   arg1.OrderDate
                                                                                             , Count = enumerable
                                                                                                   .FirstOrDefault()
                                                                                                   .Count
                                                                                             , TotalPrice = enumerable
                                                                                                   .FirstOrDefault()
                                                                                                   .TotalPrice
                                                                                             , TotalCost = enumerable
                                                                                                   .FirstOrDefault()
                                                                                                   .TotalCost
                                                                                             , TotalProfit = enumerable
                                                                                                   .FirstOrDefault()
                                                                                                   .TotalProfit
                                                                                             , ColorSpec = ""
                                                                                             , SizSpec   = ""
                                                                                             , Remark = enumerable
                                                                                                   .FirstOrDefault()
                                                                                                   .Note1
                                                                                             , Status = enumerable
                                                                                                   .FirstOrDefault()
                                                                                                   .Address
                                                                                             , UpdateDate =
                                                                                                   DateTime.Today
                                                                                           })).ToList();
            var result2 = BasicUtility.OrderInfoAdapter.AddOrUpdate(orderInfoViewModel).Result;
        }
    }
}