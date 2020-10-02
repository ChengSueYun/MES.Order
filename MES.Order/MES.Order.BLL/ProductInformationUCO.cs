using System.Collections.Generic;
using MES.Order.Adapter;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;

namespace MES.Order.BLL
{
    public class ProductInformationUCO
    {
        #region Delete

        public int DeleteProductsInfomations(List<ProductsInfomation> deleteProductsInfomations)
        {
            return this.IProductsInformationAdapter.DeleteProductsInfomations(deleteProductsInfomations);
        }

        #endregion

        #region Save

        public int SaveProductsInfomations(List<ProductsInfomation> insertProductsInfomations)
        {
            return this.IProductsInformationAdapter.SaveProductsInfomations(insertProductsInfomations);
        }

        #endregion

        #region Proptery And Field

        internal IProductsInformationAdapter IProductsInformationAdapter
        {
            get
            {
                if (this._IProductsInformationAdapter == null)
                {
                    this._IProductsInformationAdapter = new ProductInformationAdapter();
                }

                return this._IProductsInformationAdapter;
            }
            set => this._IProductsInformationAdapter = value;
        }

        internal IProductGroupIDAdapter IProductGroupIDAdapter
        {
            get
            {
                if (this._IProductGroupIDAdapter == null)
                {
                    this._IProductGroupIDAdapter = new ProductGroupIDAdapter();
                }

                return this._IProductGroupIDAdapter;
            }
            set => this._IProductGroupIDAdapter = value;
        }

        private IProductGroupIDAdapter      _IProductGroupIDAdapter;
        private IProductsInformationAdapter _IProductsInformationAdapter;

        #endregion

        #region Query

        public List<KeyAndNameForCombo> QueryProductGroupIds()
        {
            var result = this.IProductGroupIDAdapter.QueryProductGroupIds();
            this.AddAllSelectRow(ref result);
            return result;
        }

        public List<KeyAndNameForCombo> DistinctProductName()
        {
            var result = this.IProductsInformationAdapter.DistinctProductName();
            this.AddAllSelectRow(ref result);
            return result;
        }

        public List<KeyAndNameForCombo> DistinctProductName(string ProductGroupID)
        {
            var result = this.IProductsInformationAdapter.DistinctProductName(ProductGroupID);
            this.AddAllSelectRow(ref result);
            return result;
        }

        public List<ProductsInfomation> QueryProducts(string pProductGroupId, string pProductName)
        {
            return this.IProductsInformationAdapter.QueryAllProducts(pProductGroupId, pProductName);
        }

        private void AddAllSelectRow(ref List<KeyAndNameForCombo> Result)
        {
            var all = new KeyAndNameForCombo();
            all.Code             = "*ALL";
            all.LocalDescription = "全部";
            Result.Insert(0, all);
        }

        #endregion
    }
}