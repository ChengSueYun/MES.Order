using System;
using System.Collections.Generic;
using MES.Order.Infrastructure.NewViewModel;
using THS.Infrastructure.Extensions;
using static MES.Order.Infrastructure.EnumCollect;

namespace MES.Order.Infrastructure
{
    public static class Const
    {
        private static List<KeyAndName> s_customerNameList;

        public static List<KeyAndName> CustomerNameList
        {
            get => s_customerNameList ?? new List<KeyAndName>();
            set => s_customerNameList = value;
        }

        private static List<KeyAndName> s_areaList;

        public static List<KeyAndName> AreaList
        {
            get => s_areaList ?? new List<KeyAndName>();
            set => s_areaList = value;
        }

        private static List<KeyAndName> s_productGroupIdList;

        public static List<KeyAndName> ProductGroupIDList
        {
            get => s_productGroupIdList ?? new List<KeyAndName>();
            set => s_productGroupIdList = value;
        }

        private static List<KeyAndName> s_productsList;

        public static List<KeyAndName> ProductsList
        {
            get => s_productsList ?? new List<KeyAndName>();
            set => s_productsList = value;
        }

    #region New

        private static List<KeyAndName> s_customerInfoNameList;

        public static List<KeyAndName> CustomerNameInfoList
        {
            get => s_customerInfoNameList ?? new List<KeyAndName>();
            set => s_customerInfoNameList = value;
        }

        private static List<KeyAndName> s_areaInfoList;

        public static List<KeyAndName> AreaInfoList
        {
            get => s_areaInfoList ?? new List<KeyAndName>();
            set => s_areaInfoList = value;
        }

        private static List<KeyAndName> s_factoryInfoList;

        public static List<KeyAndName> FactoryInfoList
        {
            get => s_factoryInfoList ?? new List<KeyAndName>();
            set => s_factoryInfoList = value;
        }

        private static List<KeyAndName> s_productsInfoList;

        public static List<KeyAndName> ProductsNameInfoList
        {
            get => s_productsInfoList ?? new List<KeyAndName>();
            set => s_productsInfoList = value;
        }

        private static List<KeyAndName> s_productsTypeList;

        public static List<KeyAndName> ProductsTypeList
        {
            get => s_productsTypeList ?? new List<KeyAndName>();
            set => s_productsTypeList = value;
        }

        private static List<KeyAndName> s_orderStatusEnums;

        public static List<KeyAndName> OrderStatusEnums
        {
            get =>
                s_orderStatusEnums ?? (s_orderStatusEnums = new List<KeyAndName>
                                                            {
                                                                new KeyAndName()
                                                                {
                                                                    Code =
                                                                        $"{OrderStatusEnum.Y}:{DateTime.Today.ToSimpleTaiwanCalendar()} 已取貨"
                                                                  , LocalDescription =
                                                                        $"{OrderStatusEnum.Y}:{DateTime.Today.ToSimpleTaiwanCalendar()} 已取貨"
                                                                }
                                                              , new KeyAndName()
                                                                {
                                                                    Code =
                                                                        $"{OrderStatusEnum.N}:未取貨"
                                                                  , LocalDescription =
                                                                        $"{OrderStatusEnum.N}:未取貨"
                                                                }
                                                            });
            set => s_orderStatusEnums = value;
        }

        private static List<KeyAndName> s_colorSpecEnums;

        public static List<KeyAndName> ColorSpecEnums
        {
            get
            {
                if (s_colorSpecEnums == null)
                {
                    s_colorSpecEnums = new List<KeyAndName>();
                }
                foreach (var value in Enum.GetNames(typeof(ColorSpecEnum)))
                {
                    s_colorSpecEnums.Add(new KeyAndName()
                                         {
                                             Code = value, LocalDescription = value
                                         });
                }
                return s_colorSpecEnums;
            }
            set => s_colorSpecEnums = value;
        }

        private static List<KeyAndName> s_sizeSpecEnum;

        public static List<KeyAndName> SizeSpecEnum
        {
            get
            {
                if (s_sizeSpecEnum == null)
                {
                    s_sizeSpecEnum = new List<KeyAndName>();
                }
                foreach (var value in Enum.GetNames(typeof(SizeSpecEnum)))
                {
                    s_sizeSpecEnum.Add(new KeyAndName()
                                       {
                                           Code = value, LocalDescription = value
                                       });
                }
                return s_sizeSpecEnum;
            }
            set => s_sizeSpecEnum = value;
        }

        private static List<ProductsInfoViewModel> s_allProductsView;

        public static List<ProductsInfoViewModel> AllProductsView
        {
            get => s_allProductsView ?? new List<ProductsInfoViewModel>();
            set => s_allProductsView = value;
        }

    #endregion
    }
}