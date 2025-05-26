// See https://aka.ms/new-console-template for more information

Console.Write("Nhập một số nguyên dương: ");
int so = int.Parse(Console.ReadLine());

if (so <= 1)
{
    Console.WriteLine($"{so} không phải là số nguyên tố.");
}
else
{
    bool laSoNguyenTo = true;
    for (int i = 2; i <= Math.Sqrt(so); i++)
    {
        if (so % i == 0)
        {
            laSoNguyenTo = false;
            break;
        }
    }

    if (laSoNguyenTo)
    {
        Console.WriteLine($"{so} là số nguyên tố.");
    }
    else
    {
        Console.WriteLine($"{so} không phải là số nguyên tố.");
    }
}