using System;
using System.Net.Configuration;
using Lab3.ex2;

namespace Lab3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Atom atom = new Atom();
            while (true)
            {
                atom.Accept();
                Console.WriteLine("Chon 1 tiep tuc chon 2 de dung");
                int choice = int.Parse(Console.ReadLine());
                if (choice != 1)
                {
                    break;
                }
            }
            atom.Display();*/
            Employee employee = new Employee("dat","det","hihi",1,10);
            Console.WriteLine(employee.ToString());
            Console.WriteLine(employee.CalculBonus(0.5));
        }
    }
}