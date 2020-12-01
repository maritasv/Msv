
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HINVenture.Shared.Models
{
    public interface IUserRepository<T>
    {
        Task<T> Get(string id);
        IQueryable<T> GetAll();
        Task Update(T entity);
        Task Remove(T entity);
        Task Create(T p);
    }
}
