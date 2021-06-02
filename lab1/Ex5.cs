using System;

namespace labduongsinh.Properties
{
    public class Ex5
    {
        public void TimGiaiThua()
        {
            int result = 1;
            for (int i = 1; i < 21; i++)
            {
                result = result * i;
                Console.WriteLine($"Giai thua cua {i} = {result}");
            }
        }
    }
}