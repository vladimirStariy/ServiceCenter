using ServiceCenter.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.Data.Repository.Implementation
{
    public class UserRepository : IRepository<User>
    {
        public Task Create(User entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> Get()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(uint id)
        {
            throw new NotImplementedException();
        }

        public Task<User> Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
