using System;

class Program
{
    // Hàm hoán vị 2 số nguyên
    static void HoanVi(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        // Nhập từ bàn phím
        Console.Write("Nhập số nguyên a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhập số nguyên b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nTrước khi hoán vị: a = {a}, b = {b}");

        // Gọi hàm hoán vị
        HoanVi(ref a, ref b);

        Console.WriteLine($"Sau khi hoán vị:   a = {a}, b = {b}");

        Console.ReadLine();
    }
}