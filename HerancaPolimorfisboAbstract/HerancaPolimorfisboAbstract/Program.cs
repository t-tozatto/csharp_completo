using HerancaPolimorfisboAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaPolimorfisboAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int numberTaxpayer = Convert.ToInt16(Console.ReadLine());
            char individualOrCompany;
            string name;
            double annualIncome;

            List<Taxpayer> listTaxpayer = new List<Taxpayer>();
            for(int i = 0; i < numberTaxpayer; i++)
            {
                Console.WriteLine(string.Concat("Tax payer #", i + 1," data:"));
                Console.Write("Individual or company (i/c)? ");
                individualOrCompany = Convert.ToChar(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Annual income: ");
                annualIncome = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                switch(individualOrCompany)
                {
                    case 'i':
                        Console.Write("Health expenditures: ");
                        listTaxpayer.Add(new NaturalPerson(name, annualIncome, Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture)));
                        break;
                    case 'c':
                        Console.Write("Number of employess: ");
                        listTaxpayer.Add(new LegalPerson(name, annualIncome, Convert.ToInt16(Console.ReadLine(), CultureInfo.InvariantCulture)));
                        break;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("TAXES PAID:");
            double sumTax = 0, individualTaxes;
            for(int i = 0; i < listTaxpayer.Count; i++)
            {
                individualTaxes = listTaxpayer[i].Taxes();
                sumTax += individualTaxes;
                Console.WriteLine(string.Concat(listTaxpayer[i].Name, " $ ", individualTaxes.ToString("F2", CultureInfo.InvariantCulture)));
            }
            Console.WriteLine("");
            Console.WriteLine(string.Concat("TOTAL TAXES: $ ", sumTax.ToString("F2", CultureInfo.InvariantCulture)));
        }
    }
}
