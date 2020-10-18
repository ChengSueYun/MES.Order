using System.Collections.Generic;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;

namespace MES.Order.Adapter
{
    public interface IProductsInformationAdapter
    {
        #region Delete

        int DeleteProductsInfomations(List<ProductsInfomation> deleteProductsInfomations);

        #endregion

        #region Save

        int SaveProductsInfomations(List<ProductsInfomation> insertProductsInfomations);

        #endregion

        #region Query

        List<ProductsInfomation> QueryAllProducts(string ProductGroupID, string ProductName);

        List<KeyAndNameForCombo> DistinctProductName(string ProductGroupID);

        List<KeyAndNameForCombo> DistinctProductName();

        List<ProductsInfomation> GetProdctPrice(string ProductGroupID, string ProductName);

        #endregion
    }
}