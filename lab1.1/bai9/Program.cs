// See https://aka.ms/new-console-template for more information
static long giaithua(int n)
{
    long result = 1;
    for (int i = 1; i <= n; i++)
        result *= i;
    return result;
}
Console.WriteLine("nhap so nguyen duong n ");
int n = int.Parse(Console.ReadLine());
if (n < 0)
    Console.WriteLine("vui long nhap so nguyen duong");
else
    Console.WriteLine($"giai thua cua n la {giaithua(n)}");