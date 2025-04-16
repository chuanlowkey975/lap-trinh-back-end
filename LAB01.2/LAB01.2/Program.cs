using System;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace LAB01._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập C#");
            Console.WriteLine("Chọn bài tập (1-6):");
            if (int.TryParse(Console.ReadLine(), out int bai))
            {
                switch (bai)
                {
                    case 1:
                        Bai1.Chay();
                        break;
                    case 2:
                        Bai2.Chay();
                        break;
                    case 3:
                        Bai3.Chay();
                        break;
                    case 4:
                        Bai4.Chay();
                        break;
                    case 5:
                        Bai5.Chay();
                        break;
                    case 6:
                        Bai6.Chay();
                        break;
                    default:
                        Console.WriteLine("Không có bài tập này.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số hợp lệ.");
            }
        }
    }
}

