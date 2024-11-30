using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RefactoryngGenerics.Entities;
using System.Threading.Tasks;

namespace RefactoryngGenerics.Interfaces
{
    public interface IAsientoRepository <TAsientto> where TAsientto : class
    {

        void Agregar(TAsientto asiento);

        void Actuarlizar(TAsientto asiento);
        void Remover(TAsientto asiento);
        List<TAsientto> GetAll();

        TAsientto ObtenerPorId(int asientoID);

    


    }
}
