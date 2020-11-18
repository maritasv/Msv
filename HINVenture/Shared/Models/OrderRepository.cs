using HINVenture.Shared.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace HINVenture.Shared.Models
{
    class OrderRepository : IRepository<Order>
    {
        private readonly ApplicationDbContext _db;
        public OrderRepository(ApplicationDbContext db)
        {
            this._db = db;
        }

        public Task Create(Order p)
        {
            throw new NotImplementedException();
        }

        public Task<Order> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Remove(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Order entity)
        {
            throw new NotImplementedException();
        }
        
    }
}
