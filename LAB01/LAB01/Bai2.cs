using System;

class Bai2
{
    public static void Chay()
    {
        Console.Write("Nhập chiều dài: ");
        double dai = double.Parse(Console.ReadLine());

        Console.Write("Nhập chiều rộng: ");
        double rong = double.Parse(Console.ReadLine());

        double dienTich = dai * rong;
        Console.WriteLine($"Diện tích hình chữ nhật: {dienTich}");
    }
}
