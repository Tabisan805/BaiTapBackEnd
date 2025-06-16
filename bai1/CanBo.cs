using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class CanBo
    {
        public string HoTen { get; set; }
        public string NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public CanBo(string hoTen, string namSinh, string gioiTinh, string diaChi)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
        }
        public virtual void Nhap()
        {
            Console.Write("Họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Năm sinh: ");
            NamSinh = Console.ReadLine();
            Console.Write("Giới tính: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Địa chỉ: ");
            DiaChi = Console.ReadLine();
        }   
        public virtual void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Giới tính: {GioiTinh}, Địa chỉ: {DiaChi}");
        }
    }
}
