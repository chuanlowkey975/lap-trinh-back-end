using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01._2
{
    internal class Bai4
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

            int soLonThuHai = TimSoLonThuHai(arr);
            Console.WriteLine($"Số lớn thứ hai trong mảng là: {soLonThuHai}");
        }

        static int TimSoLonThuHai(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;

            foreach (int num in arr)
            {
                if (num > max1)
                {
                    max2 = max1;
                    max1 = num;
                }
                else if (num > max2 && num != max1)
                {
                    max2 = num;
                }
            }

            return max2;
        }
    }
}
