using ServiceCenter.Data.Repository;
using ServiceCenter.Domain.Entity;
using ServiceCenter.Domain.Enum;
using ServiceCenter.Domain.Response;
using ServiceCenter.Domain.Viewmodel;
using ServiceCenter.Service.Interfaces;

namespace ServiceCenter.Service.Implementations
{
    public class AbonentService : IAbonentService
    {
        private readonly IRepository<Abonent> _abonentRepository;

        public AbonentService(IRepository<Abonent> abonentRepository)
        {
            _abonentRepository = abonentRepository;
        }

        public async Task<IBaseResponce<Abonent>> Create(AbonentViewModel model)
        {
            try
            {
                  var abonent = new Abonent();
                abonent.Contract_number = model.Contract_number;
                abonent.Name = model.Name;
                abonent.Phone = model.Phone;
                abonent.Birthday = model.Birthday;
                abonent.Adress = model.Adress;
                abonent.Passport = model.Passport;

                await _abonentRepository.Create(abonent);

                return new BaseResponse<Abonent>()
                {
                    Result = abonent,
                    Description = "Объект добавлен",
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Abonent>()
                {
                    StatusCode = StatusCode.InternalServerError,
                    Description = $"Внутренняя ошибка: {ex.Message}"
                };
            }
        }

        public IBaseResponce<List<Abonent>> Get()
        {
            try
            {
                var abonents = _abonentRepository.Get().ToList();
                if (!abonents.Any())
                {
                    return new BaseResponse<List<Abonent>>()
                    {
                        Description = "Not found",
                        StatusCode = StatusCode.OK
                    };
                }
                return new BaseResponse<List<Abonent>>()
                {
                    Result = abonents,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<List<Abonent>>()
                {
                    Description = $"[GetAbonents] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public IBaseResponce<List<OrderViewModel>> GetAbonentView()
        {
            throw new NotImplementedException();
        }

        public IBaseResponce<Abonent> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponce<Abonent>> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponce<Abonent>> Update(AbonentViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
