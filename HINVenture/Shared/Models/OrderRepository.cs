using HINVenture.Shared.Data;
using HINVenture.Shared.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace HINVenture.Shared.Models
{
    public class OrderRepository : IRepository<Order>
    {
        private readonly ApplicationDbContext _db;
        public OrderRepository(ApplicationDbContext db)
        {
            this._db = db;
        }

        public async Task Create(Order p)
        {
            _db.Orders.Add(p);
            await _db.SaveChangesAsync();
        }

        public async Task<Order> Get(int id)
        {
            return await _db.Set<Order>().FindAsync(id);
        }

        public IQueryable<Order> GetAll()
        {
            return _db.Orders;
        }

        public Task Remove(Order entity)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Order entity)
        {
            _db.Set<Order>().Update(entity);
            await _db.SaveChangesAsync();
        }
        
    }
}
