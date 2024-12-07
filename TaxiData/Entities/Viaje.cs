using Azure.Core.GeoJson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Taxi.Data.Entities.Base;

namespace Taxi.Data.Entities
{
    public class Viaje:BaseEntity<int>
    {
        [Key]
        [Column("IdViaje")]
        public override int Id { get; set; }
        public int IdTaxi { get; set; }
        public Taxis Taxi { get; set; }
        public DateTime FechaIncio { get; set; }
        public DateTime FechaFin { get; set; }
        public GeoPosition Desde { get; set; } 
        public string Hasta { get; set; }
        public decimal? Calificacion { get; set; }
        public ICollection<DetalleViaje> DetallesViaje { get; set; }
    }
}
