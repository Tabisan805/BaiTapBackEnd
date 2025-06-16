using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class KhuPho
    {
        List<HoDan> hoDans = new List<HoDan>();
        public void Nhap()
        {
            Console.Write("Nhap so ho dan: ");
            int soHoDan = int.Parse(Console.ReadLine());
            for (int i = 0; i < soHoDan; i++)
            {
                Console.WriteLine($"Nhap thong tin ho dan {i + 1}:");
                HoDan hoDan = new HoDan();
                hoDan.Nhap();
                hoDans.Add(hoDan);
            }
        }
        public void HienThi()
        {
            Console.WriteLine("Danh sach ho dan trong khu pho:");
            foreach (var hoDan in hoDans)
            {
                hoDan.HienThi();
                Console.WriteLine("---------------------");
            }
        }
        public void TimKiemHoDan()
        {
            Console.WriteLine("Tim Kiem:\n1.Ho Ten\n2.So Nha");
            string chon = Console.ReadLine();
            if ( chon == "1")
            {
                Console.Write("Nhap ho ten can tim: ");
                string Ten = Console.ReadLine();
                bool found = false;
                foreach (var hoDan in hoDans)
                {
                    if (hoDan.CoNguoiTen(Ten))
                    {
                        Console.WriteLine($"Tim thay ho dan co thanh vien ten {Ten}:");
                        hoDan.HienThi();
                        found = true;
                    }
                }
            }
            else if (chon == "2")
            {
                Console.Write("Nhap so nha can tim: ");
                int soNha = int.Parse(Console.ReadLine());
                var foundHoDan = hoDans.FirstOrDefault(hd => hd.SoNha == soNha);
                if (foundHoDan != null)
                {
                    Console.WriteLine($"Tim thay ho dan so nha {foundHoDan.SoNha}");
                    foundHoDan.HienThi();
                }
                else
                {
                    Console.WriteLine("Khong tim thay ho dan voi so nha nay.");
                }
            }
            else
            {
                Console.WriteLine("Lua chon khong hop le.");
            }
        }
    }
}
