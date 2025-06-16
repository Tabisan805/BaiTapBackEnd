using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class TaiLieu
    {
        public string MaTaiLieu { get; set; }
        public string NhaXuatBan { get; set; }
        public int SoBanPhatHanh { get; set; }
        public virtual void Nhap()
        {
            Console.Write("Mã tài liệu: ");
            MaTaiLieu = Console.ReadLine();
            Console.Write("Nhà xuất bản: ");
            NhaXuatBan = Console.ReadLine();
            Console.Write("Số bản phát hành: ");
            SoBanPhatHanh = int.Parse(Console.ReadLine());
        }
        public virtual void HienThi()
        {
            Console.WriteLine($"Mã tài liệu: {MaTaiLieu}, Nhà xuất bản: {NhaXuatBan}, Số bản phát hành: {SoBanPhatHanh}");
        }
    }
}
