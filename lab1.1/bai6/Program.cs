// See https://aka.ms/new-console-template for more information
int x;
Console.WriteLine("Nhap so ");
x = int.Parse(Console.ReadLine());
if (x == 0)
    Console.WriteLine("so ban nhap vao la so 0");
else if (x > 0)
    Console.WriteLine("so ban nhap vao la so duong");
else
    Console.WriteLine("so ban nhap vao la so am");
