using ServiceCenter.Domain.Entity;
using ServiceCenter.Domain.Response;
using ServiceCenter.Domain.Viewmodel;

namespace ServiceCenter.Service.Interfaces
{
    public interface ITariffService
    {
        Task<IBaseResponce<Tariff>> Create(TariffViewModel model);
        Task<IBaseResponce<Tariff>> Update(TariffViewModel model);
        Task<IBaseResponce<Tariff>> Remove(int id);

        IBaseResponce<List<Tariff>> Get();
        IBaseResponce<List<TariffViewModel>> GetTariffView();
        IBaseResponce<Tariff> GetById(int id);
    }
}
