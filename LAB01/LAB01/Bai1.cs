using System;

class Bai1
{
    public static void Chay()
    {
        Console.Write("Nhập tên của bạn: ");
        string ten = Console.ReadLine();

        Console.Write("Nhập tuổi của bạn: ");
        int tuoi = int.Parse(Console.ReadLine());

        Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
    }
}
