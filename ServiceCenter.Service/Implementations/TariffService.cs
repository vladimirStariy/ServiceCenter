using ServiceCenter.Domain.Entity;
using ServiceCenter.Domain.Response;
using ServiceCenter.Domain.Viewmodel;
using ServiceCenter.Service.Interfaces;

namespace ServiceCenter.Service.Implementations
{
    public class TariffService : ITariffService
    {
        public Task<IBaseResponce<Tariff>> Create(TariffViewModel model)
        {
            throw new NotImplementedException();
        }

        public IBaseResponce<List<Tariff>> Get()
        {
            throw new NotImplementedException();
        }

        public IBaseResponce<Tariff> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IBaseResponce<List<TariffViewModel>> GetTariffView()
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponce<Tariff>> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponce<Tariff>> Update(TariffViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
