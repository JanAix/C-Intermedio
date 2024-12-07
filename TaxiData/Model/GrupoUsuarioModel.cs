using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data.Entities;

namespace Taxi.Data.Model
{
    public class GrupoUsuarioModel
    {
        public int IdGU { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<GrupoUsuarioDetalle> GrupoUsuarioDetalles { get; set; }
    }
}
