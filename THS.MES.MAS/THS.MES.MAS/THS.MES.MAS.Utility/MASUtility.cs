using THS.MES.MAS.DAL.EntityModel;

namespace THS.MES.MAS.Utility
{
    public class MASUtility
    {
        private static MASDbContext _masDbContext;

        public static MASDbContext MasDbContext
        {
            get => _masDbContext ?? (_masDbContext = new MASDbContext(ConnectionString));
            set => _masDbContext = value;
        }

        public static string ConnectionString { set;get; }
    }
}