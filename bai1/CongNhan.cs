using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class CongNhan : CanBo
    {
        public string Bac { get; set; }

        public CongNhan(string hoTen, string namSinh, string gioiTinh, string diaChi, string bac)
            : base(hoTen, namSinh, gioiTinh, diaChi)
        {
            Bac = bac;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Bậc (1-7): ");
            Bac = Console.ReadLine();
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Bậc: {Bac}/7");
        }
    }
}
