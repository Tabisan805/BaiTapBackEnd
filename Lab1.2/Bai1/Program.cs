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
    public static int TinhTong(int[] a, int n)
    {
        int tong = 0;
        for (int i = 0; i < n; i++) 
        { 
            if (a[i] % 2 == 0) { tong+= a[i]; }
        }
        return tong;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap n :");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        NhapMang(a, n);
        Console.WriteLine($"Tong = {TinhTong(a,n)}");
    }
}