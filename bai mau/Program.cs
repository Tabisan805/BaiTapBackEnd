// See https://aka.ms/new-console-template for more information
using bai1;

class program()
{
    public static void NhapPhanSo(PhanSo phanso1, PhanSo phanso2)
    {
        Console.WriteLine("Phan So 1:");
        phanso1.Nhap();
        Console.WriteLine("Phan So 2:");
        phanso2.Nhap();
    }
    static void main(string[] args)
    {
        PhanSo ps1 = new PhanSo();
        PhanSo ps2 = new PhanSo();
        PhanSo ps3 = new PhanSo();
        int x;
        Console.WriteLine("Cac phep toan cua phan so:");
        Console.WriteLine("\t1. Nhap 1 neu muon cong");
        Console.WriteLine("\t2. Nhap 2 neu muon tru");
        Console.WriteLine("\t3. Nhap 3 neu muon nhan");
        Console.WriteLine("\t4. Nhap 4 neu muon chia");
        Console.WriteLine("\t5. Nhap 5 neu muon toi gian");
        Console.Write("- Moi Ban Nhap lua chon: ");
        x = int.Parse(Console.ReadLine());

        switch (x)
        {
            case 1:
                NhapPhanSo(ps1, ps2);
                ps3 = ps1 + ps2;
                Console.WriteLine($"Ket Qua: {ps1.TuSo}/{ps1.MauSo} + {ps2.TuSo}/{ps2.MauSo} = {ps3.TuSo}/{ps3.MauSo}");
                ps3.Xuat();
                break;
            case 2:
                NhapPhanSo(ps1, ps2);
                ps3 = ps1 - ps2;
                Console.WriteLine($"Ket Qua: {ps1.TuSo}/{ps1.MauSo} - {ps2.TuSo}/{ps2.MauSo} = {ps3.TuSo}/{ps3.MauSo}");
                ps3.Xuat();
                break;
            case 3:
                NhapPhanSo(ps1, ps2);
                ps3 = ps1 * ps2;
                Console.WriteLine($"Ket Qua: {ps1.TuSo}/{ps1.MauSo} * {ps2.TuSo}/{ps2.MauSo} = {ps3.TuSo}/{ps3.MauSo}");
                ps3.Xuat();
                break;
            case 4:
                NhapPhanSo(ps1, ps2);
                ps3 = ps1 / ps2;
                Console.WriteLine($"Ket Qua: {ps1.TuSo}/{ps1.MauSo} / {ps2.TuSo}/{ps2.MauSo} = {ps3.TuSo}/{ps3.MauSo}");
                ps3.Xuat();
                break;
            case 5:
                Console.WriteLine("Nhap Phan So can toi gian:");
                ps1.Nhap();
                ps1.Kiemtra();
                if (ps1.Kiemtra())
                {
                    Console.WriteLine("Phan so da toi gian: " + ps1.TuSo + "/" + ps1.MauSo);
                }
                else
                {
                    ps1.ToiGian();
                    Console.WriteLine("Phan so sau khi toi gian: " + ps1.TuSo + "/" + ps1.MauSo);
                }
                break;
            default:
                Console.WriteLine("Nhap Sai!! Vui long nhap lai!");
                break;

        }
    }
}