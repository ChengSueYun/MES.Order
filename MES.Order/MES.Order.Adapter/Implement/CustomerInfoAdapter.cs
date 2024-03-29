using System.Collections.Generic;
using System.Threading.Tasks;
using MES.Order.Adapter.Interface;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.Repository;
using MES.Order.DAL.ViewModel;
using MES.Order.Infrastructure;
using MES.Order.Infrastructure.NewViewModel;

namespace MES.Order.Adapter.Implement
{
    public class CustomerInfoAdapter : ICustomerInfoAdapter
    {
        private CustomerInfoRepository mRepository;

        private CustomerInfoRepository _repository
        {
            get => this.mRepository ?? new CustomerInfoRepository(BasicUtility.Conn);
            set => this.mRepository = value;
        }

    #region Implementation of ICustomerAdapter

        /// <inheritdoc />
        public Task<List<CustomInfoViewModel>> GetAll()
        {
            return _repository.GetAll();
        }

        /// <inheritdoc />
        public Task<bool> AddOrUpdate(CustomInfoViewModel FromUi)
        {
            return _repository.AddOrUpdate(FromUi);
        }

        /// <inheritdoc />
        public Task<bool> Delete(string pArea, string pCustom)
        {
            return _repository.Delete(pArea, pCustom);
        }

        /// <inheritdoc />
        public Task<List<CustomInfoViewModel>> Get(string pArea, string pCustom)
        {
            return _repository.Get(pArea, pCustom);
        }

        /// <inheritdoc />
        public Task<List<KeyAndName>> DistinctCustomer(string pArea)
        {
            return _repository.DistinctCustomer(pArea);
        }

        /// <inheritdoc />
        public Task<List<KeyAndName>> DistinctCustomerAsync()
        {
            return this._repository.DistinctCustomerAsync();
        }

    #endregion
    }
}