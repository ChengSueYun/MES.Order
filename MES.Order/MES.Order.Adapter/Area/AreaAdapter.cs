using System.Collections.Generic;
using System.Threading.Tasks;
using MES.Order.DAL;
using MES.Order.DAL.ViewModel;

namespace MES.Order.Adapter
{
    public class AreaAdapter : IAreaAdapter
    {
        internal AreaPO areaPo
        {
            get
            {
                if (this._areaPo == null)
                {
                    this._areaPo = new AreaPO();
                }

                return this._areaPo;
            }
            set => this._areaPo = value;
        }

        private AreaPO _areaPo;

        public List<KeyAndNameForCombo> GetArea()
        {
            return this.areaPo.GetArea();
        }
        
        public async Task GetAreaAsync()
        {
            await this.areaPo.GetAreaAsync();
        }
    }
}