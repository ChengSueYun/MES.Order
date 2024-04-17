using AutoMapper;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.NewEntityFramework;
using MES.Order.Infrastructure.NewViewModel.Request;
using MES.Order.Infrastructure.NewViewModel;

namespace MES.Order.BLL.Mapper
{
    public class OldOrderProfile : Profile
    {
        public OldOrderProfile()
        {
            this.CreateMap<Areas, AreaInfoViewModel>();
            this.CreateMap<ProductsGroupID, FactoryInfoViewModel>();
            this.CreateMap<Custom, CustomInfoViewModel>();
            this.CreateMap<ProductsInfomation, ProductsInfoViewModel>();
            this.CreateMap<ProductsOrder, OrderInfoViewModel>();
        }
    }
}