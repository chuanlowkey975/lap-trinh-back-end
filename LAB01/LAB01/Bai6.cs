using System;

class Bai6
{
    public static void Chay()
    {
        Console.Write("Nhập một số: ");
        double so = double.Parse(Console.ReadLine());

        if (so > 0)
            Console.WriteLine("Số dương.");
        else if (so < 0)
            Console.WriteLine("Số âm.");
        else
            Console.WriteLine("Số không.");
    }
}
