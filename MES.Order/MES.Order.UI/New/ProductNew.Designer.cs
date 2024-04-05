namespace MES.Order.UI.New
{
    partial class ProductNew
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.productsInfoViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFactoryProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Factory_ComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colProductType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductType_ComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colProductWebSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WebSite_HyperLinkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Image_TextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colSelection = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsInfoViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Factory_ComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductType_ComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebSite_HyperLinkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_TextEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.CausesValidation = false;
            this.gridControl1.DataSource = this.productsInfoViewModelBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.WebSite_HyperLinkEdit,
            this.Factory_ComboBox,
            this.ProductType_ComboBox,
            this.repositoryItemPictureEdit1,
            this.Image_TextEdit,
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(707, 428);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // productsInfoViewModelBindingSource
            // 
            this.productsInfoViewModelBindingSource.DataSource = typeof(MES.Order.Infrastructure.NewViewModel.ProductsInfoViewModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSelection,
            this.colFactoryProduct,
            this.colFactory,
            this.colProduct,
            this.colProductType,
            this.colPrice,
            this.colCost,
            this.colProfit,
            this.colImage,
            this.gridColumn1,
            this.colProductWebSite});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "點兩下新增";
            this.gridView1.OptionsBehavior.AllowValidationErrors = false;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gridView1.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gridView1.OptionsEditForm.FormCaptionFormat = "{Factory}-{Product}";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 300;
            this.gridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.EditFormHidden += new DevExpress.XtraGrid.Views.Grid.EditFormHiddenEventHandler(this.gridView1_EditFormHidden);
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
            // 
            // colFactoryProduct
            // 
            this.colFactoryProduct.FieldName = "FactoryProduct";
            this.colFactoryProduct.Name = "colFactoryProduct";
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
            this.colFactory.ColumnEdit = this.Factory_ComboBox;
            this.colFactory.FieldName = "Factory";
            this.colFactory.Name = "colFactory";
            this.colFactory.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.colFactory.OptionsEditForm.ColumnSpan = 2;
            this.colFactory.OptionsEditForm.StartNewRow = true;
            this.colFactory.OptionsEditForm.UseEditorColRowSpan = false;
            this.colFactory.Visible = true;
            this.colFactory.VisibleIndex = 0;
            this.colFactory.Width = 78;
            // 
            // Factory_ComboBox
            // 
            this.Factory_ComboBox.AutoHeight = false;
            this.Factory_ComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Factory_ComboBox.Name = "Factory_ComboBox";
            this.Factory_ComboBox.NullText = "請選擇廠商";
            this.Factory_ComboBox.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colProduct
            // 
            this.colProduct.AppearanceCell.Options.UseTextOptions = true;
            this.colProduct.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProduct.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.colProduct.AppearanceHeader.Options.UseBackColor = true;
            this.colProduct.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProduct.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colProduct.FieldName = "Product";
            this.colProduct.MaxWidth = 200;
            this.colProduct.Name = "colProduct";
            this.colProduct.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.colProduct.OptionsEditForm.ColumnSpan = 2;
            this.colProduct.OptionsEditForm.RowSpan = 2;
            this.colProduct.OptionsEditForm.StartNewRow = true;
            this.colProduct.OptionsEditForm.UseEditorColRowSpan = false;
            this.colProduct.Visible = true;
            this.colProduct.VisibleIndex = 1;
            this.colProduct.Width = 200;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.LinesCount = 3;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            this.repositoryItemMemoEdit1.NullValuePrompt = "請輸入品名";
            // 
            // colProductType
            // 
            this.colProductType.AppearanceCell.Options.UseTextOptions = true;
            this.colProductType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductType.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProductType.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.colProductType.AppearanceHeader.Options.UseBackColor = true;
            this.colProductType.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductType.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProductType.ColumnEdit = this.ProductType_ComboBox;
            this.colProductType.FieldName = "ProductType";
            this.colProductType.Name = "colProductType";
            this.colProductType.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.colProductType.OptionsEditForm.ColumnSpan = 2;
            this.colProductType.OptionsEditForm.StartNewRow = true;
            this.colProductType.OptionsEditForm.UseEditorColRowSpan = false;
            this.colProductType.Visible = true;
            this.colProductType.VisibleIndex = 2;
            this.colProductType.Width = 122;
            // 
            // ProductType_ComboBox
            // 
            this.ProductType_ComboBox.AutoHeight = false;
            this.ProductType_ComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ProductType_ComboBox.Name = "ProductType_ComboBox";
            this.ProductType_ComboBox.NullText = "請選擇類別";
            this.ProductType_ComboBox.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colPrice
            // 
            this.colPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPrice.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.colPrice.AppearanceHeader.Options.UseBackColor = true;
            this.colPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrice.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.colPrice.OptionsEditForm.ColumnSpan = 2;
            this.colPrice.OptionsEditForm.StartNewRow = true;
            this.colPrice.OptionsEditForm.UseEditorColRowSpan = false;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            this.colPrice.Width = 59;
            // 
            // colCost
            // 
            this.colCost.AppearanceCell.Options.UseTextOptions = true;
            this.colCost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCost.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCost.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.colCost.AppearanceHeader.Options.UseBackColor = true;
            this.colCost.AppearanceHeader.Options.UseTextOptions = true;
            this.colCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCost.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCost.FieldName = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.colCost.OptionsEditForm.ColumnSpan = 2;
            this.colCost.OptionsEditForm.StartNewRow = true;
            this.colCost.OptionsEditForm.UseEditorColRowSpan = false;
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 4;
            this.colCost.Width = 56;
            // 
            // colProfit
            // 
            this.colProfit.AppearanceCell.Options.UseTextOptions = true;
            this.colProfit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProfit.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProfit.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.colProfit.AppearanceHeader.Options.UseBackColor = true;
            this.colProfit.AppearanceHeader.Options.UseTextOptions = true;
            this.colProfit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProfit.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProfit.FieldName = "Profit";
            this.colProfit.Name = "colProfit";
            this.colProfit.OptionsColumn.AllowEdit = false;
            this.colProfit.OptionsColumn.ReadOnly = true;
            this.colProfit.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.colProfit.OptionsEditForm.ColumnSpan = 2;
            this.colProfit.OptionsEditForm.StartNewRow = true;
            this.colProfit.OptionsEditForm.UseEditorColRowSpan = false;
            this.colProfit.Visible = true;
            this.colProfit.VisibleIndex = 5;
            this.colProfit.Width = 63;
            // 
            // colImage
            // 
            this.colImage.AppearanceCell.Options.UseTextOptions = true;
            this.colImage.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colImage.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colImage.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.colImage.AppearanceHeader.Options.UseBackColor = true;
            this.colImage.AppearanceHeader.Options.UseTextOptions = true;
            this.colImage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colImage.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.colImage.OptionsEditForm.ColumnSpan = 2;
            this.colImage.OptionsEditForm.StartNewRow = true;
            this.colImage.OptionsEditForm.UseEditorColRowSpan = false;
            this.colImage.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colImage.Width = 83;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "顯示圖片";
            this.gridColumn1.ColumnEdit = this.repositoryItemPictureEdit1;
            this.gridColumn1.FieldName = "Photo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.UnboundDataType = typeof(object);
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 86;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemPictureEdit1.AllowDisposeImage = true;
            this.repositoryItemPictureEdit1.CustomHeight = 40;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.repositoryItemPictureEdit1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repositoryItemPictureEdit1_EditValueChanging);
            // 
            // colProductWebSite
            // 
            this.colProductWebSite.AppearanceCell.Options.UseTextOptions = true;
            this.colProductWebSite.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductWebSite.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProductWebSite.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.colProductWebSite.AppearanceHeader.Options.UseBackColor = true;
            this.colProductWebSite.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductWebSite.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductWebSite.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colProductWebSite.ColumnEdit = this.WebSite_HyperLinkEdit;
            this.colProductWebSite.FieldName = "ProductWebSite";
            this.colProductWebSite.Name = "colProductWebSite";
            this.colProductWebSite.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.colProductWebSite.OptionsEditForm.ColumnSpan = 2;
            this.colProductWebSite.OptionsEditForm.StartNewRow = true;
            this.colProductWebSite.OptionsEditForm.UseEditorColRowSpan = false;
            this.colProductWebSite.Visible = true;
            this.colProductWebSite.VisibleIndex = 6;
            this.colProductWebSite.Width = 153;
            // 
            // WebSite_HyperLinkEdit
            // 
            this.WebSite_HyperLinkEdit.AutoHeight = false;
            this.WebSite_HyperLinkEdit.Name = "WebSite_HyperLinkEdit";
            this.WebSite_HyperLinkEdit.NullValuePrompt = "請輸入產品網址";
            this.WebSite_HyperLinkEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // Image_TextEdit
            // 
            this.Image_TextEdit.AutoHeight = false;
            this.Image_TextEdit.Name = "Image_TextEdit";
            this.Image_TextEdit.NullValuePrompt = "請輸入圖片網址";
            // 
            // colSelection
            // 
            this.colSelection.FieldName = "Selection";
            this.colSelection.Name = "colSelection";
            // 
            // ProductNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(707, 428);
            this.Controls.Add(this.gridControl1);
            this.Name = "ProductNew";
            this.Text = "產品";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsInfoViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Factory_ComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductType_ComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebSite_HyperLinkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_TextEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource productsInfoViewModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFactoryProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colFactory;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colProductType;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCost;
        private DevExpress.XtraGrid.Columns.GridColumn colProfit;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colProductWebSite;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit WebSite_HyperLinkEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox Factory_ComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox ProductType_ComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit Image_TextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colSelection;
    }
}