using HINVenture.Shared.Data;
using HINVenture.Shared.Models.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HINVenture.Shared.Models
{
    public class SpecialitiesRepository : IRepository<Speciality>
    {
        private readonly ApplicationDbContext _db;
        public SpecialitiesRepository(ApplicationDbContext db)
        {
            this._db = db;
        }
        public Task Create(Speciality p)
        {
            throw new NotImplementedException();
        }

        public Task<Speciality> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Speciality> GetAll()
        {
            return _db.Specialities;
        }

        public Task Remove(Speciality entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Speciality entity)
        {
            throw new NotImplementedException();
        }
    }
}
