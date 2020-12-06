using HINVenture.Shared.Data;
using HINVenture.Shared.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HINVenture.Shared.Models
{
    public class CustomerRepository : IUserRepository<CustomerUser>
    {
        private readonly ApplicationDbContext _db;
        public CustomerRepository(ApplicationDbContext db)
        {
            this._db = db;
        }
        public Task Create(CustomerUser p)
        {
            throw new NotImplementedException();
        }

        public async Task<CustomerUser> Get(string id)
        {
            return await _db.CustomerUsers.FindAsync(id);
        }

        public IQueryable<CustomerUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Remove(CustomerUser entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(CustomerUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
