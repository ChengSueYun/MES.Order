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
    public class WorkTypeRepository
    {
        #region Constructor

        private readonly string       _conn;
        private readonly MASDbContext _masDbContext;

        public WorkTypeRepository(MASDbContext dbContext)
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

        public List<WorkTypeViewModel> QueryAll()
        {
            var result = new List<WorkTypeViewModel>();
            using (var masDbContext = MASDbContext.CreateAndOpen(this._conn))
            {
                var workTypesEnumerable = masDbContext.WorkTypes;
                if (workTypesEnumerable.Any())
                {
                    Mappers.DefaultMapper.Map(workTypesEnumerable.AsNoTracking().ToList(), result);
                }
            }

            return result;
        }

        public WorkTypeViewModel QueryAllByWorkType(string pWorkType)
        {
            var result = new WorkTypeViewModel();
            using (var masDbContext = MASDbContext.CreateAndOpen(this._conn))
            {
                var workTypesEnumerable = masDbContext.WorkTypes.Where(x => x.WorkType == pWorkType);
                if (workTypesEnumerable.Any())
                {
                    Mappers.DefaultMapper.Map(workTypesEnumerable.AsNoTracking().FirstOrDefault(), result);
                }
            }

            return result;
        }

        public List<WorkTypeViewModel> QueryAllByWorkTypes(List<string> pWorkType)
        {
            var result = new List<WorkTypeViewModel>();
            using (var masDbContext = MASDbContext.CreateAndOpen(this._conn))
            {
                var workTypesEnumerable = masDbContext.WorkTypes.Where(x => pWorkType.Contains(x.WorkType));
                if (workTypesEnumerable.Any())
                {
                    Mappers.DefaultMapper.Map(workTypesEnumerable.AsNoTracking().ToList(), result);
                }
            }

            return result;
        }

        public bool Insert(List<WorkTypes> insertWorkTypesList)
        {
            var result = false;
            foreach (var item in insertWorkTypesList)
            {
                this._masDbContext.WorkTypes.Attach(item);
                this._masDbContext.Entry(item).State = EntityState.Added;
            }

            var saveCount = this._masDbContext.Save();
            if (saveCount == insertWorkTypesList.Count)
            {
                result = true;
            }

            return result;
        }

        public bool Insert(WorkTypes insertWorkTypesList)
        {
            var result = false;

            this._masDbContext.WorkTypes.Attach(insertWorkTypesList);
            this._masDbContext.Entry(insertWorkTypesList).State = EntityState.Added;

            var saveCount = this._masDbContext.Save();
            if (saveCount == 1)
            {
                result = true;
            }

            return result;
        }

        public bool Delete(List<WorkTypes> deleteWorkTypesList)
        {
            var result = false;
            foreach (var item in deleteWorkTypesList)
            {
                this._masDbContext.WorkTypes.Attach(item);
                this._masDbContext.Entry(item).State = EntityState.Deleted;
            }

            var saveCount = this._masDbContext.Save();
            if (saveCount == deleteWorkTypesList.Count)
            {
                result = true;
            }

            return result;
        }

        public bool Delete(WorkTypes deleteWorkTypesList)
        {
            var result = false;

            this._masDbContext.WorkTypes.Attach(deleteWorkTypesList);
            this._masDbContext.Entry(deleteWorkTypesList).State = EntityState.Deleted;

            var saveCount = this._masDbContext.Save();
            if (saveCount == 1)
            {
                result = true;
            }

            return result;
        }

        public bool Update(List<WorkTypes> updateWorkTypesList)
        {
            var result = false;
            foreach (var item in updateWorkTypesList)
            {
                this._masDbContext.WorkTypes.Attach(item);
                this._masDbContext.Entry(item).State = EntityState.Modified;
            }

            var saveCount = this._masDbContext.Save();
            if (saveCount == updateWorkTypesList.Count)
            {
                result = true;
            }

            return result;
        }

        public bool Update(WorkTypes updateWorkTypes)
        {
            var result = false;

            this._masDbContext.WorkTypes.Attach(updateWorkTypes);
            this._masDbContext.Entry(updateWorkTypes).State = EntityState.Modified;

            var saveCount = this._masDbContext.Save();
            if (saveCount == 1)
            {
                result = true;
            }

            return result;
        }
    }
}