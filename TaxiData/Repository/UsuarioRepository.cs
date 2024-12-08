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
    public sealed class UsuarioRepository : IUsuarioRepository
    {
        public Task<bool> Exists(Expression<Func<Usuario, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<UsuarioModel>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<UsuarioModel>>> GetAll(Expression<Func<Usuario, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<UsuarioModel>> GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<UsuarioModel>> Remove(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<UsuarioModel>> Save(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<UsuarioModel>> Update(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
