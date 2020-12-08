using HINVenture.Shared.Data;
using HINVenture.Shared.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HINVenture.Shared.Models.ViewModels
{
    public class FreelancersRepository : IUserRepository<FreelancerUser>
    {
        private readonly ApplicationDbContext _db;
        public FreelancersRepository(ApplicationDbContext db)
        {
            this._db = db;
        }
        public Task Create(FreelancerUser p)
        {
            throw new NotImplementedException();
        }

        public async Task<FreelancerUser> Get(string id)
        {
            return await _db.FreelancerUsers.FindAsync(id);
        }

        public IQueryable<FreelancerUser> GetAll()
        {
            return _db.FreelancerUsers;
        }

        public Task Remove(FreelancerUser entity)
        {
            throw new NotImplementedException();
        }

        public async Task Update(FreelancerUser entity)
        {
            _db.FreelancerUsers.Update(entity);
            await _db.SaveChangesAsync();
        }
    }
}
