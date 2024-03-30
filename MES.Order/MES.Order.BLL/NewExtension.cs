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
            Const.AreaInfoList = new List<KeyAndName>();
            var areaAsync = BasicUtility.AreaInfoAdapter.GetAreaAsync().Result;
            Const.AreaInfoList.AddRange(areaAsync);

            // Const.AreaInfoList.SetAllChoise();
        }

        /// <summary>
        /// 非同步取得客戶清單
        /// </summary>
        public static void GetCustomerAsync()
        {
            Const.CustomerNameInfoList = new List<KeyAndName>();
            var customerAsync = BasicUtility.CustomerInfoAdapter.DistinctCustomerAsync().Result;
            Const.CustomerNameInfoList.AddRange(customerAsync);

            // Const.CustomerNameInfoList.SetAllChoise();
        }

        /// <summary>
        /// 非同步取得廠商清單
        /// </summary>
        public static void GetFactoryIdAsync()
        {
            Const.FactoryInfoList = new List<KeyAndName>();
            var groupIdAsync = BasicUtility.FactoryInfoAdapter.GetFactoryIdAsync().Result;
            Const.FactoryInfoList.AddRange(groupIdAsync);

            // Const.FactoryInfoList.SetAllChoise();
        }

        /// <summary>
        /// 非同步取得產品清單
        /// </summary>
        public static void GetProductAsync()
        {
            Const.ProductsNameInfoList = new List<KeyAndName>();
            var productsAsync = BasicUtility.ProductsInfoAdapter.GetProductNameAsync().Result;
            Const.ProductsNameInfoList.AddRange(productsAsync);
        }

        /// <summary>
        /// 非同步取得產品類別清單
        /// </summary>
        public static void GetProductTypeAsync()
        {
            Const.ProductsTypeList = new List<KeyAndName>();
            var productsAsync = BasicUtility.ProductsInfoAdapter.GetProductTypeAsync().Result;
            Const.ProductsTypeList.AddRange(productsAsync);

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