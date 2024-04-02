using MES.Order.Adapter;
using MES.Order.Adapter.Interface;
using MES.Order.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MES.Order.Infrastructure.NewViewModel;

namespace MES.Order.BLL
{
    public static class NewExtension
    {
        /// <summary>
        /// 非同步取得地區別清單
        /// </summary>
        public static void GetAreaAsync()
        {
            Const.AllAreaView = new List<AreaInfoViewModel>(BasicUtility.AreaInfoAdapter.GetAsync().Result);
            Const.AreaInfoList = new List<KeyAndName>(Const.AllAreaView
                                                           .Select(x => new KeyAndName()
                                                                        { Code = x.Area, LocalDescription = x.Area })
                                                           .Distinct().ToList());
        }

        /// <summary>
        /// 非同步取得客戶清單
        /// </summary>
        public static void GetCustomerAsync()
        {
            Const.AllCustomerView = new List<CustomInfoViewModel>(BasicUtility.CustomerInfoAdapter.GetAll().Result.OrderByDescending(x=>x.CreateDate));
            Const.CustomerNameInfoList = new List<KeyAndName>(Const.AllCustomerView
                                                                   .Select(x => new KeyAndName()
                                                                               {
                                                                                   Code             = x.Customer
                                                                                 , LocalDescription = x.Area
                                                                               })
                                                                   .Distinct().ToList());

          
        }

        /// <summary>
        /// 非同步取得廠商清單
        /// </summary>
        public static void GetFactoryIdAsync()
        {
            Const.AllFactoryView = new List<FactoryInfoViewModel>(BasicUtility.FactoryInfoAdapter.Get().Result);
            Const.FactoryInfoList = new List<KeyAndName>(Const.AllFactoryView
                                                              .Select(x => new KeyAndName()
                                                                           {
                                                                               Code             = x.Factory
                                                                             , LocalDescription = x.Factory
                                                                           })
                                                              .Distinct().ToList());
         
        }

        /// <summary>
        /// 非同步取得產品清單
        /// </summary>
        public static void GetProductAsync()
        {
            // Const.ProductsNameInfoList = new List<KeyAndName>();
            // var productsAsync = BasicUtility.ProductsInfoAdapter.GetProductNameAsync().Result;
            // Const.ProductsNameInfoList.AddRange(productsAsync);
        }

        /// <summary>
        /// 非同步取得產品類別清單
        /// </summary>
        public static void GetProductTypeAsync()
        {
            // Const.ProductsTypeList = new List<KeyAndName>();
            // var productsAsync = BasicUtility.ProductsInfoAdapter.GetProductTypeAsync().Result;
            // Const.ProductsTypeList.AddRange(productsAsync);

            // Const.ProductsTypeList.SetAllChoise();
        }

        /// <summary>
        /// 非同步取得產品資料表
        /// </summary>
        public static void GetAllProductAsync()
        {
            Const.AllProductsView = new List<ProductsInfoViewModel>();
            var productsAsync = BasicUtility.ProductsInfoAdapter.Get().Result;
            Const.AllProductsView.AddRange(productsAsync);

            Const.ProductsNameInfoList = new List<KeyAndName>();
            Const.ProductsNameInfoList = Const.AllProductsView.Select(a => new KeyAndName()
                                                                           {
                                                                               Code             = a.Product
                                                                             , LocalDescription = a.Factory
                                                                           }).Distinct().ToList();

            Const.ProductsTypeList = new List<KeyAndName>();
            Const.ProductsTypeList = Const.AllProductsView.Select(a => new KeyAndName()
                                                                       {
                                                                           Code             = a.Product
                                                                         , LocalDescription = a.ProductType
                                                                       }).Distinct().ToList();
        }

        private static void SetAllChoise(this List<KeyAndName> keyAndNames)
        {
            keyAndNames.Insert(0, new KeyAndName()
                                  {
                                      Code = "全部", LocalDescription = "全部"
                                  });
        }
    }
}