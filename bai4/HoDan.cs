using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class HoDan
    {
        public int SoNha { get; set; }
        public int SoThanhVien { get; set; }
        public List<Nguoi> ThanhVien { get; set; }
        public void Nhap()
        {
            Console.Write("Nhap so nha: ");
            SoNha = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thanh vien: ");
            SoThanhVien = int.Parse(Console.ReadLine());
            ThanhVien = new List<Nguoi>();
            for (int i = 0; i < SoThanhVien; i++)
            {
                Console.WriteLine($"Nhap thong tin thanh vien {i + 1}:");
                Nguoi nguoi = new Nguoi();
                nguoi.Nhap();
                ThanhVien.Add(nguoi);
            }
        }
        public void HienThi()
        {
            Console.WriteLine($"So nha: {SoNha}");
            Console.WriteLine($"So thanh vien: {SoThanhVien}");
            Console.WriteLine("Danh sach thanh vien:");
            foreach (var nguoi in ThanhVien)
            {
                nguoi.HienThi();
                Console.WriteLine("---------------------");
            }
        }
        public bool CoNguoiTen(string hoTen)
        {
            foreach (var nguoi in ThanhVien)
            {
                if (nguoi.HoTen.Equals(hoTen, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
