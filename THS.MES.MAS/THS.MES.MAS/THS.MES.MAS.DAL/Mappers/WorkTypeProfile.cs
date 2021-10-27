using AutoMapper;
using THS.MES.MAS.DAL.EntityModel;
using THS.MES.MAS.Infrastructure.ViewModel;

namespace THS.MES.MAS.DAL.Mappers
{
    public class WorkTypeProfile : Profile
    {
        public WorkTypeProfile()
        {
            this.CreateMap<WorkTypeViewModel, WorkTypes>();

            this.CreateMap<WorkTypes, WorkTypeViewModel>();
        }
    }
}