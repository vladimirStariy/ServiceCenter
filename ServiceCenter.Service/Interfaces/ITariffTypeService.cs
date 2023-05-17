using ServiceCenter.Domain.Entity;
using ServiceCenter.Domain.Response;
using ServiceCenter.Domain.Viewmodel;

namespace ServiceCenter.Service.Interfaces
{
    public interface ITariffTypeService
    {
        Task<IBaseResponce<TariffType>> Create(TariffTypeViewModel model);
        Task<IBaseResponce<TariffType>> Update(TariffTypeViewModel model);
        Task<IBaseResponce<TariffType>> Remove(int id);

        IBaseResponce<List<TariffType>> Get();
        IBaseResponce<List<TariffTypeViewModel>> GetTarifTypeView();
        IBaseResponce<TariffType> GetById(int id);
    }
}
