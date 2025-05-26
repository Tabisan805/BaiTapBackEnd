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
    public static void SortTangDan(int[] a) 
    { 
        Array.Sort(a);
    }
    public static void HienThiMang(int[] a)
    {
        Console.WriteLine("Mang sau khi sap xep:");
        foreach (int i in a) Console.WriteLine(i+" ");
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap n :");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        NhapMang(a, n);
        SortTangDan(a);
        HienThiMang(a);

    }
}