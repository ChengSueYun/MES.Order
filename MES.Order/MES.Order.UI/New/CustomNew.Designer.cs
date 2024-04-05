namespace MES.Order.UI.New
{
    partial class CustomNew
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
            this.gridControl_Custom = new DevExpress.XtraGrid.GridControl();
            this.customInfoViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_Custom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAreaCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Area_ComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaceBookId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaceBookLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Custom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInfoViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Custom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Area_ComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_Custom
            // 
            this.gridControl_Custom.DataSource = this.customInfoViewModelBindingSource;
            this.gridControl_Custom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Custom.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_Custom.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_Custom.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_Custom.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_Custom.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_Custom.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Custom.MainView = this.gridView_Custom;
            this.gridControl_Custom.Name = "gridControl_Custom";
            this.gridControl_Custom.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Area_ComboBox});
            this.gridControl_Custom.Size = new System.Drawing.Size(724, 268);
            this.gridControl_Custom.TabIndex = 0;
            this.gridControl_Custom.UseEmbeddedNavigator = true;
            this.gridControl_Custom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Custom});
            // 
            // customInfoViewModelBindingSource
            // 
            this.customInfoViewModelBindingSource.DataSource = typeof(MES.Order.Infrastructure.NewViewModel.CustomInfoViewModel);
            // 
            // gridView_Custom
            // 
            this.gridView_Custom.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.gridView_Custom.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_Custom.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView_Custom.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView_Custom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAreaCustomer,
            this.colArea,
            this.colCustomer,
            this.colFaceBookId,
            this.colFaceBookLink,
            this.colRemark,
            this.colCreateDate,
            this.colUpdateDate,
            this.colUpdateUser});
            this.gridView_Custom.GridControl = this.gridControl_Custom;
            this.gridView_Custom.Name = "gridView_Custom";
            this.gridView_Custom.NewItemRowText = "點兩下新增";
            this.gridView_Custom.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView_Custom.OptionsEditForm.PopupEditFormWidth = 300;
            this.gridView_Custom.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView_Custom.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView_Custom.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView_Custom.OptionsView.ShowGroupPanel = false;
            this.gridView_Custom.EditFormHidden += new DevExpress.XtraGrid.Views.Grid.EditFormHiddenEventHandler(this.gridView_Custom_EditFormHidden);
            // 
            // colAreaCustomer
            // 
            this.colAreaCustomer.FieldName = "AreaCustomer";
            this.colAreaCustomer.Name = "colAreaCustomer";
            this.colAreaCustomer.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
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
            this.colArea.ColumnEdit = this.Area_ComboBox;
            this.colArea.FieldName = "Area";
            this.colArea.Name = "colArea";
            this.colArea.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.colArea.OptionsEditForm.StartNewRow = true;
            this.colArea.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colArea.Visible = true;
            this.colArea.VisibleIndex = 0;
            // 
            // Area_ComboBox
            // 
            this.Area_ComboBox.AutoHeight = false;
            this.Area_ComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Area_ComboBox.Name = "Area_ComboBox";
            this.Area_ComboBox.NullText = "請選擇地區";
            // 
            // colCustomer
            // 
            this.colCustomer.AppearanceCell.Options.UseTextOptions = true;
            this.colCustomer.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomer.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCustomer.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.colCustomer.AppearanceHeader.Options.UseBackColor = true;
            this.colCustomer.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomer.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCustomer.FieldName = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.colCustomer.OptionsEditForm.StartNewRow = true;
            this.colCustomer.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 1;
            // 
            // colFaceBookId
            // 
            this.colFaceBookId.AppearanceCell.Options.UseTextOptions = true;
            this.colFaceBookId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFaceBookId.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFaceBookId.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.colFaceBookId.AppearanceHeader.Options.UseBackColor = true;
            this.colFaceBookId.AppearanceHeader.Options.UseTextOptions = true;
            this.colFaceBookId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFaceBookId.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFaceBookId.FieldName = "FaceBookId";
            this.colFaceBookId.Name = "colFaceBookId";
            this.colFaceBookId.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.colFaceBookId.OptionsEditForm.StartNewRow = true;
            this.colFaceBookId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colFaceBookId.Visible = true;
            this.colFaceBookId.VisibleIndex = 2;
            // 
            // colFaceBookLink
            // 
            this.colFaceBookLink.AppearanceCell.Options.UseTextOptions = true;
            this.colFaceBookLink.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFaceBookLink.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFaceBookLink.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.colFaceBookLink.AppearanceHeader.Options.UseBackColor = true;
            this.colFaceBookLink.AppearanceHeader.Options.UseTextOptions = true;
            this.colFaceBookLink.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFaceBookLink.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFaceBookLink.FieldName = "FaceBookLink";
            this.colFaceBookLink.Name = "colFaceBookLink";
            this.colFaceBookLink.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.colFaceBookLink.OptionsEditForm.StartNewRow = true;
            this.colFaceBookLink.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colFaceBookLink.Visible = true;
            this.colFaceBookLink.VisibleIndex = 3;
            // 
            // colRemark
            // 
            this.colRemark.AppearanceCell.Options.UseTextOptions = true;
            this.colRemark.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemark.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colRemark.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.colRemark.AppearanceHeader.Options.UseBackColor = true;
            this.colRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemark.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.colRemark.OptionsEditForm.StartNewRow = true;
            this.colRemark.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 4;
            // 
            // colCreateDate
            // 
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colUpdateDate
            // 
            this.colUpdateDate.FieldName = "UpdateDate";
            this.colUpdateDate.Name = "colUpdateDate";
            this.colUpdateDate.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colUpdateUser
            // 
            this.colUpdateUser.FieldName = "UpdateUser";
            this.colUpdateUser.Name = "colUpdateUser";
            this.colUpdateUser.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // CustomNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 268);
            this.Controls.Add(this.gridControl_Custom);
            this.Name = "CustomNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客戶";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Custom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInfoViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Custom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Area_ComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_Custom;
        private System.Windows.Forms.BindingSource customInfoViewModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Custom;
        private DevExpress.XtraGrid.Columns.GridColumn colAreaCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colArea;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colFaceBookId;
        private DevExpress.XtraGrid.Columns.GridColumn colFaceBookLink;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateUser;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox Area_ComboBox;
    }
}