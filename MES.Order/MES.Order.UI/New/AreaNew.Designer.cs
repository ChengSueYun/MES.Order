namespace MES.Order.UI.New
{
    partial class AreaNew
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
            this.gridControl_Area = new DevExpress.XtraGrid.GridControl();
            this.areaInfoViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_Area = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colArea = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Area)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaInfoViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Area)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_Area
            // 
            this.gridControl_Area.DataSource = this.areaInfoViewModelBindingSource;
            this.gridControl_Area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Area.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Area.MainView = this.gridView_Area;
            this.gridControl_Area.Name = "gridControl_Area";
            this.gridControl_Area.Size = new System.Drawing.Size(298, 268);
            this.gridControl_Area.TabIndex = 0;
            this.gridControl_Area.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Area});
            // 
            // areaInfoViewModelBindingSource
            // 
            this.areaInfoViewModelBindingSource.DataSource = typeof(MES.Order.Infrastructure.NewViewModel.AreaInfoViewModel);
            // 
            // gridView_Area
            // 
            this.gridView_Area.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.gridView_Area.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView_Area.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colArea});
            this.gridView_Area.GridControl = this.gridControl_Area;
            this.gridView_Area.Name = "gridView_Area";
            this.gridView_Area.NewItemRowText = "點兩下新增";
            this.gridView_Area.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView_Area.OptionsEditForm.PopupEditFormWidth = 200;
            this.gridView_Area.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView_Area.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView_Area.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView_Area.OptionsView.ShowGroupPanel = false;
            this.gridView_Area.EditFormHidden += new DevExpress.XtraGrid.Views.Grid.EditFormHiddenEventHandler(this.gridView_Area_EditFormHidden);
            // 
            // colArea
            // 
            this.colArea.AppearanceCell.Options.UseTextOptions = true;
            this.colArea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colArea.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colArea.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.colArea.AppearanceHeader.Options.UseBackColor = true;
            this.colArea.AppearanceHeader.Options.UseTextOptions = true;
            this.colArea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colArea.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colArea.FieldName = "Area";
            this.colArea.Name = "colArea";
            this.colArea.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.colArea.Visible = true;
            this.colArea.VisibleIndex = 0;
            // 
            // AreaNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.gridControl_Area);
            this.Name = "AreaNew";
            this.Text = "地區";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Area)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaInfoViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Area)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_Area;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Area;
        private System.Windows.Forms.BindingSource areaInfoViewModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colArea;
    }
}