using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class QuanLy
    {
        List<TaiLieu> taiLieus = new List<TaiLieu>();
        public void ThemTaiLieu(TaiLieu taiLieu)
        {
            Console.WriteLine("1. Sách\n2. Tạp chí\n3. Báo");
            Console.Write("Chọn loại tài liệu: ");
            string loai = Console.ReadLine();
            TaiLieu tl = null;
            switch (loai)
            {
                case "1":
                    tl = new Sach();
                    break;
                case "2":
                    tl = new TapChi();
                    break;
                case "3":
                    tl = new Bao();
                    break;
                default:
                    Console.WriteLine("Loại tài liệu không hợp lệ.");
                    return;
            }
            tl.Nhap();
            taiLieus.Add(tl);
        }
        public void TimKiemTaiLieu(string maTaiLieu)
        {
            foreach (var taiLieu in taiLieus)
            {
                if (taiLieu.MaTaiLieu.Equals(maTaiLieu, StringComparison.OrdinalIgnoreCase))
                {
                    taiLieu.HienThi();
                    Console.WriteLine("---------------------------------");
                    return;
                }
            }
            Console.WriteLine("Tài liệu không tìm thấy.");
        }
        public void HienThiDanhSach()
        {
            foreach (var taiLieu in taiLieus)
            {
                taiLieu.HienThi();
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
