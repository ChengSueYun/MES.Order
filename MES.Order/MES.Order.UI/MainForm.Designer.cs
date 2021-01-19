
namespace MES.Order.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.windowsUIView1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.tileContainer1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            this.OrderTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.orderDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.CustomerTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.customerDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.ProductInformationTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.productInformationDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductInformationTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInformationDocument)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.windowsUIView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView1});
            // 
            // windowsUIView1
            // 
            this.windowsUIView1.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.tileContainer1});
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.orderDocument,
            this.customerDocument,
            this.productInformationDocument});
            this.windowsUIView1.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.OrderTile,
            this.CustomerTile,
            this.ProductInformationTile});
            this.windowsUIView1.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.windowsUIView1_QueryControl);
            // 
            // tileContainer1
            // 
            this.tileContainer1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.OrderTile,
            this.CustomerTile,
            this.ProductInformationTile});
            this.tileContainer1.Name = "tileContainer1";
            // 
            // OrderTile
            // 
            this.OrderTile.Document = this.orderDocument;
            this.OrderTile.Name = "OrderTile";
            // 
            // orderDocument
            // 
            this.orderDocument.Caption = "Order";
            this.orderDocument.ControlName = "Order";
            this.orderDocument.ControlTypeName = "MES.Order.UI.Order";
            // 
            // CustomerTile
            // 
            this.CustomerTile.Document = this.customerDocument;
            this.tileContainer1.SetID(this.CustomerTile, 1);
            this.CustomerTile.Name = "CustomerTile";
            // 
            // customerDocument
            // 
            this.customerDocument.Caption = "Customer";
            this.customerDocument.ControlName = "Customer";
            this.customerDocument.ControlTypeName = "MES.Order.UI.Customer";
            // 
            // ProductInformationTile
            // 
            this.ProductInformationTile.Document = this.productInformationDocument;
            this.tileContainer1.SetID(this.ProductInformationTile, 2);
            this.ProductInformationTile.Name = "ProductInformationTile";
            // 
            // productInformationDocument
            // 
            this.productInformationDocument.Caption = "ProductInformation";
            this.productInformationDocument.ControlName = "ProductInformation";
            this.productInformationDocument.ControlTypeName = "MES.Order.UI.ProductInformation";
            // 
            // MainForm
            // 
            this.AllowMdiBar = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 730);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductInformationTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInformationDocument)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile OrderTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document orderDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile CustomerTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document customerDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile ProductInformationTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document productInformationDocument;
    }
}