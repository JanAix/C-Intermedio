

using System.Linq.Expressions;
using Taxi.Data.Entities.Base;
using Taxi.Data.Interfaces;

namespace Taxi.Data.Repository
{
    public abstract class BaseRepository<TEntety, TModel> : IBaserepository<TEntety, TModel> where TEntety : class
    {
        public Task<bool> Exists(Expression<Func<TEntety, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<TModel>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<TModel>>> GetAll(Expression<Func<TEntety, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<TModel>> GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<TModel>> Remove(TEntety entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<TModel>> Save(TEntety entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<TModel>> Update(TEntety entity)
        {
            throw new NotImplementedException();
        }
    }
}
