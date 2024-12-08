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
    public class Taxis : BaseEntity<int>
    {
        [Key]
        [Column("IdTaxi")]
        public override int Id { get; set; }
        public int IdUser { get; set; }
        public string Placa { get; set; }
    }
}
