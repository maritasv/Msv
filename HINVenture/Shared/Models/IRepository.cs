﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HINVenture.Shared.Models
{
    public interface IRepository<T>
    {
        Task<T> Get(int id);
        IQueryable<T> GetAll();
        Task Update(T entity);
        Task Remove(T entity);
        Task Create(T p);
    }
}
