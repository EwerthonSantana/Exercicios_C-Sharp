using System;
using System.Globalization;
using System.Collections.Generic;
using DesafioHeranca.Entities;

namespace DesafioHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayers> taxpayers = new List<Taxpayers>();

            Console.Write("Enter the number of tax payers: ");
            int amountTaxPayers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= amountTaxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char typeOfPerson = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(typeOfPerson == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxpayers.Add(new PrivateIndividual(name, anualIncome, healthExpenditure));
                }
                if(typeOfPerson == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxpayers.Add(new LegalEntity(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();

            double totalPax = 0;
            Console.WriteLine("TAXES PAID:");
            foreach (Taxpayers payers in taxpayers)
            {
                Console.WriteLine($"{payers.Name}: $ {payers.TotalTax().ToString("F2", CultureInfo.InvariantCulture)}");
                totalPax += payers.TotalTax();
            }
            Console.WriteLine();

            Console.WriteLine("TOTAL TAXES: $ " + totalPax.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
