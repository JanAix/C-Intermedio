using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data.Interfaces;
using Taxi.Data.Model;

namespace Taxi.Data.Repository
{
    public sealed class GrupoUsuario : IBaserepository<GrupoUsuario, GrupoUsuarioModel>
    {
        public Task<bool> Exists(Expression<Func<GrupoUsuario, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Base.OperationResult<List<GrupoUsuarioModel>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Base.OperationResult<List<GrupoUsuarioModel>>> GetAll(Expression<Func<GrupoUsuario, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Base.OperationResult<GrupoUsuarioModel>> GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Base.OperationResult<GrupoUsuarioModel>> Remove(GrupoUsuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Base.OperationResult<GrupoUsuarioModel>> Save(GrupoUsuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Base.OperationResult<GrupoUsuarioModel>> Update(GrupoUsuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
