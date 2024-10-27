using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OCP
{
    public class TaxCalculator: Cliente
    {

        public decimal Calculate(ICountryCalcular calcular)
        {

           return calcular.Calcular(income, deduction);

            
        }
    }
}
