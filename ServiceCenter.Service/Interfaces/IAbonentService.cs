using ServiceCenter.Domain.Entity;
using ServiceCenter.Domain.Response;
using ServiceCenter.Domain.Viewmodel;

namespace ServiceCenter.Service.Interfaces
{
    public interface IAbonentService
    {
        Task<IBaseResponce<Abonent>> Create(AbonentViewModel model);
        Task<IBaseResponce<Abonent>> Update(AbonentViewModel model);
        Task<IBaseResponce<Abonent>> Remove(int id);

        IBaseResponce<List<Abonent>> Get();
        IBaseResponce<List<OrderViewModel>> GetAbonentView();
        IBaseResponce<Abonent> GetById(int id);
    }
}
