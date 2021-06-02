using System;

namespace labduongsinh
{
    public class Ex1
    {
        public void ShowEx1()
        {
            Console.WriteLine("Vui Lòng nhập tên:");
            var Ten = Console.ReadLine();
            Console.WriteLine("Vui lòng nhập địa chỉ");
            var diaChi = Console.ReadLine();
            Console.WriteLine("Vui lòng nhập điện thoại");
            var dienThoai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ten: {Ten}, Diachi: {diaChi}, Dienthoai: {dienThoai}");

        }
    }
}