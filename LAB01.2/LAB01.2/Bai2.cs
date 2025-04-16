using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01._2
{
    internal class Bai2
    {
        public static void Chay()
        {
            Console.WriteLine("Nhập số phần tử của mảng:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Các số nguyên tố trong mảng:");
            LietKeSoNguyenTo(arr);
        }

        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        static void LietKeSoNguyenTo(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (LaSoNguyenTo(arr[i]))
                {
                    Console.WriteLine($"arr[{i}] = {arr[i]} là số nguyên tố");
                }
            }
        }
    }
}
