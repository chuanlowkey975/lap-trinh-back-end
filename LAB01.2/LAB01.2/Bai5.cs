using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01._2
{
    internal class Bai5
    {
        public static void Chay()
        {
            Console.Write("Nhập a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b = ");
            int b = int.Parse(Console.ReadLine());

            HoanVi(ref a, ref b);
            Console.WriteLine($"Sau khi hoán vị: a = {a}, b = {b}");
        }

        static void HoanVi(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
