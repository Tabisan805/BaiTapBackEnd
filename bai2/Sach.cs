using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Sach : TaiLieu
    {
        public int TacGia { get; set; }
        public int SoTrang { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Số phát hành: ");
            TacGia = int.Parse(Console.ReadLine());
            Console.Write("Tháng phát hành: ");
            SoTrang = int.Parse(Console.ReadLine());
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Số PH: {TacGia}, Tháng PH: {SoTrang}");
        }
    }
}
