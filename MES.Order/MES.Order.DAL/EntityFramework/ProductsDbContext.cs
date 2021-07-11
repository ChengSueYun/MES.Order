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

        // public ProductsDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        // {
        // }
        //
        // public static void Close(ProductsDbContext dbContext)
        // {
        //     if (dbContext.Database.Connection != null)
        //     {
        //         var dbConnection = dbContext.Database.Connection;
        //         if (dbConnection.State == ConnectionState.Open)
        //         {
        //             dbConnection.Close();
        //         }
        //     }
        // }
        //
        // public static ProductsDbContext Create(string connectionStringName)
        // {
        //     var dbContext = new ProductsDbContext("ProductsDbContext");
        //
        //     dbContext.Configuration.AutoDetectChangesEnabled = false;
        //     dbContext.Configuration.LazyLoadingEnabled       = false;
        //     dbContext.Configuration.ProxyCreationEnabled     = false;
        //
        //     return dbContext;
        // }
        //
        // public static ProductsDbContext CreateAndOpen(string connectionStringName)
        // {
        //     var dbContext    = Create(connectionStringName);
        //     var dbConnection = dbContext.Database.Connection;
        //     if (dbConnection.State == ConnectionState.Closed)
        //     {
        //         dbConnection.Open();
        //     }
        //
        //     return dbContext;
        // }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}