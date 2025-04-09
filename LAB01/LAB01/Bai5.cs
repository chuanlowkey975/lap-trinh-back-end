using System;

class Bai5
{
    public static void Chay()
    {
        Console.Write("Nhập số thứ nhất: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine($"Tổng: {a + b}");
        Console.WriteLine($"Tích: {a * b}");
    }
}
