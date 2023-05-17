using ServiceCenter.Domain.Entity;
using ServiceCenter.Domain.Response;
using ServiceCenter.Domain.Viewmodel;
using ServiceCenter.Service.Interfaces;

namespace ServiceCenter.Service.Implementations
{
    public class TariffTypeService : ITariffTypeService
    {
        public Task<IBaseResponce<TariffType>> Create(TariffTypeViewModel model)
        {
            throw new NotImplementedException();
        }

        public IBaseResponce<List<TariffType>> Get()
        {
            throw new NotImplementedException();
        }

        public IBaseResponce<TariffType> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IBaseResponce<List<TariffTypeViewModel>> GetTarifTypeView()
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponce<TariffType>> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponce<TariffType>> Update(TariffTypeViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
