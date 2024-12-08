using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data.Entities.Base;

namespace Taxi.Data.Entities
{
    public  class DetalleViaje:BaseEntity<int>
    {
        [Key]
        [Column("IdDetailViaje")]
        public override int Id { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public int Idviaje { get; set; }
        public Viaje Viaje { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
    }
}
