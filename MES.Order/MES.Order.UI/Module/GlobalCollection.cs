using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using MES.Order.UI.Properties;
using THS.Infrastructure.Extensions;

namespace MES.Order.UI.Module
{
    public static class GlobalCollection
    {
        public static StringCollection ProductTypeCollection = Settings.Default.ProductType;
        private static List<string> _orderStatusCollection;
        private static StringCollection _colorSpeCollection;
        private static StringCollection _siezSpcCollection;
        public static List<string> OrderStatusCollection
        {
            get
            {
                if (_orderStatusCollection == null)
                {
                    _orderStatusCollection = new List<string>();
                    foreach (var i in Settings.Default.OrderStatus)
                    {
                        _orderStatusCollection.Add(i);
                    }
                    _orderStatusCollection.Add($"Y:{DateTime.Today.ToSimpleTaiwanCalendar()} 已取貨");
                }

                return _orderStatusCollection;
            }

            set => _orderStatusCollection = value;
        }
        public static StringCollection ColorSpeCollection
        {
            get
            {
                if (_colorSpeCollection == null)
                {
                    _colorSpeCollection = new StringCollection();
                    _colorSpeCollection = Settings.Default.ColorSpec;
                }

                return _colorSpeCollection;
            }


            set => _colorSpeCollection = value;
        }
        public static StringCollection SiezSpcCollection
        {
            get
            {
                if (_siezSpcCollection == null)
                {
                    _siezSpcCollection = new StringCollection();
                    _siezSpcCollection = Settings.Default.SizeSpec;
                }

                return _siezSpcCollection;
            }

            set => _siezSpcCollection = value;
        }
    }
}