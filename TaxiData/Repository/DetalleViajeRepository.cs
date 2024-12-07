using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data.Entities;
using Taxi.Data.Entities.Base;
using Taxi.Data.Interfaces;
using Taxi.Data.Model;

namespace Taxi.Data.Repository
{
    public sealed class DetalleViajeRepository : IBaserepository<DetalleViaje, DetalleViajeModel>
    {
        public Task<bool> Exists(Expression<Func<DetalleViaje, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<DetalleViajeModel>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<DetalleViajeModel>>> GetAll(Expression<Func<DetalleViaje, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<DetalleViajeModel>> GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<DetalleViajeModel>> Remove(DetalleViaje entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<DetalleViajeModel>> Save(DetalleViaje entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<DetalleViajeModel>> Update(DetalleViaje entity)
        {
            throw new NotImplementedException();
        }
    }
}
