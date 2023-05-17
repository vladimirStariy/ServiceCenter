using Microsoft.EntityFrameworkCore;
using ServiceCenter.Data.Repository;
using ServiceCenter.Domain.Entity;
using ServiceCenter.Domain.Enum;
using ServiceCenter.Domain.Response;
using ServiceCenter.Domain.Viewmodel;
using ServiceCenter.Domain.Viewmodel.User;
using ServiceCenter.Service.Interfaces;
using System.Security.Claims;

namespace ServiceCenter.Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        private ClaimsIdentity Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Username),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.ToString())
            };
            return new ClaimsIdentity(claims, "ApplicationCookie",
                ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
        }

        public async Task<BaseResponse<ClaimsIdentity>> Login(LoginViewModel model)
        {
            try
            {
                var user = await _userRepository.Get().FirstOrDefaultAsync(x => x.Username == model.Username);
                if (user == null)
                {
                    return new BaseResponse<ClaimsIdentity>()
                    {
                        Description = "Пользователь не найден"
                    };
                }

                if (user.Password != model.Password)
                {
                    return new BaseResponse<ClaimsIdentity>()
                    {
                        Description = "Неверный пароль или логин"
                    };
                }
                var result = Authenticate(user);

                return new BaseResponse<ClaimsIdentity>()
                {
                    Result = result,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<ClaimsIdentity>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public IBaseResponce<List<User>> Get()
        {
            throw new NotImplementedException();
        }

        public IBaseResponce<List<UserListViewModel>> GetUserView()
        {
            try
            {
                var users = _userRepository.Get().ToList();
                var userView = new List<UserListViewModel>();
                foreach (var item in users)
                {
                    UserListViewModel model = new UserListViewModel();
                    model.Login = item.Username;
                    model.Role = item.Role.ToString();
                    userView.Add(model);
                }
                if (!userView.Any())
                {
                    return new BaseResponse<List<UserListViewModel>>()
                    {
                        Description = "Not found",
                        StatusCode = StatusCode.OK
                    };
                }
                return new BaseResponse<List<UserListViewModel>>()
                {
                    Result = userView,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<List<UserListViewModel>>()
                {
                    Description = $"[GetUsers] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public IBaseResponce<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IBaseResponce<User>> Create(UserViewModel model)
        {
            try
            {
                var user = new User()
                {
                    Username = model.Login,
                    Password = model.Password,
                    Role = model.Role
                };

                await _userRepository.Create(user);

                return new BaseResponse<User>()
                {
                    Result = user,
                    Description = "Пользователь добавлен",
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<User>()
                {
                    StatusCode = StatusCode.InternalServerError,
                    Description = $"Внутренняя ошибка: {ex.Message}"
                };
            }
        }

        public Task<IBaseResponce<User>> Update(UserViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
