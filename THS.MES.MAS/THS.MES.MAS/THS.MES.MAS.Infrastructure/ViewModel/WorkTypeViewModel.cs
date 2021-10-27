using System;

namespace THS.MES.MAS.Infrastructure.ViewModel
{
    public partial class WorkTypeViewModel
    {
        public int AutoID { get; set; }

        public string WorkType { get; set; }

        public string WorkTypeBrief { get; set; }

        public string WorkTypeLocalBrief { get; set; }

        public string ValidDepartment { get; set; }

        public string ExceptDepartment { get; set; }

        public string CreateUser { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string CreateWorkstationID { get; set; }

        public string ModifiedUser { get; set; }

        public DateTime ModifiedDateTime { get; set; }

        public string ModifiedWorkstationID { get; set; }

        public string LockFlag { get; set; }

        public string LockUser { get; set; }

        public DateTime LockDateTime { get; set; }
    }
}
