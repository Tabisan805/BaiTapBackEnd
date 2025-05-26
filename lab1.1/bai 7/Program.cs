// See https://aka.ms/new-console-template for more information
int x;
Console.WriteLine("Nhap nam ");
x = int.Parse(Console.ReadLine());
if (x % 4 == 0 & x % 100 == 0)
    Console.WriteLine($"nam {x} khong phai nam nhuan");
else if (x % 100 != 0 & x % 4 == 0)
    Console.WriteLine($"nam {x} la nam nhuan");
else Console.WriteLine($"nam {x} khong phai nam nhuan");