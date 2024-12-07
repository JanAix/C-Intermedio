using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data.Entities;

namespace Taxi.Data.Model
{
    public class UsuarioModel
    {

        public int IdUser { get; set; }
        public int Id_Grupousuarios { get; set; }
        public Grupousuario Grupousuario { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public ICollection<Taxis> Taxis { get; set; }
        public ICollection<DetalleViaje> DetallesViaje { get; set; }
    }
}
