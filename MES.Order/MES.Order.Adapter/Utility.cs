using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Order.Adapter
{
    public static class Utility
    {
        private static IProductsInformationAdapter s_productsInformationAdapter;
        private static IProductGroupIDAdapter      s_productGroupIdAdapter;
        private static ICustomerAdapter            s_customerAdapter;
        private static IProductsOrderAdapter       s_orderAdapter;

        public static IProductsInformationAdapter productsInformationAdapter
        {
            get => s_productsInformationAdapter ?? new ProductInformationAdapter();
            set => s_productsInformationAdapter = value;
        }

        public static IProductGroupIDAdapter ProductGroupIdAdapter
        {
            get => s_productGroupIdAdapter ?? new ProductGroupIDAdapter();
            set => s_productGroupIdAdapter = value;
        }

        public static ICustomerAdapter CustomerAdapter
        {
            get => s_customerAdapter ?? new CustomerAdapter();
            set => s_customerAdapter = value;
        }

        public static IProductsOrderAdapter OrderAdapter
        {
            get => s_orderAdapter ?? new ProducstOrderAdapter();
            set => s_orderAdapter = value;
        }
    }
}