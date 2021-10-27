using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace THS.MES.MAS.DAL.EntityModel
{
    public partial class MASDbContext : DbContext
    {
        public MASDbContext()
            : base("name=MASDbContext")
        {
        }

        public virtual DbSet<AccessRule> AccessRules { get; set; }
        public virtual DbSet<BadgeInfo> BadgeInfoes { get; set; }
        public virtual DbSet<BadgeInfoHold> BadgeInfoHolds { get; set; }
        public virtual DbSet<BlackList> BlackLists { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<EmployeeApprover> EmployeeApprovers { get; set; }
        public virtual DbSet<EmployeeApproverSupport> EmployeeApproverSupports { get; set; }
        public virtual DbSet<EntranceLog> EntranceLogs { get; set; }
        public virtual DbSet<MaintenanceMan> MaintenanceMen { get; set; }
        public virtual DbSet<MaintenanceProvider> MaintenanceProviders { get; set; }
        public virtual DbSet<MaintenanceWork> MaintenanceWorks { get; set; }
        public virtual DbSet<MaintenanceWorkMan> MaintenanceWorkMen { get; set; }
        public virtual DbSet<MASSystemParameter> MASSystemParameters { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<VisitFactory> VisitFactories { get; set; }
        public virtual DbSet<WorkTypes> WorkTypes { get; set; }
        public virtual DbSet<View_AccessApplication> View_AccessApplication { get; set; }
        public virtual DbSet<View_AllEnterPerson> View_AllEnterPerson { get; set; }
        public virtual DbSet<View_AllEntrance> View_AllEntrance { get; set; }

        public MASDbContext(string connectionStringName) : base(connectionStringName)
        {
        }


        public static void Close(MASDbContext dbContext)
        {
            if (dbContext.Database.Connection != null)
            {
                var dbConnection = dbContext.Database.Connection;
                if (dbConnection.State == ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
        }

        public static MASDbContext Create(string connectionStringName)
        {
            var dbContext = new MASDbContext(connectionStringName);

            dbContext.Configuration.AutoDetectChangesEnabled = false;
            dbContext.Configuration.LazyLoadingEnabled       = false;
            dbContext.Configuration.ProxyCreationEnabled     = false;

            return dbContext;
        }

        public static MASDbContext CreateAndOpen(string connectionStringName)
        {
            var dbContext    = Create(connectionStringName);
            var dbConnection = dbContext.Database.Connection;
            if (dbConnection.State == ConnectionState.Closed)
            {
                dbConnection.Open();
            }

            return dbContext;
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessRule>()
                .Property(e => e.LocationID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AccessRule>()
                .Property(e => e.RuleNo)
                .IsUnicode(false);

            modelBuilder.Entity<AccessRule>()
                .Property(e => e.RuleType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AccessRule>()
                .Property(e => e.TipCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AccessRule>()
                .Property(e => e.TipRange)
                .IsUnicode(false);

            modelBuilder.Entity<AccessRule>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<AccessRule>()
                .Property(e => e.CreateWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<AccessRule>()
                .Property(e => e.ModifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<AccessRule>()
                .Property(e => e.ModifiedWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<AccessRule>()
                .Property(e => e.LockFlag)
                .IsUnicode(false);

            modelBuilder.Entity<AccessRule>()
                .Property(e => e.LockUser)
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfo>()
                .Property(e => e.LocationID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfo>()
                .Property(e => e.ProviderID)
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfo>()
                .Property(e => e.WorkID)
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfo>()
                .Property(e => e.VoidCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfo>()
                .Property(e => e.VoidWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfo>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfo>()
                .Property(e => e.CreateWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfo>()
                .Property(e => e.ModifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfo>()
                .Property(e => e.ModifiedWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfo>()
                .Property(e => e.LockFlag)
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfo>()
                .Property(e => e.LockUser)
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfo>()
                .Property(e => e.DepositStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfo>()
                .Property(e => e.Useflag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfo>()
                .Property(e => e.Type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfo>()
                .Property(e => e.IdentityID)
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfoHold>()
                .Property(e => e.LocationID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfoHold>()
                .Property(e => e.ProviderID)
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfoHold>()
                .Property(e => e.WorkID)
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfoHold>()
                .Property(e => e.AskCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfoHold>()
                .Property(e => e.AskUser)
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfoHold>()
                .Property(e => e.AskWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfoHold>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfoHold>()
                .Property(e => e.CreateWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfoHold>()
                .Property(e => e.ModifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<BadgeInfoHold>()
                .Property(e => e.ModifiedWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<BlackList>()
                .Property(e => e.LocationID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BlackList>()
                .Property(e => e.ProviderID)
                .IsUnicode(false);

            modelBuilder.Entity<BlackList>()
                .Property(e => e.CarNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BlackList>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<BlackList>()
                .Property(e => e.CreateWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<BlackList>()
                .Property(e => e.ModifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<BlackList>()
                .Property(e => e.ModifiedWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<BlackList>()
                .Property(e => e.LockFlag)
                .IsUnicode(false);

            modelBuilder.Entity<BlackList>()
                .Property(e => e.LockUser)
                .IsUnicode(false);

            modelBuilder.Entity<BlackList>()
                .Property(e => e.IdentityID)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.LocationID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.DeptID)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.CreateWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.ModifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.ModifiedWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.LockFlag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.LockUser)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeApprover>()
                .Property(e => e.LocationID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeApprover>()
                .Property(e => e.DeptID)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeApprover>()
                .Property(e => e.SalaryLocationID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeApprover>()
                .Property(e => e.SalaryDeptID)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeApprover>()
                .Property(e => e.EmployeeID)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeApprover>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeApprover>()
                .Property(e => e.SignLevel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeApprover>()
                .Property(e => e.SupervisorID)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeApproverSupport>()
                .Property(e => e.LocationID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeApproverSupport>()
                .Property(e => e.DeptID)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeApproverSupport>()
                .Property(e => e.SalaryLocationID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeApproverSupport>()
                .Property(e => e.SalaryDeptID)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeApproverSupport>()
                .Property(e => e.EmployeeID)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeApproverSupport>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeApproverSupport>()
                .Property(e => e.SignLevel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeApproverSupport>()
                .Property(e => e.SupervisorID)
                .IsUnicode(false);

            modelBuilder.Entity<EntranceLog>()
                .Property(e => e.LocationID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EntranceLog>()
                .Property(e => e.ProviderID)
                .IsUnicode(false);

            modelBuilder.Entity<EntranceLog>()
                .Property(e => e.WorkType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EntranceLog>()
                .Property(e => e.WorkID)
                .IsUnicode(false);

            modelBuilder.Entity<EntranceLog>()
                .Property(e => e.DepartmentID)
                .IsUnicode(false);

            modelBuilder.Entity<EntranceLog>()
                .Property(e => e.BadgeNo)
                .IsUnicode(false);

            modelBuilder.Entity<EntranceLog>()
                .Property(e => e.OfficialPermission)
                .IsUnicode(false);

            modelBuilder.Entity<EntranceLog>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<EntranceLog>()
                .Property(e => e.CreateWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<EntranceLog>()
                .Property(e => e.ModifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<EntranceLog>()
                .Property(e => e.ModifiedWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<EntranceLog>()
                .Property(e => e.LockFlag)
                .IsUnicode(false);

            modelBuilder.Entity<EntranceLog>()
                .Property(e => e.LockUser)
                .IsUnicode(false);

            modelBuilder.Entity<EntranceLog>()
                .Property(e => e.LicensePlatNumber)
                .IsUnicode(false);

            modelBuilder.Entity<EntranceLog>()
                .Property(e => e.InsuranceStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EntranceLog>()
                .Property(e => e.HealthCheckUpStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EntranceLog>()
                .Property(e => e.IdentityID)
                .IsUnicode(false);

            modelBuilder.Entity<EntranceLog>()
                .Property(e => e.OccupationalHazardsCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceMan>()
                .Property(e => e.LocationID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceMan>()
                .Property(e => e.ProviderID)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceMan>()
                .Property(e => e.DepartmentID)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceMan>()
                .Property(e => e.BadgeNo)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceMan>()
                .Property(e => e.Qualification)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceMan>()
                .Property(e => e.LaborInsurance)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceMan>()
                .Property(e => e.OccupationalHazards)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceMan>()
                .Property(e => e.InformedDate)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceMan>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceMan>()
                .Property(e => e.CreateWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceMan>()
                .Property(e => e.ModifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceMan>()
                .Property(e => e.ModifiedWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceMan>()
                .Property(e => e.LockFlag)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceMan>()
                .Property(e => e.LockUser)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceProvider>()
                .Property(e => e.LocationID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceProvider>()
                .Property(e => e.ProviderID)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceProvider>()
                .Property(e => e.ProviderType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceProvider>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceProvider>()
                .Property(e => e.CreateWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceProvider>()
                .Property(e => e.ModifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceProvider>()
                .Property(e => e.ModifiedWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceProvider>()
                .Property(e => e.LockFlag)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceProvider>()
                .Property(e => e.LockUser)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.LocationID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.WorkType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.WorkID)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.InsuranceCheck)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.ProviderID)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.RequiringDepartment)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.WorkingFrom)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.WorkingTo)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.QualificationRequire)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.CloseCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.CreateWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.ModifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.ModifiedWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.LockFlag)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.LockUser)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.CrossDayCheck)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.CreateUserDeptID)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.AllowEnterCar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWork>()
                .Property(e => e.ContractModifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWorkMan>()
                .Property(e => e.LocationID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWorkMan>()
                .Property(e => e.WorkType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWorkMan>()
                .Property(e => e.WorkID)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWorkMan>()
                .Property(e => e.ProviderID)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWorkMan>()
                .Property(e => e.OccupationalHazardsCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWorkMan>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWorkMan>()
                .Property(e => e.CreateWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWorkMan>()
                .Property(e => e.ModifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWorkMan>()
                .Property(e => e.ModifiedWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWorkMan>()
                .Property(e => e.LockFlag)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWorkMan>()
                .Property(e => e.LockUser)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWorkMan>()
                .Property(e => e.OccupationalMan)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWorkMan>()
                .Property(e => e.InsuranceStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWorkMan>()
                .Property(e => e.HealthCheckUpStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWorkMan>()
                .Property(e => e.IdentityID)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceWorkMan>()
                .Property(e => e.OvertimeCheck)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MASSystemParameter>()
                .Property(e => e.ParameterTabID)
                .IsUnicode(false);

            modelBuilder.Entity<MASSystemParameter>()
                .Property(e => e.DefinitionCode)
                .IsUnicode(false);

            modelBuilder.Entity<MASSystemParameter>()
                .Property(e => e.DefinitionValue)
                .IsUnicode(false);

            modelBuilder.Entity<MASSystemParameter>()
                .Property(e => e.StatusCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MASSystemParameter>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<MASSystemParameter>()
                .Property(e => e.CreateWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<MASSystemParameter>()
                .Property(e => e.ModifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<MASSystemParameter>()
                .Property(e => e.ModifiedWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<MASSystemParameter>()
                .Property(e => e.LockFlag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MASSystemParameter>()
                .Property(e => e.LockUser)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.TransactFlag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.VendorID)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.VatNo)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.PhoneNo)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.FaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.ContactPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.ContactMphone)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.ContactEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.AreaID)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.ActiveFlag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.CreateWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.ModifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.ModifiedWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.LockFlag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.LockUser)
                .IsUnicode(false);

            modelBuilder.Entity<VisitFactory>()
                .Property(e => e.LocationID)
                .IsUnicode(false);

            modelBuilder.Entity<VisitFactory>()
                .Property(e => e.VendorID)
                .IsUnicode(false);

            modelBuilder.Entity<VisitFactory>()
                .Property(e => e.ProjectID)
                .IsUnicode(false);

            modelBuilder.Entity<VisitFactory>()
                .Property(e => e.ReceptionDept)
                .IsUnicode(false);

            modelBuilder.Entity<VisitFactory>()
                .Property(e => e.VisitID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VisitFactory>()
                .Property(e => e.IDnumber)
                .IsUnicode(false);

            modelBuilder.Entity<VisitFactory>()
                .Property(e => e.ContactPhone)
                .IsUnicode(false);

            modelBuilder.Entity<VisitFactory>()
                .Property(e => e.CertificateType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VisitFactory>()
                .Property(e => e.CertificateID)
                .IsUnicode(false);

            modelBuilder.Entity<VisitFactory>()
                .Property(e => e.SendMail)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VisitFactory>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<VisitFactory>()
                .Property(e => e.CreateWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<VisitFactory>()
                .Property(e => e.ModifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<VisitFactory>()
                .Property(e => e.ModifiedWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<VisitFactory>()
                .Property(e => e.LockFlag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VisitFactory>()
                .Property(e => e.LockUser)
                .IsUnicode(false);

            modelBuilder.Entity<WorkTypes>()
                .Property(e => e.WorkType)
                .IsUnicode(false);

            modelBuilder.Entity<WorkTypes>()
                .Property(e => e.WorkTypeBrief)
                .IsUnicode(false);

            modelBuilder.Entity<WorkTypes>()
                .Property(e => e.ValidDepartment)
                .IsUnicode(false);

            modelBuilder.Entity<WorkTypes>()
                .Property(e => e.ExceptDepartment)
                .IsUnicode(false);

            modelBuilder.Entity<WorkTypes>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<WorkTypes>()
                .Property(e => e.CreateWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<WorkTypes>()
                .Property(e => e.ModifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<WorkTypes>()
                .Property(e => e.ModifiedWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<WorkTypes>()
                .Property(e => e.LockFlag)
                .IsUnicode(false);

            modelBuilder.Entity<WorkTypes>()
                .Property(e => e.LockUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.ProviderID)
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.WorkType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.WorkID)
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.RequiringDepartment)
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.WorkingFrom)
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.WorkingTo)
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.QualificationRequire)
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.CloseCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.CreateWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.ModifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.ModifiedWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.InsuranceCheck)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.CrossDayCheck)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.CreateUserDeptID)
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.OccupationalHazardsCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.LocationID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.BadgeNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.AllowEnterCar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.OccupationalMan)
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.ContractModifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.IdentityID)
                .IsUnicode(false);

            modelBuilder.Entity<View_AccessApplication>()
                .Property(e => e.InsuranceStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.WorkID)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.WorkType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.InsuranceCheck)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.RequiringDepartment)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.WorkingFrom)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.WorkingTo)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.CloseCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.ProviderID)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.LocationID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.CrossDayCheck)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.CreateWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.AllowEnterCar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.OccupationalHazardsCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.CreateUserDeptID)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.MailContactPerson)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.ProviderName)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.BadgeNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.InsuranceStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.HealthCheckUpStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEnterPerson>()
                .Property(e => e.IdentityID)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.LocationID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.WorkType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.WorkID)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.RequiringDepartment)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.WorkingFrom)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.WorkingTo)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.InsuranceCheck)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.ProviderID)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.CloseCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.CreateWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.ModifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.ModifiedWorkstationID)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.CreateUserDeptID)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.CrossDayCheck)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.MailContactPerson)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.QualificationRequire)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.OccupationalHazardsCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.ProviderName)
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.ProviderType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.VoidCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<View_AllEntrance>()
                .Property(e => e.AllowEnterCar)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
