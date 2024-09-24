using lap3;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;
void main()
{
    Sach sach = new Sach();
    sach.Nhap();
    sach.Xuat();
    //sach.SapXepMang_BubbleSort();
    //sach.TimSachTheoMa();
    sach.InsertBook();
}
main();
