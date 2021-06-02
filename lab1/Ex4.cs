using System;

namespace labduongsinh.Properties
{
    public class Ex4
    {
        public void SoNguyen()
        {
            Console.WriteLine("Vui lòng nhập số nguyên N");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }
    }
}