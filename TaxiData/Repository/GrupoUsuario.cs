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
    public sealed class GrupoUsuario : IGrupoUsuarioRepository
    {
        public Task<bool> Exists(Expression<Func<Grupousuario, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<GrupoUsuarioModel>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<GrupoUsuarioModel>>> GetAll(Expression<Func<Grupousuario, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<GrupoUsuarioModel>> GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<GrupoUsuarioModel>> Remove(Grupousuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<GrupoUsuarioModel>> Save(Grupousuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<GrupoUsuarioModel>> Update(Grupousuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
