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
    public  class GrupoUsuarioDetalle:BaseEntity<int>
    {
        [Key]
        [Column("IdGPU")]
        public override int Id { get; set; }
        public int Id_Grupousuario { get; set; }
        public Grupousuario Grupousuario { get; set; }
    }
}
