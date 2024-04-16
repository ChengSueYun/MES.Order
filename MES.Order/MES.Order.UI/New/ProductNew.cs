using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Services.Description;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MES.Order.Adapter;
using MES.Order.Infrastructure;
using MES.Order.Infrastructure.NewViewModel;
using MES.Order.UI.Module;
using THS.Infrastructure.Extensions;

namespace MES.Order.UI.New
{
    public partial class ProductNew : XtraForm
    {
        Hashtable Images = new Hashtable();
        string ImageDir = @"Images\";

        public ProductNew()
        {
            InitializeComponent();
            productsInfoViewModelBindingSource.DataSource = Const.AllProductsView;
            this.Factory_ComboBox.Items.AddRange(Const.AllFactoryView.Select(x => x.Factory).ToList());
            this.ProductType_ComboBox.Items.AddRange(GlobalCollection.ProductTypeCollection);
            gridView1.BestFitColumns();
        }

        private void gridView1_EditFormHidden(object sender, EditFormHiddenEventArgs e)
        {
            try
            {
                if (e.Result == EditFormResult.Update)
                    if (productsInfoViewModelBindingSource.Current is ProductsInfoViewModel request)
                    {
                        request.SetDefaultValue();

                        var addOrUpdate = BasicUtility.ProductsInfoAdapter.AddOrUpdate(request);
                        while (addOrUpdate.IsCompleted)
                        {
                            Const.AllProductsView = BasicUtility.ProductsInfoAdapter.Get().Result;
                            productsInfoViewModelBindingSource.DataSource = Const.AllProductsView;
                            this.gridControl1.RefreshDataSource();
                        }
                    }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.ToString());
            }
        }

        private void repositoryItemPictureEdit1_EditValueChanging(object sender,
            DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            // byte[] bytes = Encoding.ASCII.GetBytes(e.NewValue.ToString());
            // if (productsInfoViewModelBindingSource.Current is ProductsInfoViewModel request)
            // {
            //     request.Image = bytes;
            // }
        }

        private void gridView1_CustomUnboundColumnData(object sender,
            DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Photo" && e.IsGetData)
            {
                // //RefImage是存储图片路径的那一列
                // string filePath = (e.Row as ProductsInfoViewModel).Image;
                // Image img = null;
                try
                {
                //     //判断图片路径是否为网络路径
                //     if (UrlDiscern(filePath))
                //     {
                //         //文件是否存在
                //         if (RemoteFileExists(filePath))
                //         {
                //             //读取文件
                //             using (WebClient wc = new WebClient())
                //             {
                //                 img = new Bitmap(wc.OpenRead(filePath));
                //             }
                //         }
                //     }
                //     // 判断本地文件是否存在
                //     else if (LocalFileExists(filePath))
                //     {
                //         //加载本地图片
                //         img = Image.FromFile(filePath);
                //     }
                //
                //     //pictureEdit列绑定图片
                //     e.Value = img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        /// <summary>
        /// 判断本地文件是否存在
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool LocalFileExists(string filePath)
        {
            if (File.Exists(filePath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 识别urlStr是否是网络路径
        /// </summary>
        /// <param name="urlStr"></param>
        /// <returns></returns>
        public bool UrlDiscern(string urlStr)
        {
            if (Regex.IsMatch(urlStr,
                    @"((http|ftp|https)://)(([a-zA-Z0-9\._-]+\.[a-zA-Z]{2,6})|([0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}))(:[0-9]{1,4})*(/[a-zA-Z0-9\&%_\./-~-]*)?"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 判断远程文件是否存在
        /// </summary>
        /// <param name="fileUrl"></param>
        /// <returns></returns>
        public bool RemoteFileExists(string fileUrl)
        {
            HttpWebRequest re = null;
            HttpWebResponse res = null;
            try
            {
                re = (HttpWebRequest)WebRequest.Create(fileUrl);
                res = (HttpWebResponse)re.GetResponse();
                if (res.ContentLength != 0)
                {
                    //MessageBox.Show("文件存在");
                    return true;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("无此文件");
                return false;
            }
            finally
            {
                if (re != null)
                {
                    re.Abort(); //销毁关闭连接
                }

                if (res != null)
                {
                    res.Close(); //销毁关闭响应
                }
            }

            return false;
        }

        string GetFileName(string color)
        {
            if (color == null || color == string.Empty)

                return string.Empty;

            return color + ".jpg";
        }
    }
}