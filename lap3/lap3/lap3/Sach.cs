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
        public void binarySearch()
        {
            Console.Write("nhap ma sach can tim ");

            for (int i = 0; i < a.Length; i++)
            {

            }
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
            Console.Write("Nhap ma sach : ");
            intbook = Convert.ToInt32(Console.ReadLine());
            while (TonTai(intbook, b.Length - 1))
            {
                Console.Write("ma sach da ton tai nhap lai  : ");
                intbook = Convert.ToInt32(Console.ReadLine());
            }
            b[a.Length].MaSach = intbook;

            Console.Write("Nhap ten sach : ");
            b[a.Length].TenSach = Console.ReadLine();

            Console.Write("Nhap ten tac gia : ");
            b[a.Length].TacGia = Console.ReadLine();

            Console.Write("Nhap nam xuat ban : ");
            b[a.Length].NamXB = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("ma sach = " + b[i].MaSach);
                Console.WriteLine("ten sach = " + b[i].TenSach);
                Console.WriteLine("tac gia  = " + b[i].TacGia);
                Console.WriteLine("Nam xuat ban = " + b[i].NamXB);

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
