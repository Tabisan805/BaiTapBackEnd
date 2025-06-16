using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class KhoiC : ThiSinh
    {
        public int diemVan { get; set; }
        public int diemSu { get; set; }
        public int diemDia { get; set; }
        public virtual void Nhap()
        {
            base.Nhap();
            Console.Write("Điểm Văn: ");
            diemVan = int.Parse(Console.ReadLine());
            Console.Write("Điểm Sử: ");
            diemSu = int.Parse(Console.ReadLine());
            Console.Write("Điểm Địa: ");
            diemDia = int.Parse(Console.ReadLine());
        }
        public virtual void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Điểm Văn: {diemVan}, Điểm Sử: {diemSu}, Điểm Địa: {diemDia}");
        }
        public double TongDiem()
        {
            return diemVan + diemSu + diemDia + UuTien;
        }
    }
}
