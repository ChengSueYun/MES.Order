using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Xml;
using MES.Order.Adapter;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;

namespace MES.Order.BLL
{
    public static class ProductsOrderUCO
    {
        private static IProductsOrderAdapter       _IproductsOrderAdapter;
        private static IAreaAdapter                _IareaAdapter;
        private static IProductGroupIDAdapter      _iproductGroupIdAdapter;
        private static IProductsInformationAdapter _ipProductsInformationAdapter;
        private static ICustomerAdapter            _icustomerAdapter;

        internal static IProductsOrderAdapter IProductsOrderAdapter
        {
            get
            {
                if (_IproductsOrderAdapter == null)
                {
                    _IproductsOrderAdapter = new ProducstOrderAdapter();
                }

                return _IproductsOrderAdapter;
            }
            set => _IproductsOrderAdapter = value;
        }

        internal static IAreaAdapter IareaAdapter
        {
            get
            {
                if (_IareaAdapter == null)
                {
                    _IareaAdapter = new AreaAdapter();
                }

                return _IareaAdapter;
            }
            set => _IareaAdapter = value;
        }

        internal static IProductGroupIDAdapter IproductGroupIdAdapter
        {
            get
            {
                if (_iproductGroupIdAdapter == null)
                {
                    _iproductGroupIdAdapter = new ProductGroupIDAdapter();
                }

                return _iproductGroupIdAdapter;
            }
            set => _iproductGroupIdAdapter = value;
        }

        internal static IProductsInformationAdapter ipProductsInformationAdapter
        {
            get
            {
                if (_ipProductsInformationAdapter == null)
                {
                    _ipProductsInformationAdapter = new ProductInformationAdapter();
                }

                return _ipProductsInformationAdapter;
            }
            set => _ipProductsInformationAdapter = value;
        }

        internal static ICustomerAdapter IcustomerAdapter
        {
            get
            {
                if (_icustomerAdapter == null)
                {
                    _icustomerAdapter = new CustomerAdapter();
                }

                return _icustomerAdapter;
            }
            set => _icustomerAdapter = value;
        }

        private static void AddAllSelectRow(ref List<KeyAndNameForCombo> Result)
        {
            var all = new KeyAndNameForCombo();
            all.Code             = "*ALL";
            all.LocalDescription = "全部";
            Result.Insert(0, all);
        }

        public static List<ProductsOrder> QueryAllOrders(string   Area, string ProductGroupID, string CustomerName,
                                                         string   ProductName, DateTime orderDateTimeS,
                                                         DateTime orderDateTimeE)
        {
            return IProductsOrderAdapter.QueryAllOrders(Area, ProductGroupID, CustomerName, ProductName,
                                                        orderDateTimeS,
                                                        orderDateTimeE);
        }

        public static List<ProductsOrder> QueryAllOrders(string Area, string ProductGroupID, List<string> CustomerName,
                                                         List<string> ProductName, DateTime orderDateTimeS,
                                                         DateTime orderDateTimeE) =>
            IProductsOrderAdapter.QueryAllOrders(Area, ProductGroupID, CustomerName, ProductName, orderDateTimeS,
                                                 orderDateTimeE);

        public static List<KeyAndNameForCombo> GetArea()
        {
            List<KeyAndNameForCombo> result = IareaAdapter.GetArea();
            AddAllSelectRow(ref result);
            return result;
        }

        public static List<KeyAndNameForCombo> GetProductGroupID()
        {
            List<KeyAndNameForCombo> result = IproductGroupIdAdapter.QueryProductGroupIds();
            AddAllSelectRow(ref result);
            return result;
        }

        public static string QuerySpecifcName(string pCustomName) => _icustomerAdapter.QuerySpecifcName(pCustomName);

        public static List<KeyAndNameForCombo> GetCustomerName(string Area)
        {
            List<KeyAndNameForCombo> result = IcustomerAdapter.DistinctCustomer(Area);
            AddAllSelectRow(ref result);
            return result;
        }

        public static List<KeyAndNameForCombo> GetProductName(string ProductGroupID)
        {
            var result = ipProductsInformationAdapter.DistinctProductName(ProductGroupID);
            AddAllSelectRow(ref result);
            return result;
        }

        public static List<ProductsInfomation> GetProductPrice(string ProductGroupID, string ProductName)
        {
            return ipProductsInformationAdapter.GetProdctPrice(ProductGroupID, ProductName);
        }

        public static List<ProductsInfomation> GetProductCost(string ProductGroupID, string ProductName)
        {
            return ipProductsInformationAdapter.GetProdctCost(ProductGroupID, ProductName);
        }

        public static int SaveOrders(List<ProductsOrder> insertProductsOrders)
        {
            return IProductsOrderAdapter.SaveOrder(insertProductsOrders);
        }

        public static int DeleteOrders(List<ProductsOrder> deleteProductsOrders)
        {
            return IProductsOrderAdapter.DeleteOrder(deleteProductsOrders);
        }

        public static int UpdateOrders(List<ProductsOrder> updateProductsOrders)
        {
            return IProductsOrderAdapter.UpdateOrder(updateProductsOrders);
        }
    }
}