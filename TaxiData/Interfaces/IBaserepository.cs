using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data.Entities.Base;

namespace Taxi.Data.Interfaces
{
    public interface IBaserepository<TEntety, TModel> where TEntety : class
    {

        Task<OperationResult<TModel>> Save(TEntety entity);
        Task<OperationResult<TModel>> Update(TEntety entity);
        Task<OperationResult<TModel>> Remove(TEntety entity);
        Task<OperationResult<List<TModel>>> GetAll();
        Task<OperationResult<List<TModel>>> GetAll(Expression<Func<TEntety, bool>> filter);
        Task<OperationResult<TModel>> GetEntityBy(int Id);
        Task<bool> Exists(Expression<Func<TEntety, bool>> filter);
    }
}
