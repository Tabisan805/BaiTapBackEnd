using System;
namespace bai2;
class Program()
{
    static void Main(string[] args)
    {
        QuanLy quanLy = new QuanLy();
        while (true)
        {
            Console.WriteLine("1. Thêm tài liệu");
            Console.WriteLine("2. Tìm kiếm tài liệu");
            Console.WriteLine("3. Hiển thị danh sách tài liệu");
            Console.WriteLine("4. Thoát");
            Console.Write("Chọn chức năng: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    quanLy.ThemTaiLieu(new TaiLieu());
                    break;
                case "2":
                    Console.Write("Nhập mã tài liệu cần tìm: ");
                    string maTaiLieu = Console.ReadLine();
                    quanLy.TimKiemTaiLieu(maTaiLieu);
                    break;
                case "3":
                    quanLy.HienThiDanhSach();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}