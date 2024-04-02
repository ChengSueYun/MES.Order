using System.Collections.Generic;
using System.Threading.Tasks;
using MES.Order.Adapter.Interface;
using MES.Order.DAL.Repository;
using MES.Order.Infrastructure;
using MES.Order.Infrastructure.NewViewModel;

namespace MES.Order.Adapter.Implement
{
    public class FactoryInfoAdapter : IFactoryInfoAdapter
    {
        private FactoryInfoRepository mRepository;

        private FactoryInfoRepository _repository
        {
            get => this.mRepository ?? new FactoryInfoRepository(BasicUtility.Conn);
            set => this.mRepository = value;
        }

        /// <inheritdoc />
        public Task<List<FactoryInfoViewModel>> Get()
        {
            return this._repository.Get();
        }

        /// <inheritdoc />
        public Task<bool> AddOrUpdate(IEnumerable<FactoryInfoViewModel> FromUi)
        {
            return this._repository.AddOrUpdate(FromUi);
        }

        /// <inheritdoc />
        public Task<bool> AddOrUpdate(FactoryInfoViewModel FromUi) => this._repository.AddOrUpdate(FromUi);

        /// <inheritdoc />
        public Task<List<KeyAndName>> GetFactoryIdAsync()
        {
            return this._repository.GetFactoryIdAsync();
        }
    }
}