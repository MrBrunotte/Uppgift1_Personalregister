using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1_Personalregister
{
    class Employee
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Salary { get; set; } = 0;

        public Employee()
        {

        }
        public Employee(string firstName, string lastName, int salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
        public static void AddEmployee(string firstName, string lastName, int salary)
        {
            Console.Write("Type first name of employee: ");
            firstName = Console.ReadLine();
            Console.Write("Type last name of employee: ");
            lastName = Console.ReadLine();
            Console.Write("Type employee salary: ");
            salary = int.Parse(Console.ReadLine());

            ChangeConsoleColor();
            Console.WriteLine($"\n\tFirst name: {firstName}\n" +
                              $"\tLast name: {lastName}\n" +
                              $"\tSalary: {salary}\n");
            ResetConsoleColor();
        }
        private static void ChangeConsoleColor()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        private static void ResetConsoleColor()
        {
            Console.ResetColor();
        }
    }
}
