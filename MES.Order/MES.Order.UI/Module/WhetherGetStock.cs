using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MES.Order.DAL.ViewModel;
using THS.Infrastructure.Extensions;

namespace MES.Order.UI.Module
{
    public class WhetherGetStock
    {
        private KeyAndNameForCombo _get;

        public KeyAndNameForCombo Get
        {
            get
            {
                this._get = new KeyAndNameForCombo
                {
                    Code             = "Y:" + DateTime.Today.ToSimpleTaiwanCalendar() + " 已取貨",
                    LocalDescription = "Y:" + DateTime.Today.ToSimpleTaiwanCalendar() + " 已取貨"
                };
                return this._get;
            }
            set => this._get = value;
        }

        private KeyAndNameForCombo _unGet;

        public KeyAndNameForCombo unGet
        {
            get
            {
                this._unGet = new KeyAndNameForCombo {Code = "N:未取貨", LocalDescription = "N:未取貨"};
                return this._unGet;
            }
            set => this._unGet = value;
        }

        private KeyAndNameForCombo _allNone;

        public KeyAndNameForCombo AllNone
        {
            get
            {
                this._allNone = new KeyAndNameForCombo {Code = "", LocalDescription = ""};
                return this._allNone;
            }
            set => this._allNone = value;
        }
    }
}