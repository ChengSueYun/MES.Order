
using MES.Order.Infrastructure.Share;

namespace MES.Order.UI.New
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginTitle = new DevExpress.XtraEditors.LabelControl();
            this.close = new CSYCodeAdvance.EditorControls.CSYCircleSvgImageBox();
            this.OK = new CSYCodeAdvance.EditorControls.CSYButton();
            this.csyCircleSvgImageBox1 = new CSYCodeAdvance.EditorControls.CSYCircleSvgImageBox();
            this.locationUtilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboLocationID = new CSYCodeAdvance.EditorControls.CSYLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csyCircleSvgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationUtilityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLocationID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTitle
            // 
            this.LoginTitle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.LoginTitle.Appearance.Font = new System.Drawing.Font("Sarasa Mono Slab TC Nerd Font", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitle.Appearance.ForeColor = System.Drawing.Color.White;
            this.LoginTitle.Appearance.Options.UseBackColor = true;
            this.LoginTitle.Appearance.Options.UseFont = true;
            this.LoginTitle.Appearance.Options.UseForeColor = true;
            this.LoginTitle.Appearance.Options.UseTextOptions = true;
            this.LoginTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LoginTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LoginTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LoginTitle.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.LoginTitle.Location = new System.Drawing.Point(8, 0);
            this.LoginTitle.Margin = new System.Windows.Forms.Padding(0);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Padding = new System.Windows.Forms.Padding(5);
            this.LoginTitle.Size = new System.Drawing.Size(242, 38);
            this.LoginTitle.TabIndex = 61;
            this.LoginTitle.Text = "登入";
            this.LoginTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginTitle_MouseDown);
            this.LoginTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginTitle_MouseMove);
            this.LoginTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginTitle_MouseUp);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.close.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.close.BorderColor = System.Drawing.Color.Empty;
            this.close.BorderColor2 = System.Drawing.Color.Empty;
            this.close.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.close.BorderRadius = 0;
            this.close.BorderSize = 0;
            this.close.GradientAngle = 50F;
            this.close.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.ItemAppearance.Hovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.close.ItemAppearance.Hovered.BorderThickness = 25F;
            this.close.ItemAppearance.Normal.BorderColor = System.Drawing.Color.White;
            this.close.ItemAppearance.Normal.FillColor = System.Drawing.Color.White;
            this.close.ItemAppearance.Pressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.close.ItemAppearance.Pressed.BorderThickness = 25F;
            this.close.Location = new System.Drawing.Point(295, 8);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.close.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("close.SvgImage")));
            this.close.TabIndex = 62;
            this.close.Text = "csyCircleSvgImageBox1";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(208)))), ((int)(((byte)(162)))));
            this.OK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(208)))), ((int)(((byte)(162)))));
            this.OK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(92)))));
            this.OK.BorderRadius = 20;
            this.OK.BorderSize = 0;
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.OK.FlatAppearance.BorderSize = 0;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Font = new System.Drawing.Font("Sarasa Mono TC Nerd Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OK.ForeColor = System.Drawing.Color.White;
            this.OK.Location = new System.Drawing.Point(77, 144);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(107, 38);
            this.OK.TabIndex = 71;
            this.OK.Text = "登入";
            this.OK.TextColor = System.Drawing.Color.White;
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // csyCircleSvgImageBox1
            // 
            this.csyCircleSvgImageBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.csyCircleSvgImageBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.csyCircleSvgImageBox1.BorderColor = System.Drawing.Color.Empty;
            this.csyCircleSvgImageBox1.BorderColor2 = System.Drawing.Color.Empty;
            this.csyCircleSvgImageBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.csyCircleSvgImageBox1.BorderRadius = 20;
            this.csyCircleSvgImageBox1.BorderSize = 2;
            this.csyCircleSvgImageBox1.GradientAngle = 50F;
            this.csyCircleSvgImageBox1.ItemAppearance.Hovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.csyCircleSvgImageBox1.ItemAppearance.Hovered.BorderThickness = 0F;
            this.csyCircleSvgImageBox1.ItemAppearance.Pressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.csyCircleSvgImageBox1.ItemAppearance.Pressed.BorderThickness = 0F;
            this.csyCircleSvgImageBox1.Location = new System.Drawing.Point(21, 58);
            this.csyCircleSvgImageBox1.MaximumSize = new System.Drawing.Size(305, 250);
            this.csyCircleSvgImageBox1.Name = "csyCircleSvgImageBox1";
            this.csyCircleSvgImageBox1.Size = new System.Drawing.Size(210, 80);
            this.csyCircleSvgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.csyCircleSvgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("csyCircleSvgImageBox1.SvgImage")));
            this.csyCircleSvgImageBox1.TabIndex = 63;
            this.csyCircleSvgImageBox1.Text = "csyCircleSvgImageBox1";
            // 
            // locationUtilityBindingSource
            // 
            this.locationUtilityBindingSource.DataSource = typeof(MES.Order.Infrastructure.Share.LocationUtility);
            // 
            // cboLocationID
            // 
            this.cboLocationID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.cboLocationID.BorderColor = System.Drawing.Color.Black;
            this.cboLocationID.BorderRadius = 5;
            this.cboLocationID.BorderSize = 1;
            this.cboLocationID.Location = new System.Drawing.Point(54, 80);
            this.cboLocationID.Name = "cboLocationID";
            this.cboLocationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.cboLocationID.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cboLocationID.Properties.Appearance.Options.UseBackColor = true;
            this.cboLocationID.Properties.Appearance.Options.UseForeColor = true;
            this.cboLocationID.Properties.Appearance.Options.UseTextOptions = true;
            this.cboLocationID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cboLocationID.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cboLocationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)});
            this.cboLocationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationId", "名稱", 93, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationName", "敘述", 124, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboLocationID.Properties.DataSource = this.locationUtilityBindingSource;
            this.cboLocationID.Properties.DisplayMember = "LocationName";
            this.cboLocationID.Properties.NullText = "請選擇主機";
            this.cboLocationID.Properties.NullValuePrompt = "請選擇主機";
            this.cboLocationID.Properties.ValueMember = "LocationId";
            this.cboLocationID.Size = new System.Drawing.Size(150, 26);
            this.cboLocationID.TabIndex = 72;
            this.cboLocationID.TextColor = System.Drawing.Color.Black;
            this.cboLocationID.EditValueChanged += new System.EventHandler(this.cboLocationID_EditValueChanged);
            // 
            // Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseTextOptions = true;
            this.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(260, 209);
            this.Controls.Add(this.cboLocationID);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.csyCircleSvgImageBox1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.LoginTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Sarasa Mono TC Nerd Font", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Login.IconOptions.Image")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "煉鋼品管系統使用者登入";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csyCircleSvgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationUtilityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLocationID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl LoginTitle;
        private CSYCodeAdvance.EditorControls.CSYCircleSvgImageBox close;
        private CSYCodeAdvance.EditorControls.CSYButton OK;
        private CSYCodeAdvance.EditorControls.CSYCircleSvgImageBox csyCircleSvgImageBox1;
        private System.Windows.Forms.BindingSource locationUtilityBindingSource;
        private CSYCodeAdvance.EditorControls.CSYLookUpEdit cboLocationID;
    }
}