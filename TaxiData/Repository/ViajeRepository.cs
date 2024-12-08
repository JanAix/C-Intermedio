using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data.Context;
using Taxi.Data.Entities;
using Taxi.Data.Entities.Base;
using Taxi.Data.Interfaces;
using Taxi.Data.Model;

namespace Taxi.Data.Repository
{
    public sealed class ViajeRepository : IViajeRepository
    {
        private readonly ILogger<ViajeRepository> _logger;
        private readonly TaxiContext _context;
        public ViajeRepository(TaxiContext taxiContext, ILogger<ViajeRepository> logger)
        {
            taxiContext = _context;
            logger = _logger;

        }
        public Task<bool> Exists(Expression<Func<Viaje, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<ViajeModel>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<ViajeModel>>> GetAll(Expression<Func<Viaje, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<ViajeModel>> GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<ViajeModel>> Remove(Viaje entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<ViajeModel>> Save(Viaje entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<ViajeModel>> Update(Viaje entity)
        {
            throw new NotImplementedException();
        }
    }
}
