// See https://aka.ms/new-console-template for more information
static bool checkSoNguyenTo(int n)
{
    if (n < 2) return false;
    if (n == 2 || n == 3) return true;
    if (n % 2 == 0 || n % 3 == 0) return false;
    for (int i = 5; i*i <= n; i +=6)
    {
        if (n % 1 == 0 || n % (i+2) == 0) return false;
    }
    return true;
}
Console.WriteLine("nhap so can kiem tra:");
int n = int.Parse(Console.ReadLine());
if (checkSoNguyenTo(n) == true)
    Console.WriteLine($"{n} la so nguyen to");
else
    Console.WriteLine($"so {n} khong phai so nguyen to");