
using CSYCodeAdvance.EditorControls;
using DevExpress.XtraEditors;

namespace Ritek.App.Demo
{
    partial class MaintainMetalMask
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
            DevExpress.Utils.Animation.SlideFadeTransition slideFadeTransition1 = new DevExpress.Utils.Animation.SlideFadeTransition();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textEdit_SeriesNo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_SteelPlate = new DevExpress.XtraGrid.GridControl();
            this.steelPlateViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_SteelPlate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSteelPlate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSteelPlateSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_Thickness = new DevExpress.XtraGrid.GridControl();
            this.thicknessViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_Thickness = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPhotoresistThickness = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriesNoThickness = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_Development = new DevExpress.XtraGrid.GridControl();
            this.developmentViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_Development = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDevelopPressure1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFluidPressure2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDevelopmentSpeed1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFluidVelocity2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_LDI = new DevExpress.XtraGrid.GridControl();
            this.lDIViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_LDI = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLimitCollation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDefocus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExposure = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_SeriesNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_SteelPlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelPlateViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_SteelPlate)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Thickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Thickness)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Development)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developmentViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Development)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_LDI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDIViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_LDI)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(935, 570);
            this.splitContainerControl1.SplitterPosition = 41;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.48128F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.51871F));
            this.tableLayoutPanel1.Controls.Add(this.textEdit_SeriesNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.11005F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(935, 41);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textEdit_SeriesNo
            // 
            this.textEdit_SeriesNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", global::Ritek.App.Demo.Properties.Settings.Default, "SeriesNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_SeriesNo.Dock = System.Windows.Forms.DockStyle.Left;
            this.textEdit_SeriesNo.EditValue = global::Ritek.App.Demo.Properties.Settings.Default.SeriesNo;
            this.textEdit_SeriesNo.Location = new System.Drawing.Point(100, 3);
            this.textEdit_SeriesNo.Name = "textEdit_SeriesNo";
            this.textEdit_SeriesNo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_SeriesNo.Properties.Appearance.Options.UseFont = true;
            this.textEdit_SeriesNo.Size = new System.Drawing.Size(100, 28);
            this.textEdit_SeriesNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "輸入訂單:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(177)))), ((int)(((byte)(181)))));
            this.xtraTabControl1.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabControl1.Appearance.Options.UseBorderColor = true;
            this.xtraTabControl1.Appearance.Options.UseFont = true;
            this.xtraTabControl1.AppearancePage.Header.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(177)))), ((int)(((byte)(181)))));
            this.xtraTabControl1.AppearancePage.Header.Options.UseBorderColor = true;
            this.xtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.xtraTabControl1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(935, 519);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            this.xtraTabControl1.Transition.EasingMode = DevExpress.Data.Utils.EasingMode.EaseOut;
            this.xtraTabControl1.Transition.TransitionType = slideFadeTransition1;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(143)))), ((int)(((byte)(176)))));
            this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage1.Appearance.Header.Options.UseBackColor = true;
            this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage1.Appearance.HeaderActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.xtraTabPage1.Appearance.HeaderActive.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.xtraTabPage1.Appearance.HeaderActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.xtraTabPage1.Appearance.HeaderActive.Options.UseBackColor = true;
            this.xtraTabPage1.Appearance.HeaderActive.Options.UseFont = true;
            this.xtraTabPage1.Appearance.HeaderActive.Options.UseForeColor = true;
            this.xtraTabPage1.Controls.Add(this.gridControl_SteelPlate);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(882, 513);
            this.xtraTabPage1.Text = "鋼板";
            // 
            // gridControl_SteelPlate
            // 
            this.gridControl_SteelPlate.DataSource = this.steelPlateViewModelBindingSource;
            this.gridControl_SteelPlate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_SteelPlate.Location = new System.Drawing.Point(0, 0);
            this.gridControl_SteelPlate.MainView = this.gridView_SteelPlate;
            this.gridControl_SteelPlate.Name = "gridControl_SteelPlate";
            this.gridControl_SteelPlate.Size = new System.Drawing.Size(882, 513);
            this.gridControl_SteelPlate.TabIndex = 0;
            this.gridControl_SteelPlate.UseEmbeddedNavigator = true;
            this.gridControl_SteelPlate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_SteelPlate});
            // 
            // steelPlateViewModelBindingSource
            // 
            this.steelPlateViewModelBindingSource.DataSource = typeof(Ritek.App.Infrastructure.SteelPlateViewModel);
            // 
            // gridView_SteelPlate
            // 
            this.gridView_SteelPlate.Appearance.HeaderPanel.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.gridView_SteelPlate.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView_SteelPlate.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_SteelPlate.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_SteelPlate.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_SteelPlate.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_SteelPlate.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_SteelPlate.Appearance.Row.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView_SteelPlate.Appearance.Row.Options.UseFont = true;
            this.gridView_SteelPlate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSteelPlate,
            this.colSteelPlateSize});
            this.gridView_SteelPlate.GridControl = this.gridControl_SteelPlate;
            this.gridView_SteelPlate.Name = "gridView_SteelPlate";
            this.gridView_SteelPlate.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            // 
            // colSteelPlate
            // 
            this.colSteelPlate.FieldName = "SteelPlate";
            this.colSteelPlate.Name = "colSteelPlate";
            this.colSteelPlate.Visible = true;
            this.colSteelPlate.VisibleIndex = 0;
            // 
            // colSteelPlateSize
            // 
            this.colSteelPlateSize.FieldName = "SteelPlateSize";
            this.colSteelPlateSize.Name = "colSteelPlateSize";
            this.colSteelPlateSize.Visible = true;
            this.colSteelPlateSize.VisibleIndex = 1;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(143)))), ((int)(((byte)(176)))));
            this.xtraTabPage2.Appearance.Header.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage2.Appearance.Header.Options.UseBackColor = true;
            this.xtraTabPage2.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage2.Appearance.HeaderActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.xtraTabPage2.Appearance.HeaderActive.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.xtraTabPage2.Appearance.HeaderActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.xtraTabPage2.Appearance.HeaderActive.Options.UseBackColor = true;
            this.xtraTabPage2.Appearance.HeaderActive.Options.UseFont = true;
            this.xtraTabPage2.Appearance.HeaderActive.Options.UseForeColor = true;
            this.xtraTabPage2.Controls.Add(this.gridControl_Thickness);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(882, 513);
            this.xtraTabPage2.Text = "厚度";
            // 
            // gridControl_Thickness
            // 
            this.gridControl_Thickness.DataSource = this.thicknessViewModelBindingSource;
            this.gridControl_Thickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Thickness.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Thickness.MainView = this.gridView_Thickness;
            this.gridControl_Thickness.Name = "gridControl_Thickness";
            this.gridControl_Thickness.Size = new System.Drawing.Size(882, 513);
            this.gridControl_Thickness.TabIndex = 0;
            this.gridControl_Thickness.UseEmbeddedNavigator = true;
            this.gridControl_Thickness.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Thickness});
            // 
            // thicknessViewModelBindingSource
            // 
            this.thicknessViewModelBindingSource.DataSource = typeof(Ritek.App.Infrastructure.ThicknessViewModel);
            // 
            // gridView_Thickness
            // 
            this.gridView_Thickness.Appearance.HeaderPanel.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.gridView_Thickness.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView_Thickness.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_Thickness.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_Thickness.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_Thickness.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_Thickness.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.gridView_Thickness.Appearance.Row.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.gridView_Thickness.Appearance.Row.Options.UseFont = true;
            this.gridView_Thickness.Appearance.TopNewRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView_Thickness.Appearance.TopNewRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView_Thickness.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView_Thickness.Appearance.TopNewRow.Options.UseForeColor = true;
            this.gridView_Thickness.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView_Thickness.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_Thickness.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_Thickness.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPhotoresistThickness,
            this.colSeriesNoThickness});
            this.gridView_Thickness.GridControl = this.gridControl_Thickness;
            this.gridView_Thickness.Name = "gridView_Thickness";
            this.gridView_Thickness.NewItemRowText = "點此新增";
            this.gridView_Thickness.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView_Thickness.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colPhotoresistThickness
            // 
            this.colPhotoresistThickness.FieldName = "PhotoresistThickness";
            this.colPhotoresistThickness.Name = "colPhotoresistThickness";
            this.colPhotoresistThickness.Visible = true;
            this.colPhotoresistThickness.VisibleIndex = 0;
            // 
            // colSeriesNoThickness
            // 
            this.colSeriesNoThickness.FieldName = "SeriesNoThickness";
            this.colSeriesNoThickness.Name = "colSeriesNoThickness";
            this.colSeriesNoThickness.Visible = true;
            this.colSeriesNoThickness.VisibleIndex = 1;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(143)))), ((int)(((byte)(176)))));
            this.xtraTabPage3.Appearance.Header.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage3.Appearance.Header.Options.UseBackColor = true;
            this.xtraTabPage3.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage3.Appearance.HeaderActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.xtraTabPage3.Appearance.HeaderActive.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.xtraTabPage3.Appearance.HeaderActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.xtraTabPage3.Appearance.HeaderActive.Options.UseBackColor = true;
            this.xtraTabPage3.Appearance.HeaderActive.Options.UseFont = true;
            this.xtraTabPage3.Appearance.HeaderActive.Options.UseForeColor = true;
            this.xtraTabPage3.Controls.Add(this.gridControl_Development);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(882, 513);
            this.xtraTabPage3.Text = "顯影";
            // 
            // gridControl_Development
            // 
            this.gridControl_Development.DataSource = this.developmentViewModelBindingSource;
            this.gridControl_Development.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Development.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Development.MainView = this.gridView_Development;
            this.gridControl_Development.Name = "gridControl_Development";
            this.gridControl_Development.Size = new System.Drawing.Size(882, 513);
            this.gridControl_Development.TabIndex = 0;
            this.gridControl_Development.UseEmbeddedNavigator = true;
            this.gridControl_Development.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Development});
            // 
            // developmentViewModelBindingSource
            // 
            this.developmentViewModelBindingSource.DataSource = typeof(Ritek.App.Infrastructure.DevelopmentViewModel);
            // 
            // gridView_Development
            // 
            this.gridView_Development.Appearance.HeaderPanel.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.gridView_Development.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView_Development.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_Development.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_Development.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_Development.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_Development.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_Development.Appearance.Row.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.gridView_Development.Appearance.Row.Options.UseFont = true;
            this.gridView_Development.Appearance.TopNewRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView_Development.Appearance.TopNewRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView_Development.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView_Development.Appearance.TopNewRow.Options.UseForeColor = true;
            this.gridView_Development.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView_Development.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_Development.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_Development.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDevelopPressure1,
            this.colFluidPressure2,
            this.colDevelopmentSpeed1,
            this.colFluidVelocity2});
            this.gridView_Development.GridControl = this.gridControl_Development;
            this.gridView_Development.Name = "gridView_Development";
            this.gridView_Development.NewItemRowText = "點此新增";
            this.gridView_Development.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView_Development.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colDevelopPressure1
            // 
            this.colDevelopPressure1.FieldName = "DevelopPressure1";
            this.colDevelopPressure1.Name = "colDevelopPressure1";
            this.colDevelopPressure1.Visible = true;
            this.colDevelopPressure1.VisibleIndex = 0;
            // 
            // colFluidPressure2
            // 
            this.colFluidPressure2.FieldName = "FluidPressure2";
            this.colFluidPressure2.Name = "colFluidPressure2";
            this.colFluidPressure2.Visible = true;
            this.colFluidPressure2.VisibleIndex = 1;
            // 
            // colDevelopmentSpeed1
            // 
            this.colDevelopmentSpeed1.FieldName = "DevelopmentSpeed1";
            this.colDevelopmentSpeed1.Name = "colDevelopmentSpeed1";
            this.colDevelopmentSpeed1.Visible = true;
            this.colDevelopmentSpeed1.VisibleIndex = 2;
            // 
            // colFluidVelocity2
            // 
            this.colFluidVelocity2.FieldName = "FluidVelocity2";
            this.colFluidVelocity2.Name = "colFluidVelocity2";
            this.colFluidVelocity2.Visible = true;
            this.colFluidVelocity2.VisibleIndex = 3;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(143)))), ((int)(((byte)(176)))));
            this.xtraTabPage4.Appearance.Header.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage4.Appearance.Header.Options.UseBackColor = true;
            this.xtraTabPage4.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage4.Appearance.HeaderActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.xtraTabPage4.Appearance.HeaderActive.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.xtraTabPage4.Appearance.HeaderActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.xtraTabPage4.Appearance.HeaderActive.Options.UseBackColor = true;
            this.xtraTabPage4.Appearance.HeaderActive.Options.UseFont = true;
            this.xtraTabPage4.Appearance.HeaderActive.Options.UseForeColor = true;
            this.xtraTabPage4.Controls.Add(this.gridControl_LDI);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(882, 513);
            this.xtraTabPage4.Text = "曝光";
            // 
            // gridControl_LDI
            // 
            this.gridControl_LDI.DataSource = this.lDIViewModelBindingSource;
            this.gridControl_LDI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_LDI.Location = new System.Drawing.Point(0, 0);
            this.gridControl_LDI.MainView = this.gridView_LDI;
            this.gridControl_LDI.Name = "gridControl_LDI";
            this.gridControl_LDI.Size = new System.Drawing.Size(882, 513);
            this.gridControl_LDI.TabIndex = 0;
            this.gridControl_LDI.UseEmbeddedNavigator = true;
            this.gridControl_LDI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_LDI});
            // 
            // lDIViewModelBindingSource
            // 
            this.lDIViewModelBindingSource.DataSource = typeof(Ritek.App.Infrastructure.LDIViewModel);
            // 
            // gridView_LDI
            // 
            this.gridView_LDI.Appearance.HeaderPanel.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.gridView_LDI.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView_LDI.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_LDI.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_LDI.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_LDI.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_LDI.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_LDI.Appearance.Row.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.gridView_LDI.Appearance.Row.Options.UseFont = true;
            this.gridView_LDI.Appearance.TopNewRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView_LDI.Appearance.TopNewRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView_LDI.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView_LDI.Appearance.TopNewRow.Options.UseForeColor = true;
            this.gridView_LDI.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView_LDI.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_LDI.Appearance.TopNewRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.gridView_LDI.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_LDI.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategory,
            this.colLimitCollation,
            this.colDefocus,
            this.colExposure});
            this.gridView_LDI.GridControl = this.gridControl_LDI;
            this.gridView_LDI.Name = "gridView_LDI";
            this.gridView_LDI.NewItemRowText = "點此新增";
            this.gridView_LDI.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView_LDI.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 0;
            // 
            // colLimitCollation
            // 
            this.colLimitCollation.FieldName = "LimitCollation";
            this.colLimitCollation.Name = "colLimitCollation";
            this.colLimitCollation.Visible = true;
            this.colLimitCollation.VisibleIndex = 1;
            // 
            // colDefocus
            // 
            this.colDefocus.FieldName = "Defocus";
            this.colDefocus.Name = "colDefocus";
            this.colDefocus.Visible = true;
            this.colDefocus.VisibleIndex = 2;
            // 
            // colExposure
            // 
            this.colExposure.FieldName = "Exposure";
            this.colExposure.Name = "colExposure";
            this.colExposure.Visible = true;
            this.colExposure.VisibleIndex = 3;
            // 
            // MaintainMetalMask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 570);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "MaintainMetalMask";
            this.Text = "生產記錄表";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MaintainMetalMask_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_SeriesNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_SteelPlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelPlateViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_SteelPlate)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Thickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Thickness)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Development)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developmentViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Development)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_LDI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDIViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_LDI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TextEdit textEdit_SeriesNo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridControl_SteelPlate;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_SteelPlate;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl_Thickness;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Thickness;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl gridControl_Development;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Development;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraGrid.GridControl gridControl_LDI;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_LDI;
        private System.Windows.Forms.BindingSource steelPlateViewModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSteelPlate;
        private DevExpress.XtraGrid.Columns.GridColumn colSteelPlateSize;
        private System.Windows.Forms.BindingSource thicknessViewModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPhotoresistThickness;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriesNoThickness;
        private System.Windows.Forms.BindingSource developmentViewModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDevelopPressure1;
        private DevExpress.XtraGrid.Columns.GridColumn colFluidPressure2;
        private DevExpress.XtraGrid.Columns.GridColumn colDevelopmentSpeed1;
        private DevExpress.XtraGrid.Columns.GridColumn colFluidVelocity2;
        private System.Windows.Forms.BindingSource lDIViewModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colLimitCollation;
        private DevExpress.XtraGrid.Columns.GridColumn colDefocus;
        private DevExpress.XtraGrid.Columns.GridColumn colExposure;
    }
}