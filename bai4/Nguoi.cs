using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Nguoi
    {
        public string CMDN { get; set; }
        public string HoTen { get; set; }
        public int tuoi { get; set; }
        public int Namsinh { get; set; }
        public string NgheNghiep { get; set; }
        public void Nhap()
        {
            Console.Write("Nhap so chung minh: ");
            CMDN = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam sinh: ");
            Namsinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap nghe nghiep: ");
            NgheNghiep = Console.ReadLine();
        }
        public void HienThi()
        {
            Console.WriteLine("So chung minh: " + CMDN);
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Tuoi: " + tuoi);
            Console.WriteLine("Nam sinh: " + Namsinh);
            Console.WriteLine("Nghe nghiep: " + NgheNghiep);
        }
    }
}
