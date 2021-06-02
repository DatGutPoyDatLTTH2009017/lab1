using System;
using System.Runtime.InteropServices;

namespace labduongsinh.Properties
{
    public class Ex2
    {
        public void NhapBaSo()
        {
            Console.WriteLine("Vui lòng nhập số thu1");
            int so1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vui lòng nhập số thu2");
            int so2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vui lòng nhập số thu3");
            int so3 = Convert.ToInt32(Console.ReadLine());
            int soLonNhat = so1;
            if (soLonNhat < so2)
            {
                soLonNhat = so2;
            }

            if (soLonNhat < so3)
            {
                soLonNhat = so3;
            }

            Console.WriteLine($"Số lớn nhất là: {soLonNhat}");
        }
    }
}