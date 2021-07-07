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
            this.btn_Export = new DevExpress.XtraEditors.SimpleButton();
            this.label_Area = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit_Area = new DevExpress.XtraEditors.LookUpEdit();
            this.label_CustomerName = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit_CustomerName = new DevExpress.XtraEditors.LookUpEdit();
            this.lbl_ProductGroupID = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit_ProductGroupID = new DevExpress.XtraEditors.LookUpEdit();
            this.lbl_ProductName = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit_ProductName = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateEdit_OrderDateS = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label_OrderDate = new DevExpress.XtraEditors.LabelControl();
            this.btn_FocusRow = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.keyAndNameForComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.lookUpEdit_addProductGroupID = new DevExpress.XtraEditors.LookUpEdit();
            this.LookUpEdit_addProductName = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.spinEdit_addCount = new DevExpress.XtraEditors.SpinEdit();
            this.textEdit_addTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_addNote1 = new DevExpress.XtraEditors.TextEdit();
            this.gridControl_ProductOrder = new DevExpress.XtraGrid.GridControl();
            this.productsOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_ProductOrder = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAutoID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colArea = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCustomID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCustomName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProductGroupID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProductName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUpdateDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNote3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNote2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTotalCost = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTotalProfit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAddress = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNote1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.FocusbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDateE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDateE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Area.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_CustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_ProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_ProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDateS.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDateS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAndNameForComboBindingSource)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ProductOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ProductOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FocusbindingSource)).BeginInit();
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
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1282, 207);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "查詢";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.05882F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.82353F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.94118F));
            this.tableLayoutPanel1.Controls.Add(this.dateEdit_OrderDateE, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Export, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_Area, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEdit_Area, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_CustomerName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEdit_CustomerName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ProductGroupID, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEdit_ProductGroupID, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ProductName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEdit_ProductName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateEdit_OrderDateS, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_OrderDate, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_FocusRow, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Query, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Save, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Cancel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.toggleSwitch1, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 38);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1274, 164);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dateEdit_OrderDateE
            // 
            this.dateEdit_OrderDateE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEdit_OrderDateE.EditValue = new System.DateTime(2020, 10, 2, 16, 12, 40, 524);
            this.dateEdit_OrderDateE.Location = new System.Drawing.Point(1058, 66);
            this.dateEdit_OrderDateE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateEdit_OrderDateE.Name = "dateEdit_OrderDateE";
            this.dateEdit_OrderDateE.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit_OrderDateE.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_OrderDateE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_OrderDateE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_OrderDateE.Size = new System.Drawing.Size(214, 30);
            this.dateEdit_OrderDateE.TabIndex = 374;
            // 
            // btn_Export
            // 
            this.btn_Export.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_Export.Appearance.BackColor2 = System.Drawing.Color.Khaki;
            this.btn_Export.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Export.Appearance.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Export.Appearance.Options.UseBackColor = true;
            this.btn_Export.Appearance.Options.UseFont = true;
            this.btn_Export.Appearance.Options.UseForeColor = true;
            this.btn_Export.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_Export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Export.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Export.ImageOptions.Image")));
            this.btn_Export.Location = new System.Drawing.Point(185, 112);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(176, 48);
            this.btn_Export.TabIndex = 373;
            this.btn_Export.Text = "匯出";
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // label_Area
            // 
            this.label_Area.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_Area.Appearance.ForeColor = System.Drawing.Color.Black;
            this.label_Area.Appearance.Options.UseFont = true;
            this.label_Area.Appearance.Options.UseForeColor = true;
            this.label_Area.Appearance.Options.UseTextOptions = true;
            this.label_Area.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.label_Area.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.label_Area.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label_Area.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.label_Area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Area.Location = new System.Drawing.Point(3, 4);
            this.label_Area.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_Area.Name = "label_Area";
            this.label_Area.Size = new System.Drawing.Size(176, 46);
            this.label_Area.TabIndex = 364;
            this.label_Area.Text = "地區";
            // 
            // lookUpEdit_Area
            // 
            this.lookUpEdit_Area.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEdit_Area.Location = new System.Drawing.Point(185, 12);
            this.lookUpEdit_Area.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpEdit_Area.Name = "lookUpEdit_Area";
            this.lookUpEdit_Area.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lookUpEdit_Area.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lookUpEdit_Area.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEdit_Area.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_Area.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lookUpEdit_Area.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_Area.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lookUpEdit_Area.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "代號"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocalDescription", "敘述")});
            this.lookUpEdit_Area.Properties.DisplayMember = "LocalDescription";
            this.lookUpEdit_Area.Properties.MaxLength = 8;
            this.lookUpEdit_Area.Properties.NullText = "";
            this.lookUpEdit_Area.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit_Area.Properties.ValueMember = "Code";
            this.lookUpEdit_Area.Size = new System.Drawing.Size(176, 30);
            this.lookUpEdit_Area.TabIndex = 365;
            this.lookUpEdit_Area.TabStop = false;
            this.lookUpEdit_Area.EditValueChanged += new System.EventHandler(this.lookUpEdit_Area_EditValueChanged);
            // 
            // label_CustomerName
            // 
            this.label_CustomerName.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_CustomerName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.label_CustomerName.Appearance.Options.UseFont = true;
            this.label_CustomerName.Appearance.Options.UseForeColor = true;
            this.label_CustomerName.Appearance.Options.UseTextOptions = true;
            this.label_CustomerName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.label_CustomerName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.label_CustomerName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label_CustomerName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.label_CustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_CustomerName.Location = new System.Drawing.Point(367, 4);
            this.label_CustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_CustomerName.Name = "label_CustomerName";
            this.label_CustomerName.Size = new System.Drawing.Size(176, 46);
            this.label_CustomerName.TabIndex = 366;
            this.label_CustomerName.Text = "客戶名稱";
            // 
            // lookUpEdit_CustomerName
            // 
            this.lookUpEdit_CustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEdit_CustomerName.Location = new System.Drawing.Point(549, 12);
            this.lookUpEdit_CustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpEdit_CustomerName.Name = "lookUpEdit_CustomerName";
            this.lookUpEdit_CustomerName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lookUpEdit_CustomerName.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lookUpEdit_CustomerName.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEdit_CustomerName.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_CustomerName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lookUpEdit_CustomerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_CustomerName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lookUpEdit_CustomerName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "代號"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocalDescription", "敘述")});
            this.lookUpEdit_CustomerName.Properties.DisplayMember = "LocalDescription";
            this.lookUpEdit_CustomerName.Properties.MaxLength = 8;
            this.lookUpEdit_CustomerName.Properties.NullText = "";
            this.lookUpEdit_CustomerName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit_CustomerName.Properties.ValueMember = "Code";
            this.lookUpEdit_CustomerName.Size = new System.Drawing.Size(176, 30);
            this.lookUpEdit_CustomerName.TabIndex = 367;
            this.lookUpEdit_CustomerName.TabStop = false;
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
            this.lbl_ProductGroupID.Location = new System.Drawing.Point(731, 4);
            this.lbl_ProductGroupID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_ProductGroupID.Name = "lbl_ProductGroupID";
            this.lbl_ProductGroupID.Size = new System.Drawing.Size(185, 46);
            this.lbl_ProductGroupID.TabIndex = 12;
            this.lbl_ProductGroupID.Text = "廠商名稱";
            // 
            // lookUpEdit_ProductGroupID
            // 
            this.lookUpEdit_ProductGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEdit_ProductGroupID.Location = new System.Drawing.Point(922, 12);
            this.lookUpEdit_ProductGroupID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.lookUpEdit_ProductGroupID.Properties.DisplayMember = "LocalDescription";
            this.lookUpEdit_ProductGroupID.Properties.MaxLength = 8;
            this.lookUpEdit_ProductGroupID.Properties.NullText = "";
            this.lookUpEdit_ProductGroupID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit_ProductGroupID.Properties.ValueMember = "Code";
            this.lookUpEdit_ProductGroupID.Size = new System.Drawing.Size(131, 30);
            this.lookUpEdit_ProductGroupID.TabIndex = 360;
            this.lookUpEdit_ProductGroupID.TabStop = false;
            this.lookUpEdit_ProductGroupID.EditValueChanged += new System.EventHandler(this.lookUpEdit_ProductGroupID_EditValueChanged);
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
            this.lbl_ProductName.Location = new System.Drawing.Point(3, 58);
            this.lbl_ProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(176, 46);
            this.lbl_ProductName.TabIndex = 50;
            this.lbl_ProductName.Text = "產品名稱";
            // 
            // lookUpEdit_ProductName
            // 
            this.lookUpEdit_ProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.lookUpEdit_ProductName, 2);
            this.lookUpEdit_ProductName.Location = new System.Drawing.Point(184, 67);
            this.lookUpEdit_ProductName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lookUpEdit_ProductName.Name = "lookUpEdit_ProductName";
            this.lookUpEdit_ProductName.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit_ProductName.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_ProductName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lookUpEdit_ProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_ProductName.Properties.DisplayMember = "LocalDescription";
            this.lookUpEdit_ProductName.Properties.NullText = "";
            this.lookUpEdit_ProductName.Properties.PopupView = this.searchLookUpEdit1View;
            this.lookUpEdit_ProductName.Properties.ValueMember = "Code";
            this.lookUpEdit_ProductName.Size = new System.Drawing.Size(360, 28);
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
            // dateEdit_OrderDateS
            // 
            this.dateEdit_OrderDateS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEdit_OrderDateS.EditValue = new System.DateTime(2020, 10, 2, 16, 12, 40, 524);
            this.dateEdit_OrderDateS.Location = new System.Drawing.Point(730, 66);
            this.dateEdit_OrderDateS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateEdit_OrderDateS.Name = "dateEdit_OrderDateS";
            this.dateEdit_OrderDateS.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit_OrderDateS.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_OrderDateS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_OrderDateS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_OrderDateS.Size = new System.Drawing.Size(187, 30);
            this.dateEdit_OrderDateS.TabIndex = 369;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(922, 58);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(131, 46);
            this.labelControl1.TabIndex = 371;
            this.labelControl1.Text = "~";
            // 
            // label_OrderDate
            // 
            this.label_OrderDate.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_OrderDate.Appearance.ForeColor = System.Drawing.Color.Black;
            this.label_OrderDate.Appearance.Options.UseFont = true;
            this.label_OrderDate.Appearance.Options.UseForeColor = true;
            this.label_OrderDate.Appearance.Options.UseTextOptions = true;
            this.label_OrderDate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.label_OrderDate.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.label_OrderDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label_OrderDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.label_OrderDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_OrderDate.Location = new System.Drawing.Point(549, 58);
            this.label_OrderDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_OrderDate.Name = "label_OrderDate";
            this.label_OrderDate.Size = new System.Drawing.Size(176, 46);
            this.label_OrderDate.TabIndex = 368;
            this.label_OrderDate.Text = "訂貨日期";
            // 
            // btn_FocusRow
            // 
            this.btn_FocusRow.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_FocusRow.Appearance.BackColor2 = System.Drawing.Color.Khaki;
            this.btn_FocusRow.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_FocusRow.Appearance.ForeColor = System.Drawing.Color.Sienna;
            this.btn_FocusRow.Appearance.Options.UseBackColor = true;
            this.btn_FocusRow.Appearance.Options.UseFont = true;
            this.btn_FocusRow.Appearance.Options.UseForeColor = true;
            this.btn_FocusRow.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_FocusRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_FocusRow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_FocusRow.ImageOptions.Image")));
            this.btn_FocusRow.Location = new System.Drawing.Point(3, 112);
            this.btn_FocusRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_FocusRow.Name = "btn_FocusRow";
            this.btn_FocusRow.Size = new System.Drawing.Size(176, 48);
            this.btn_FocusRow.TabIndex = 372;
            this.btn_FocusRow.Text = "鎖定列";
            this.btn_FocusRow.Click += new System.EventHandler(this.btn_FocusRow_Click);
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
            this.btn_Query.Location = new System.Drawing.Point(1059, 4);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(212, 46);
            this.btn_Query.TabIndex = 363;
            this.btn_Query.Text = "查詢";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
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
            this.btn_Save.Location = new System.Drawing.Point(367, 112);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(176, 48);
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
            this.btn_Cancel.Location = new System.Drawing.Point(549, 112);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(176, 48);
            this.btn_Cancel.TabIndex = 31;
            this.btn_Cancel.Text = "刪除";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleSwitch1.Location = new System.Drawing.Point(731, 119);
            this.toggleSwitch1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.Appearance.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch1.Properties.Appearance.Options.UseTextOptions = true;
            this.toggleSwitch1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.toggleSwitch1.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.toggleSwitch1.Properties.AppearanceDisabled.Options.UseFont = true;
            this.toggleSwitch1.Properties.AppearanceFocused.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.toggleSwitch1.Properties.AppearanceFocused.Options.UseFont = true;
            this.toggleSwitch1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.toggleSwitch1.Properties.OffText = "關閉拉單模式";
            this.toggleSwitch1.Properties.OnText = "開啟拉單模式";
            this.toggleSwitch1.Size = new System.Drawing.Size(185, 52);
            this.toggleSwitch1.TabIndex = 375;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // keyAndNameForComboBindingSource
            // 
            this.keyAndNameForComboBindingSource.DataSource = typeof(MES.Order.DAL.ViewModel.KeyAndNameForCombo);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 207);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl_ProductOrder);
            this.splitContainer1.Size = new System.Drawing.Size(1282, 660);
            this.splitContainer1.SplitterDistance = 116;
            this.splitContainer1.TabIndex = 8;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.tableLayoutPanel2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1282, 116);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "新增";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 41);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.57143F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.42857F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1278, 73);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(1096, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "備註";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(996, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "總售價";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(820, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "數量";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(482, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "產品";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(314, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "廠商";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "地區";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(133, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "客戶名稱";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lookUpEdit_addArea
            // 
            this.lookUpEdit_addArea.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.addOrderViewModelBindingSource, "Area", true));
            this.lookUpEdit_addArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpEdit_addArea.Location = new System.Drawing.Point(6, 33);
            this.lookUpEdit_addArea.Name = "lookUpEdit_addArea";
            this.lookUpEdit_addArea.Properties.Appearance.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lookUpEdit_addArea.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_addArea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_addArea.Properties.DataSource = this.keyAndNameForComboBindingSource;
            this.lookUpEdit_addArea.Properties.DisplayMember = "LocalDescription";
            this.lookUpEdit_addArea.Properties.NullText = "";
            this.lookUpEdit_addArea.Properties.ValueMember = "Code";
            this.lookUpEdit_addArea.Size = new System.Drawing.Size(118, 32);
            this.lookUpEdit_addArea.TabIndex = 7;
            this.lookUpEdit_addArea.EditValueChanged += new System.EventHandler(this.lookUpEdit_addArea_EditValueChanged);
            // 
            // addOrderViewModelBindingSource
            // 
            this.addOrderViewModelBindingSource.DataSource = typeof(MES.Order.DAL.ViewModel.AddOrderViewModel);
            // 
            // LookUpEdit_addCustomerName
            // 
            this.LookUpEdit_addCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.addOrderViewModelBindingSource, "CustomName", true));
            this.LookUpEdit_addCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LookUpEdit_addCustomerName.EditValue = "";
            this.LookUpEdit_addCustomerName.Location = new System.Drawing.Point(133, 33);
            this.LookUpEdit_addCustomerName.Name = "LookUpEdit_addCustomerName";
            this.LookUpEdit_addCustomerName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.LookUpEdit_addCustomerName.Properties.Appearance.Options.UseFont = true;
            this.LookUpEdit_addCustomerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_addCustomerName.Properties.DataSource = this.keyAndNameForComboBindingSource;
            this.LookUpEdit_addCustomerName.Properties.DisplayMember = "LocalDescription";
            this.LookUpEdit_addCustomerName.Properties.NullText = "";
            this.LookUpEdit_addCustomerName.Properties.PopupView = this.gridView3;
            this.LookUpEdit_addCustomerName.Properties.ValueMember = "Code";
            this.LookUpEdit_addCustomerName.Size = new System.Drawing.Size(172, 32);
            this.LookUpEdit_addCustomerName.TabIndex = 8;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // lookUpEdit_addProductGroupID
            // 
            this.lookUpEdit_addProductGroupID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.addOrderViewModelBindingSource, "ProductGroupID", true));
            this.lookUpEdit_addProductGroupID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpEdit_addProductGroupID.Location = new System.Drawing.Point(314, 33);
            this.lookUpEdit_addProductGroupID.Name = "lookUpEdit_addProductGroupID";
            this.lookUpEdit_addProductGroupID.Properties.Appearance.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lookUpEdit_addProductGroupID.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_addProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_addProductGroupID.Properties.DataSource = this.keyAndNameForComboBindingSource;
            this.lookUpEdit_addProductGroupID.Properties.DisplayMember = "LocalDescription";
            this.lookUpEdit_addProductGroupID.Properties.NullText = "";
            this.lookUpEdit_addProductGroupID.Properties.ValueMember = "Code";
            this.lookUpEdit_addProductGroupID.Size = new System.Drawing.Size(159, 32);
            this.lookUpEdit_addProductGroupID.TabIndex = 9;
            this.lookUpEdit_addProductGroupID.EditValueChanged += new System.EventHandler(this.lookUpEdit_addProductGroupID_EditValueChanged);
            // 
            // LookUpEdit_addProductName
            // 
            this.LookUpEdit_addProductName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.addOrderViewModelBindingSource, "ProductName", true));
            this.LookUpEdit_addProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LookUpEdit_addProductName.Location = new System.Drawing.Point(482, 33);
            this.LookUpEdit_addProductName.Name = "LookUpEdit_addProductName";
            this.LookUpEdit_addProductName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.LookUpEdit_addProductName.Properties.Appearance.Options.UseFont = true;
            this.LookUpEdit_addProductName.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.LookUpEdit_addProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_addProductName.Properties.DataSource = this.keyAndNameForComboBindingSource;
            this.LookUpEdit_addProductName.Properties.DisplayMember = "LocalDescription";
            this.LookUpEdit_addProductName.Properties.NullText = "";
            this.LookUpEdit_addProductName.Properties.PopupView = this.searchLookUpEdit2View;
            this.LookUpEdit_addProductName.Properties.ValueMember = "Code";
            this.LookUpEdit_addProductName.Size = new System.Drawing.Size(329, 32);
            this.LookUpEdit_addProductName.TabIndex = 10;
            this.LookUpEdit_addProductName.EditValueChanged += new System.EventHandler(this.LookUpEdit_addProductName_EditValueChanged);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // spinEdit_addCount
            // 
            this.spinEdit_addCount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.addOrderViewModelBindingSource, "Count", true));
            this.spinEdit_addCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spinEdit_addCount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit_addCount.Location = new System.Drawing.Point(820, 33);
            this.spinEdit_addCount.Name = "spinEdit_addCount";
            this.spinEdit_addCount.Properties.Appearance.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.spinEdit_addCount.Properties.Appearance.Options.UseFont = true;
            this.spinEdit_addCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_addCount.Properties.NullText = "0";
            this.spinEdit_addCount.Size = new System.Drawing.Size(167, 32);
            this.spinEdit_addCount.TabIndex = 11;
            this.spinEdit_addCount.EditValueChanged += new System.EventHandler(this.spinEdit_addCount_EditValueChanged);
            // 
            // textEdit_addTotalPrice
            // 
            this.textEdit_addTotalPrice.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.addOrderViewModelBindingSource, "TotalPrice", true));
            this.textEdit_addTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit_addTotalPrice.EditValue = ((short)(0));
            this.textEdit_addTotalPrice.Enabled = false;
            this.textEdit_addTotalPrice.Location = new System.Drawing.Point(996, 33);
            this.textEdit_addTotalPrice.Name = "textEdit_addTotalPrice";
            this.textEdit_addTotalPrice.Properties.Appearance.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.textEdit_addTotalPrice.Properties.Appearance.Options.UseFont = true;
            this.textEdit_addTotalPrice.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.textEdit_addTotalPrice.Properties.ReadOnly = true;
            this.textEdit_addTotalPrice.Size = new System.Drawing.Size(91, 32);
            this.textEdit_addTotalPrice.TabIndex = 12;
            // 
            // textEdit_addNote1
            // 
            this.textEdit_addNote1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.addOrderViewModelBindingSource, "Note1", true));
            this.textEdit_addNote1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit_addNote1.Location = new System.Drawing.Point(1096, 33);
            this.textEdit_addNote1.Name = "textEdit_addNote1";
            this.textEdit_addNote1.Properties.Appearance.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.textEdit_addNote1.Properties.Appearance.Options.UseFont = true;
            this.textEdit_addNote1.Size = new System.Drawing.Size(176, 32);
            this.textEdit_addNote1.TabIndex = 13;
            // 
            // gridControl_ProductOrder
            // 
            this.gridControl_ProductOrder.AllowDrop = true;
            this.gridControl_ProductOrder.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridControl_ProductOrder.DataSource = this.productsOrderBindingSource;
            this.gridControl_ProductOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ProductOrder.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridControl_ProductOrder.Location = new System.Drawing.Point(0, 0);
            this.gridControl_ProductOrder.MainView = this.gridView_ProductOrder;
            this.gridControl_ProductOrder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridControl_ProductOrder.Name = "gridControl_ProductOrder";
            this.gridControl_ProductOrder.Size = new System.Drawing.Size(1282, 540);
            this.gridControl_ProductOrder.TabIndex = 5;
            this.gridControl_ProductOrder.UseEmbeddedNavigator = true;
            this.gridControl_ProductOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ProductOrder});
            // 
            // productsOrderBindingSource
            // 
            this.productsOrderBindingSource.DataSource = typeof(MES.Order.DAL.EntityFramework.ProductsOrder);
            // 
            // gridView_ProductOrder
            // 
            this.gridView_ProductOrder.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.gridView_ProductOrder.Appearance.Row.Options.UseFont = true;
            this.gridView_ProductOrder.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.gridView_ProductOrder.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
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
            this.colAddress,
            this.colTotalCost,
            this.colTotalProfit,
            this.colUpdateDate,
            this.colNote3,
            this.colNote2});
            this.gridView_ProductOrder.DetailHeight = 450;
            this.gridView_ProductOrder.FixedLineWidth = 3;
            this.gridView_ProductOrder.GridControl = this.gridControl_ProductOrder;
            this.gridView_ProductOrder.Name = "gridView_ProductOrder";
            this.gridView_ProductOrder.NewItemRowText = "點此新增";
            this.gridView_ProductOrder.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView_ProductOrder.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView_ProductOrder.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView_ProductOrder.OptionsSelection.MultiSelect = true;
            this.gridView_ProductOrder.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView_ProductOrder.OptionsView.ShowGroupPanel = false;
            this.gridView_ProductOrder.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAutoID, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.Caption = "基本資料";
            this.gridBand1.Columns.Add(this.colAutoID);
            this.gridBand1.Columns.Add(this.colArea);
            this.gridBand1.Columns.Add(this.colCustomID);
            this.gridBand1.Columns.Add(this.colCustomName);
            this.gridBand1.Columns.Add(this.colProductGroupID);
            this.gridBand1.Columns.Add(this.colProductName);
            this.gridBand1.Columns.Add(this.colOrderDate);
            this.gridBand1.Columns.Add(this.colUpdateDate);
            this.gridBand1.Columns.Add(this.colNote3);
            this.gridBand1.Columns.Add(this.colNote2);
            this.gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand1.MinWidth = 11;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 544;
            // 
            // colAutoID
            // 
            this.colAutoID.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colAutoID.AppearanceCell.Options.UseFont = true;
            this.colAutoID.AppearanceCell.Options.UseTextOptions = true;
            this.colAutoID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAutoID.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAutoID.AppearanceHeader.Options.UseFont = true;
            this.colAutoID.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAutoID.FieldName = "AutoID";
            this.colAutoID.MinWidth = 23;
            this.colAutoID.Name = "colAutoID";
            this.colAutoID.OptionsColumn.AllowFocus = false;
            this.colAutoID.Width = 86;
            // 
            // colArea
            // 
            this.colArea.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colArea.AppearanceCell.Options.UseFont = true;
            this.colArea.AppearanceCell.Options.UseTextOptions = true;
            this.colArea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colArea.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colArea.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colArea.AppearanceHeader.Options.UseFont = true;
            this.colArea.AppearanceHeader.Options.UseTextOptions = true;
            this.colArea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colArea.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colArea.Caption = "地區";
            this.colArea.FieldName = "Area";
            this.colArea.MinWidth = 23;
            this.colArea.Name = "colArea";
            this.colArea.OptionsColumn.AllowFocus = false;
            this.colArea.Visible = true;
            this.colArea.Width = 64;
            // 
            // colCustomID
            // 
            this.colCustomID.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colCustomID.AppearanceCell.Options.UseFont = true;
            this.colCustomID.AppearanceCell.Options.UseTextOptions = true;
            this.colCustomID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCustomID.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCustomID.AppearanceHeader.Options.UseFont = true;
            this.colCustomID.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCustomID.Caption = "客戶代號";
            this.colCustomID.FieldName = "CustomID";
            this.colCustomID.MinWidth = 23;
            this.colCustomID.Name = "colCustomID";
            this.colCustomID.OptionsColumn.AllowFocus = false;
            this.colCustomID.Width = 86;
            // 
            // colCustomName
            // 
            this.colCustomName.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colCustomName.AppearanceCell.Options.UseFont = true;
            this.colCustomName.AppearanceCell.Options.UseTextOptions = true;
            this.colCustomName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCustomName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCustomName.AppearanceHeader.Options.UseFont = true;
            this.colCustomName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCustomName.Caption = "客戶名稱";
            this.colCustomName.FieldName = "CustomName";
            this.colCustomName.MinWidth = 23;
            this.colCustomName.Name = "colCustomName";
            this.colCustomName.OptionsColumn.AllowFocus = false;
            this.colCustomName.Visible = true;
            this.colCustomName.Width = 99;
            // 
            // colProductGroupID
            // 
            this.colProductGroupID.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colProductGroupID.AppearanceCell.Options.UseFont = true;
            this.colProductGroupID.AppearanceCell.Options.UseTextOptions = true;
            this.colProductGroupID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductGroupID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProductGroupID.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colProductGroupID.AppearanceHeader.Options.UseFont = true;
            this.colProductGroupID.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductGroupID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductGroupID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProductGroupID.Caption = "廠商";
            this.colProductGroupID.FieldName = "ProductGroupID";
            this.colProductGroupID.MinWidth = 23;
            this.colProductGroupID.Name = "colProductGroupID";
            this.colProductGroupID.OptionsColumn.AllowFocus = false;
            this.colProductGroupID.Width = 78;
            // 
            // colProductName
            // 
            this.colProductName.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colProductName.AppearanceCell.Options.UseFont = true;
            this.colProductName.AppearanceCell.Options.UseTextOptions = true;
            this.colProductName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProductName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colProductName.AppearanceHeader.Options.UseFont = true;
            this.colProductName.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProductName.Caption = "產品";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.MinWidth = 23;
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.AllowFocus = false;
            this.colProductName.Visible = true;
            this.colProductName.Width = 290;
            // 
            // colOrderDate
            // 
            this.colOrderDate.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colOrderDate.AppearanceCell.Options.UseFont = true;
            this.colOrderDate.AppearanceCell.Options.UseTextOptions = true;
            this.colOrderDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colOrderDate.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colOrderDate.AppearanceHeader.Options.UseFont = true;
            this.colOrderDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrderDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colOrderDate.Caption = "訂購日期";
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.MinWidth = 23;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.OptionsColumn.AllowFocus = false;
            this.colOrderDate.Visible = true;
            this.colOrderDate.Width = 91;
            // 
            // colUpdateDate
            // 
            this.colUpdateDate.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colUpdateDate.AppearanceCell.Options.UseFont = true;
            this.colUpdateDate.AppearanceCell.Options.UseTextOptions = true;
            this.colUpdateDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUpdateDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUpdateDate.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUpdateDate.AppearanceHeader.Options.UseFont = true;
            this.colUpdateDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colUpdateDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUpdateDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUpdateDate.FieldName = "UpdateDate";
            this.colUpdateDate.MinWidth = 23;
            this.colUpdateDate.Name = "colUpdateDate";
            this.colUpdateDate.OptionsColumn.AllowFocus = false;
            this.colUpdateDate.Width = 86;
            // 
            // colNote3
            // 
            this.colNote3.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colNote3.AppearanceCell.Options.UseFont = true;
            this.colNote3.AppearanceCell.Options.UseTextOptions = true;
            this.colNote3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNote3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNote3.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNote3.AppearanceHeader.Options.UseFont = true;
            this.colNote3.AppearanceHeader.Options.UseTextOptions = true;
            this.colNote3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNote3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNote3.FieldName = "Note3";
            this.colNote3.MinWidth = 23;
            this.colNote3.Name = "colNote3";
            this.colNote3.OptionsColumn.AllowFocus = false;
            this.colNote3.Width = 86;
            // 
            // colNote2
            // 
            this.colNote2.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colNote2.AppearanceCell.Options.UseFont = true;
            this.colNote2.AppearanceCell.Options.UseTextOptions = true;
            this.colNote2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNote2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNote2.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNote2.AppearanceHeader.Options.UseFont = true;
            this.colNote2.AppearanceHeader.Options.UseTextOptions = true;
            this.colNote2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNote2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNote2.FieldName = "Note2";
            this.colNote2.MinWidth = 23;
            this.colNote2.Name = "colNote2";
            this.colNote2.OptionsColumn.AllowFocus = false;
            this.colNote2.Width = 86;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.Caption = "訂購資料";
            this.gridBand2.Columns.Add(this.colCount);
            this.gridBand2.Columns.Add(this.colPrice);
            this.gridBand2.Columns.Add(this.colTotalCost);
            this.gridBand2.Columns.Add(this.colTotalPrice);
            this.gridBand2.Columns.Add(this.colTotalProfit);
            this.gridBand2.Columns.Add(this.colAddress);
            this.gridBand2.Columns.Add(this.colNote1);
            this.gridBand2.MinWidth = 11;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 554;
            // 
            // colCount
            // 
            this.colCount.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colCount.AppearanceCell.Options.UseFont = true;
            this.colCount.AppearanceCell.Options.UseTextOptions = true;
            this.colCount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCount.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCount.AppearanceHeader.Options.UseFont = true;
            this.colCount.AppearanceHeader.Options.UseTextOptions = true;
            this.colCount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCount.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCount.Caption = "數量";
            this.colCount.FieldName = "Count";
            this.colCount.MinWidth = 23;
            this.colCount.Name = "colCount";
            this.colCount.OptionsColumn.AllowFocus = false;
            this.colCount.Visible = true;
            this.colCount.Width = 64;
            // 
            // colPrice
            // 
            this.colPrice.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colPrice.AppearanceCell.Options.UseFont = true;
            this.colPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPrice.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPrice.AppearanceHeader.Options.UseFont = true;
            this.colPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrice.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPrice.Caption = "售價";
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 23;
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowFocus = false;
            this.colPrice.Visible = true;
            this.colPrice.Width = 61;
            // 
            // colTotalCost
            // 
            this.colTotalCost.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colTotalCost.AppearanceCell.Options.UseFont = true;
            this.colTotalCost.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalCost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalCost.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTotalCost.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTotalCost.AppearanceHeader.Options.UseFont = true;
            this.colTotalCost.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalCost.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTotalCost.Caption = "總批價";
            this.colTotalCost.FieldName = "TotalCost";
            this.colTotalCost.MinWidth = 23;
            this.colTotalCost.Name = "colTotalCost";
            this.colTotalCost.OptionsColumn.AllowFocus = false;
            this.colTotalCost.Visible = true;
            this.colTotalCost.Width = 70;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colTotalPrice.AppearanceCell.Options.UseFont = true;
            this.colTotalPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTotalPrice.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTotalPrice.AppearanceHeader.Options.UseFont = true;
            this.colTotalPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalPrice.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTotalPrice.Caption = "總售價";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.MinWidth = 23;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.OptionsColumn.AllowFocus = false;
            this.colTotalPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "Sum:{0}")});
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.Width = 70;
            // 
            // colTotalProfit
            // 
            this.colTotalProfit.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colTotalProfit.AppearanceCell.Options.UseFont = true;
            this.colTotalProfit.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalProfit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalProfit.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTotalProfit.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTotalProfit.AppearanceHeader.Options.UseFont = true;
            this.colTotalProfit.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalProfit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalProfit.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTotalProfit.Caption = "總利潤";
            this.colTotalProfit.FieldName = "TotalProfit";
            this.colTotalProfit.MinWidth = 23;
            this.colTotalProfit.Name = "colTotalProfit";
            this.colTotalProfit.OptionsColumn.AllowFocus = false;
            this.colTotalProfit.Visible = true;
            this.colTotalProfit.Width = 77;
            // 
            // colAddress
            // 
            this.colAddress.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colAddress.AppearanceCell.Options.UseFont = true;
            this.colAddress.AppearanceCell.Options.UseTextOptions = true;
            this.colAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddress.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAddress.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAddress.AppearanceHeader.Options.UseFont = true;
            this.colAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddress.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAddress.Caption = "是否取貨";
            this.colAddress.FieldName = "Address";
            this.colAddress.MinWidth = 23;
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.Width = 89;
            // 
            // colNote1
            // 
            this.colNote1.AppearanceCell.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.colNote1.AppearanceCell.Options.UseFont = true;
            this.colNote1.AppearanceCell.Options.UseTextOptions = true;
            this.colNote1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNote1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNote1.AppearanceHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNote1.AppearanceHeader.Options.UseFont = true;
            this.colNote1.AppearanceHeader.Options.UseTextOptions = true;
            this.colNote1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNote1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNote1.Caption = "備註";
            this.colNote1.FieldName = "Note1";
            this.colNote1.MinWidth = 23;
            this.colNote1.Name = "colNote1";
            this.colNote1.OptionsColumn.AllowFocus = false;
            this.colNote1.Visible = true;
            this.colNote1.Width = 123;
            // 
            // FocusbindingSource
            // 
            this.FocusbindingSource.DataSource = typeof(MES.Order.DAL.EntityFramework.ProductsOrder);
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
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(1282, 867);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDateE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDateE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Area.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_CustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_ProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_ProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDateS.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDateS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAndNameForComboBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ProductOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ProductOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FocusbindingSource)).EndInit();
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
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_CustomerName;
        private DevExpress.XtraEditors.LabelControl label_OrderDate;
        private DevExpress.XtraEditors.DateEdit dateEdit_OrderDateE;
        internal DevExpress.XtraEditors.SimpleButton btn_Export;
        private DevExpress.XtraEditors.DateEdit dateEdit_OrderDateS;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        internal DevExpress.XtraEditors.SimpleButton btn_FocusRow;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl_ProductOrder;
        private System.Windows.Forms.BindingSource productsOrderBindingSource;
        private System.Windows.Forms.BindingSource keyAndNameForComboBindingSource;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource FocusbindingSource;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gridView_ProductOrder;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAutoID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colArea;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCustomID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCustomName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProductGroupID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProductName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOrderDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUpdateDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNote3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNote2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTotalCost;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTotalPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTotalProfit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAddress;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNote1;
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
    }
}