using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> FindAll(string[] includes);
        Task<T> Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
