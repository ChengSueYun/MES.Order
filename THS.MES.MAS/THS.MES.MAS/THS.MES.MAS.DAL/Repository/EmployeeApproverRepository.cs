using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THS.Data.Entity.Extension;
using THS.MES.MAS.DAL.EntityModel;
using THS.MES.MAS.Infrastructure.ViewModel;

namespace THS.MES.MAS.DAL.Repository
{
    public class EmployeeApproverRepository
    {
        #region Constructor

        private readonly string       _conn;
        private readonly MASDbContext _masDbContext;

        public EmployeeApproverRepository(MASDbContext dbContext)
        {
            try
            {
                this._masDbContext = dbContext;
                this._conn         = dbContext.Database.Connection.ConnectionString;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        #endregion

        #region Query

        public List<EmployeeApproverViewModel> QueryAll()
        {
            var result = new List<EmployeeApproverViewModel>();
            using (var masDbContext = MASDbContext.CreateAndOpen(this._conn))
            {
                var employeeApprovers = masDbContext.EmployeeApprovers;
                if (employeeApprovers.Any())
                {
                    Mappers.DefaultMapper.Map(employeeApprovers.AsNoTracking().ToList(), result);
                }
            }

            return result;
        }

        public List<EmployeeApproverViewModel> QueryByName(string name)
        {
            var result = new List<EmployeeApproverViewModel>();
            using (var masDbContext = MASDbContext.CreateAndOpen(this._conn))
            {
                var employeeApprovers = masDbContext.EmployeeApprovers.Where(x => x.Name == name);
                if (employeeApprovers.Any())
                {
                    Mappers.DefaultMapper.Map(employeeApprovers.AsNoTracking().ToList(), result);
                }
            }

            return result;
        }

        public List<EmployeeApproverViewModel> QueryByNames(List<string> names)
        {
            var result = new List<EmployeeApproverViewModel>();
            using (var masDbContext = MASDbContext.CreateAndOpen(this._conn))
            {
                var employeeApprovers = masDbContext.EmployeeApprovers.Where(x => names.Contains(x.Name));
                if (employeeApprovers.Any())
                {
                    Mappers.DefaultMapper.Map(employeeApprovers.AsNoTracking().ToList(), result);
                }
            }

            return result;
        }

        public List<EmployeeApproverViewModel> QueryByDeptId(string deptId)
        {
            var result = new List<EmployeeApproverViewModel>();
            using (var masDbContext = MASDbContext.CreateAndOpen(this._conn))
            {
                var employeeApprovers = masDbContext.EmployeeApprovers.Where(x => x.DeptID == deptId);
                if (employeeApprovers.Any())
                {
                    Mappers.DefaultMapper.Map(employeeApprovers.AsNoTracking().ToList(), result);
                }
            }

            return result;
        }

        public List<EmployeeApproverViewModel> QueryByDeptIds(List<string> deptIds)
        {
            var result = new List<EmployeeApproverViewModel>();
            using (var masDbContext = MASDbContext.CreateAndOpen(this._conn))
            {
                var employeeApprovers = masDbContext.EmployeeApprovers.Where(x => deptIds.Contains(x.DeptID));
                if (employeeApprovers.Any())
                {
                    Mappers.DefaultMapper.Map(employeeApprovers.AsNoTracking().ToList(), result);
                }
            }

            return result;
        }

        public List<EmployeeApproverViewModel> QueryBySalaryDeptId(string SalaryDeptId)
        {
            var result = new List<EmployeeApproverViewModel>();
            using (var masDbContext = MASDbContext.CreateAndOpen(this._conn))
            {
                var employeeApprovers = masDbContext.EmployeeApprovers.Where(x => x.SalaryDeptID == SalaryDeptId);
                if (employeeApprovers.Any())
                {
                    Mappers.DefaultMapper.Map(employeeApprovers.AsNoTracking().ToList(), result);
                }
            }

            return result;
        }

        public List<EmployeeApproverViewModel> QueryBySalaryDeptIds(List<string> SalaryDeptIds)
        {
            var result = new List<EmployeeApproverViewModel>();
            using (var masDbContext = MASDbContext.CreateAndOpen(this._conn))
            {
                var employeeApprovers =
                    masDbContext.EmployeeApprovers.Where(x => SalaryDeptIds.Contains(x.SalaryDeptID));
                if (employeeApprovers.Any())
                {
                    Mappers.DefaultMapper.Map(employeeApprovers.AsNoTracking().ToList(), result);
                }
            }

            return result;
        }

        public List<EmployeeApproverViewModel> StartWithDeptId(string deptId)
        {
            var result = new List<EmployeeApproverViewModel>();
            using (var masDbContext = MASDbContext.CreateAndOpen(this._conn))
            {
                var employeeApprovers =
                    masDbContext.EmployeeApprovers.Where(x => x.DeptID.StartsWith(deptId));
                if (employeeApprovers.Any())
                {
                    Mappers.DefaultMapper.Map(employeeApprovers.AsNoTracking().ToList(), result);
                }
            }

            return result;
        }

        public EmployeeApproverViewModel QueryByEmployeeId(string employeeId)
        {
            var result = new EmployeeApproverViewModel();
            using (var masDbContext = MASDbContext.CreateAndOpen(this._conn))
            {
                var employeeApprovers =
                    masDbContext.EmployeeApprovers.Where(x => x.EmployeeID == employeeId);
                if (employeeApprovers.Any())
                {
                    Mappers.DefaultMapper.Map(employeeApprovers.AsNoTracking().ToList(), result);
                }
            }

            return result;
        }

        public List<EmployeeApproverViewModel> QueryByEmployeeIds(List<string> employeeIds)
        {
            var result = new List<EmployeeApproverViewModel>();
            using (var masDbContext = MASDbContext.CreateAndOpen(this._conn))
            {
                var employeeApprovers =
                    masDbContext.EmployeeApprovers.Where(x => employeeIds.Contains(x.EmployeeID));
                if (employeeApprovers.Any())
                {
                    Mappers.DefaultMapper.Map(employeeApprovers.AsNoTracking().ToList(), result);
                }
            }

            return result;
        }

        public EmployeeApproverViewModel QueryByAutoId(int autoId)
        {
            var result = new EmployeeApproverViewModel();
            using (var masDbContext = MASDbContext.CreateAndOpen(this._conn))
            {
                var employeeApprovers =
                    masDbContext.EmployeeApprovers.Where(x => x.AutoID == autoId);
                if (employeeApprovers.Any())
                {
                    Mappers.DefaultMapper.Map(employeeApprovers.AsNoTracking().ToList(), result);
                }
            }

            return result;
        }

        #endregion

        #region Insert

        public bool Insert(List<EmployeeApprover> insertList)
        {
            var result = false;
            foreach (var item in insertList)
            {
                this._masDbContext.EmployeeApprovers.Attach(item);
                this._masDbContext.Entry(item).State = EntityState.Added;
            }

            var saveCount = this._masDbContext.Save();
            if (saveCount == insertList.Count)
            {
                result = true;
            }

            return result;
        }

        public bool Insert(EmployeeApprover insert)
        {
            var result = false;

            this._masDbContext.EmployeeApprovers.Attach(insert);
            this._masDbContext.Entry(insert).State = EntityState.Added;

            var saveCount = this._masDbContext.Save();
            if (saveCount == 1)
            {
                result = true;
            }

            return result;
        }

        #endregion

        #region Delete

        public bool Delete(List<EmployeeApprover> deleteList)
        {
            var result = false;
            foreach (var item in deleteList)
            {
                this._masDbContext.EmployeeApprovers.Attach(item);
                this._masDbContext.Entry(item).State = EntityState.Deleted;
            }

            var saveCount = this._masDbContext.Save();
            if (saveCount == deleteList.Count)
            {
                result = true;
            }

            return result;
        }

        public bool Delete(EmployeeApprover delete)
        {
            var result = false;

            this._masDbContext.EmployeeApprovers.Attach(delete);
            this._masDbContext.Entry(delete).State = EntityState.Deleted;

            var saveCount = this._masDbContext.Save();
            if (saveCount == 1)
            {
                result = true;
            }

            return result;
        }

        #endregion

        #region Update

        public bool Update(List<EmployeeApprover> updateList)
        {
            var result = false;
            foreach (var item in updateList)
            {
                this._masDbContext.EmployeeApprovers.Attach(item);
                this._masDbContext.Entry(item).State = EntityState.Modified;
            }

            var saveCount = this._masDbContext.Save();
            if (saveCount == updateList.Count)
            {
                result = true;
            }

            return result;
        }

        public bool Update(EmployeeApprover update)
        {
            var result = false;

            this._masDbContext.EmployeeApprovers.Attach(update);
            this._masDbContext.Entry(update).State = EntityState.Modified;

            var saveCount = this._masDbContext.Save();
            if (saveCount == 1)
            {
                result = true;
            }

            return result;
        }

        #endregion
    }
}