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
    public class Usuario:BaseEntity<int>
    {
        [Key]
        [Column("IdUser")]
        public override int Id { get; set; }
        public int Id_Grupousuarios { get; set; }
        public Grupousuario Grupousuario { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public ICollection<Taxis> Taxis { get; set; }
        public ICollection<DetalleViaje> DetallesViaje { get; set; }
    }
}
