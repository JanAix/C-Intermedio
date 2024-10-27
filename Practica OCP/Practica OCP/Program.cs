


using Practica_OCP;

TaxCalculator taxCalculator = new TaxCalculator();

IndiaTaxCalcular taxindia = new IndiaTaxCalcular();
taxindia.taxDeduction = 5;
taxindia.taxAmount = 3;
taxCalculator.Calculate(taxindia);



UsaTaxCalcular taxusa = new UsaTaxCalcular();
taxusa.taxDeduction = 3;
taxusa.taxAmount = 4;
taxCalculator.Calculate(taxusa);


UkTaxCalcular taxu = new UkTaxCalcular();
taxu.taxDeduction = 10;
taxu.taxAmount = 11;
taxCalculator.Calculate(taxu);

Console.ReadLine();

