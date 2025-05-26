// See https://aka.ms/new-console-template for more information
int x;
Console.WriteLine("nhap so nguyen :");
x= int.Parse(Console.ReadLine());
if (x % 2 == 0)
    Console.WriteLine($"so {x} la so chan");
else 
    Console.WriteLine($"so {x} la so le");