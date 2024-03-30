using AutoMapper;
using MES.Order.DAL.NewEntityFramework;
using MES.Order.Infrastructure.NewViewModel;
using MES.Order.Infrastructure.NewViewModel.Request;

namespace MES.Order.DAL.Mapper
{
    public class OrderProfile: Profile
    {
        public OrderProfile()
        {
            this.CreateMap<AreaInfo, AreaInfoViewModel>();
            this.CreateMap<AreaInfoViewModel, AreaInfo>();

            this.CreateMap<FactoryInfo, FactoryInfoViewModel>();
            this.CreateMap<FactoryInfoViewModel, FactoryInfo>();

            this.CreateMap<CustomInfo, CustomInfoViewModel>();
            this.CreateMap<CustomInfoViewModel, CustomInfo>();



            this.CreateMap<ProductsInfo, ProductsInfoViewModel>();
            this.CreateMap<ProductsInfoViewModel, ProductsInfo>();

            this.CreateMap<OrderInfo, OrderInfoViewModel>();
            this.CreateMap<OrderInfoViewModel, OrderInfo>();

            this.CreateMap<OrderInfo, OrderInfoRequest>();
            this.CreateMap<OrderInfoRequest, OrderInfo>();
        }
    }
}
