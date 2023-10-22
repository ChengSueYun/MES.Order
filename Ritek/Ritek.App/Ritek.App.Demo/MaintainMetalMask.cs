using System.Collections.Generic;
using DevExpress.Data.Helpers;
using DevExpress.XtraEditors;
using Ritek.App.Demo.Properties;
using Ritek.App.Infrastructure;

namespace Ritek.App.Demo
{
    public partial class MaintainMetalMask : XtraForm
    {
        public MaintainMetalMask()
        {
            InitializeComponent();
            //鋼板
            InitialSteelPlateData();
            //厚度
            InitialThicknessData();
            //顯影
            InitialDevelopmentData();
            //曝光
            InitialLDIData();


            this.steelPlateViewModelBindingSource.DataSource = Settings.Default.AppDefaultSteelPlate;
            this.thicknessViewModelBindingSource.DataSource = Settings.Default.AppDefaultThickness;
            this.developmentViewModelBindingSource.DataSource = Settings.Default.AppDefaultDevelopment;
            this.lDIViewModelBindingSource.DataSource = Settings.Default.AppDefaultLDI;
            Settings.Default.Save();
        }

        /// <summary>
        /// 曝光
        /// </summary>
        private static void InitialLDIData()
        {
            if (Settings.Default.AppDefaultLDI == null ||
                Settings.Default.AppDefaultLDI.Count < 0)
            {
                var pLDIList = new List<LDIViewModel>()
                {
                    new LDIViewModel
                    {
                        Category = "BALL",
                        LimitCollation = "光阻厚度 > 112",
                        Defocus = 650,
                        Exposure = -50
                    },
                    new LDIViewModel
                    {
                        Category = "BALL",
                        LimitCollation = "光阻厚度 <= 112",
                        Defocus = 600,
                        Exposure = -50
                    },
                    new LDIViewModel
                    {
                        Category = "FLUX",
                        LimitCollation = "厚度 40~50",
                        Defocus = 600,
                        Exposure = -50
                    },
                    new LDIViewModel
                    {
                        Category = "FLUX",
                        LimitCollation = "40 光阻",
                        Defocus = 150,
                        Exposure = -15
                    },
                    new LDIViewModel
                    {
                        Category = "FLUX",
                        LimitCollation = "25 光阻",
                        Defocus = 200,
                        Exposure = -25
                    },
                    new LDIViewModel
                    {
                        Category = "L2",
                        LimitCollation = "一般肋骨",
                        Defocus = 300,
                        Exposure = 0
                    },
                    new LDIViewModel
                    {
                        Category = "L3",
                        LimitCollation = "永久材",
                        Defocus = 300,
                        Exposure = 0
                    },
                };
                Settings.Default.AppDefaultLDI = pLDIList;
            }
        }

        /// <summary>
        /// 顯影
        /// </summary>
        private static void InitialDevelopmentData()
        {
            if (Settings.Default.AppDefaultDevelopment == null ||
                Settings.Default.AppDefaultDevelopment.Count < 0)
            {
                var pDevelopmentList = new List<DevelopmentViewModel>
                {
                    new DevelopmentViewModel
                    {
                        DevelopPressure1 = 0,
                        FluidPressure2 = (decimal) 0.4,
                        DevelopmentSpeed1 = (decimal) 1.5,
                        FluidVelocity2 = (decimal) 1.5
                    },
                    new DevelopmentViewModel
                    {
                        DevelopPressure1 = (decimal) 1.5,
                        FluidPressure2 = (decimal) 0,
                        DevelopmentSpeed1 = (decimal) 0.5,
                        FluidVelocity2 = 1
                    },
                    new DevelopmentViewModel
                    {
                        DevelopPressure1 = (decimal) 1,
                        FluidPressure2 = (decimal) 1,
                        DevelopmentSpeed1 = (decimal) 1.5,
                        FluidVelocity2 = (decimal) 1
                    },
                    new DevelopmentViewModel
                    {
                        DevelopPressure1 = (decimal) 1,
                        FluidPressure2 = (decimal) 1,
                        DevelopmentSpeed1 = (decimal) 1.5,
                        FluidVelocity2 = (decimal) 1
                    },
                    new DevelopmentViewModel
                    {
                        DevelopPressure1 = (decimal) 1,
                        FluidPressure2 = (decimal) 1,
                        DevelopmentSpeed1 = (decimal) 1,
                        FluidVelocity2 = (decimal) 1
                    },
                    new DevelopmentViewModel
                    {
                        DevelopPressure1 = (decimal) 1.8,
                        FluidPressure2 = (decimal) 1.5,
                        DevelopmentSpeed1 = (decimal) 0.5,
                        FluidVelocity2 = (decimal) 1
                    },
                    new DevelopmentViewModel
                    {
                        DevelopPressure1 = (decimal) 0,
                        FluidPressure2 = (decimal) 0.3,
                        DevelopmentSpeed1 = (decimal) 2.5,
                        FluidVelocity2 = (decimal) 2
                    },
                    new DevelopmentViewModel
                    {
                        DevelopPressure1 = (decimal) 0,
                        FluidPressure2 = (decimal) 0.1,
                        DevelopmentSpeed1 = (decimal) 4,
                        FluidVelocity2 = (decimal) 2.5
                    },
                    new DevelopmentViewModel
                    {
                        DevelopPressure1 = (decimal) 0,
                        FluidPressure2 = (decimal) 0.2,
                        DevelopmentSpeed1 = (decimal) 4,
                        FluidVelocity2 = (decimal) 1.8
                    },
                };
                Settings.Default.AppDefaultDevelopment = pDevelopmentList;
            }
        }

        /// <summary>
        /// 厚度
        /// </summary>
        private static void InitialThicknessData()
        {
            if (Settings.Default.AppDefaultThickness == null ||
                Settings.Default.AppDefaultThickness.Count < 0)
            {
                var pThicknessList = new List<ThicknessViewModel>()
                {
                    new ThicknessViewModel
                    {
                        PhotoresistThickness = "56X1",
                        SeriesNoThickness = "60"
                    },
                    new ThicknessViewModel
                    {
                        PhotoresistThickness = "56X2",
                        SeriesNoThickness = "62"
                    },
                    new ThicknessViewModel
                    {
                        PhotoresistThickness = "56+75",
                        SeriesNoThickness = "62"
                    },
                    new ThicknessViewModel
                    {
                        PhotoresistThickness = "75X2",
                        SeriesNoThickness = "62"
                    },
                    new ThicknessViewModel
                    {
                        PhotoresistThickness = "112X2",
                        SeriesNoThickness = "62"
                    },
                    new ThicknessViewModel
                    {
                        PhotoresistThickness = "2HD",
                        SeriesNoThickness = "62"
                    },
                    new ThicknessViewModel
                    {
                        PhotoresistThickness = "Permanent Material 40X1",
                        SeriesNoThickness = "62"
                    },
                    new ThicknessViewModel
                    {
                        PhotoresistThickness = "Light Resistance 25X1",
                        SeriesNoThickness = "62"
                    },
                    new ThicknessViewModel
                    {
                        PhotoresistThickness = "Light Resistance 25X2",
                        SeriesNoThickness = "62"
                    },
                };
                Settings.Default.AppDefaultThickness = pThicknessList;
            }
        }

        /// <summary>
        /// 鋼板尺寸
        /// </summary>
        /// <returns></returns>
        private static void InitialSteelPlateData()
        {
            if (Settings.Default.AppDefaultSteelPlate == null ||
                Settings.Default.AppDefaultSteelPlate.Count < 0)
            {
                var pSteelPlateList = new List<SteelPlateViewModel>()
                {
                    new SteelPlateViewModel
                    {
                        SteelPlate = "Ball",
                        SteelPlateSize = "650X600"
                    },
                    new SteelPlateViewModel
                    {
                        SteelPlate = "FLUX",
                        SteelPlateSize = "600X600"
                    }
                };

                Settings.Default.AppDefaultSteelPlate = pSteelPlateList;
            }
        }

        private void MaintainMetalMask_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Settings.Default.AppDefaultSteelPlate =
                (List<SteelPlateViewModel>) this.steelPlateViewModelBindingSource.DataSource;
            Settings.Default.AppDefaultThickness =
                (List<ThicknessViewModel>) this.thicknessViewModelBindingSource.DataSource;
            Settings.Default.AppDefaultDevelopment =
                (List<DevelopmentViewModel>) this.developmentViewModelBindingSource.DataSource;
            Settings.Default.AppDefaultLDI = (List<LDIViewModel>) this.lDIViewModelBindingSource.DataSource;
            Settings.Default.Save();
        }
    }
}