using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class TuyenSinh
    {
        private List<ThiSinh> thiSinhs;
        public void ThemThiSinh()
        {
            Console.WriteLine("1. Khối A\n2. Khối B\n3. Khối C");
            Console.Write("Chọn loại thí sinh: ");
            string loai = Console.ReadLine();
            ThiSinh newTs = null;
            switch (loai)
            {
                case "1":
                    newTs = new KhoiA();
                    break;
                case "2":
                    newTs = new KhoiB();
                    break;
                case "3":
                    newTs = new KhoiC();
                    break;
                default:
                    Console.WriteLine("Loại thí sinh không hợp lệ.");
                    return;
            }
            newTs.Nhap();
            thiSinhs.Add(newTs);
        }
        public void HienThiTatCa()
        {
            foreach (var ts in thiSinhs)
            {
                ts.HienThi();
            }
        }
        public void TimKiemTheoSoBaoDanh(int soBaoDanh)
        {
            var result = thiSinhs.FirstOrDefault(ts => ts.SoBaoDanh == soBaoDanh);
            if (result != null)
            {
                result.HienThi();
            }
            else
            {
                Console.WriteLine("Không tìm thấy thí sinh với số báo danh: " + soBaoDanh);
            }
        }
        public void HienThiTheoKhoi(string khoi)
        {
            var result = thiSinhs.Where(ts => ts.GetType().Name.Equals(khoi, StringComparison.OrdinalIgnoreCase)).ToList();
            if (result.Count > 0)
            {
                foreach (var ts in result)
                {
                    ts.HienThi();
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy thí sinh thuộc khối: " + khoi);
            }
        }
        public void HienThiThiSinhTrungTuyen(double diemChuan)
        {
            Console.WriteLine("=== Danh Sach Hoc Sinh Trung Tuyen ===");
            foreach (var ts in thiSinhs)
            {
                bool Trungtruyen = false;
                switch (ts)
                {
                    case KhoiA khoiA:
                        Trungtruyen = khoiA.TongDiem() >= 15;
                        break;
                    case KhoiB khoiB:
                        Trungtruyen = khoiB.TongDiem() >= 16;
                        break;
                    case KhoiC khoiC:
                        Trungtruyen = khoiC.TongDiem() >= 13.5;
                        break;
                }
                if (Trungtruyen)
                {
                    ts.HienThi();
                }
            }
        }
    }
}
