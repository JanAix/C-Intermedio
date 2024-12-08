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
    public  class Grupousuario:BaseEntity<int>
    {
        [Key]
        [Column("IdGU")]
        public override int Id { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<GrupoUsuarioDetalle> GrupoUsuarioDetalles { get; set; }
    }
}
