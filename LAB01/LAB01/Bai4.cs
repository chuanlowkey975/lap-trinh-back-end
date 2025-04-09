using System;

class Bai4
{
    public static void Chay()
    {
        Console.Write("Nhập một số nguyên: ");
        int so = int.Parse(Console.ReadLine());

        if (so % 2 == 0)
            Console.WriteLine($"{so} là số chẵn.");
        else
            Console.WriteLine($"{so} là số lẻ.");
    }
}
