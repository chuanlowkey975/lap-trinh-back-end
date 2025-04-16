using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01._2
{
    internal class Bai6
    {
        public static void Chay()
        {
            Console.WriteLine("Nhập số phần tử của mảng:");
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = double.Parse(Console.ReadLine());
            }

            SapXepTangDan(arr);
            Console.WriteLine("Mảng sau khi sắp xếp:");
            foreach (double d in arr)
            {
                Console.Write(d + " ");
            }
        }

        static void SapXepTangDan(double[] arr)
        {
            Array.Sort(arr);
        }
    }
}
