namespace THS.MES.MAS.WebAPI.Modules
{
    public class GlobalPara
    {
        public enum DB
        {
            MAS
        }

        public enum LocationID
        {
            H,
            U,
            F
        }

        // public static UserStruc gUser;
        //
        // //跨廠區查詢旗標(測試時設為True,上線時需改為False)
        // public static bool gChangeLocation = true;
        //
        // //跨廠區編輯(測試時設為True,上線時需改為False)
        // public static bool gDifferentLocationModify = true;
        //
        // //指定系統代號
        // public static string gAppID = Properties.Settings.Default.ApplicationID;

        //使用者登入廠區
        public static string gLoginLocation = "";

        private static LocationID LocationEnum;

        public static string GetConnectionString(string pLocationID, DB DB)
        {
            switch (DB)
            {
                case GlobalPara.DB.MAS:
                    return SetMASDbContext(pLocationID);
                default:
                    return "";
            }
        }
        private static string SetMASDbContext(string pLocationId)
        {
            switch (LocationEnum)
            {
                case LocationID.H:
                    return Properties.Settings.Default.MASConnectionStringH;
                case LocationID.U:
                    return Properties.Settings.Default.MASConnectionStringU;
                case LocationID.F:
                    return null;
                default:
                    return "";
            }
        }
        public static string GetConfigConnectionName(string pLocationID, DB DB)
        {
            switch (DB)
            {
                case GlobalPara.DB.MAS:
                    return GetConnectionName(pLocationID);
                default:
                    return "";
            }
        }
        private static string GetConnectionName(string pLocationID)
        {
            
            switch (LocationEnum)
            {
                case LocationID.H:
                    return Properties.Settings.Default.MASConnectionNameH;
                case LocationID.U:
                    return Properties.Settings.Default.MASConnectionNameU;
                case LocationID.F:
                    return null;
                default:
                    return "";
            }
        }

     
    }
}