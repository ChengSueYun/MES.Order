namespace MES.Order.UI.New
{
    partial class FactoryNew
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
            this.factoryInfoViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl_Factory = new DevExpress.XtraGrid.GridControl();
            this.gridView_Factory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFactory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactoryWebSit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Factory_ItemHyperLinkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryInfoViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Factory_ItemHyperLinkEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // factoryInfoViewModelBindingSource
            // 
            this.factoryInfoViewModelBindingSource.DataSource = typeof(MES.Order.Infrastructure.NewViewModel.FactoryInfoViewModel);
            // 
            // gridControl_Factory
            // 
            this.gridControl_Factory.DataSource = this.factoryInfoViewModelBindingSource;
            this.gridControl_Factory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Factory.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Factory.MainView = this.gridView_Factory;
            this.gridControl_Factory.Name = "gridControl_Factory";
            this.gridControl_Factory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Factory_ItemHyperLinkEdit});
            this.gridControl_Factory.Size = new System.Drawing.Size(298, 268);
            this.gridControl_Factory.TabIndex = 0;
            this.gridControl_Factory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Factory});
            // 
            // gridView_Factory
            // 
            this.gridView_Factory.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.gridView_Factory.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView_Factory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFactory,
            this.colFactoryWebSit});
            this.gridView_Factory.GridControl = this.gridControl_Factory;
            this.gridView_Factory.Name = "gridView_Factory";
            this.gridView_Factory.NewItemRowText = "點兩下新增";
            this.gridView_Factory.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView_Factory.OptionsEditForm.PopupEditFormWidth = 300;
            this.gridView_Factory.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView_Factory.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView_Factory.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView_Factory.OptionsView.ShowGroupPanel = false;
            this.gridView_Factory.EditFormHidden += new DevExpress.XtraGrid.Views.Grid.EditFormHiddenEventHandler(this.gridView_Factory_EditFormHidden);
            // 
            // colFactory
            // 
            this.colFactory.AppearanceCell.Options.UseTextOptions = true;
            this.colFactory.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFactory.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFactory.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.colFactory.AppearanceHeader.Options.UseBackColor = true;
            this.colFactory.AppearanceHeader.Options.UseTextOptions = true;
            this.colFactory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFactory.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFactory.FieldName = "Factory";
            this.colFactory.Name = "colFactory";
            this.colFactory.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.colFactory.OptionsEditForm.StartNewRow = true;
            this.colFactory.OptionsEditForm.UseEditorColRowSpan = false;
            this.colFactory.Visible = true;
            this.colFactory.VisibleIndex = 0;
            // 
            // colFactoryWebSit
            // 
            this.colFactoryWebSit.AppearanceCell.Options.UseTextOptions = true;
            this.colFactoryWebSit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFactoryWebSit.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFactoryWebSit.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.colFactoryWebSit.AppearanceHeader.Options.UseBackColor = true;
            this.colFactoryWebSit.AppearanceHeader.Options.UseTextOptions = true;
            this.colFactoryWebSit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFactoryWebSit.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFactoryWebSit.FieldName = "FactoryWebSit";
            this.colFactoryWebSit.Name = "colFactoryWebSit";
            this.colFactoryWebSit.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.colFactoryWebSit.OptionsEditForm.StartNewRow = true;
            this.colFactoryWebSit.Visible = true;
            this.colFactoryWebSit.VisibleIndex = 1;
            // 
            // Factory_ItemHyperLinkEdit
            // 
            this.Factory_ItemHyperLinkEdit.AutoHeight = false;
            this.Factory_ItemHyperLinkEdit.Name = "Factory_ItemHyperLinkEdit";
            // 
            // FactoryNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.gridControl_Factory);
            this.Name = "FactoryNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "廠商";
            ((System.ComponentModel.ISupportInitialize)(this.factoryInfoViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Factory_ItemHyperLinkEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource factoryInfoViewModelBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl_Factory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Factory;
        private DevExpress.XtraGrid.Columns.GridColumn colFactory;
        private DevExpress.XtraGrid.Columns.GridColumn colFactoryWebSit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Factory_ItemHyperLinkEdit;
    }
}