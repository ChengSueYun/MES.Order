using System.Collections.Specialized;
using System.Configuration;

namespace MES.Order.UI.Module
{
    public static class GlobalCollection
    {
        public static StringCollection OrderStatusCollection = Properties.Settings.Default.OrderStatus;
        public static StringCollection ColorSpeCollection = Properties.Settings.Default.ColorSpec;
        public static StringCollection SiezSpcCollection = Properties.Settings.Default.SizeSpec;
        public static StringCollection ProductTypeCollection = Properties.Settings.Default.ProductType;
    }
}