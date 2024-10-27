using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OCP
{
    public abstract class Cliente
    {

        public int id { get; set; }

        public string name {  get; set; }
        public decimal income { get; set; }

        public decimal deduction { get; set; }

        public string country {  get; set; }
    }
}
