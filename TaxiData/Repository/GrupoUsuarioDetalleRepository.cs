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
    public sealed class GrupoUsuarioDetalleRepository : IBaserepository<GrupoUsuarioDetalle, GrupoUsuarioDetalleModel>
    {
        public Task<bool> Exists(Expression<Func<GrupoUsuarioDetalle, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<GrupoUsuarioDetalleModel>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<GrupoUsuarioDetalleModel>>> GetAll(Expression<Func<GrupoUsuarioDetalle, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<GrupoUsuarioDetalleModel>> GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<GrupoUsuarioDetalleModel>> Remove(GrupoUsuarioDetalle entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<GrupoUsuarioDetalleModel>> Save(GrupoUsuarioDetalle entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<GrupoUsuarioDetalleModel>> Update(GrupoUsuarioDetalle entity)
        {
            throw new NotImplementedException();
        }
    }
}
