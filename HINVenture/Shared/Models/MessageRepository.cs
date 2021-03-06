﻿using HINVenture.Shared.Data;
using HINVenture.Shared.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HINVenture.Shared.Models
{
    public class MessageRepository : IRepository<Message>
    {
        private readonly ApplicationDbContext _db;
        public MessageRepository(ApplicationDbContext db)
        {
            this._db = db;
        }

        public async Task Create(Message p)
        {
            _db.Messages.Add(p);
            await _db.SaveChangesAsync();
        }

        public Task<Message> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Message> GetAll()
        {
            return _db.Messages;
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
