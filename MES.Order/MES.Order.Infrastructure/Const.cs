using System.Collections.Generic;

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

    #endregion
    }
}