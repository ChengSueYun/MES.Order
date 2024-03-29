using System.Collections.Generic;
using System.Threading.Tasks;
using MES.Order.Adapter;
using MES.Order.DAL.ViewModel;
using MES.Order.Infrastructure;

namespace MES.Order.BLL
{
    public static class Extension
    {
        private static IProductsOrderAdapter       _IproductsOrderAdapter;
        private static IAreaAdapter                _IareaAdapter;
        private static IProductGroupIDAdapter      _iproductGroupIdAdapter;
        private static IProductsInformationAdapter _ipProductsInformationAdapter;
        private static ICustomerAdapter            _icustomerAdapter;

        internal static IProductsOrderAdapter IProductsOrderAdapter
        {
            get => _IproductsOrderAdapter ?? (_IproductsOrderAdapter = new ProducstOrderAdapter());
            set => _IproductsOrderAdapter = value;
        }

        internal static IAreaAdapter IareaAdapter
        {
            get => _IareaAdapter ?? (_IareaAdapter = new AreaAdapter());
            set => _IareaAdapter = value;
        }

        internal static IProductGroupIDAdapter IproductGroupIdAdapter
        {
            get => _iproductGroupIdAdapter ?? (_iproductGroupIdAdapter = new ProductGroupIDAdapter());
            set => _iproductGroupIdAdapter = value;
        }

        internal static IProductsInformationAdapter IpProductsInformationAdapter
        {
            get =>
                _ipProductsInformationAdapter ??
                (_ipProductsInformationAdapter = new ProductInformationAdapter());
            set => _ipProductsInformationAdapter = value;
        }

        internal static ICustomerAdapter IcustomerAdapter
        {
            get => _icustomerAdapter ?? (_icustomerAdapter = new CustomerAdapter());
            set => _icustomerAdapter = value;
        }

        /// <summary>
        /// 非同步取得地區別清單
        /// </summary>
        public static async Task GetAreaAsync()
        {
            Const.AreaList = new List<KeyAndName>();
            var areaAsync = IareaAdapter.GetAreaAsync();
            await areaAsync.ConfigureAwait(false);
            Const.AreaList.SetAllChoise();
        }

        /// <summary>
        /// 非同步取得客戶清單
        /// </summary>
        public static async Task GetCustomerAsync()
        {
            Const.CustomerNameList = new List<KeyAndName>();
            var customerAsync = IcustomerAdapter.DistinctCustomerAsync();
            await customerAsync.ConfigureAwait(false);
            Const.CustomerNameList.SetAllChoise();
        }

        /// <summary>
        /// 非同步取得廠商清單
        /// </summary>
        public static async Task GetProductGroupIdAsync()
        {
            Const.ProductGroupIDList = new List<KeyAndName>();
            var groupIdAsync = IproductGroupIdAdapter.GetProductGroupIdAsync();
            await groupIdAsync.ConfigureAwait(false);
            Const.ProductGroupIDList.SetAllChoise();
        }

        /// <summary>
        /// 非同步取得產品清單
        /// </summary>
        public static async Task GetProductAsync()
        {
            Const.ProductsList = new List<KeyAndName>();
            var productsAsync = IpProductsInformationAdapter.GetProductNameAsync();
            await productsAsync.ConfigureAwait(false);
            Const.ProductsList.SetAllChoise();
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