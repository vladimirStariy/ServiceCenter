using ServiceCenter.Data.Repository;
using ServiceCenter.Data.Repository.Implementation;
using ServiceCenter.Domain.Entity;
using ServiceCenter.Service.Implementations;
using ServiceCenter.Service.Interfaces;

namespace ServiceCenter.View
{
    public static class Initializer
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<User>, UserRepository>();
        }

        public static void InitializeServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}
