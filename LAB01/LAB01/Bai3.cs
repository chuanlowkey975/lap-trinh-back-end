using System;

class Bai3
{
    public static void Chay()
    {
        Console.Write("Nhập độ C: ");
        double doC = double.Parse(Console.ReadLine());

        double doF = (doC * 9 / 5) + 32;
        Console.WriteLine($"{doC}°C = {doF}°F");
    }
}
