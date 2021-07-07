using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;

namespace MES.Order.UI.Mappers
{
   internal class ProductsOrderProfile : Profile
    {
        public ProductsOrderProfile()
        {
            this.CreateMap<AddOrderViewModel, ProductsOrder>();
            this.CreateMap<ProductsOrder, AddOrderViewModel>();
        }
    }
}
