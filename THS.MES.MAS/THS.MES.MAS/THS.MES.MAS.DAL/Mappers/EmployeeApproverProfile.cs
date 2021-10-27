using AutoMapper;
using THS.MES.MAS.DAL.EntityModel;
using THS.MES.MAS.Infrastructure.ViewModel;

namespace THS.MES.MAS.DAL.Mappers
{
    public class EmployeeApproverProfile : Profile
    {
        public EmployeeApproverProfile()
        {
            this.CreateMap<EmployeeApproverViewModel, EmployeeApprover>();

            this.CreateMap<EmployeeApprover, EmployeeApproverViewModel>();
        }
    }
}