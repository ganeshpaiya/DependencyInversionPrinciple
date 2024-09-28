using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employ = new Employee(new Intimation());
            employ.AddEmployee();
            Console.WriteLine("Hello World!");
        }
    }
}
