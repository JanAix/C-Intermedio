using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RefactoryngGenerics.Repository
{
    public class IRepository <T> where T : class
    {

        private readonly List<T> _dbset = new List<T>();



        public void Agregar(T entity) {

            _dbset.Add(entity);
        }

        public void Actualizar(T entity)
        {

            _dbset.Remove(entity);
            _dbset.Add(entity);
        }

        public void Eliminar(T entity) {

            _dbset.Remove(entity);
        }

        public List<T> GetAll() { 
        
        return _dbset;
        }

    


    }
}
