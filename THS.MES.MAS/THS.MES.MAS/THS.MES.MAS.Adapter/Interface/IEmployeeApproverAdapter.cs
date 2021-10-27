using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THS.MES.MAS.DAL.EntityModel;
using THS.MES.MAS.Infrastructure.ViewModel;

namespace THS.MES.MAS.Adapter.Interface
{
    public interface IEmployeeApproverAdapter
    {
        #region Query

        List<EmployeeApproverViewModel> QueryAll();

        List<EmployeeApproverViewModel> QueryByName(string name);

        List<EmployeeApproverViewModel> QueryByNames(List<string> names);

        List<EmployeeApproverViewModel> QueryByDeptId(string deptId);

        List<EmployeeApproverViewModel> QueryByDeptIds(List<string> deptIds);

        List<EmployeeApproverViewModel> QueryBySalaryDeptId(string SalaryDeptId);

        List<EmployeeApproverViewModel> QueryBySalaryDeptIds(List<string> SalaryDeptIds);

        List<EmployeeApproverViewModel> StartWithDeptId(string deptId);

        EmployeeApproverViewModel QueryByEmployeeId(string employeeId);

        List<EmployeeApproverViewModel> QueryByEmployeeIds(List<string> employeeIds);

        EmployeeApproverViewModel QueryByAutoId(int autoId);

        #endregion

        #region Insert

        bool Insert(List<EmployeeApprover> insertList);

        bool Insert(EmployeeApprover insert);

        #endregion

        #region Delete

        bool Delete(List<EmployeeApprover> deleteList);

        bool Delete(EmployeeApprover delete);

        #endregion

        #region Update

        bool Update(List<EmployeeApprover> updateList);

        bool Update(EmployeeApprover update);

        #endregion
    }
}