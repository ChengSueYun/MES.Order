
namespace MES.Order.UI
{
    partial class ChartData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.productsOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldArea1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCustomName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCount1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductGroupID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTotalPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTotalCost1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTotalProfit1 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.pivotGridControl1.DataSource = this.productsOrdersBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldArea1,
            this.fieldCustomName1,
            this.fieldCount1,
            this.pivotGridField1,
            this.fieldOrderDate1,
            this.fieldProductGroupID1,
            this.fieldPrice1,
            this.fieldTotalPrice1,
            this.fieldTotalCost1,
            this.fieldTotalProfit1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsBehavior.UseAsyncMode = true;
            this.pivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText;
            this.pivotGridControl1.OptionsDataField.RowHeaderWidth = 300;
            this.pivotGridControl1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.pivotGridControl1.OptionsView.RowTreeWidth = 300;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotalHeader = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(900, 566);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // productsOrdersBindingSource
            // 
            this.productsOrdersBindingSource.DataSource = typeof(MES.Order.DAL.EntityFramework.ProductsOrder);
            // 
            // fieldArea1
            // 
            this.fieldArea1.Appearance.Cell.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldArea1.Appearance.Cell.Options.UseFont = true;
            this.fieldArea1.Appearance.CellGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldArea1.Appearance.CellGrandTotal.Options.UseFont = true;
            this.fieldArea1.Appearance.CellTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldArea1.Appearance.CellTotal.Options.UseFont = true;
            this.fieldArea1.Appearance.Header.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldArea1.Appearance.Header.Options.UseFont = true;
            this.fieldArea1.Appearance.Value.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldArea1.Appearance.Value.Options.UseFont = true;
            this.fieldArea1.Appearance.ValueGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldArea1.Appearance.ValueGrandTotal.Options.UseFont = true;
            this.fieldArea1.Appearance.ValueTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldArea1.Appearance.ValueTotal.Options.UseFont = true;
            this.fieldArea1.AreaIndex = 0;
            this.fieldArea1.Caption = "地區";
            this.fieldArea1.FieldName = "Area";
            this.fieldArea1.MinWidth = 15;
            this.fieldArea1.Name = "fieldArea1";
            this.fieldArea1.Width = 75;
            // 
            // fieldCustomName1
            // 
            this.fieldCustomName1.Appearance.Cell.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldCustomName1.Appearance.Cell.Options.UseFont = true;
            this.fieldCustomName1.Appearance.CellGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldCustomName1.Appearance.CellGrandTotal.Options.UseFont = true;
            this.fieldCustomName1.Appearance.CellTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldCustomName1.Appearance.CellTotal.Options.UseFont = true;
            this.fieldCustomName1.Appearance.Header.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldCustomName1.Appearance.Header.Options.UseFont = true;
            this.fieldCustomName1.Appearance.Value.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldCustomName1.Appearance.Value.Options.UseFont = true;
            this.fieldCustomName1.Appearance.ValueGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldCustomName1.Appearance.ValueGrandTotal.Options.UseFont = true;
            this.fieldCustomName1.Appearance.ValueTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldCustomName1.Appearance.ValueTotal.Options.UseFont = true;
            this.fieldCustomName1.AreaIndex = 1;
            this.fieldCustomName1.Caption = "客戶";
            this.fieldCustomName1.FieldName = "CustomName";
            this.fieldCustomName1.MinWidth = 15;
            this.fieldCustomName1.Name = "fieldCustomName1";
            this.fieldCustomName1.Width = 75;
            // 
            // fieldCount1
            // 
            this.fieldCount1.Appearance.Cell.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldCount1.Appearance.Cell.Options.UseFont = true;
            this.fieldCount1.Appearance.CellGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldCount1.Appearance.CellGrandTotal.Options.UseFont = true;
            this.fieldCount1.Appearance.CellTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldCount1.Appearance.CellTotal.Options.UseFont = true;
            this.fieldCount1.Appearance.Header.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldCount1.Appearance.Header.Options.UseFont = true;
            this.fieldCount1.Appearance.Value.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldCount1.Appearance.Value.Options.UseFont = true;
            this.fieldCount1.Appearance.ValueGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldCount1.Appearance.ValueGrandTotal.Options.UseFont = true;
            this.fieldCount1.Appearance.ValueTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldCount1.Appearance.ValueTotal.Options.UseFont = true;
            this.fieldCount1.AreaIndex = 3;
            this.fieldCount1.Caption = "訂購數量";
            this.fieldCount1.FieldName = "Count";
            this.fieldCount1.MinWidth = 15;
            this.fieldCount1.Name = "fieldCount1";
            this.fieldCount1.Width = 75;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Appearance.Cell.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.pivotGridField1.Appearance.Cell.Options.UseFont = true;
            this.pivotGridField1.Appearance.CellGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.pivotGridField1.Appearance.CellGrandTotal.Options.UseFont = true;
            this.pivotGridField1.Appearance.CellTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.pivotGridField1.Appearance.CellTotal.Options.UseFont = true;
            this.pivotGridField1.Appearance.Header.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.pivotGridField1.Appearance.Header.Options.UseFont = true;
            this.pivotGridField1.Appearance.Value.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.pivotGridField1.Appearance.Value.Options.UseFont = true;
            this.pivotGridField1.Appearance.ValueGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.pivotGridField1.Appearance.ValueGrandTotal.Options.UseFont = true;
            this.pivotGridField1.Appearance.ValueTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.pivotGridField1.Appearance.ValueTotal.Options.UseFont = true;
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "訂購年";
            this.pivotGridField1.FieldName = "OrderDate";
            this.pivotGridField1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.pivotGridField1.MinWidth = 15;
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.UnboundFieldName = "pivotGridField1";
            this.pivotGridField1.Width = 75;
            // 
            // fieldOrderDate1
            // 
            this.fieldOrderDate1.Appearance.Cell.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldOrderDate1.Appearance.Cell.Options.UseFont = true;
            this.fieldOrderDate1.Appearance.CellGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldOrderDate1.Appearance.CellGrandTotal.Options.UseFont = true;
            this.fieldOrderDate1.Appearance.CellTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldOrderDate1.Appearance.CellTotal.Options.UseFont = true;
            this.fieldOrderDate1.Appearance.Header.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldOrderDate1.Appearance.Header.Options.UseFont = true;
            this.fieldOrderDate1.Appearance.Value.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldOrderDate1.Appearance.Value.Options.UseFont = true;
            this.fieldOrderDate1.Appearance.ValueGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldOrderDate1.Appearance.ValueGrandTotal.Options.UseFont = true;
            this.fieldOrderDate1.Appearance.ValueTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldOrderDate1.Appearance.ValueTotal.Options.UseFont = true;
            this.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldOrderDate1.AreaIndex = 1;
            this.fieldOrderDate1.Caption = "訂購月";
            this.fieldOrderDate1.FieldName = "OrderDate";
            this.fieldOrderDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldOrderDate1.MinWidth = 15;
            this.fieldOrderDate1.Name = "fieldOrderDate1";
            this.fieldOrderDate1.UnboundFieldName = "fieldOrderDate1";
            this.fieldOrderDate1.UseNativeFormat = DevExpress.Utils.DefaultBoolean.True;
            this.fieldOrderDate1.Width = 75;
            // 
            // fieldProductGroupID1
            // 
            this.fieldProductGroupID1.Appearance.Cell.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldProductGroupID1.Appearance.Cell.Options.UseFont = true;
            this.fieldProductGroupID1.Appearance.CellGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldProductGroupID1.Appearance.CellGrandTotal.Options.UseFont = true;
            this.fieldProductGroupID1.Appearance.CellTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldProductGroupID1.Appearance.CellTotal.Options.UseFont = true;
            this.fieldProductGroupID1.Appearance.Header.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldProductGroupID1.Appearance.Header.Options.UseFont = true;
            this.fieldProductGroupID1.Appearance.Value.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldProductGroupID1.Appearance.Value.Options.UseFont = true;
            this.fieldProductGroupID1.Appearance.ValueGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldProductGroupID1.Appearance.ValueGrandTotal.Options.UseFont = true;
            this.fieldProductGroupID1.Appearance.ValueTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldProductGroupID1.Appearance.ValueTotal.Options.UseFont = true;
            this.fieldProductGroupID1.AreaIndex = 2;
            this.fieldProductGroupID1.Caption = "廠商";
            this.fieldProductGroupID1.FieldName = "ProductGroupID";
            this.fieldProductGroupID1.MinWidth = 15;
            this.fieldProductGroupID1.Name = "fieldProductGroupID1";
            this.fieldProductGroupID1.Width = 75;
            // 
            // fieldPrice1
            // 
            this.fieldPrice1.Appearance.Cell.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldPrice1.Appearance.Cell.Options.UseFont = true;
            this.fieldPrice1.Appearance.CellGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldPrice1.Appearance.CellGrandTotal.Options.UseFont = true;
            this.fieldPrice1.Appearance.CellTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldPrice1.Appearance.CellTotal.Options.UseFont = true;
            this.fieldPrice1.Appearance.Header.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldPrice1.Appearance.Header.Options.UseFont = true;
            this.fieldPrice1.Appearance.Value.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldPrice1.Appearance.Value.Options.UseFont = true;
            this.fieldPrice1.Appearance.ValueGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldPrice1.Appearance.ValueGrandTotal.Options.UseFont = true;
            this.fieldPrice1.Appearance.ValueTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldPrice1.Appearance.ValueTotal.Options.UseFont = true;
            this.fieldPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPrice1.AreaIndex = 0;
            this.fieldPrice1.Caption = "售價";
            this.fieldPrice1.CellFormat.FormatString = "N0";
            this.fieldPrice1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldPrice1.FieldName = "Price";
            this.fieldPrice1.GrandTotalCellFormat.FormatString = "N0";
            this.fieldPrice1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldPrice1.MinWidth = 15;
            this.fieldPrice1.Name = "fieldPrice1";
            this.fieldPrice1.TotalCellFormat.FormatString = "N0";
            this.fieldPrice1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldPrice1.TotalValueFormat.FormatString = "N0";
            this.fieldPrice1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldPrice1.ValueFormat.FormatString = "N0";
            this.fieldPrice1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldPrice1.Visible = false;
            this.fieldPrice1.Width = 75;
            // 
            // fieldTotalPrice1
            // 
            this.fieldTotalPrice1.Appearance.Cell.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalPrice1.Appearance.Cell.Options.UseFont = true;
            this.fieldTotalPrice1.Appearance.CellGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalPrice1.Appearance.CellGrandTotal.Options.UseFont = true;
            this.fieldTotalPrice1.Appearance.CellTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalPrice1.Appearance.CellTotal.Options.UseFont = true;
            this.fieldTotalPrice1.Appearance.Header.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalPrice1.Appearance.Header.Options.UseFont = true;
            this.fieldTotalPrice1.Appearance.Value.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalPrice1.Appearance.Value.Options.UseFont = true;
            this.fieldTotalPrice1.Appearance.ValueGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalPrice1.Appearance.ValueGrandTotal.Options.UseFont = true;
            this.fieldTotalPrice1.Appearance.ValueTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalPrice1.Appearance.ValueTotal.Options.UseFont = true;
            this.fieldTotalPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldTotalPrice1.AreaIndex = 0;
            this.fieldTotalPrice1.Caption = "總售價";
            this.fieldTotalPrice1.CellFormat.FormatString = "N0";
            this.fieldTotalPrice1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldTotalPrice1.FieldName = "TotalPrice";
            this.fieldTotalPrice1.GrandTotalCellFormat.FormatString = "N0";
            this.fieldTotalPrice1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldTotalPrice1.MinWidth = 15;
            this.fieldTotalPrice1.Name = "fieldTotalPrice1";
            this.fieldTotalPrice1.TotalCellFormat.FormatString = "N0";
            this.fieldTotalPrice1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldTotalPrice1.TotalValueFormat.FormatString = "N0";
            this.fieldTotalPrice1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldTotalPrice1.ValueFormat.FormatString = "N0";
            this.fieldTotalPrice1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldTotalPrice1.Width = 75;
            // 
            // fieldTotalCost1
            // 
            this.fieldTotalCost1.Appearance.Cell.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalCost1.Appearance.Cell.Options.UseFont = true;
            this.fieldTotalCost1.Appearance.CellGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalCost1.Appearance.CellGrandTotal.Options.UseFont = true;
            this.fieldTotalCost1.Appearance.CellTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalCost1.Appearance.CellTotal.Options.UseFont = true;
            this.fieldTotalCost1.Appearance.Header.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalCost1.Appearance.Header.Options.UseFont = true;
            this.fieldTotalCost1.Appearance.Value.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalCost1.Appearance.Value.Options.UseFont = true;
            this.fieldTotalCost1.Appearance.ValueGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalCost1.Appearance.ValueGrandTotal.Options.UseFont = true;
            this.fieldTotalCost1.Appearance.ValueTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalCost1.Appearance.ValueTotal.Options.UseFont = true;
            this.fieldTotalCost1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldTotalCost1.AreaIndex = 1;
            this.fieldTotalCost1.Caption = "總批價";
            this.fieldTotalCost1.CellFormat.FormatString = "N0";
            this.fieldTotalCost1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldTotalCost1.FieldName = "TotalCost";
            this.fieldTotalCost1.GrandTotalCellFormat.FormatString = "N0";
            this.fieldTotalCost1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldTotalCost1.MinWidth = 15;
            this.fieldTotalCost1.Name = "fieldTotalCost1";
            this.fieldTotalCost1.TotalCellFormat.FormatString = "N0";
            this.fieldTotalCost1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldTotalCost1.TotalValueFormat.FormatString = "N0";
            this.fieldTotalCost1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldTotalCost1.ValueFormat.FormatString = "N0";
            this.fieldTotalCost1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldTotalCost1.Width = 75;
            // 
            // fieldTotalProfit1
            // 
            this.fieldTotalProfit1.Appearance.Cell.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalProfit1.Appearance.Cell.Options.UseFont = true;
            this.fieldTotalProfit1.Appearance.CellGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalProfit1.Appearance.CellGrandTotal.Options.UseFont = true;
            this.fieldTotalProfit1.Appearance.CellTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalProfit1.Appearance.CellTotal.Options.UseFont = true;
            this.fieldTotalProfit1.Appearance.Header.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalProfit1.Appearance.Header.Options.UseFont = true;
            this.fieldTotalProfit1.Appearance.Value.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalProfit1.Appearance.Value.Options.UseFont = true;
            this.fieldTotalProfit1.Appearance.ValueGrandTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalProfit1.Appearance.ValueGrandTotal.Options.UseFont = true;
            this.fieldTotalProfit1.Appearance.ValueTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.fieldTotalProfit1.Appearance.ValueTotal.Options.UseFont = true;
            this.fieldTotalProfit1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldTotalProfit1.AreaIndex = 2;
            this.fieldTotalProfit1.Caption = "總利潤";
            this.fieldTotalProfit1.CellFormat.FormatString = "N0";
            this.fieldTotalProfit1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldTotalProfit1.FieldName = "TotalProfit";
            this.fieldTotalProfit1.GrandTotalCellFormat.FormatString = "N0";
            this.fieldTotalProfit1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldTotalProfit1.MinWidth = 15;
            this.fieldTotalProfit1.Name = "fieldTotalProfit1";
            this.fieldTotalProfit1.TotalCellFormat.FormatString = "N0";
            this.fieldTotalProfit1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldTotalProfit1.TotalValueFormat.FormatString = "N0";
            this.fieldTotalProfit1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldTotalProfit1.ValueFormat.FormatString = "N0";
            this.fieldTotalProfit1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldTotalProfit1.Width = 75;
            // 
            // ChartData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChartData";
            this.Size = new System.Drawing.Size(900, 566);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.BindingSource productsOrdersBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldArea1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCustomName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCount1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductGroupID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTotalPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTotalCost1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTotalProfit1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
    }
}
