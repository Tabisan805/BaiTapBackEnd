using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class NhanVien : CanBo
    {
        public string CongViec { get; set; }

        public NhanVien(string hoTen, string namSinh, string gioiTinh, string diaChi, string congViec)
            : base(hoTen, namSinh, gioiTinh, diaChi)
        {
            CongViec = congViec;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Công việc: ");
            CongViec = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Công việc: {CongViec}");
        }
    }
}
