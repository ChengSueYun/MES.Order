using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using MES.Order.DAL;
using MES.Order.DAL.EntityFramework;

namespace MES.Order.Adapter
{
    public class ProducstOrderAdapter:IProductsOrderAdapter
    {
        private ProductsOrderPO _productsOrderPo;

        internal ProductsOrderPO productsOrderPo
        {
            get
            {
                if (this._productsOrderPo==null)
                {
                    this._productsOrderPo=new ProductsOrderPO();
                }
                return this._productsOrderPo;
            }
            set => this._productsOrderPo = value;
        }

        public List<ProductsOrder> QueryAllOrders(string   Area,           string   ProductGroupID, string CustomerName, string ProductName,
                                                  DateTime orderDateTimeS, DateTime orderDateTimeE)
        {
            return this.productsOrderPo.QueryAllOrders(Area, ProductGroupID, CustomerName, ProductName, orderDateTimeS,
                                                       orderDateTimeE);
        }

        public int SaveOrder(List<ProductsOrder> insertProductsOrders)
        {
            return this.productsOrderPo.SaveOrder(insertProductsOrders);
        }

        public int DeleteOrder(List<ProductsOrder> deletOders)
        {
            return this.productsOrderPo.DeleteOrder(deletOders);
        }

        public int UpdateOrder(List<ProductsOrder> updateOders)
        {
            return this.productsOrderPo.UpdateOrder(updateOders);

        }
    }
}