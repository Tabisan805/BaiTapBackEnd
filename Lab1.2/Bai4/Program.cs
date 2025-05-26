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
    static int TimSoLonThuHai(int[] a)
    {
        if (a.Length < 2)
            throw new ArgumentException("Mảng phải có ít nhất 2 phần tử.");

        int max1 = int.MinValue;
        int max2 = int.MinValue;

        foreach (int x in a)
        {
            if (x > max1)
            {
                max2 = max1;
                max1 = x;
            }
            else if (x > max2 && x != max1)
            {
                max2 = x;
            }
        }

        if (max2 == int.MinValue)
            throw new InvalidOperationException("Không tìm thấy số lớn thứ hai (có thể do tất cả phần tử đều giống nhau).");

        return max2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap n :");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        NhapMang(a, n);
        int ketqua = TimSoLonThuHai(a);
        Console.WriteLine($"so lon thu 2 la {ketqua}");
    }
}