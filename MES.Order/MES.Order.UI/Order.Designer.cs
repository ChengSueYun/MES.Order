namespace MES.Order.UI
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateEdit_OrderDateE = new DevExpress.XtraEditors.DateEdit();
            this.label_Area = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit_Area = new DevExpress.XtraEditors.LookUpEdit();
            this.label_CustomerName = new DevExpress.XtraEditors.LabelControl();
            this.lbl_ProductGroupID = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit_ProductGroupID = new DevExpress.XtraEditors.LookUpEdit();
            this.lbl_ProductName = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit_ProductName = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.keyAndNameForComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateEdit_OrderDateS = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label_OrderDate = new DevExpress.XtraEditors.LabelControl();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit_CustomerName = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_FocusRow = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_UnFocus = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Export = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.toggleSwitch_GroupColumn = new DevExpress.XtraEditors.ToggleSwitch();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lookUpEdit_addArea = new DevExpress.XtraEditors.LookUpEdit();
            this.addOrderViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LookUpEdit_addCustomerName = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEdit_addProductGroupID = new DevExpress.XtraEditors.LookUpEdit();
            this.LookUpEdit_addProductName = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalDescription2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinEdit_addCount = new DevExpress.XtraEditors.SpinEdit();
            this.textEdit_addTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_addNote1 = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_ProductOrder = new DevExpress.XtraGrid.GridControl();
            this.productsOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_ProductOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductGroupID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repository_Count = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repository_Note = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colSetAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repository_WhetherStock = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProfit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.pivotGrid_FocusOrder = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.FocusbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldNote1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCustomName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldArea = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTotalCost = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTotalPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTotalProfit = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAddress = new DevExpress.XtraPivotGrid.PivotGridField();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridControl_Focus = new DevExpress.XtraGrid.GridControl();
            this.gridView_Focus = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colAutoID1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colArea1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCustomID1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCustomName1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUpdateDate1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCount1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAddress1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOrderDate1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProductGroupID1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProductName1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPrice1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTotalPrice1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTotalCost1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTotalProfit1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNote31 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNote21 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNote11 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDateE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDateE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Area.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_ProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_ProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAndNameForComboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDateS.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDateS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_CustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_GroupColumn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_addArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addOrderViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_addCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_addProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_addProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_addCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_addTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_addNote1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ProductOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ProductOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_Note)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_WhetherStock)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGrid_FocusOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FocusbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Focus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Focus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.groupControl1.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.White;
            this.groupControl1.AppearanceCaption.BackColor2 = System.Drawing.Color.White;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.tableLayoutPanel1);
            this.groupControl1.Controls.Add(this.toggleSwitch_GroupColumn);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1122, 138);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "查詢";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.54403F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.91509F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.87284F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.46311F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.4427F));
            this.tableLayoutPanel1.Controls.Add(this.dateEdit_OrderDateE, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_Area, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEdit_Area, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_CustomerName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ProductGroupID, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEdit_ProductGroupID, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ProductName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEdit_ProductName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateEdit_OrderDateS, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_OrderDate, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Query, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEdit_CustomerName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_FocusRow, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Save, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_UnFocus, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Export, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Cancel, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Update, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.0303F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.87879F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 95);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dateEdit_OrderDateE
            // 
            this.dateEdit_OrderDateE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateEdit_OrderDateE.EditValue = new System.DateTime(2020, 10, 2, 16, 12, 40, 524);
            this.dateEdit_OrderDateE.Location = new System.Drawing.Point(953, 35);
            this.dateEdit_OrderDateE.Margin = new System.Windows.Forms.Padding(2);
            this.dateEdit_OrderDateE.Name = "dateEdit_OrderDateE";
            this.dateEdit_OrderDateE.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.dateEdit_OrderDateE.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_OrderDateE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_OrderDateE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_OrderDateE.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateEdit_OrderDateE.Properties.SelectionMode = DevExpress.XtraEditors.Repository.CalendarSelectionMode.Multiple;
            this.dateEdit_OrderDateE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEdit_OrderDateE.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit_OrderDateE.Size = new System.Drawing.Size(157, 24);
            this.dateEdit_OrderDateE.TabIndex = 374;
            this.dateEdit_OrderDateE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            // 
            // label_Area
            // 
            this.label_Area.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Area.Appearance.ForeColor = System.Drawing.Color.Black;
            this.label_Area.Appearance.Options.UseFont = true;
            this.label_Area.Appearance.Options.UseForeColor = true;
            this.label_Area.Appearance.Options.UseTextOptions = true;
            this.label_Area.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.label_Area.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.label_Area.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label_Area.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.label_Area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Area.Location = new System.Drawing.Point(5, 5);
            this.label_Area.Name = "label_Area";
            this.label_Area.Size = new System.Drawing.Size(151, 23);
            this.label_Area.TabIndex = 364;
            this.label_Area.Text = "地區";
            // 
            // lookUpEdit_Area
            // 
            this.lookUpEdit_Area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpEdit_Area.Location = new System.Drawing.Point(164, 5);
            this.lookUpEdit_Area.Name = "lookUpEdit_Area";
            this.lookUpEdit_Area.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lookUpEdit_Area.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.lookUpEdit_Area.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEdit_Area.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_Area.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lookUpEdit_Area.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_Area.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lookUpEdit_Area.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "代號", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocalDescription", "敘述", 17, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit_Area.Properties.DisplayMember = "Code";
            this.lookUpEdit_Area.Properties.MaxLength = 8;
            this.lookUpEdit_Area.Properties.NullText = "";
            this.lookUpEdit_Area.Properties.ValueMember = "Code";
            this.lookUpEdit_Area.Size = new System.Drawing.Size(151, 26);
            this.lookUpEdit_Area.TabIndex = 365;
            this.lookUpEdit_Area.TabStop = false;
            this.lookUpEdit_Area.EditValueChanged += new System.EventHandler(this.lookUpEdit_Area_EditValueChanged);
            this.lookUpEdit_Area.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            // 
            // label_CustomerName
            // 
            this.label_CustomerName.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label_CustomerName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.label_CustomerName.Appearance.Options.UseFont = true;
            this.label_CustomerName.Appearance.Options.UseForeColor = true;
            this.label_CustomerName.Appearance.Options.UseTextOptions = true;
            this.label_CustomerName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.label_CustomerName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.label_CustomerName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label_CustomerName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.label_CustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_CustomerName.Location = new System.Drawing.Point(323, 5);
            this.label_CustomerName.Name = "label_CustomerName";
            this.label_CustomerName.Size = new System.Drawing.Size(153, 23);
            this.label_CustomerName.TabIndex = 366;
            this.label_CustomerName.Text = "客戶名稱";
            // 
            // lbl_ProductGroupID
            // 
            this.lbl_ProductGroupID.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_ProductGroupID.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbl_ProductGroupID.Appearance.Options.UseFont = true;
            this.lbl_ProductGroupID.Appearance.Options.UseForeColor = true;
            this.lbl_ProductGroupID.Appearance.Options.UseTextOptions = true;
            this.lbl_ProductGroupID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbl_ProductGroupID.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbl_ProductGroupID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_ProductGroupID.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lbl_ProductGroupID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ProductGroupID.Location = new System.Drawing.Point(639, 5);
            this.lbl_ProductGroupID.Name = "lbl_ProductGroupID";
            this.lbl_ProductGroupID.Size = new System.Drawing.Size(135, 23);
            this.lbl_ProductGroupID.TabIndex = 12;
            this.lbl_ProductGroupID.Text = "廠商名稱";
            // 
            // lookUpEdit_ProductGroupID
            // 
            this.lookUpEdit_ProductGroupID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpEdit_ProductGroupID.Location = new System.Drawing.Point(782, 5);
            this.lookUpEdit_ProductGroupID.Name = "lookUpEdit_ProductGroupID";
            this.lookUpEdit_ProductGroupID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lookUpEdit_ProductGroupID.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.lookUpEdit_ProductGroupID.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEdit_ProductGroupID.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_ProductGroupID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lookUpEdit_ProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_ProductGroupID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lookUpEdit_ProductGroupID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "代號", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocalDescription", "敘述", 17, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit_ProductGroupID.Properties.DisplayMember = "Code";
            this.lookUpEdit_ProductGroupID.Properties.MaxLength = 8;
            this.lookUpEdit_ProductGroupID.Properties.NullText = "";
            this.lookUpEdit_ProductGroupID.Properties.ValueMember = "Code";
            this.lookUpEdit_ProductGroupID.Size = new System.Drawing.Size(164, 26);
            this.lookUpEdit_ProductGroupID.TabIndex = 360;
            this.lookUpEdit_ProductGroupID.TabStop = false;
            this.lookUpEdit_ProductGroupID.EditValueChanged += new System.EventHandler(this.lookUpEdit_ProductGroupID_EditValueChanged);
            this.lookUpEdit_ProductGroupID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_ProductName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbl_ProductName.Appearance.Options.UseFont = true;
            this.lbl_ProductName.Appearance.Options.UseForeColor = true;
            this.lbl_ProductName.Appearance.Options.UseTextOptions = true;
            this.lbl_ProductName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbl_ProductName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbl_ProductName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_ProductName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lbl_ProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ProductName.Location = new System.Drawing.Point(5, 36);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(151, 18);
            this.lbl_ProductName.TabIndex = 50;
            this.lbl_ProductName.Text = "產品名稱";
            // 
            // lookUpEdit_ProductName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lookUpEdit_ProductName, 2);
            this.lookUpEdit_ProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpEdit_ProductName.Location = new System.Drawing.Point(163, 35);
            this.lookUpEdit_ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.lookUpEdit_ProductName.Name = "lookUpEdit_ProductName";
            this.lookUpEdit_ProductName.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.lookUpEdit_ProductName.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_ProductName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lookUpEdit_ProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_ProductName.Properties.DataSource = this.keyAndNameForComboBindingSource;
            this.lookUpEdit_ProductName.Properties.DisplayMember = "Code";
            this.lookUpEdit_ProductName.Properties.NullText = "";
            this.lookUpEdit_ProductName.Properties.PopupView = this.searchLookUpEdit1View;
            this.lookUpEdit_ProductName.Properties.ValueMember = "Code";
            this.lookUpEdit_ProductName.Size = new System.Drawing.Size(314, 26);
            this.lookUpEdit_ProductName.TabIndex = 362;
            this.lookUpEdit_ProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            // 
            // keyAndNameForComboBindingSource
            // 
            this.keyAndNameForComboBindingSource.DataSource = typeof(MES.Order.DAL.ViewModel.KeyAndNameForCombo);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colLocalDescription});
            this.searchLookUpEdit1View.DetailHeight = 272;
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.searchLookUpEdit1View.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.searchLookUpEdit1View.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.searchLookUpEdit1View.OptionsView.ShowIndicator = false;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 17;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 66;
            // 
            // colLocalDescription
            // 
            this.colLocalDescription.FieldName = "LocalDescription";
            this.colLocalDescription.MinWidth = 17;
            this.colLocalDescription.Name = "colLocalDescription";
            this.colLocalDescription.Width = 66;
            // 
            // dateEdit_OrderDateS
            // 
            this.dateEdit_OrderDateS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateEdit_OrderDateS.EditValue = new System.DateTime(2020, 10, 2, 16, 12, 40, 524);
            this.dateEdit_OrderDateS.Location = new System.Drawing.Point(638, 35);
            this.dateEdit_OrderDateS.Margin = new System.Windows.Forms.Padding(2);
            this.dateEdit_OrderDateS.Name = "dateEdit_OrderDateS";
            this.dateEdit_OrderDateS.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.dateEdit_OrderDateS.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_OrderDateS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_OrderDateS.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit_OrderDateS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_OrderDateS.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "d";
            this.dateEdit_OrderDateS.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_OrderDateS.Properties.CalendarTimeProperties.EditFormat.FormatString = "d";
            this.dateEdit_OrderDateS.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_OrderDateS.Properties.CalendarTimeProperties.Mask.EditMask = "d";
            this.dateEdit_OrderDateS.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateEdit_OrderDateS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEdit_OrderDateS.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit_OrderDateS.Size = new System.Drawing.Size(137, 24);
            this.dateEdit_OrderDateS.TabIndex = 369;
            this.dateEdit_OrderDateS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(782, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(164, 18);
            this.labelControl1.TabIndex = 371;
            this.labelControl1.Text = "~";
            // 
            // label_OrderDate
            // 
            this.label_OrderDate.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label_OrderDate.Appearance.ForeColor = System.Drawing.Color.Black;
            this.label_OrderDate.Appearance.Options.UseFont = true;
            this.label_OrderDate.Appearance.Options.UseForeColor = true;
            this.label_OrderDate.Appearance.Options.UseTextOptions = true;
            this.label_OrderDate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.label_OrderDate.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.label_OrderDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label_OrderDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.label_OrderDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_OrderDate.Location = new System.Drawing.Point(484, 36);
            this.label_OrderDate.Name = "label_OrderDate";
            this.label_OrderDate.Size = new System.Drawing.Size(147, 18);
            this.label_OrderDate.TabIndex = 368;
            this.label_OrderDate.Text = "訂貨日期";
            // 
            // btn_Query
            // 
            this.btn_Query.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_Query.Appearance.BackColor2 = System.Drawing.Color.Khaki;
            this.btn_Query.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_Query.Appearance.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Query.Appearance.Options.UseBackColor = true;
            this.btn_Query.Appearance.Options.UseFont = true;
            this.btn_Query.Appearance.Options.UseForeColor = true;
            this.btn_Query.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_Query.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Query.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Query.ImageOptions.Image")));
            this.btn_Query.Location = new System.Drawing.Point(954, 5);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(155, 23);
            this.btn_Query.TabIndex = 31;
            this.btn_Query.Text = "查詢(Enter)";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            this.btn_Query.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            // 
            // lookUpEdit_CustomerName
            // 
            this.lookUpEdit_CustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpEdit_CustomerName.Location = new System.Drawing.Point(483, 4);
            this.lookUpEdit_CustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.lookUpEdit_CustomerName.Name = "lookUpEdit_CustomerName";
            this.lookUpEdit_CustomerName.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.lookUpEdit_CustomerName.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_CustomerName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lookUpEdit_CustomerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_CustomerName.Properties.DisplayMember = "Code";
            this.lookUpEdit_CustomerName.Properties.NullText = "";
            this.lookUpEdit_CustomerName.Properties.PopupView = this.gridView1;
            this.lookUpEdit_CustomerName.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth;
            this.lookUpEdit_CustomerName.Properties.ValueMember = "Code";
            this.lookUpEdit_CustomerName.Size = new System.Drawing.Size(149, 26);
            this.lookUpEdit_CustomerName.TabIndex = 376;
            this.lookUpEdit_CustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.DetailHeight = 272;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Code";
            this.gridColumn1.MinWidth = 17;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 66;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "LocalDescription";
            this.gridColumn2.MinWidth = 17;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 66;
            // 
            // btn_FocusRow
            // 
            this.btn_FocusRow.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_FocusRow.Appearance.BackColor2 = System.Drawing.Color.Khaki;
            this.btn_FocusRow.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_FocusRow.Appearance.ForeColor = System.Drawing.Color.Sienna;
            this.btn_FocusRow.Appearance.Options.UseBackColor = true;
            this.btn_FocusRow.Appearance.Options.UseFont = true;
            this.btn_FocusRow.Appearance.Options.UseForeColor = true;
            this.btn_FocusRow.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_FocusRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_FocusRow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_FocusRow.ImageOptions.Image")));
            this.btn_FocusRow.Location = new System.Drawing.Point(5, 62);
            this.btn_FocusRow.Name = "btn_FocusRow";
            this.btn_FocusRow.Size = new System.Drawing.Size(151, 28);
            this.btn_FocusRow.TabIndex = 372;
            this.btn_FocusRow.Text = "鎖定列(F1)";
            this.btn_FocusRow.Click += new System.EventHandler(this.btn_FocusRow_Click);
            this.btn_FocusRow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_Save.Appearance.BackColor2 = System.Drawing.Color.Khaki;
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_Save.Appearance.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Save.Appearance.Options.UseBackColor = true;
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Appearance.Options.UseForeColor = true;
            this.btn_Save.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(954, 62);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(155, 28);
            this.btn_Save.TabIndex = 53;
            this.btn_Save.Text = "存檔(F5)";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            this.btn_Save.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            // 
            // btn_UnFocus
            // 
            this.btn_UnFocus.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_UnFocus.Appearance.BackColor2 = System.Drawing.Color.Khaki;
            this.btn_UnFocus.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_UnFocus.Appearance.ForeColor = System.Drawing.Color.Sienna;
            this.btn_UnFocus.Appearance.Options.UseBackColor = true;
            this.btn_UnFocus.Appearance.Options.UseFont = true;
            this.btn_UnFocus.Appearance.Options.UseForeColor = true;
            this.btn_UnFocus.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_UnFocus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_UnFocus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_UnFocus.ImageOptions.Image")));
            this.btn_UnFocus.Location = new System.Drawing.Point(323, 62);
            this.btn_UnFocus.Name = "btn_UnFocus";
            this.btn_UnFocus.Size = new System.Drawing.Size(153, 28);
            this.btn_UnFocus.TabIndex = 377;
            this.btn_UnFocus.Text = "清除鎖定列(F2)";
            this.btn_UnFocus.Visible = false;
            this.btn_UnFocus.Click += new System.EventHandler(this.btn_UnFocus_Click);
            this.btn_UnFocus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            // 
            // btn_Export
            // 
            this.btn_Export.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_Export.Appearance.BackColor2 = System.Drawing.Color.Khaki;
            this.btn_Export.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_Export.Appearance.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Export.Appearance.Options.UseBackColor = true;
            this.btn_Export.Appearance.Options.UseFont = true;
            this.btn_Export.Appearance.Options.UseForeColor = true;
            this.btn_Export.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_Export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Export.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Export.ImageOptions.Image")));
            this.btn_Export.Location = new System.Drawing.Point(164, 62);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(151, 28);
            this.btn_Export.TabIndex = 373;
            this.btn_Export.Text = "匯出";
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            this.btn_Export.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Appearance.BackColor = System.Drawing.Color.Orange;
            this.btn_Cancel.Appearance.BackColor2 = System.Drawing.Color.Aquamarine;
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_Cancel.Appearance.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Cancel.Appearance.Options.UseBackColor = true;
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Appearance.Options.UseForeColor = true;
            this.btn_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageOptions.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(782, 62);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(164, 28);
            this.btn_Cancel.TabIndex = 31;
            this.btn_Cancel.Text = "刪除(F3)";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_Update.Appearance.BackColor2 = System.Drawing.Color.LightSkyBlue;
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_Update.Appearance.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Update.Appearance.Options.UseBackColor = true;
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.Appearance.Options.UseForeColor = true;
            this.btn_Update.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.ImageOptions.Image")));
            this.btn_Update.Location = new System.Drawing.Point(639, 62);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(135, 28);
            this.btn_Update.TabIndex = 379;
            this.btn_Update.Text = "批次更新";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // toggleSwitch_GroupColumn
            // 
            this.toggleSwitch_GroupColumn.Location = new System.Drawing.Point(80, 5);
            this.toggleSwitch_GroupColumn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toggleSwitch_GroupColumn.Name = "toggleSwitch_GroupColumn";
            this.toggleSwitch_GroupColumn.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.toggleSwitch_GroupColumn.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.toggleSwitch_GroupColumn.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch_GroupColumn.Properties.Appearance.Options.UseForeColor = true;
            this.toggleSwitch_GroupColumn.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.toggleSwitch_GroupColumn.Properties.OffText = "取消群組支數";
            this.toggleSwitch_GroupColumn.Properties.OnText = "群組支數";
            this.toggleSwitch_GroupColumn.Size = new System.Drawing.Size(189, 26);
            this.toggleSwitch_GroupColumn.TabIndex = 378;
            this.toggleSwitch_GroupColumn.Toggled += new System.EventHandler(this.toggleSwitch_GroupColumn_Toggled);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 138);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1122, 536);
            this.splitContainer1.SplitterDistance = 92;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 8;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupControl2.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AutoSize = true;
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.tableLayoutPanel2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1122, 92);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "新增";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.937402F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.16275F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.14554F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.68232F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.77152F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.746479F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lookUpEdit_addArea, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LookUpEdit_addCustomerName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lookUpEdit_addProductGroupID, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.LookUpEdit_addProductName, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.spinEdit_addCount, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.textEdit_addTotalPrice, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.textEdit_addNote1, 6, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 33);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.57143F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.42857F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1118, 57);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(958, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "備註";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(872, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "總售價";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(718, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "數量";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(419, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "產品";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(272, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "廠商";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "地區";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(114, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "客戶名稱";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lookUpEdit_addArea
            // 
            this.lookUpEdit_addArea.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.addOrderViewModelBindingSource, "Area", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lookUpEdit_addArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpEdit_addArea.Location = new System.Drawing.Point(3, 23);
            this.lookUpEdit_addArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lookUpEdit_addArea.Name = "lookUpEdit_addArea";
            this.lookUpEdit_addArea.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.lookUpEdit_addArea.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_addArea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_addArea.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocalDescription", "Local Description", 155, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit_addArea.Properties.DataSource = this.keyAndNameForComboBindingSource;
            this.lookUpEdit_addArea.Properties.DisplayMember = "Code";
            this.lookUpEdit_addArea.Properties.NullText = "";
            this.lookUpEdit_addArea.Properties.ValueMember = "Code";
            this.lookUpEdit_addArea.Size = new System.Drawing.Size(105, 24);
            this.lookUpEdit_addArea.TabIndex = 7;
            this.lookUpEdit_addArea.EditValueChanged += new System.EventHandler(this.lookUpEdit_addArea_EditValueChanged);
            this.lookUpEdit_addArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            // 
            // addOrderViewModelBindingSource
            // 
            this.addOrderViewModelBindingSource.DataSource = typeof(MES.Order.DAL.ViewModel.AddOrderViewModel);
            // 
            // LookUpEdit_addCustomerName
            // 
            this.LookUpEdit_addCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.addOrderViewModelBindingSource, "CustomName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LookUpEdit_addCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LookUpEdit_addCustomerName.EditValue = "";
            this.LookUpEdit_addCustomerName.Location = new System.Drawing.Point(114, 23);
            this.LookUpEdit_addCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LookUpEdit_addCustomerName.Name = "LookUpEdit_addCustomerName";
            this.LookUpEdit_addCustomerName.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.LookUpEdit_addCustomerName.Properties.Appearance.Options.UseFont = true;
            this.LookUpEdit_addCustomerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_addCustomerName.Properties.DataSource = this.keyAndNameForComboBindingSource;
            this.LookUpEdit_addCustomerName.Properties.DisplayMember = "Code";
            this.LookUpEdit_addCustomerName.Properties.NullText = "";
            this.LookUpEdit_addCustomerName.Properties.PopupView = this.gridView3;
            this.LookUpEdit_addCustomerName.Properties.ValueMember = "Code";
            this.LookUpEdit_addCustomerName.Size = new System.Drawing.Size(152, 24);
            this.LookUpEdit_addCustomerName.TabIndex = 8;
            this.LookUpEdit_addCustomerName.EditValueChanged += new System.EventHandler(this.LookUpEdit_addCustomerName_EditValueChanged);
            this.LookUpEdit_addCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            this.LookUpEdit_addCustomerName.Leave += new System.EventHandler(this.LookUpEdit_addCustomerName_Leave);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode1,
            this.colLocalDescription1});
            this.gridView3.DetailHeight = 272;
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colCode1
            // 
            this.colCode1.FieldName = "Code";
            this.colCode1.MinWidth = 17;
            this.colCode1.Name = "colCode1";
            this.colCode1.Visible = true;
            this.colCode1.VisibleIndex = 0;
            this.colCode1.Width = 66;
            // 
            // colLocalDescription1
            // 
            this.colLocalDescription1.FieldName = "LocalDescription";
            this.colLocalDescription1.MinWidth = 17;
            this.colLocalDescription1.Name = "colLocalDescription1";
            this.colLocalDescription1.Width = 66;
            // 
            // lookUpEdit_addProductGroupID
            // 
            this.lookUpEdit_addProductGroupID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.addOrderViewModelBindingSource, "ProductGroupID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lookUpEdit_addProductGroupID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpEdit_addProductGroupID.Location = new System.Drawing.Point(272, 23);
            this.lookUpEdit_addProductGroupID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lookUpEdit_addProductGroupID.Name = "lookUpEdit_addProductGroupID";
            this.lookUpEdit_addProductGroupID.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.lookUpEdit_addProductGroupID.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_addProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_addProductGroupID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocalDescription", "Local Description", 155, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit_addProductGroupID.Properties.DataSource = this.keyAndNameForComboBindingSource;
            this.lookUpEdit_addProductGroupID.Properties.DisplayMember = "Code";
            this.lookUpEdit_addProductGroupID.Properties.NullText = "";
            this.lookUpEdit_addProductGroupID.Properties.ValueMember = "Code";
            this.lookUpEdit_addProductGroupID.Size = new System.Drawing.Size(141, 24);
            this.lookUpEdit_addProductGroupID.TabIndex = 9;
            this.lookUpEdit_addProductGroupID.EditValueChanged += new System.EventHandler(this.lookUpEdit_addProductGroupID_EditValueChanged);
            this.lookUpEdit_addProductGroupID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            // 
            // LookUpEdit_addProductName
            // 
            this.LookUpEdit_addProductName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.addOrderViewModelBindingSource, "ProductName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LookUpEdit_addProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LookUpEdit_addProductName.Location = new System.Drawing.Point(419, 23);
            this.LookUpEdit_addProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LookUpEdit_addProductName.Name = "LookUpEdit_addProductName";
            this.LookUpEdit_addProductName.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.LookUpEdit_addProductName.Properties.Appearance.Options.UseFont = true;
            this.LookUpEdit_addProductName.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.LookUpEdit_addProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_addProductName.Properties.DataSource = this.keyAndNameForComboBindingSource;
            this.LookUpEdit_addProductName.Properties.DisplayMember = "Code";
            this.LookUpEdit_addProductName.Properties.NullText = "";
            this.LookUpEdit_addProductName.Properties.PopupView = this.searchLookUpEdit2View;
            this.LookUpEdit_addProductName.Properties.ValueMember = "Code";
            this.LookUpEdit_addProductName.Size = new System.Drawing.Size(293, 24);
            this.LookUpEdit_addProductName.TabIndex = 10;
            this.LookUpEdit_addProductName.EditValueChanged += new System.EventHandler(this.LookUpEdit_addProductName_EditValueChanged);
            this.LookUpEdit_addProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            this.LookUpEdit_addProductName.Leave += new System.EventHandler(this.LookUpEdit_addProductName_Leave);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode2,
            this.colLocalDescription2});
            this.searchLookUpEdit2View.DetailHeight = 272;
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colCode2
            // 
            this.colCode2.FieldName = "Code";
            this.colCode2.MinWidth = 17;
            this.colCode2.Name = "colCode2";
            this.colCode2.Visible = true;
            this.colCode2.VisibleIndex = 0;
            this.colCode2.Width = 66;
            // 
            // colLocalDescription2
            // 
            this.colLocalDescription2.FieldName = "LocalDescription";
            this.colLocalDescription2.MinWidth = 17;
            this.colLocalDescription2.Name = "colLocalDescription2";
            this.colLocalDescription2.Width = 66;
            // 
            // spinEdit_addCount
            // 
            this.spinEdit_addCount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.addOrderViewModelBindingSource, "Count", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.spinEdit_addCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spinEdit_addCount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit_addCount.Location = new System.Drawing.Point(718, 23);
            this.spinEdit_addCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spinEdit_addCount.Name = "spinEdit_addCount";
            this.spinEdit_addCount.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.spinEdit_addCount.Properties.Appearance.Options.UseFont = true;
            this.spinEdit_addCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_addCount.Properties.NullText = "0";
            this.spinEdit_addCount.Size = new System.Drawing.Size(148, 24);
            this.spinEdit_addCount.TabIndex = 11;
            this.spinEdit_addCount.EditValueChanged += new System.EventHandler(this.spinEdit_addCount_EditValueChanged);
            this.spinEdit_addCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            // 
            // textEdit_addTotalPrice
            // 
            this.textEdit_addTotalPrice.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.addOrderViewModelBindingSource, "TotalPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_addTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit_addTotalPrice.EditValue = ((short)(0));
            this.textEdit_addTotalPrice.Enabled = false;
            this.textEdit_addTotalPrice.Location = new System.Drawing.Point(872, 23);
            this.textEdit_addTotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit_addTotalPrice.Name = "textEdit_addTotalPrice";
            this.textEdit_addTotalPrice.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.textEdit_addTotalPrice.Properties.Appearance.Options.UseFont = true;
            this.textEdit_addTotalPrice.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.textEdit_addTotalPrice.Properties.ReadOnly = true;
            this.textEdit_addTotalPrice.Size = new System.Drawing.Size(80, 24);
            this.textEdit_addTotalPrice.TabIndex = 12;
            // 
            // textEdit_addNote1
            // 
            this.textEdit_addNote1.CausesValidation = false;
            this.textEdit_addNote1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.addOrderViewModelBindingSource, "Note1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_addNote1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit_addNote1.EditValue = "";
            this.textEdit_addNote1.Location = new System.Drawing.Point(958, 23);
            this.textEdit_addNote1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit_addNote1.Name = "textEdit_addNote1";
            this.textEdit_addNote1.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.textEdit_addNote1.Properties.Appearance.Options.UseFont = true;
            this.textEdit_addNote1.Size = new System.Drawing.Size(157, 24);
            this.textEdit_addNote1.TabIndex = 13;
            this.textEdit_addNote1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1122, 441);
            this.xtraTabControl1.TabIndex = 7;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl_ProductOrder);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1120, 415);
            this.xtraTabPage1.Text = "查詢結果";
            // 
            // gridControl_ProductOrder
            // 
            this.gridControl_ProductOrder.AllowDrop = true;
            this.gridControl_ProductOrder.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridControl_ProductOrder.DataSource = this.productsOrderBindingSource;
            this.gridControl_ProductOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ProductOrder.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl_ProductOrder.Location = new System.Drawing.Point(0, 0);
            this.gridControl_ProductOrder.MainView = this.gridView_ProductOrder;
            this.gridControl_ProductOrder.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl_ProductOrder.Name = "gridControl_ProductOrder";
            this.gridControl_ProductOrder.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repository_WhetherStock,
            this.repository_Note,
            this.repository_Count});
            this.gridControl_ProductOrder.Size = new System.Drawing.Size(1120, 415);
            this.gridControl_ProductOrder.TabIndex = 6;
            this.gridControl_ProductOrder.UseEmbeddedNavigator = true;
            this.gridControl_ProductOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ProductOrder});
            this.gridControl_ProductOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            // 
            // productsOrderBindingSource
            // 
            this.productsOrderBindingSource.DataSource = typeof(MES.Order.DAL.EntityFramework.ProductsOrder);
            // 
            // gridView_ProductOrder
            // 
            this.gridView_ProductOrder.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.gridView_ProductOrder.Appearance.Row.Options.UseFont = true;
            this.gridView_ProductOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoID,
            this.colArea,
            this.colCustomID,
            this.colCustomName,
            this.colProductGroupID,
            this.colProductName,
            this.colCount,
            this.colPrice,
            this.colTotalPrice,
            this.colOrderDate,
            this.colNote1,
            this.colSetAddress,
            this.colAddress,
            this.colTotalCost,
            this.colTotalProfit,
            this.colUpdateDate,
            this.colNote3,
            this.colNote2});
            this.gridView_ProductOrder.FixedLineWidth = 3;
            this.gridView_ProductOrder.GridControl = this.gridControl_ProductOrder;
            this.gridView_ProductOrder.GroupFormat = "{0}:{1} ,{2}";
            this.gridView_ProductOrder.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Count", null, "數量: {0:0.##}")});
            this.gridView_ProductOrder.Name = "gridView_ProductOrder";
            this.gridView_ProductOrder.NewItemRowText = "點此新增";
            this.gridView_ProductOrder.OptionsSelection.CheckBoxSelectorField = "Note3";
            this.gridView_ProductOrder.OptionsSelection.MultiSelect = true;
            this.gridView_ProductOrder.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView_ProductOrder.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gridView_ProductOrder.OptionsView.ColumnAutoWidth = false;
            this.gridView_ProductOrder.OptionsView.ShowFooter = true;
            this.gridView_ProductOrder.OptionsView.ShowGroupPanel = false;
            // 
            // colAutoID
            // 
            this.colAutoID.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colAutoID.AppearanceCell.Options.UseFont = true;
            this.colAutoID.AppearanceCell.Options.UseTextOptions = true;
            this.colAutoID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAutoID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAutoID.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colAutoID.AppearanceHeader.Options.UseFont = true;
            this.colAutoID.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAutoID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAutoID.FieldName = "AutoID";
            this.colAutoID.Name = "colAutoID";
            this.colAutoID.OptionsColumn.AllowFocus = false;
            // 
            // colArea
            // 
            this.colArea.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colArea.AppearanceCell.Options.UseFont = true;
            this.colArea.AppearanceCell.Options.UseTextOptions = true;
            this.colArea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colArea.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colArea.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colArea.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.colArea.AppearanceHeader.Options.UseFont = true;
            this.colArea.AppearanceHeader.Options.UseTextOptions = true;
            this.colArea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colArea.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colArea.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colArea.Caption = "地區";
            this.colArea.FieldName = "Area";
            this.colArea.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colArea.Name = "colArea";
            this.colArea.OptionsColumn.AllowFocus = false;
            this.colArea.Visible = true;
            this.colArea.VisibleIndex = 1;
            this.colArea.Width = 53;
            // 
            // colCustomID
            // 
            this.colCustomID.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colCustomID.AppearanceCell.Options.UseFont = true;
            this.colCustomID.AppearanceCell.Options.UseTextOptions = true;
            this.colCustomID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCustomID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCustomID.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colCustomID.AppearanceHeader.Options.UseFont = true;
            this.colCustomID.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCustomID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCustomID.Caption = "客戶代號";
            this.colCustomID.FieldName = "CustomID";
            this.colCustomID.Name = "colCustomID";
            this.colCustomID.OptionsColumn.AllowFocus = false;
            // 
            // colCustomName
            // 
            this.colCustomName.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colCustomName.AppearanceCell.Options.UseFont = true;
            this.colCustomName.AppearanceCell.Options.UseTextOptions = true;
            this.colCustomName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCustomName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCustomName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCustomName.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colCustomName.AppearanceHeader.Options.UseFont = true;
            this.colCustomName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCustomName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colCustomName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCustomName.Caption = "客戶名稱";
            this.colCustomName.FieldName = "CustomName";
            this.colCustomName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colCustomName.Name = "colCustomName";
            this.colCustomName.OptionsColumn.FixedWidth = true;
            this.colCustomName.Visible = true;
            this.colCustomName.VisibleIndex = 2;
            this.colCustomName.Width = 134;
            // 
            // colProductGroupID
            // 
            this.colProductGroupID.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colProductGroupID.AppearanceCell.Options.UseFont = true;
            this.colProductGroupID.AppearanceCell.Options.UseTextOptions = true;
            this.colProductGroupID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProductGroupID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProductGroupID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colProductGroupID.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colProductGroupID.AppearanceHeader.Options.UseFont = true;
            this.colProductGroupID.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductGroupID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProductGroupID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProductGroupID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colProductGroupID.Caption = "廠商";
            this.colProductGroupID.FieldName = "ProductGroupID";
            this.colProductGroupID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colProductGroupID.Name = "colProductGroupID";
            this.colProductGroupID.OptionsColumn.AllowFocus = false;
            this.colProductGroupID.Width = 54;
            // 
            // colProductName
            // 
            this.colProductName.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colProductName.AppearanceCell.Options.UseFont = true;
            this.colProductName.AppearanceCell.Options.UseTextOptions = true;
            this.colProductName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProductName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProductName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colProductName.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colProductName.AppearanceHeader.Options.UseFont = true;
            this.colProductName.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProductName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colProductName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colProductName.Caption = "產品";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.FixedWidth = true;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 3;
            this.colProductName.Width = 231;
            // 
            // colCount
            // 
            this.colCount.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colCount.AppearanceCell.Options.UseFont = true;
            this.colCount.AppearanceCell.Options.UseTextOptions = true;
            this.colCount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCount.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCount.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colCount.AppearanceHeader.Options.UseFont = true;
            this.colCount.AppearanceHeader.Options.UseTextOptions = true;
            this.colCount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCount.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colCount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCount.Caption = "數量";
            this.colCount.ColumnEdit = this.repository_Count;
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Count", "{0:N0}")});
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 7;
            this.colCount.Width = 99;
            // 
            // repository_Count
            // 
            this.repository_Count.AutoHeight = false;
            this.repository_Count.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repository_Count.Name = "repository_Count";
            this.repository_Count.EditValueChanged += new System.EventHandler(this.repository_Count_EditValueChanged);
            // 
            // colPrice
            // 
            this.colPrice.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colPrice.AppearanceCell.Options.UseFont = true;
            this.colPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPrice.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPrice.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colPrice.AppearanceHeader.Options.UseFont = true;
            this.colPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrice.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPrice.Caption = "售價";
            this.colPrice.ColumnEdit = this.repository_Count;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowFocus = false;
            this.colPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", "{0:N0}")});
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 6;
            this.colPrice.Width = 59;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colTotalPrice.AppearanceCell.Options.UseFont = true;
            this.colTotalPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTotalPrice.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTotalPrice.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colTotalPrice.AppearanceHeader.Options.UseFont = true;
            this.colTotalPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalPrice.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colTotalPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTotalPrice.Caption = "總售價";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.OptionsColumn.AllowFocus = false;
            this.colTotalPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "{0:N0}")});
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 8;
            this.colTotalPrice.Width = 71;
            // 
            // colOrderDate
            // 
            this.colOrderDate.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colOrderDate.AppearanceCell.Options.UseFont = true;
            this.colOrderDate.AppearanceCell.Options.UseTextOptions = true;
            this.colOrderDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colOrderDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colOrderDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colOrderDate.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colOrderDate.AppearanceHeader.Options.UseFont = true;
            this.colOrderDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrderDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colOrderDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colOrderDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colOrderDate.Caption = "訂購日期";
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.OptionsColumn.AllowFocus = false;
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 4;
            this.colOrderDate.Width = 80;
            // 
            // colNote1
            // 
            this.colNote1.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colNote1.AppearanceCell.Options.UseFont = true;
            this.colNote1.AppearanceCell.Options.UseTextOptions = true;
            this.colNote1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNote1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNote1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNote1.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colNote1.AppearanceHeader.Options.UseFont = true;
            this.colNote1.AppearanceHeader.Options.UseTextOptions = true;
            this.colNote1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNote1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colNote1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNote1.Caption = "備註";
            this.colNote1.ColumnEdit = this.repository_Note;
            this.colNote1.FieldName = "Note1";
            this.colNote1.Name = "colNote1";
            this.colNote1.Visible = true;
            this.colNote1.VisibleIndex = 12;
            this.colNote1.Width = 105;
            // 
            // repository_Note
            // 
            this.repository_Note.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.repository_Note.Appearance.Options.UseFont = true;
            this.repository_Note.AppearanceFocused.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.repository_Note.AppearanceFocused.Options.UseFont = true;
            this.repository_Note.AutoHeight = false;
            this.repository_Note.Name = "repository_Note";
            this.repository_Note.EditValueChanged += new System.EventHandler(this.repository_Note_EditValueChanged);
            // 
            // colSetAddress
            // 
            this.colSetAddress.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colSetAddress.AppearanceCell.Options.UseFont = true;
            this.colSetAddress.AppearanceCell.Options.UseTextOptions = true;
            this.colSetAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSetAddress.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colSetAddress.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSetAddress.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colSetAddress.AppearanceHeader.Options.UseFont = true;
            this.colSetAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colSetAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSetAddress.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colSetAddress.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSetAddress.Caption = "是否取貨";
            this.colSetAddress.ColumnEdit = this.repository_WhetherStock;
            this.colSetAddress.MinWidth = 22;
            this.colSetAddress.Name = "colSetAddress";
            this.colSetAddress.Visible = true;
            this.colSetAddress.VisibleIndex = 10;
            this.colSetAddress.Width = 82;
            // 
            // repository_WhetherStock
            // 
            this.repository_WhetherStock.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.repository_WhetherStock.Appearance.Options.UseFont = true;
            this.repository_WhetherStock.AppearanceDropDown.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.repository_WhetherStock.AppearanceDropDown.Options.UseFont = true;
            this.repository_WhetherStock.AutoHeight = false;
            this.repository_WhetherStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repository_WhetherStock.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 55, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocalDescription", "Local Description", 122, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repository_WhetherStock.DisplayMember = "LocalDescription";
            this.repository_WhetherStock.Name = "repository_WhetherStock";
            this.repository_WhetherStock.NullText = "";
            this.repository_WhetherStock.ValueMember = "Code";
            this.repository_WhetherStock.EditValueChanged += new System.EventHandler(this.repository_WhetherStock_EditValueChanged);
            // 
            // colAddress
            // 
            this.colAddress.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colAddress.AppearanceCell.Options.UseFont = true;
            this.colAddress.AppearanceCell.Options.UseTextOptions = true;
            this.colAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAddress.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAddress.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAddress.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colAddress.AppearanceHeader.Options.UseFont = true;
            this.colAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAddress.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colAddress.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAddress.Caption = "取貨";
            this.colAddress.FieldName = "Address";
            this.colAddress.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 5;
            this.colAddress.Width = 117;
            // 
            // colTotalCost
            // 
            this.colTotalCost.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colTotalCost.AppearanceCell.Options.UseFont = true;
            this.colTotalCost.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalCost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalCost.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTotalCost.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTotalCost.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colTotalCost.AppearanceHeader.Options.UseFont = true;
            this.colTotalCost.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalCost.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colTotalCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTotalCost.Caption = "總批價";
            this.colTotalCost.FieldName = "TotalCost";
            this.colTotalCost.Name = "colTotalCost";
            this.colTotalCost.OptionsColumn.AllowFocus = false;
            this.colTotalCost.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalCost", "{0:N0}")});
            this.colTotalCost.Visible = true;
            this.colTotalCost.VisibleIndex = 9;
            this.colTotalCost.Width = 71;
            // 
            // colTotalProfit
            // 
            this.colTotalProfit.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colTotalProfit.AppearanceCell.Options.UseFont = true;
            this.colTotalProfit.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalProfit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalProfit.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTotalProfit.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTotalProfit.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colTotalProfit.AppearanceHeader.Options.UseFont = true;
            this.colTotalProfit.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalProfit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalProfit.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colTotalProfit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTotalProfit.Caption = "總利潤";
            this.colTotalProfit.FieldName = "TotalProfit";
            this.colTotalProfit.Name = "colTotalProfit";
            this.colTotalProfit.OptionsColumn.AllowFocus = false;
            this.colTotalProfit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalProfit", "{0:N0}")});
            this.colTotalProfit.Visible = true;
            this.colTotalProfit.VisibleIndex = 11;
            this.colTotalProfit.Width = 82;
            // 
            // colUpdateDate
            // 
            this.colUpdateDate.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colUpdateDate.AppearanceCell.Options.UseFont = true;
            this.colUpdateDate.AppearanceCell.Options.UseTextOptions = true;
            this.colUpdateDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUpdateDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUpdateDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colUpdateDate.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colUpdateDate.AppearanceHeader.Options.UseFont = true;
            this.colUpdateDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colUpdateDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUpdateDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUpdateDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colUpdateDate.FieldName = "UpdateDate";
            this.colUpdateDate.Name = "colUpdateDate";
            this.colUpdateDate.OptionsColumn.AllowFocus = false;
            // 
            // colNote3
            // 
            this.colNote3.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colNote3.AppearanceCell.Options.UseFont = true;
            this.colNote3.AppearanceCell.Options.UseTextOptions = true;
            this.colNote3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNote3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNote3.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNote3.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colNote3.AppearanceHeader.Options.UseFont = true;
            this.colNote3.AppearanceHeader.Options.UseTextOptions = true;
            this.colNote3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNote3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNote3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNote3.FieldName = "Note3";
            this.colNote3.Name = "colNote3";
            this.colNote3.OptionsColumn.AllowFocus = false;
            // 
            // colNote2
            // 
            this.colNote2.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colNote2.AppearanceCell.Options.UseFont = true;
            this.colNote2.AppearanceCell.Options.UseTextOptions = true;
            this.colNote2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNote2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNote2.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNote2.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.colNote2.AppearanceHeader.Options.UseFont = true;
            this.colNote2.AppearanceHeader.Options.UseTextOptions = true;
            this.colNote2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNote2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNote2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNote2.FieldName = "Note2";
            this.colNote2.Name = "colNote2";
            this.colNote2.OptionsColumn.AllowFocus = false;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.pivotGrid_FocusOrder);
            this.xtraTabPage2.Controls.Add(this.gridControl_Focus);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1120, 415);
            this.xtraTabPage2.Text = "拉單";
            // 
            // pivotGrid_FocusOrder
            // 
            this.pivotGrid_FocusOrder.AppearancePrint.Cell.Options.UseBorderColor = true;
            this.pivotGrid_FocusOrder.AppearancePrint.CustomTotalCell.Options.UseBorderColor = true;
            this.pivotGrid_FocusOrder.AppearancePrint.FieldHeader.Options.UseBorderColor = true;
            this.pivotGrid_FocusOrder.AppearancePrint.FieldValue.Options.UseBorderColor = true;
            this.pivotGrid_FocusOrder.AppearancePrint.FieldValueGrandTotal.Options.UseBorderColor = true;
            this.pivotGrid_FocusOrder.AppearancePrint.FieldValueTotal.Options.UseBorderColor = true;
            this.pivotGrid_FocusOrder.AppearancePrint.GrandTotalCell.Options.UseBorderColor = true;
            this.pivotGrid_FocusOrder.AppearancePrint.Lines.Options.UseBorderColor = true;
            this.pivotGrid_FocusOrder.AppearancePrint.TotalCell.Options.UseBorderColor = true;
            this.pivotGrid_FocusOrder.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.pivotGrid_FocusOrder.DataSource = this.FocusbindingSource;
            this.pivotGrid_FocusOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGrid_FocusOrder.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldNote1,
            this.fieldCustomName,
            this.fieldArea,
            this.fieldPrice,
            this.fieldProductName,
            this.fieldTotalCost,
            this.fieldTotalPrice,
            this.fieldTotalProfit,
            this.fieldCount,
            this.fieldAddress});
            this.pivotGrid_FocusOrder.Location = new System.Drawing.Point(0, 0);
            this.pivotGrid_FocusOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pivotGrid_FocusOrder.Name = "pivotGrid_FocusOrder";
            this.pivotGrid_FocusOrder.OptionsBehavior.BestFitConsiderCustomAppearance = true;
            this.pivotGrid_FocusOrder.OptionsChartDataSource.ProvideRowCustomTotals = true;
            this.pivotGrid_FocusOrder.OptionsChartDataSource.ProvideRowGrandTotals = true;
            this.pivotGrid_FocusOrder.OptionsChartDataSource.ProvideRowTotals = true;
            this.pivotGrid_FocusOrder.OptionsDataField.AreaIndex = 0;
            this.pivotGrid_FocusOrder.OptionsDataField.RowHeaderWidth = 262;
            this.pivotGrid_FocusOrder.OptionsOLAP.SortByCustomFieldValueDisplayText = true;
            this.pivotGrid_FocusOrder.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGrid_FocusOrder.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGrid_FocusOrder.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGrid_FocusOrder.OptionsPrint.PrintHorzLines = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGrid_FocusOrder.OptionsPrint.PrintRowHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGrid_FocusOrder.OptionsPrint.PrintUnusedFilterFields = false;
            this.pivotGrid_FocusOrder.OptionsPrint.PrintVertLines = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGrid_FocusOrder.OptionsPrint.UsePrintAppearance = true;
            this.pivotGrid_FocusOrder.OptionsSelection.EnableAppearanceFocusedCell = true;
            this.pivotGrid_FocusOrder.OptionsView.RowTreeOffset = 18;
            this.pivotGrid_FocusOrder.OptionsView.RowTreeWidth = 87;
            this.pivotGrid_FocusOrder.OptionsView.ShowColumnGrandTotalHeader = false;
            this.pivotGrid_FocusOrder.OptionsView.ShowRowGrandTotalHeader = false;
            this.pivotGrid_FocusOrder.OptionsView.ShowTotalsForSingleValues = true;
            this.pivotGrid_FocusOrder.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.pivotGrid_FocusOrder.Size = new System.Drawing.Size(1120, 415);
            this.pivotGrid_FocusOrder.TabIndex = 8;
            this.pivotGrid_FocusOrder.FieldValueDisplayText += new DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(this.pivotGrid_FocusOrder_FieldValueDisplayText);
            this.pivotGrid_FocusOrder.CustomCellValue += new System.EventHandler<DevExpress.XtraPivotGrid.PivotCellValueEventArgs>(this.pivotGrid_FocusOrder_CustomCellValue);
            this.pivotGrid_FocusOrder.CustomDrawCell += new DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(this.pivotGrid_FocusOrder_CustomDrawCell);
            // 
            // FocusbindingSource
            // 
            this.FocusbindingSource.DataSource = typeof(MES.Order.DAL.EntityFramework.ProductsOrder);
            // 
            // fieldNote1
            // 
            this.fieldNote1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldNote1.AreaIndex = 3;
            this.fieldNote1.Caption = "備註";
            this.fieldNote1.FieldName = "Note1";
            this.fieldNote1.MinWidth = 17;
            this.fieldNote1.Name = "fieldNote1";
            this.fieldNote1.Options.ShowTotals = false;
            this.fieldNote1.Width = 175;
            // 
            // fieldCustomName
            // 
            this.fieldCustomName.Appearance.CellTotal.ForeColor = System.Drawing.Color.Red;
            this.fieldCustomName.Appearance.CellTotal.Options.UseForeColor = true;
            this.fieldCustomName.Appearance.CellTotal.Options.UseTextOptions = true;
            this.fieldCustomName.Appearance.CellTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.fieldCustomName.Appearance.ValueTotal.ForeColor = System.Drawing.Color.Red;
            this.fieldCustomName.Appearance.ValueTotal.Options.UseForeColor = true;
            this.fieldCustomName.Appearance.ValueTotal.Options.UseTextOptions = true;
            this.fieldCustomName.Appearance.ValueTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.fieldCustomName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCustomName.AreaIndex = 1;
            this.fieldCustomName.Caption = "客戶";
            this.fieldCustomName.FieldName = "CustomName";
            this.fieldCustomName.MinWidth = 26;
            this.fieldCustomName.Name = "fieldCustomName";
            this.fieldCustomName.Options.ShowGrandTotal = false;
            this.fieldCustomName.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom;
            this.fieldCustomName.TotalCellFormat.FormatString = "\"合計\"0";
            this.fieldCustomName.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCustomName.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldCustomName.Width = 175;
            // 
            // fieldArea
            // 
            this.fieldArea.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldArea.AreaIndex = 0;
            this.fieldArea.Caption = "地區";
            this.fieldArea.FieldName = "Area";
            this.fieldArea.MinWidth = 17;
            this.fieldArea.Name = "fieldArea";
            this.fieldArea.Width = 87;
            // 
            // fieldPrice
            // 
            this.fieldPrice.AreaIndex = 2;
            this.fieldPrice.Caption = "售價";
            this.fieldPrice.FieldName = "Price";
            this.fieldPrice.MinWidth = 17;
            this.fieldPrice.Name = "fieldPrice";
            this.fieldPrice.Width = 87;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 2;
            this.fieldProductName.Caption = "產品";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.GrandTotalText = "合計";
            this.fieldProductName.MinWidth = 87;
            this.fieldProductName.Name = "fieldProductName";
            this.fieldProductName.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.fieldProductName.Width = 262;
            // 
            // fieldTotalCost
            // 
            this.fieldTotalCost.AreaIndex = 0;
            this.fieldTotalCost.Caption = "總批價";
            this.fieldTotalCost.FieldName = "TotalCost";
            this.fieldTotalCost.MinWidth = 17;
            this.fieldTotalCost.Name = "fieldTotalCost";
            this.fieldTotalCost.Width = 87;
            // 
            // fieldTotalPrice
            // 
            this.fieldTotalPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldTotalPrice.AreaIndex = 1;
            this.fieldTotalPrice.Caption = "總售價";
            this.fieldTotalPrice.FieldName = "TotalPrice";
            this.fieldTotalPrice.GrandTotalCellFormat.FormatString = "\"$\"0";
            this.fieldTotalPrice.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldTotalPrice.MinWidth = 17;
            this.fieldTotalPrice.Name = "fieldTotalPrice";
            this.fieldTotalPrice.Options.ShowTotals = false;
            this.fieldTotalPrice.Options.ShowValues = false;
            this.fieldTotalPrice.Width = 87;
            // 
            // fieldTotalProfit
            // 
            this.fieldTotalProfit.AreaIndex = 1;
            this.fieldTotalProfit.Caption = "總利潤";
            this.fieldTotalProfit.FieldName = "TotalProfit";
            this.fieldTotalProfit.MinWidth = 17;
            this.fieldTotalProfit.Name = "fieldTotalProfit";
            this.fieldTotalProfit.Width = 87;
            // 
            // fieldCount
            // 
            this.fieldCount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCount.AreaIndex = 0;
            this.fieldCount.Caption = "數量";
            this.fieldCount.FieldName = "Count";
            this.fieldCount.GrandTotalCellFormat.FormatString = "\"+\"0";
            this.fieldCount.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldCount.MinWidth = 17;
            this.fieldCount.Name = "fieldCount";
            this.fieldCount.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.fieldCount.Width = 122;
            // 
            // fieldAddress
            // 
            this.fieldAddress.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldAddress.AreaIndex = 3;
            this.fieldAddress.Caption = "是否取貨";
            this.fieldAddress.FieldName = "Address";
            this.fieldAddress.MinWidth = 17;
            this.fieldAddress.Name = "fieldAddress";
            this.fieldAddress.Options.ShowGrandTotal = false;
            this.fieldAddress.Options.ShowTotals = false;
            this.fieldAddress.Visible = false;
            this.fieldAddress.Width = 131;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridControl_Focus
            // 
            this.gridControl_Focus.AllowDrop = true;
            this.gridControl_Focus.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridControl_Focus.DataSource = this.FocusbindingSource;
            this.gridControl_Focus.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl_Focus.Location = new System.Drawing.Point(504, 0);
            this.gridControl_Focus.MainView = this.gridView_Focus;
            this.gridControl_Focus.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl_Focus.Name = "gridControl_Focus";
            this.gridControl_Focus.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemSpinEdit1});
            this.gridControl_Focus.Size = new System.Drawing.Size(612, 413);
            this.gridControl_Focus.TabIndex = 9;
            this.gridControl_Focus.UseEmbeddedNavigator = true;
            this.gridControl_Focus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Focus});
            this.gridControl_Focus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            // 
            // gridView_Focus
            // 
            this.gridView_Focus.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.gridView_Focus.Appearance.Row.Options.UseFont = true;
            this.gridView_Focus.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn13,
            this.gridColumn15});
            this.gridView_Focus.FixedLineWidth = 3;
            this.gridView_Focus.GridControl = this.gridControl_Focus;
            this.gridView_Focus.GroupFormat = "{0}:{1} ,{2}";
            this.gridView_Focus.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Count", null, "數量: {0:0.##}")});
            this.gridView_Focus.Name = "gridView_Focus";
            this.gridView_Focus.NewItemRowText = "點此新增";
            this.gridView_Focus.OptionsSelection.CheckBoxSelectorField = "Note3";
            this.gridView_Focus.OptionsSelection.MultiSelect = true;
            this.gridView_Focus.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView_Focus.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gridView_Focus.OptionsView.ColumnAutoWidth = false;
            this.gridView_Focus.OptionsView.ShowFooter = true;
            this.gridView_Focus.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.gridColumn4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn4.Caption = "地區";
            this.gridColumn4.FieldName = "Area";
            this.gridColumn4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 53;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn6.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.gridColumn6.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn6.Caption = "客戶名稱";
            this.gridColumn6.FieldName = "CustomName";
            this.gridColumn6.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.FixedWidth = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 134;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.gridColumn7.AppearanceCell.Options.UseFont = true;
            this.gridColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn7.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn7.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn7.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn7.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn7.Caption = "廠商";
            this.gridColumn7.FieldName = "ProductGroupID";
            this.gridColumn7.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.Width = 54;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.gridColumn8.AppearanceCell.Options.UseFont = true;
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn8.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn8.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn8.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.gridColumn8.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn8.Caption = "產品";
            this.gridColumn8.FieldName = "ProductName";
            this.gridColumn8.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.FixedWidth = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            this.gridColumn8.Width = 231;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.gridColumn9.AppearanceCell.Options.UseFont = true;
            this.gridColumn9.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn9.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn9.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn9.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.gridColumn9.AppearanceHeader.Options.UseFont = true;
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.gridColumn9.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn9.Caption = "數量";
            this.gridColumn9.ColumnEdit = this.repositoryItemSpinEdit1;
            this.gridColumn9.FieldName = "Count";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            this.gridColumn9.Width = 99;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.gridColumn10.AppearanceCell.Options.UseFont = true;
            this.gridColumn10.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn10.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn10.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn10.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.gridColumn10.AppearanceHeader.Options.UseFont = true;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.gridColumn10.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn10.Caption = "售價";
            this.gridColumn10.ColumnEdit = this.repositoryItemSpinEdit1;
            this.gridColumn10.FieldName = "Price";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowFocus = false;
            this.gridColumn10.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", "{0:N0}")});
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            this.gridColumn10.Width = 59;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.gridColumn11.AppearanceCell.Options.UseFont = true;
            this.gridColumn11.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn11.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn11.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn11.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.gridColumn11.AppearanceHeader.Options.UseFont = true;
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.gridColumn11.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn11.Caption = "總售價";
            this.gridColumn11.FieldName = "TotalPrice";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowFocus = false;
            this.gridColumn11.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "{0:N0}")});
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 7;
            this.gridColumn11.Width = 71;
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.gridColumn13.AppearanceCell.Options.UseFont = true;
            this.gridColumn13.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn13.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn13.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn13.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.gridColumn13.AppearanceHeader.Options.UseFont = true;
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn13.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.gridColumn13.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn13.Caption = "備註";
            this.gridColumn13.ColumnEdit = this.repositoryItemTextEdit1;
            this.gridColumn13.FieldName = "Note1";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 8;
            this.gridColumn13.Width = 105;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.repositoryItemTextEdit1.Appearance.Options.UseFont = true;
            this.repositoryItemTextEdit1.AppearanceFocused.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.repositoryItemTextEdit1.AppearanceFocused.Options.UseFont = true;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gridColumn15
            // 
            this.gridColumn15.AppearanceCell.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.gridColumn15.AppearanceCell.Options.UseFont = true;
            this.gridColumn15.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn15.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn15.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn15.AppearanceHeader.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.gridColumn15.AppearanceHeader.Options.UseFont = true;
            this.gridColumn15.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn15.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.gridColumn15.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn15.Caption = "取貨";
            this.gridColumn15.FieldName = "Address";
            this.gridColumn15.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 4;
            this.gridColumn15.Width = 117;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.Appearance.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.repositoryItemLookUpEdit1.Appearance.Options.UseFont = true;
            this.repositoryItemLookUpEdit1.AppearanceDropDown.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.repositoryItemLookUpEdit1.AppearanceDropDown.Options.UseFont = true;
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 55, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocalDescription", "Local Description", 122, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit1.DisplayMember = "LocalDescription";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "Code";
            // 
            // alertControl1
            // 
            this.alertControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertControl1.AppearanceCaption.Options.UseFont = true;
            this.alertControl1.AppearanceText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertControl1.AppearanceText.Options.UseFont = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "欲存檔路徑";
            // 
            // colAutoID1
            // 
            this.colAutoID1.FieldName = "AutoID";
            this.colAutoID1.Name = "colAutoID1";
            // 
            // colArea1
            // 
            this.colArea1.FieldName = "Area";
            this.colArea1.Name = "colArea1";
            // 
            // colCustomID1
            // 
            this.colCustomID1.FieldName = "CustomID";
            this.colCustomID1.Name = "colCustomID1";
            // 
            // colCustomName1
            // 
            this.colCustomName1.FieldName = "CustomName";
            this.colCustomName1.Name = "colCustomName1";
            // 
            // colUpdateDate1
            // 
            this.colUpdateDate1.FieldName = "UpdateDate";
            this.colUpdateDate1.Name = "colUpdateDate1";
            // 
            // colCount1
            // 
            this.colCount1.FieldName = "Count";
            this.colCount1.Name = "colCount1";
            // 
            // colAddress1
            // 
            this.colAddress1.FieldName = "Address";
            this.colAddress1.Name = "colAddress1";
            // 
            // colOrderDate1
            // 
            this.colOrderDate1.FieldName = "OrderDate";
            this.colOrderDate1.Name = "colOrderDate1";
            // 
            // colProductGroupID1
            // 
            this.colProductGroupID1.FieldName = "ProductGroupID";
            this.colProductGroupID1.Name = "colProductGroupID1";
            // 
            // colProductName1
            // 
            this.colProductName1.FieldName = "ProductName";
            this.colProductName1.Name = "colProductName1";
            // 
            // colPrice1
            // 
            this.colPrice1.FieldName = "Price";
            this.colPrice1.Name = "colPrice1";
            // 
            // colTotalPrice1
            // 
            this.colTotalPrice1.FieldName = "TotalPrice";
            this.colTotalPrice1.Name = "colTotalPrice1";
            // 
            // colTotalCost1
            // 
            this.colTotalCost1.FieldName = "TotalCost";
            this.colTotalCost1.Name = "colTotalCost1";
            // 
            // colTotalProfit1
            // 
            this.colTotalProfit1.FieldName = "TotalProfit";
            this.colTotalProfit1.Name = "colTotalProfit1";
            // 
            // colNote31
            // 
            this.colNote31.FieldName = "Note3";
            this.colNote31.Name = "colNote31";
            // 
            // colNote21
            // 
            this.colNote21.FieldName = "Note2";
            this.colNote21.Name = "colNote21";
            // 
            // colNote11
            // 
            this.colNote11.FieldName = "Note1";
            this.colNote11.Name = "colNote11";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(1122, 674);
            this.Enter += new System.EventHandler(this.Order_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDateE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDateE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Area.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_ProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_ProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAndNameForComboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDateS.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDateS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_CustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_GroupColumn.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_addArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addOrderViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_addCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_addProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_addProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_addCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_addTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_addNote1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ProductOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ProductOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_Note)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_WhetherStock)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGrid_FocusOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FocusbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Focus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Focus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl lbl_ProductName;
        private DevExpress.XtraEditors.SearchLookUpEdit lookUpEdit_ProductName;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalDescription;
        internal DevExpress.XtraEditors.SimpleButton btn_Save;
        internal DevExpress.XtraEditors.SimpleButton btn_Cancel;
        internal DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.LabelControl lbl_ProductGroupID;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_ProductGroupID;
        private DevExpress.XtraEditors.LabelControl label_Area;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_Area;
        private DevExpress.XtraEditors.LabelControl label_CustomerName;
        private DevExpress.XtraEditors.LabelControl label_OrderDate;
        private DevExpress.XtraEditors.DateEdit dateEdit_OrderDateE;
        internal DevExpress.XtraEditors.SimpleButton btn_Export;
        private DevExpress.XtraEditors.DateEdit dateEdit_OrderDateS;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        internal DevExpress.XtraEditors.SimpleButton btn_FocusRow;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource productsOrderBindingSource;
        private System.Windows.Forms.BindingSource keyAndNameForComboBindingSource;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource FocusbindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_addArea;
        private DevExpress.XtraEditors.SearchLookUpEdit LookUpEdit_addCustomerName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_addProductGroupID;
        private DevExpress.XtraEditors.SearchLookUpEdit LookUpEdit_addProductName;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.SpinEdit spinEdit_addCount;
        private DevExpress.XtraEditors.TextEdit textEdit_addTotalPrice;
        private DevExpress.XtraEditors.TextEdit textEdit_addNote1;
        private System.Windows.Forms.BindingSource addOrderViewModelBindingSource;
        private DevExpress.XtraEditors.SearchLookUpEdit lookUpEdit_CustomerName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.GridControl gridControl_ProductOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ProductOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoID;
        private DevExpress.XtraGrid.Columns.GridColumn colArea;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductGroupID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNote1;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repository_WhetherStock;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCost;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProfit;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNote3;
        private DevExpress.XtraGrid.Columns.GridColumn colNote2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        internal DevExpress.XtraEditors.SimpleButton btn_UnFocus;
        private DevExpress.XtraGrid.Columns.GridColumn colCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalDescription1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode2;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalDescription2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repository_Note;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch_GroupColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repository_Count;
        private DevExpress.XtraGrid.Columns.GridColumn colSetAddress;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGrid_FocusOrder;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNote1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCustomName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldArea;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPrice;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTotalCost;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTotalPrice;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTotalProfit;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCount;
        internal DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAddress;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.GridControl gridControl_Focus;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Focus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAutoID1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colArea1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCustomID1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCustomName1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUpdateDate1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCount1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAddress1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOrderDate1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProductGroupID1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProductName1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPrice1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTotalPrice1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTotalCost1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTotalProfit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNote31;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNote21;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNote11;
    }
}