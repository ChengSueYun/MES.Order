using System.Configuration;
using MES.Order.Adapter.Implement;
using MES.Order.Adapter.Interface;

namespace MES.Order.Adapter
{
    public static class BasicUtility
    {

        public static string Conn { get; set; }

        private static IAreaInfoAdapter s_areaAdapter;

        public static IAreaInfoAdapter AreaInfoAdapter
        {
            get => s_areaAdapter ?? new AreaInfoAdapter();
            set => s_areaAdapter = value;
        }

        private static IProductsInfoAdapter s_productsInfoAdapter;

        public static IProductsInfoAdapter ProductsInfoAdapter
        {
            get => s_productsInfoAdapter ?? new ProductsInfoAdapter();
            set => s_productsInfoAdapter = value;
        }

        private static ICustomerInfoAdapter s_customerInfoAdapter;

        public static ICustomerInfoAdapter CustomerInfoAdapter
        {
            get => s_customerInfoAdapter ?? new CustomerInfoAdapter();
            set => s_customerInfoAdapter = value;
        }

        private static IFactoryInfoAdapter s_factoryInfoAdapter;
        private static IOrderInfoAdapter _orderInfoAdapter;

        public static IFactoryInfoAdapter FactoryInfoAdapter
        {
            get => s_factoryInfoAdapter ?? new FactoryInfoAdapter();
            set => s_factoryInfoAdapter = value;
        }

        public static IOrderInfoAdapter OrderInfoAdapter
        {
            get => _orderInfoAdapter ?? new OrderInfoAdapter();

            set => _orderInfoAdapter = value;
        }
    }
}