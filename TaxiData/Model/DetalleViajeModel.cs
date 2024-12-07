using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data.Entities;

namespace Taxi.Data.Model
{
    public class DetalleViajeModel
    {
        public  int IdDetailViaje { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public int Idviaje { get; set; }
        public Viaje Viaje { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
    }
}
