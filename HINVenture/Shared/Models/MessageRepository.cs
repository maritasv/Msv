using HINVenture.Shared.Data;
using HINVenture.Shared.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HINVenture.Shared.Models
{
    class MessageRepository : IRepository<Message>
    {
        private readonly ApplicationDbContext _db;
        public MessageRepository(ApplicationDbContext db)
        {
            this._db = db;
        }

        public Task Create(Message p)
        {
            throw new NotImplementedException();
        }

        public Task<Message> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Message> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Remove(Message entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Message entity)
        {
            throw new NotImplementedException();
        }
    }
}
