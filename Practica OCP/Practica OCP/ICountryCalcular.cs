using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OCP
{
    public interface ICountryCalcular
    {
        decimal taxAmount { get; set; }
        decimal taxDeduction { get; set; }
        decimal Calcular(decimal income, decimal deduction);
    }
}
