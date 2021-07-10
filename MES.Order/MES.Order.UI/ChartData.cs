using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Threading;
using MES.Order.DAL.EntityFramework;
using THS.Infrastructure.Extensions;

namespace MES.Order.UI
{
    public partial class ChartData : UserControl
    {
       
        public ChartData()
        {
            this.InitializeComponent();
            var task1 = Task.Run(this.LoadAsync);
        }

        private void LoadAsync()
        {
            var dbContext = new ProductsDbContext();
            dbContext.ProductsOrders.Load();
            var productsOrders = dbContext.ProductsOrders.Local.ToBindingList();
            this.productsOrdersBindingSource.DataSource = productsOrders;
            this.pivotGridControl1.RefreshData();
        }

    }
}