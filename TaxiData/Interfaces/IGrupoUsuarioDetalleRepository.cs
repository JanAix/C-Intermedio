using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data.Entities;
using Taxi.Data.Model;

namespace Taxi.Data.Interfaces
{
    public interface IGrupoUsuarioDetalleRepository:IBaserepository<GrupoUsuarioDetalle, int, GrupoUsuarioDetalleModel>
    {
    }
}
