using System.Collections.Generic;
using System.Threading.Tasks;
using MES.Order.Adapter.Interface;
using MES.Order.DAL.Repository;
using MES.Order.Infrastructure;
using MES.Order.Infrastructure.NewViewModel;

namespace MES.Order.Adapter.Implement
{
    public class AreaInfoAdapter : IAreaInfoAdapter
    {
        private AreaInfoRepository mRepository;

        private AreaInfoRepository _repository
        {
            get => this.mRepository ?? new AreaInfoRepository(BasicUtility.Conn);
            set => this.mRepository = value;
        }

    #region Implementation of IAreaInfoAdapter

        /// <inheritdoc />
        public Task<List<AreaInfoViewModel>> GetAsync() => _repository.Get();

        /// <inheritdoc />
        public Task<bool> AddOrUpdateAsync(IEnumerable<AreaInfoViewModel> FromUi) => _repository.AddOrUpdate(FromUi);

        /// <inheritdoc />
        public Task<List<KeyAndName>> GetAreaAsync()
        {
            return _repository.GetAreaAsync();
        }

    #endregion
    }
}