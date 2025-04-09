using System;
using System.Text;
namespace LAB01
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("----- MENU BÀI TẬP C# -----");
            Console.WriteLine("Chọn bài tập (1 - 10): ");
            int bai = int.Parse(Console.ReadLine());

            switch (bai)
            {
                case 1: Bai1.Chay(); break;
                case 2: Bai2.Chay(); break;
                case 3: Bai3.Chay(); break;
                case 4: Bai4.Chay(); break;
                case 5: Bai5.Chay(); break;
                case 6: Bai6.Chay(); break;
                case 7: Bai7.Chay(); break;
                case 8: Bai8.Chay(); break;
                case 9: Bai9.Chay(); break;
                case 10: Bai10.Chay(); break;
                default: Console.WriteLine("Lựa chọn không hợp lệ."); break;
            }
        }
    }
}