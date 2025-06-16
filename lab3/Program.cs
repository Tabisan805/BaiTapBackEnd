namespace lab3;
using System;
 class Program()
{
    static void main(string[] args)
    {
        TuyenSinh ts = new TuyenSinh();
        while (true)
        {
            Console.WriteLine("1. Thêm thí sinh");
            Console.WriteLine("2. Hiển thị tất cả thí sinh");
            Console.WriteLine("3. Tìm kiếm theo số báo danh");
            Console.WriteLine("4. Hiển thị theo khối");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn chức năng: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ts.ThemThiSinh();
                    break;
                case "2":
                    ts.HienThiTatCa();
                    break;
                case "3":
                    Console.Write("Nhập số báo danh cần tìm: ");
                    int soBaoDanh = int.Parse(Console.ReadLine());
                    ts.TimKiemTheoSoBaoDanh(soBaoDanh);
                    break;
                case "4":
                    Console.Write("Nhập khối cần hiển thị (A, B, C): ");
                    string khoi = Console.ReadLine();
                    ts.HienThiTheoKhoi(khoi);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}