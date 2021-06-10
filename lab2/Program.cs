using System;

namespace lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Vui lòng nhập mã SIN");
            ;
            int n = int.Parse(Console.ReadLine());
            int sun = 0;
            if (n.ToString().Length != 9)
            {
                Console.WriteLine("Chương trình chỉ nhận 9 số");
            }
            else
            {
                while (n != 0)
                {
                    sun = sun + n % 10;
                    n = n / 10;
                }

                int total = sun % 10;
                if (total == 0)
                {
                    Console.WriteLine("This is valid SIN");
                }
            }
        }
    }
}