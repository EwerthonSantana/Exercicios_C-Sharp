using System;
using System.Globalization;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int qtdEmployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdEmployees; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employee.Add(new Employee() { Id = id, Name = name, Salary = salary });
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that have salary increase: ");
            int idChoise = int.Parse(Console.ReadLine());
            
             Employee employeeId = employee.Find(x => x.Id == idChoise);

            if(employeeId != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employeeId.IncreaseSalary(percentage);
            } else
            {
                Console.WriteLine("this id not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee item in employee)
            {
                Console.WriteLine(item);
            }


        }
    }
}
