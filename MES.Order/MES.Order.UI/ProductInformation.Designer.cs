namespace MES.Order.UI
{
    partial class ProductInformation
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInformation));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ProductGroupID = new DevExpress.XtraEditors.LabelControl();
            this.lbl_ProductName = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit_ProductGroupID = new DevExpress.XtraEditors.LookUpEdit();
            this.keyAndNameForComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit_ProductName = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl_ProductInfo = new DevExpress.XtraGrid.GridControl();
            this.productsInfomationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_ProductInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductGroupID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfit1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_AddProducts = new DevExpress.XtraGrid.GridControl();
            this.AddproductsInfomationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_AddProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repository_ProductGroupID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repository_ProductName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repository_Price = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repository_Cost = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repository_Profit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_ProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAndNameForComboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_ProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ProductInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsInfomationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ProductInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_AddProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddproductsInfomationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_AddProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_ProductGroupID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_ProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_Profit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.White;
            this.groupControl1.AppearanceCaption.BackColor2 = System.Drawing.Color.White;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.tableLayoutPanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1226, 138);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "查詢";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_ProductGroupID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ProductName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEdit_ProductGroupID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Save, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Cancel, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Query, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEdit_ProductName, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 38);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1218, 95);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_ProductGroupID
            // 
            this.lbl_ProductGroupID.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_ProductGroupID.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbl_ProductGroupID.Appearance.Options.UseFont = true;
            this.lbl_ProductGroupID.Appearance.Options.UseForeColor = true;
            this.lbl_ProductGroupID.Appearance.Options.UseTextOptions = true;
            this.lbl_ProductGroupID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbl_ProductGroupID.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbl_ProductGroupID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_ProductGroupID.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lbl_ProductGroupID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ProductGroupID.Location = new System.Drawing.Point(6, 6);
            this.lbl_ProductGroupID.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_ProductGroupID.Name = "lbl_ProductGroupID";
            this.lbl_ProductGroupID.Size = new System.Drawing.Size(192, 36);
            this.lbl_ProductGroupID.TabIndex = 12;
            this.lbl_ProductGroupID.Text = "廠商名稱";
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_ProductName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbl_ProductName.Appearance.Options.UseFont = true;
            this.lbl_ProductName.Appearance.Options.UseForeColor = true;
            this.lbl_ProductName.Appearance.Options.UseTextOptions = true;
            this.lbl_ProductName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbl_ProductName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbl_ProductName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_ProductName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lbl_ProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ProductName.Location = new System.Drawing.Point(410, 6);
            this.lbl_ProductName.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(192, 36);
            this.lbl_ProductName.TabIndex = 50;
            this.lbl_ProductName.Text = "產品名稱";
            // 
            // lookUpEdit_ProductGroupID
            // 
            this.lookUpEdit_ProductGroupID.Location = new System.Drawing.Point(208, 6);
            this.lookUpEdit_ProductGroupID.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpEdit_ProductGroupID.Name = "lookUpEdit_ProductGroupID";
            this.lookUpEdit_ProductGroupID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lookUpEdit_ProductGroupID.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lookUpEdit_ProductGroupID.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEdit_ProductGroupID.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_ProductGroupID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lookUpEdit_ProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_ProductGroupID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lookUpEdit_ProductGroupID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "代號"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocalDescription", "敘述")});
            this.lookUpEdit_ProductGroupID.Properties.DataSource = this.keyAndNameForComboBindingSource;
            this.lookUpEdit_ProductGroupID.Properties.DisplayMember = "LocalDescription";
            this.lookUpEdit_ProductGroupID.Properties.MaxLength = 8;
            this.lookUpEdit_ProductGroupID.Properties.NullText = "";
            this.lookUpEdit_ProductGroupID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit_ProductGroupID.Properties.ValueMember = "Code";
            this.lookUpEdit_ProductGroupID.Size = new System.Drawing.Size(192, 30);
            this.lookUpEdit_ProductGroupID.TabIndex = 360;
            this.lookUpEdit_ProductGroupID.TabStop = false;
            // 
            // keyAndNameForComboBindingSource
            // 
            this.keyAndNameForComboBindingSource.DataSource = typeof(MES.Order.DAL.ViewModel.KeyAndNameForCombo);
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_Save.Appearance.BackColor2 = System.Drawing.Color.Khaki;
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Save.Appearance.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Save.Appearance.Options.UseBackColor = true;
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Appearance.Options.UseForeColor = true;
            this.btn_Save.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(814, 52);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(192, 37);
            this.btn_Save.TabIndex = 53;
            this.btn_Save.Text = "存檔";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Appearance.BackColor = System.Drawing.Color.Orange;
            this.btn_Cancel.Appearance.BackColor2 = System.Drawing.Color.Aquamarine;
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.Appearance.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Cancel.Appearance.Options.UseBackColor = true;
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Appearance.Options.UseForeColor = true;
            this.btn_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageOptions.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(1016, 52);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(196, 37);
            this.btn_Cancel.TabIndex = 31;
            this.btn_Cancel.Text = "刪除";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Query
            // 
            this.btn_Query.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_Query.Appearance.BackColor2 = System.Drawing.Color.Khaki;
            this.btn_Query.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Query.Appearance.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Query.Appearance.Options.UseBackColor = true;
            this.btn_Query.Appearance.Options.UseFont = true;
            this.btn_Query.Appearance.Options.UseForeColor = true;
            this.btn_Query.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_Query.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Query.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Query.ImageOptions.Image")));
            this.btn_Query.Location = new System.Drawing.Point(1016, 6);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(196, 36);
            this.btn_Query.TabIndex = 363;
            this.btn_Query.Text = "查詢";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // lookUpEdit_ProductName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lookUpEdit_ProductName, 2);
            this.lookUpEdit_ProductName.Location = new System.Drawing.Point(611, 5);
            this.lookUpEdit_ProductName.Name = "lookUpEdit_ProductName";
            this.lookUpEdit_ProductName.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit_ProductName.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_ProductName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lookUpEdit_ProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_ProductName.Properties.DataSource = this.keyAndNameForComboBindingSource;
            this.lookUpEdit_ProductName.Properties.DisplayMember = "LocalDescription";
            this.lookUpEdit_ProductName.Properties.NullText = "";
            this.lookUpEdit_ProductName.Properties.PopupView = this.searchLookUpEdit1View;
            this.lookUpEdit_ProductName.Properties.ValueMember = "Code";
            this.lookUpEdit_ProductName.Size = new System.Drawing.Size(396, 28);
            this.lookUpEdit_ProductName.TabIndex = 362;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colLocalDescription});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colLocalDescription
            // 
            this.colLocalDescription.FieldName = "LocalDescription";
            this.colLocalDescription.Name = "colLocalDescription";
            // 
            // gridControl_ProductInfo
            // 
            this.gridControl_ProductInfo.DataSource = this.productsInfomationBindingSource;
            this.gridControl_ProductInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ProductInfo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridControl_ProductInfo.Location = new System.Drawing.Point(0, 0);
            this.gridControl_ProductInfo.MainView = this.gridView_ProductInfo;
            this.gridControl_ProductInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridControl_ProductInfo.Name = "gridControl_ProductInfo";
            this.gridControl_ProductInfo.Size = new System.Drawing.Size(1226, 424);
            this.gridControl_ProductInfo.TabIndex = 5;
            this.gridControl_ProductInfo.UseEmbeddedNavigator = true;
            this.gridControl_ProductInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ProductInfo});
            // 
            // productsInfomationBindingSource
            // 
            this.productsInfomationBindingSource.DataSource = typeof(MES.Order.DAL.EntityFramework.ProductsInfomation);
            // 
            // gridView_ProductInfo
            // 
            this.gridView_ProductInfo.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView_ProductInfo.Appearance.Row.Options.UseFont = true;
            this.gridView_ProductInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoID1,
            this.colProductGroupID1,
            this.colProductName1,
            this.colPrice1,
            this.colCost1,
            this.colProfit1});
            this.gridView_ProductInfo.GridControl = this.gridControl_ProductInfo;
            this.gridView_ProductInfo.Name = "gridView_ProductInfo";
            this.gridView_ProductInfo.NewItemRowText = "點此新增";
            this.gridView_ProductInfo.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView_ProductInfo.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView_ProductInfo.OptionsSelection.MultiSelect = true;
            this.gridView_ProductInfo.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView_ProductInfo.OptionsView.ShowGroupPanel = false;
            this.gridView_ProductInfo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAutoID1, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colAutoID1
            // 
            this.colAutoID1.FieldName = "AutoID";
            this.colAutoID1.Name = "colAutoID1";
            // 
            // colProductGroupID1
            // 
            this.colProductGroupID1.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colProductGroupID1.AppearanceCell.Options.UseFont = true;
            this.colProductGroupID1.AppearanceCell.Options.UseTextOptions = true;
            this.colProductGroupID1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductGroupID1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProductGroupID1.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colProductGroupID1.AppearanceHeader.Options.UseFont = true;
            this.colProductGroupID1.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductGroupID1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductGroupID1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProductGroupID1.Caption = "廠商名稱";
            this.colProductGroupID1.FieldName = "ProductGroupID";
            this.colProductGroupID1.Name = "colProductGroupID1";
            this.colProductGroupID1.OptionsColumn.AllowEdit = false;
            this.colProductGroupID1.Visible = true;
            this.colProductGroupID1.VisibleIndex = 1;
            // 
            // colProductName1
            // 
            this.colProductName1.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colProductName1.AppearanceCell.Options.UseFont = true;
            this.colProductName1.AppearanceCell.Options.UseTextOptions = true;
            this.colProductName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductName1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProductName1.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colProductName1.AppearanceHeader.Options.UseFont = true;
            this.colProductName1.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductName1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProductName1.Caption = "產品名稱";
            this.colProductName1.FieldName = "ProductName";
            this.colProductName1.Name = "colProductName1";
            this.colProductName1.OptionsColumn.AllowEdit = false;
            this.colProductName1.Visible = true;
            this.colProductName1.VisibleIndex = 2;
            // 
            // colPrice1
            // 
            this.colPrice1.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colPrice1.AppearanceCell.Options.UseFont = true;
            this.colPrice1.AppearanceCell.Options.UseTextOptions = true;
            this.colPrice1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrice1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPrice1.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colPrice1.AppearanceHeader.Options.UseFont = true;
            this.colPrice1.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrice1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrice1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPrice1.Caption = "定價";
            this.colPrice1.DisplayFormat.FormatString = "N0";
            this.colPrice1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice1.FieldName = "Price";
            this.colPrice1.Name = "colPrice1";
            this.colPrice1.OptionsColumn.AllowEdit = false;
            this.colPrice1.Visible = true;
            this.colPrice1.VisibleIndex = 3;
            // 
            // colCost1
            // 
            this.colCost1.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colCost1.AppearanceCell.Options.UseFont = true;
            this.colCost1.AppearanceCell.Options.UseTextOptions = true;
            this.colCost1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCost1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCost1.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colCost1.AppearanceHeader.Options.UseFont = true;
            this.colCost1.AppearanceHeader.Options.UseTextOptions = true;
            this.colCost1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCost1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCost1.Caption = "批價";
            this.colCost1.DisplayFormat.FormatString = "N0";
            this.colCost1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCost1.FieldName = "Cost";
            this.colCost1.Name = "colCost1";
            this.colCost1.OptionsColumn.AllowEdit = false;
            this.colCost1.Visible = true;
            this.colCost1.VisibleIndex = 4;
            // 
            // colProfit1
            // 
            this.colProfit1.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colProfit1.AppearanceCell.Options.UseFont = true;
            this.colProfit1.AppearanceCell.Options.UseTextOptions = true;
            this.colProfit1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProfit1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProfit1.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colProfit1.AppearanceHeader.Options.UseFont = true;
            this.colProfit1.AppearanceHeader.Options.UseTextOptions = true;
            this.colProfit1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProfit1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProfit1.Caption = "利潤";
            this.colProfit1.DisplayFormat.FormatString = "N";
            this.colProfit1.FieldName = "Profit";
            this.colProfit1.Name = "colProfit1";
            this.colProfit1.OptionsColumn.AllowEdit = false;
            this.colProfit1.OptionsColumn.AllowFocus = false;
            this.colProfit1.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colProfit1.Visible = true;
            this.colProfit1.VisibleIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 138);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl_ProductInfo);
            this.splitContainer1.Size = new System.Drawing.Size(1226, 613);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 7;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.gridControl_AddProducts);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1226, 185);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "新增";
            // 
            // gridControl_AddProducts
            // 
            this.gridControl_AddProducts.DataSource = this.AddproductsInfomationBindingSource;
            this.gridControl_AddProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_AddProducts.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridControl_AddProducts.Location = new System.Drawing.Point(2, 41);
            this.gridControl_AddProducts.MainView = this.gridView_AddProducts;
            this.gridControl_AddProducts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridControl_AddProducts.Name = "gridControl_AddProducts";
            this.gridControl_AddProducts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repository_ProductGroupID,
            this.repository_ProductName,
            this.repository_Price,
            this.repository_Cost,
            this.repository_Profit});
            this.gridControl_AddProducts.Size = new System.Drawing.Size(1222, 142);
            this.gridControl_AddProducts.TabIndex = 6;
            this.gridControl_AddProducts.UseEmbeddedNavigator = true;
            this.gridControl_AddProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_AddProducts});
            // 
            // AddproductsInfomationBindingSource
            // 
            this.AddproductsInfomationBindingSource.DataSource = typeof(MES.Order.DAL.EntityFramework.ProductsInfomation);
            // 
            // gridView_AddProducts
            // 
            this.gridView_AddProducts.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView_AddProducts.Appearance.Row.Options.UseFont = true;
            this.gridView_AddProducts.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView_AddProducts.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView_AddProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView_AddProducts.GridControl = this.gridControl_AddProducts;
            this.gridView_AddProducts.Name = "gridView_AddProducts";
            this.gridView_AddProducts.NewItemRowText = "點此新增";
            this.gridView_AddProducts.OptionsSelection.MultiSelect = true;
            this.gridView_AddProducts.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView_AddProducts.OptionsView.ShowGroupPanel = false;
            this.gridView_AddProducts.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "AutoID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.Caption = "廠商名稱";
            this.gridColumn2.ColumnEdit = this.repository_ProductGroupID;
            this.gridColumn2.FieldName = "ProductGroupID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // repository_ProductGroupID
            // 
            this.repository_ProductGroupID.AutoHeight = false;
            this.repository_ProductGroupID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repository_ProductGroupID.DataSource = this.keyAndNameForComboBindingSource;
            this.repository_ProductGroupID.DisplayMember = "LocalDescription";
            this.repository_ProductGroupID.Name = "repository_ProductGroupID";
            this.repository_ProductGroupID.NullText = "";
            this.repository_ProductGroupID.ValueMember = "Code";
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.Caption = "產品名稱";
            this.gridColumn3.ColumnEdit = this.repository_ProductName;
            this.gridColumn3.FieldName = "ProductName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // repository_ProductName
            // 
            this.repository_ProductName.AutoHeight = false;
            this.repository_ProductName.Name = "repository_ProductName";
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.Caption = "定價";
            this.gridColumn4.ColumnEdit = this.repository_Price;
            this.gridColumn4.DisplayFormat.FormatString = "N0";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "Price";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // repository_Price
            // 
            this.repository_Price.AutoHeight = false;
            this.repository_Price.Name = "repository_Price";
            this.repository_Price.NullText = "0";
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.Caption = "批價";
            this.gridColumn5.ColumnEdit = this.repository_Cost;
            this.gridColumn5.DisplayFormat.FormatString = "N0";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "Cost";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // repository_Cost
            // 
            this.repository_Cost.AutoHeight = false;
            this.repository_Cost.Name = "repository_Cost";
            this.repository_Cost.NullText = "0";
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn6.Caption = "利潤";
            this.gridColumn6.ColumnEdit = this.repository_Profit;
            this.gridColumn6.DisplayFormat.FormatString = "N0";
            this.gridColumn6.FieldName = "Profit";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // repository_Profit
            // 
            this.repository_Profit.AutoHeight = false;
            this.repository_Profit.Name = "repository_Profit";
            this.repository_Profit.NullText = "0";
            // 
            // ProductInformation
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupControl1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductInformation";
            this.Size = new System.Drawing.Size(1226, 751);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_ProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAndNameForComboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_ProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ProductInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsInfomationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ProductInfo)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_AddProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddproductsInfomationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_AddProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_ProductGroupID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_ProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_Profit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl lbl_ProductGroupID;
        private DevExpress.XtraEditors.LabelControl lbl_ProductName;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_ProductGroupID;
        private DevExpress.XtraEditors.SearchLookUpEdit lookUpEdit_ProductName;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        internal DevExpress.XtraEditors.SimpleButton btn_Save;
        internal DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraGrid.GridControl gridControl_ProductInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ProductInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoID1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductGroupID1;
        private DevExpress.XtraGrid.Columns.GridColumn colCost1;
        private DevExpress.XtraGrid.Columns.GridColumn colProfit1;
        private System.Windows.Forms.BindingSource productsInfomationBindingSource;
        internal DevExpress.XtraEditors.SimpleButton btn_Query;
        private System.Windows.Forms.BindingSource keyAndNameForComboBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalDescription;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource AddproductsInfomationBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl_AddProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_AddProducts;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repository_ProductGroupID;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repository_ProductName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repository_Price;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repository_Cost;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repository_Profit;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}

