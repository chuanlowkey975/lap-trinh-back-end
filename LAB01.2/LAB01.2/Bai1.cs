using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01._2
{
    internal class Bai1
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

            int tong = TinhTongChan(arr);
            Console.WriteLine($"Tổng các số chẵn trong mảng là: {tong}");
        }

        static int TinhTongChan(int[] arr)
        {
            int tong = 0;
            foreach (int x in arr)
            {
                if (x % 2 == 0)
                    tong += x;
            }
            return tong;
        }
    }
}
