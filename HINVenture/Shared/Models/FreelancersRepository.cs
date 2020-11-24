using HINVenture.Shared.Data;
using HINVenture.Shared.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HINVenture.Shared.Models.ViewModels
{
    public class FreelancersRepository : IRepository<FreelancerUser>
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

        public Task<FreelancerUser> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<FreelancerUser> GetAll()
        {
            return _db.FreelancerUsers;
        }

        public Task Remove(FreelancerUser entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(FreelancerUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
