using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data.Entities;

namespace Taxi.Data.Model
{
    public class GrupoUsuarioDetalleModel
    {
        public  int IdGPU { get; set; }
        public int Id_Grupousuario { get; set; }
        public Grupousuario Grupousuario { get; set; }
    }
}
