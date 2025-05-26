using System;
class Progarm()
{
    public static void NhapMang(int[] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"a[{i}]:");
            a[i] = int.Parse(Console.ReadLine());
        }
    }
    static void DemSoAmDuong(int[] a, int n) 
    {
        int soam = 0;
        int soduong = 0;
        foreach (int x in a)
        {
            if (x < 0) { soam++; }
            else if (x > 0) { soduong++; }
        }
        Console.WriteLine($"so am = {soam}");
        Console.WriteLine($"so duong = {soduong}");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap n :");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        NhapMang(a, n);
        DemSoAmDuong(a, n);
    }

}