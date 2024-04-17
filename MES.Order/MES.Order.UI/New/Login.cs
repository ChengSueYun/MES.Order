using DevExpress.XtraEditors;
using MES.Order.Infrastructure.Share;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using MES.Order.Adapter;

namespace MES.Order.UI.New
{
    public partial class Login : XtraForm
    {
        public Login()
        {
            this.Load += this.LoginForm_Load;
            this.InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.InitialLocation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"登入畫面初始失敗，" + Environment.NewLine + ex.Message + Environment.NewLine + @"請聯絡系統人員！",
                                @"登入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    #region Control Event

        private void cboLocationID_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cboLocationID.Text))
            {
                return;
            }
            switch (this.cboLocationID.EditValue.ToString())
            {
                case "KK-PC":
                    BasicUtility.Conn = Properties.Settings.Default.KKPCDbContext;
                    break;
                case "KK-PC-OLD":
                    BasicUtility.Conn = Properties.Settings.Default.KKPCOLDDbContext;
                    break;
                case "S03CSY":
                    BasicUtility.Conn = Properties.Settings.Default.S03CSYDbContext;
                    break;
                case "SuYun":
                    BasicUtility.Conn = Properties.Settings.Default.SuYunDbContext;
                    break;
            }
        }

    #endregion

    #region Initial Data

        /// <summary>
        /// 初始廠區
        /// </summary>
        private void InitialLocation()
        {
            try
            {
                this.cboLocationID.Properties.DataSource = UI_Utility._TWNLocationUtilities;
                if (UI_Utility._TWNLocationUtilities.Count(x => x.LocationId == Properties.Settings
                                                                    .Default
                                                                    .DefaultLocation) > 0)
                {
                    this.cboLocationID.EditValue = Properties.Settings.Default.DefaultLocation;
                }
                else
                {
                    if (UI_Utility._TWNLocationUtilities.Count > 0)
                    {
                        this.cboLocationID.EditValue = UI_Utility._TWNLocationUtilities[0].LocationId;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("廠區選單初始失敗!" + Environment.NewLine + ex.Message);
            }
        }

    #endregion Initial Control

    #region Buttons

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                //儲存預設資訊
                Properties.Settings.Default.DefaultLocation = UI_Utility.LocationId =
                                                                  this.cboLocationID.EditValue.ToString();
                UI_Utility.LocationName = this.cboLocationID.Text;
                Properties.Settings.Default.Save();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                this.Close();
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    #endregion Buttons

    #region Form

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            UpdateRegion();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateRegion();
        }

        private void UpdateRegion()
        {
            Region prevRgn = Region;
            Region = new Region(CreateFormRegion(20));
            if (prevRgn != null)
                prevRgn.Dispose();
        }

        public GraphicsPath CreateFormRegion(int cornerRadius)
        {
            GraphicsPath GrpRect = new GraphicsPath();
            int          width   = Width  + 1;
            int          height  = Height + 1;
            GrpRect.AddArc(new Rectangle(0, 0, cornerRadius * 2, cornerRadius * 2), 180f, 90f); //left-top
            GrpRect.AddArc(new Rectangle((width - cornerRadius * 2) - 1, 0, cornerRadius * 2, cornerRadius * 2), -90f,
                           90f); //right-top
            GrpRect.AddArc(
                           new Rectangle((width - cornerRadius * 2) - 1, (height - cornerRadius * 2) - 1
                                       , cornerRadius * 2,
                                         cornerRadius * 2),
                           0f, 90f); //right-bottom
            GrpRect.AddArc(new Rectangle(0, (height - cornerRadius * 2) - 1, cornerRadius * 2, cornerRadius * 2), 90f,
                           90f); //left-bottom
            GrpRect.CloseAllFigures();
            return GrpRect;
        }

        bool draging = false;
        int  curPosX, curPosY;

        private void LoginTitle_MouseDown(object sender, MouseEventArgs e)
        {
            draging = true;
            curPosX = Cursor.Position.X;
            curPosY = Cursor.Position.Y;
        }

        private void LoginTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (draging)
            {
                this.Left += Cursor.Position.X - curPosX;
                curPosX   =  Cursor.Position.X;
                this.Top  += Cursor.Position.Y - curPosY;
                curPosY   =  Cursor.Position.Y;
            }
        }

        private void LoginTitle_MouseUp(object sender, MouseEventArgs e)
        {
            draging = false;
        }

    #endregion
    }
}