﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OCP
{
    public class UsaTaxCalcular : ICountryCalcular
    {
        public decimal taxAmount { get; set; }
        public decimal taxDeduction { get; set; }

        public decimal Calcular(decimal income, decimal deduction)
        {
            taxDeduction = income - deduction;

            return taxAmount = taxDeduction * (6.2m / 100);
        }
    }
}