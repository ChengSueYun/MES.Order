namespace MES.Order.Adapter
{
    public static class BasicOldUtlity
    {
        private static IAreaAdapter _areaAdapter;
        private static ICustomerAdapter _customerAdapter;
        private static IProductGroupIDAdapter _productGroupIdAdapter;
        private static IProductsInformationAdapter _productsInformationAdapter;
        private static IProductsOrderAdapter _productsOrderAdapter;

        public static string OldConn { get; set; }
        public static IAreaAdapter AreaAdapter
        {
            get => _areaAdapter ?? new AreaAdapter();

            set => _areaAdapter = value;
        }

        public static ICustomerAdapter CustomerAdapter
        {
            get => _customerAdapter ?? new CustomerAdapter();

            set => _customerAdapter = value;
        }

        public static IProductGroupIDAdapter ProductGroupIdAdapter
        {
            get => _productGroupIdAdapter ?? new ProductGroupIDAdapter();

            set => _productGroupIdAdapter = value;
        }

        public static IProductsInformationAdapter ProductsInformationAdapter
        {
            get => _productsInformationAdapter ?? new ProductInformationAdapter();

            set => _productsInformationAdapter = value;
        }

        public static IProductsOrderAdapter IProductsOrderAdapter
        {
            get => _productsOrderAdapter ?? new ProducstOrderAdapter();

            set => _productsOrderAdapter = value;
        }
    }
}