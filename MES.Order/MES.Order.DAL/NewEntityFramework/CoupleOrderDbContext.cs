using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace MES.Order.DAL.NewEntityFramework
{
    public partial class CoupleOrderDbContext : DbContext
    {
        public CoupleOrderDbContext()
            : base("name=CoupleOrderDbContext")
        {
        }

        public CoupleOrderDbContext(string connectionStringName) : base(connectionStringName)
        {
        }

        public static void Close(CoupleOrderDbContext dbContext)
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

        public static CoupleOrderDbContext Create(string connectionStringName)
        {
            var dbContext = new CoupleOrderDbContext(connectionStringName);

            dbContext.Configuration.AutoDetectChangesEnabled = false;
            dbContext.Configuration.LazyLoadingEnabled       = false;
            dbContext.Configuration.ProxyCreationEnabled     = false;

            return dbContext;
        }

        public static CoupleOrderDbContext CreateAndOpen(string connectionStringName)
        {
            var dbContext    = Create(connectionStringName);
            var dbConnection = dbContext.Database.Connection;
            if (dbConnection.State == ConnectionState.Closed)
            {
                dbConnection.Open();
            }
            return dbContext;
        }

        public virtual DbSet<AreaInfo> AreaInfoes { get; set; }
        public virtual DbSet<CustomInfo> CustomInfoes { get; set; }
        public virtual DbSet<FactoryInfo> FactoryInfoes { get; set; }
        public virtual DbSet<OrderInfo> OrderInfoes { get; set; }
        public virtual DbSet<ProductsInfo> ProductsInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomInfo>()
                .Property(e => e.FaceBookId)
                .IsUnicode(false);

            modelBuilder.Entity<FactoryInfo>()
                .Property(e => e.Factory)
                .IsUnicode(false);

            modelBuilder.Entity<OrderInfo>()
                .Property(e => e.Factory)
                .IsUnicode(false);

            modelBuilder.Entity<OrderInfo>()
                .Property(e => e.ColorSpec)
                .IsUnicode(false);

            modelBuilder.Entity<OrderInfo>()
                .Property(e => e.SizSpec)
                .IsUnicode(false);

            modelBuilder.Entity<OrderInfo>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<ProductsInfo>()
                .Property(e => e.Factory)
                .IsUnicode(false);

            modelBuilder.Entity<ProductsInfo>()
                .Property(e => e.ProductType)
                .IsUnicode(false);
        }
    }
}
