using System.Data;
using System.Data.Entity;

namespace MES.Order.DAL.EntityFramework
{
    public class ProductsDbContext : DbContext
    {
        public virtual DbSet<Areas> Areas { get; set; }

        public virtual DbSet<Custom> Customs { get; set; }

        public virtual DbSet<ProductsGroupID> ProductGroupIDs { get; set; }

        public virtual DbSet<ProductsInfomation> ProductsInfomations { get; set; }

        public virtual DbSet<ProductsOrder> ProductsOrders { get; set; }

        public ProductsDbContext()
            : base("name=ProductsDbContext")
        {
        }

        public ProductsDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public static void Close(ProductsDbContext dbContext)
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

        public static ProductsDbContext Create(string connectionStringName)
        {
            var dbContext = new ProductsDbContext(connectionStringName);

            dbContext.Configuration.AutoDetectChangesEnabled = false;
            dbContext.Configuration.LazyLoadingEnabled       = false;
            dbContext.Configuration.ProxyCreationEnabled     = false;

            return dbContext;
        }

        public static ProductsDbContext CreateAndOpen(string connectionStringName)
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
            modelBuilder.Entity<Areas>()
                        .Property(e => e.Area)
                        .IsUnicode(false);

            modelBuilder.Entity<Areas>()
                        .Property(e => e.AreaName)
                        .IsUnicode(false);

            modelBuilder.Entity<ProductsGroupID>()
                        .Property(e => e.ProductGroupID)
                        .IsUnicode(false);

            modelBuilder.Entity<ProductsGroupID>()
                        .Property(e => e.ProductGroupName)
                        .IsUnicode(false);

            modelBuilder.Entity<ProductsInfomation>()
                        .Property(e => e.ProductName)
                        .IsUnicode(false);

            modelBuilder.Entity<ProductsInfomation>()
                        .Property(e => e.ProductGroupID)
                        .IsUnicode(false);

            modelBuilder.Entity<ProductsOrder>()
                        .Property(e => e.Area)
                        .IsUnicode(false);

            modelBuilder.Entity<ProductsOrder>()
                        .Property(e => e.CustomID)
                        .IsUnicode(false);

            modelBuilder.Entity<ProductsOrder>()
                        .Property(e => e.CustomName)
                        .IsUnicode(false);

            modelBuilder.Entity<ProductsOrder>()
                        .Property(e => e.Address)
                        .IsUnicode(false);

            modelBuilder.Entity<ProductsOrder>()
                        .Property(e => e.ProductGroupID)
                        .IsUnicode(false);

            modelBuilder.Entity<ProductsOrder>()
                        .Property(e => e.ProductName)
                        .IsUnicode(false);

            modelBuilder.Entity<ProductsOrder>()
                        .Property(e => e.Price)
                        .IsUnicode(false);

            modelBuilder.Entity<ProductsOrder>()
                        .Property(e => e.Note3)
                        .IsUnicode(false);

            modelBuilder.Entity<ProductsOrder>()
                        .Property(e => e.Note2)
                        .IsUnicode(false);

            modelBuilder.Entity<ProductsOrder>()
                        .Property(e => e.Note1)
                        .IsUnicode(false);
        }
    }
}