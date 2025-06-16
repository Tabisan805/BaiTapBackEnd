// See https://aka.ms/new-console-template for more information
using bai1;

class program()
{
    public List<CanBo> danhsach = new List<CanBo>();
    public void ThemCanBo(CanBo canbo)
    {
        Console.Write("Nhập loại cán bộ (1: Công nhân, 2: Kỹ sư, 3: Nhân viên): ");
        Console.Write("Chọn loại cán bộ: ");
        string loai = Console.ReadLine();
        CanBo cb = null;
        switch (loai)
        {
            case "1":
                cb = new CongNhan("", "", "", "", "");break;
                break;
            case "2":
                cb = new KySu("", "", "", "", "");
                break;
            case "3":
                cb = new NhanVien("", "", "", "", "");
                break;
            default:
                Console.WriteLine("Loại không hợp lệ.");
                break;
        }
        canbo.Nhap();
        danhsach.Add(canbo);
    }
    public void TimKiemCanBo(string hoTen)
    {
        foreach (var canbo in danhsach)
        {
            if (canbo.HoTen.Equals(hoTen, StringComparison.OrdinalIgnoreCase))
            {
                canbo.HienThi();
                Console.WriteLine("---------------------------------");
                return;
            }
        }
    }
    public void HienThiDanhSach()
    {
        foreach (var canbo in danhsach)
        {
            canbo.HienThi();
            Console.WriteLine("-----------------------------");
        }
    }
    static void Main(string[] args)
    {
        program p = new program();
        while (true)
        {
            Console.WriteLine("1. Thêm cán bộ");
            Console.WriteLine("2. Tìm kiếm theo tên");
            Console.WriteLine("3. Hiển thị danh sách cán bộ");
            Console.WriteLine("4. Thoát");
            Console.Write("Chọn: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    p.ThemCanBo(new CanBo("", "", "", ""));
                    break;
                case "2":
                    Console.WriteLine("Nhập tên cần tìm: ");
                    string hoTen = Console.ReadLine();
                    p.TimKiemCanBo(hoTen);
                    break;
                case "3":
                    p.HienThiDanhSach();
                    return;
                case "4":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }

        }
    }
}