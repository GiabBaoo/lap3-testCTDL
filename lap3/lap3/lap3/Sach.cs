namespace lap3
{
    internal class Sach
    {
        int maSach;
        string tenSach;
        string tacGia;
        int namXB;
        Sach[] a;
        public Sach()
        {
            a = null;
        }

        public int MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public int NamXB { get => namXB; set => namXB = value; }
        public void Nhap()
        {
            Console.Write("nhap so quyen sach : ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n < 0)
            {
                Console.Write("nhap lai so quyen sach : ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            a = new Sach[n];
            for (int i = 0; i < n; i++)
            {
                Sach newsach = new Sach();


                int intbook;
                Console.Write("Nhap ma sach : ");
                intbook = Convert.ToInt32(Console.ReadLine());
                while (TonTai(intbook, i))
                {
                    Console.Write("ma sach da ton tai nhap lai  : ");
                    intbook = Convert.ToInt32(Console.ReadLine());
                }
                newsach.MaSach = intbook;

                Console.Write("Nhap ten sach : ");
                newsach.TenSach = Console.ReadLine();

                Console.Write("Nhap ten tac gia : ");
                newsach.TacGia = Console.ReadLine();

                Console.Write("Nhap nam xuat ban : ");
                newsach.NamXB = Convert.ToInt32(Console.ReadLine());




                a[i] = newsach;
            }

        }
        public void Xuat()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("ma sach = " + a[i].MaSach);
                Console.WriteLine("ten sach = " + a[i].TenSach);
                Console.WriteLine("tac gia  = " + a[i].TacGia);
                Console.WriteLine("Nam xuat ban = " + a[i].NamXB);

            }
        }
        public void Xuat2()
{
    Console.WriteLine("Mã sách = " + this.MaSach);
    Console.WriteLine("Tên sách = " + this.TenSach);
    Console.WriteLine("Tác giả = " + this.TacGia);
    Console.WriteLine("Năm xuất bản = " + this.NamXB);
    Console.WriteLine();
}

public void SapXepMang_BubbleSort()
{
    int n = a.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (a[j].maSach > a[j + 1].maSach)
            {
                // Hoán đổi arr[j] và arr[j+1]
                int temp = a[j].maSach;
                a[j].maSach = a[j + 1].maSach;
                a[j + 1].maSach = temp;
            }
        }
    }
}
public void TimSachTheoMa()
{
    Console.Write("Nhập mã sách cần tìm: ");
    int maSachCanTim = int.Parse(Console.ReadLine());

    SapXepMang_BubbleSort();
    // Sử dụng tìm kiếm nhị phân (giả sử mảng đã được sắp xếp)
    int left = 0;
    int right = a.Length - 1;
    while (left <= right)
    {
        int mid = (left + right) / 2;
        if (a[mid].MaSach == maSachCanTim)
        {
            a[mid].Xuat2();
            return;
        }
        else if (a[mid].MaSach < maSachCanTim)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }
    Console.WriteLine("Không tìm thấy sách có mã sách {0}", maSachCanTim);
}
public void InsertBook()
{
    Sach[] b = new Sach[a.Length + 1];
    for (int i = 0; i < a.Length; i++)
    {
        b[i] = new Sach();  // Initialize the Sach object before copying
        b[i].TacGia = this.a[i].TacGia;
        b[i].MaSach = this.a[i].MaSach;
        b[i].TenSach = this.a[i].TenSach;
        b[i].NamXB = this.a[i].NamXB;
    }

    b[a.Length] = new Sach();

    int intbook;
    Console.Write("Nhập mã sách : ");
    intbook = int.Parse(Console.ReadLine());
    while (TonTai(intbook, b.Length - 1))
    {
        Console.Write("Mã sách đã tồn tại, vui lòng nhập lại  : ");
        intbook = int.Parse(Console.ReadLine());
    }
    b[a.Length].MaSach = intbook;

    Console.Write("Nhập tên sách : ");
    b[a.Length].TenSach = Console.ReadLine();

    Console.Write("Nhập tên tác giả : ");
    b[a.Length].TacGia = Console.ReadLine();

    Console.Write("Nhập năm xuất bản : ");
    b[a.Length].NamXB = int.Parse(Console.ReadLine());
    Console.WriteLine();
    for (int i = 0; i < b.Length; i++)
    {
        b[i].Xuat2();
    }
}
        private bool TonTai(int msx, int vt)
        {
            for (int i = 0; i < vt; i++)
            {
                if (a[i].MaSach == msx)
                    return true;
            }
            return false;
        }

    }

}
