using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Bao : TaiLieu
    {
        public string NgayPhatHanh { get; set; }
        public void Nhap()
        {
            base.Nhap();
            Console.Write("Ngày phát hành: ");
            NgayPhatHanh = Console.ReadLine();
        }
        public void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Ngày phát hành: {NgayPhatHanh}");
        }
    }
}
