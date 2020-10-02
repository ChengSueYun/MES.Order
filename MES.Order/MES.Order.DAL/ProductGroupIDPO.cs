﻿using System;
using System.Collections.Generic;
using System.Linq;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;

namespace MES.Order.DAL
{
    public class ProductGroupIDPO
    {
        internal ProductsDbContext ProductsDbContext
        {
            get
            {
                if (this._productsDbContext == null)
                {
                    this._productsDbContext = new ProductsDbContext();
                }

                return this._productsDbContext;
            }
            set => this._productsDbContext = value;
        }

        private ProductsDbContext _productsDbContext;

        public List<KeyAndNameForCombo> QueryAllProductsGroupID()
        {
            try
            {
                using (var db =
                    ProductsDbContext.CreateAndOpen(this.ProductsDbContext.Database.Connection.ConnectionString))
                {
                    var result = (from a in db.ProductGroupIDs
                                  select new KeyAndNameForCombo
                                  {
                                      Code             = a.ProductGroupID,
                                      LocalDescription = a.ProductGroupName
                                  }).Distinct().ToList();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}