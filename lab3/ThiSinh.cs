using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class ThiSinh
    {
        public int SoBaoDanh { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string NgaySinh { get; set; }
        public int UuTien { get; set; }
        public virtual void Nhap()
        {
            Console.Write("Số báo danh: ");
            SoBaoDanh = int.Parse(Console.ReadLine());
            Console.Write("Họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Địa chỉ: ");
            DiaChi = Console.ReadLine();
            Console.Write("Ngày sinh (dd/MM/yyyy): ");
            NgaySinh = Console.ReadLine();
            Console.Write("Ưu tiên: ");
            UuTien = int.Parse(Console.ReadLine());
        }
        public virtual void HienThi()
        {
            Console.WriteLine($"Số báo danh: {SoBaoDanh}, Họ tên: {HoTen}, Địa chỉ: {DiaChi}, Ngày sinh: {NgaySinh}, Ưu tiên: {UuTien}");
        }
    }
}
