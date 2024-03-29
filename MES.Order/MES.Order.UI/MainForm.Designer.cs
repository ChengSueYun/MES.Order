
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
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.orderNewDocument = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.chartDataDocument = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.document2 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.document3 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNewDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentGroup1
            // 
            this.documentGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.orderNewDocument,
            this.chartDataDocument,
            this.document1,
            this.document2,
            this.document3});
            // 
            // orderNewDocument
            // 
            this.orderNewDocument.Caption = "OrderNew2023";
            this.orderNewDocument.ControlName = "OrderNew";
            this.orderNewDocument.ControlTypeName = "MES.Order.UI.New.OrderNew";
            // 
            // chartDataDocument
            // 
            this.chartDataDocument.Appearance.Header.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.chartDataDocument.Appearance.Header.Options.UseFont = true;
            this.chartDataDocument.Caption = "彙總";
            this.chartDataDocument.ControlName = "ChartData";
            this.chartDataDocument.ControlTypeName = "MES.Order.UI.ChartData";
            // 
            // document1
            // 
            this.document1.Appearance.Header.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.document1.Appearance.Header.Options.UseFont = true;
            this.document1.Caption = "訂單";
            this.document1.ControlName = "Order";
            this.document1.ControlTypeName = "MES.Order.UI.Order";
            // 
            // document2
            // 
            this.document2.Appearance.Header.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.document2.Appearance.Header.Options.UseFont = true;
            this.document2.Caption = "客戶";
            this.document2.ControlName = "Customer";
            this.document2.ControlTypeName = "MES.Order.UI.Customer";
            // 
            // document3
            // 
            this.document3.Appearance.Header.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.document3.Appearance.Header.Options.UseFont = true;
            this.document3.Caption = "產品";
            this.document3.ControlName = "ProductInformation";
            this.document3.ControlTypeName = "MES.Order.UI.ProductInformation";
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.documentGroup1});
            this.tabbedView1.DocumentProperties.AllowClose = false;
            this.tabbedView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.document1,
            this.document2,
            this.document3,
            this.chartDataDocument,
            this.orderNewDocument});
            dockingContainer1.Element = this.documentGroup1;
            this.tabbedView1.RootContainer.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            dockingContainer1});
            this.tabbedView1.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Classic;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(408, 9);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(82, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // MainForm
            // 
            this.AllowMdiBar = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 730);
            this.Controls.Add(this.simpleButton1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小夫妻程式";
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNewDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
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
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document2;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document3;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document chartDataDocument;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document orderNewDocument;
    }
}