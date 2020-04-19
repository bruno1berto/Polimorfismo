using Polimorfismo.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of emploees: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Emploee #{i} Data: ");
                Console.Write("OutSourced (y/n): ");
                char outSourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: $ ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (outSourced == 'y' || outSourced == 'Y')
                {
                    Console.Write("Aditional charge: $ ");
                    double aditonalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    employees.Add(new OutSourcedEmployee(name, hours, valuePerHour, aditonalCharge));
                }else if (outSourced == 'n' || outSourced == 'N')
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
                Console.WriteLine();
            }

            Console.WriteLine("PAYMENTS: ");
            foreach(Employee x in employees)
            {
                //Console.WriteLine(x);
                Console.WriteLine(x.Name + " - $ " + x.Payment().ToString("F2"),CultureInfo.InvariantCulture);
            }

            Console.ReadLine();
        }
    }
}
