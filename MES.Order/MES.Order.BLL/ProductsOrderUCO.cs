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
    public class ProductsOrderUCO
    {
        private IProductsOrderAdapter       _IproductsOrderAdapter;
        private IAreaAdapter                _IareaAdapter;
        private IProductGroupIDAdapter      _iproductGroupIdAdapter;
        private IProductsInformationAdapter _ipProductsInformationAdapter;
        private ICustomerAdapter            _icustomerAdapter;

        internal IProductsOrderAdapter IProductsOrderAdapter
        {
            get
            {
                if (this._IproductsOrderAdapter == null)
                {
                    this._IproductsOrderAdapter = new ProducstOrderAdapter();
                }

                return this._IproductsOrderAdapter;
            }
            set => this._IproductsOrderAdapter = value;
        }

        internal IAreaAdapter IareaAdapter
        {
            get
            {
                if (this._IareaAdapter == null)
                {
                    this._IareaAdapter = new AreaAdapter();
                }

                return this._IareaAdapter;
            }
            set => this._IareaAdapter = value;
        }

        internal IProductGroupIDAdapter IproductGroupIdAdapter
        {
            get
            {
                if (this._iproductGroupIdAdapter == null)
                {
                    this._iproductGroupIdAdapter = new ProductGroupIDAdapter();
                }

                return this._iproductGroupIdAdapter;
            }
            set => this._iproductGroupIdAdapter = value;
        }

        internal IProductsInformationAdapter ipProductsInformationAdapter
        {
            get
            {
                if (this._ipProductsInformationAdapter == null)
                {
                    this._ipProductsInformationAdapter = new ProductInformationAdapter();
                }

                return this._ipProductsInformationAdapter;
            }
            set => this._ipProductsInformationAdapter = value;
        }

        internal ICustomerAdapter IcustomerAdapter
        {
            get
            {
                if (this._icustomerAdapter == null)
                {
                    this._icustomerAdapter = new CustomerAdapter();
                }

                return this._icustomerAdapter;
            }
            set => this._icustomerAdapter = value;
        }

        private void AddAllSelectRow(ref List<KeyAndNameForCombo> Result)
        {
            var all = new KeyAndNameForCombo();
            all.Code             = "*ALL";
            all.LocalDescription = "全部";
            Result.Insert(0, all);
        }

        public List<ProductsOrder> QueryAllOrders(string Area,        string   ProductGroupID, string   CustomerName,
                                                  string ProductName, DateTime orderDateTimeS, DateTime orderDateTimeE)
        {
            return this.IProductsOrderAdapter.QueryAllOrders(Area, ProductGroupID, CustomerName, ProductName,
                                                             orderDateTimeS,
                                                             orderDateTimeE);
        }

        public List<ProductsOrder> QueryAllOrders(string       Area, string ProductGroupID, List<string> CustomerName,
                                                  List<string> ProductName, DateTime orderDateTimeS,
                                                  DateTime     orderDateTimeE) =>
            this.IProductsOrderAdapter.QueryAllOrders(Area, ProductGroupID, CustomerName, ProductName, orderDateTimeS,
                                                      orderDateTimeE);

        public List<KeyAndNameForCombo> GetArea()
        {
            List<KeyAndNameForCombo> result = this.IareaAdapter.GetArea();
            AddAllSelectRow(ref result);
            return result;
        }

        public List<KeyAndNameForCombo> GetProductGroupID()
        {
            List<KeyAndNameForCombo> result = this.IproductGroupIdAdapter.QueryProductGroupIds();
            AddAllSelectRow(ref result);
            return result;
        }

        public string QuerySpecifcName(string pCustomName) => this._icustomerAdapter.QuerySpecifcName(pCustomName);

        public List<KeyAndNameForCombo> GetCustomerName(string Area)
        {
            List<KeyAndNameForCombo> result = this.IcustomerAdapter.DistinctCustomer(Area);
            AddAllSelectRow(ref result);
            return result;
        }

        public List<KeyAndNameForCombo> GetProductName(string ProductGroupID)
        {
            var result = this.ipProductsInformationAdapter.DistinctProductName(ProductGroupID);
            AddAllSelectRow(ref result);
            return result;
        }

        public List<ProductsInfomation> GetProductPrice(string ProductGroupID, string ProductName)
        {
            return this.ipProductsInformationAdapter.GetProdctPrice(ProductGroupID, ProductName);
        }

        public List<ProductsInfomation> GetProductCost(string ProductGroupID, string ProductName)
        {
            return this.ipProductsInformationAdapter.GetProdctCost(ProductGroupID, ProductName);
        }

        public int SaveOrders(List<ProductsOrder> insertProductsOrders)
        {
            return this.IProductsOrderAdapter.SaveOrder(insertProductsOrders);
        }

        public int DeleteOrders(List<ProductsOrder> deleteProductsOrders)
        {
            return this.IProductsOrderAdapter.DeleteOrder(deleteProductsOrders);
        }

        public int UpdateOrders(List<ProductsOrder> updateProductsOrders)
        {
            return this.IProductsOrderAdapter.UpdateOrder(updateProductsOrders);
        }
    }
}