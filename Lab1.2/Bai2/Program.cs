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
    static bool TimSoNguyenTo(int n)
    {
        if (n<2)
        {
            return false;
        }
        for (int i = 2; i*i <= n; i++) 
        { 
            if (n % i == 0) { return false; }
        }
        return true;
    }

    static void HienThiSoNguyenTo(int[] n)
    {
        for (int i = 0; i < n.Length; i++) 
        {
            if (TimSoNguyenTo(n[i]))
            {
                Console.WriteLine($"Phần tử tại chỉ số {i} là số nguyên tố: {n[i]}");
            }
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap n :");
        int m = int.Parse(Console.ReadLine());
        int[] a = new int[m];
        NhapMang(a, m);
        HienThiSoNguyenTo(a);
    }
}