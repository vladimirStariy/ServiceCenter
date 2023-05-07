using Microsoft.EntityFrameworkCore;
using ServiceCenter.Domain.Entity;

namespace ServiceCenter.Data.Repository.Implementation
{
    public class ServiceRepository : IRepository<Service>
    {
        private readonly ApplicationDbContext _db;

        public ServiceRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Create(Service entity)
        {
            await _db.Services.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Service entity)
        {
            _db.Services.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Service> Get()
        {
            return _db.Services;
        }

        public Task<Service> GetById(uint id)
        {
            return _db.Services.Where(x => x.Service_ID == id).FirstOrDefaultAsync();
        }

        public async Task<Service> Update(Service entity)
        {
            _db.Services.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
