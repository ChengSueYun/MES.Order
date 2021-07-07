using System;
using System.Collections.Generic;
using MES.Order.DAL.EntityFramework;

namespace MES.Order.Adapter
{
    public interface IProductsOrderAdapter
    {
        List<ProductsOrder> QueryAllOrders(string Area,        string   ProductGroupID, string   CustomerName,
                                           string ProductName, DateTime orderDateTimeS, DateTime orderDateTimeE);
        
        List<ProductsOrder> QueryAllOrders(string Area,        string   ProductGroupID, List<string>   CustomerName,
                                           List<string> ProductName, DateTime orderDateTimeS, DateTime orderDateTimeE);

        int SaveOrder(List<ProductsOrder> insertProductsOrders);

        int DeleteOrder(List<ProductsOrder> deletOders);

        int UpdateOrder(List<ProductsOrder> updateOders);

    }
}