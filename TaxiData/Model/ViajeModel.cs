using Azure.Core.GeoJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data.Entities;

namespace Taxi.Data.Model
{
    public class ViajeModel
    {
        public int IdViaje { get; set; }
        public int IdTaxi { get; set; }
        public Taxis Taxi { get; set; }
        public DateTime FechaIncio { get; set; }
        public DateTime FechaFin { get; set; }
        public GeoPosition Desde { get; set; }
        public string Hasta { get; set; }
        public decimal? Calificacion { get; set; }
        public ICollection<DetalleViaje> DetallesViaje{  get; set; }

    }
}
