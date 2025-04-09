using System;

class Bai9
{
    public static void Chay()
    {
        Console.Write("Nhập số nguyên dương: ");
        int n = int.Parse(Console.ReadLine());

        long giaiThua = 1;
        for (int i = 1; i <= n; i++)
        {
            giaiThua *= i;
        }

        Console.WriteLine($"{n}! = {giaiThua}");
    }
}
