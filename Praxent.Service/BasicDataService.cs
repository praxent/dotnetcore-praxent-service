using System.Linq;
using Praxent.Data;

namespace Praxent.Service
{
    public class BasicDataService<T> : IBasicDataService<T> where T : class, IDataEntity, new()
    {
        private readonly IRepository<T> _repository;

        public BasicDataService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public IQueryable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(string id)
        {
            return _repository.GetById(id);
        }

        public T Add(T entity)
        {
            return _repository.Add(entity);
        }

        public T Update(T entity)
        {
            return _repository.Update(entity);
        }

        public T Delete(T entity)
        {
            return _repository.Delete(entity);
        }

        public T Delete(string id)
        {
            return _repository.Delete(id);
        }
    }
}