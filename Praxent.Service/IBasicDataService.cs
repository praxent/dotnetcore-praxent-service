using System.Linq;
using Praxent.Data;

namespace Praxent.Service
{
    public interface IBasicDataService<T> where T : class, IDataEntity, new()
    {
        IQueryable<T> GetAll();
        T GetById(string id);
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        T Delete(string id);
    }
}