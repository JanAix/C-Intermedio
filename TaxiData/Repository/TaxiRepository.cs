using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data.Entities;
using Taxi.Data.Entities.Base;
using Taxi.Data.Interfaces;
using Taxi.Data.Model;

namespace Taxi.Data.Repository
{
    public sealed class TaxiRepository : IBaserepository<Taxis, TaxisModel>
    {
        public Task<bool> Exists(System.Linq.Expressions.Expression<Func<Taxis, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<TaxisModel>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<TaxisModel>>> GetAll(System.Linq.Expressions.Expression<Func<Taxis, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<TaxisModel>> GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<TaxisModel>> Remove(Taxis entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<TaxisModel>> Save(Taxis entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<TaxisModel>> Update(Taxis entity)
        {
            throw new NotImplementedException();
        }
    }
}
