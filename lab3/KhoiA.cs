using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class KhoiA : ThiSinh
    {
        public int diemToan { get; set; }
        public int diemLy { get; set; }
        public int diemHoa { get; set; }
        public virtual void Nhap()
        {
            base.Nhap();
            Console.Write("Điểm Toán: ");
            diemToan = int.Parse(Console.ReadLine());
            Console.Write("Điểm Lý: ");
            diemLy = int.Parse(Console.ReadLine());
            Console.Write("Điểm Hóa: ");
            diemHoa = int.Parse(Console.ReadLine());
        }
        public virtual void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Điểm Toán: {diemToan}, Điểm Lý: {diemLy}, Điểm Hóa: {diemHoa}");
        }
        public double TongDiem()
        {
            return diemToan + diemLy + diemHoa +UuTien;
        }

    }
}
