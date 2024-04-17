using System;
using System.Collections.Generic;
using THS.Infrastructure.EnumType;

namespace MES.Order.Infrastructure.Share
{
    public class UI_Utility
    {
    #region Initial Value

        public static DateTime DateTimeDefaultValue = new DateTime(1900, 01, 01);

    #endregion

    #region Enum

        public enum CRUDMode
        {
            Add
          , Update
          , Delete
          , None
        }

    #endregion

    #region SystemParameter Property Or Field

      
        
    #endregion

    #region Global UI

        public static string LocationId;

        public static string Area;

        private static List<LocationUtility> _twnLocationUtilities;

        public static List<LocationUtility> _TWNLocationUtilities =>
            _twnLocationUtilities ?? (_twnLocationUtilities = new List<LocationUtility>(_TWNLocationData));

        public static string LocationName { get; set; }

        internal static List<LocationUtility> _TWNLocationData = new List<LocationUtility>
                                                                 {
                                                                     new LocationUtility
                                                                     {
                                                                         LocationId = "KK-PC", LocationName = "Lenvo黑"
                                                                     }
                                                                   , new LocationUtility
                                                                     {
                                                                         LocationId   = "KK-PC-OLD"
                                                                       , LocationName = "Lenvo粉"
                                                                     }
                                                                   , new LocationUtility
                                                                     {
                                                                         LocationId = "S03CSY", LocationName = "素雲筆電"
                                                                     }
                                                                   , new LocationUtility
                                                                     {
                                                                         LocationId = "SuYun", LocationName = "素雲桌電"
                                                                     }
                                                                 };

    #endregion
    }
}