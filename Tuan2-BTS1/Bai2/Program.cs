using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pho[] a = new Pho[10];
            for(int i =1; i<=10;i++)
            {
                a[i] = a[i].tinh();
            }*/

            Pho bat1 = new Pho(); Pho bat2 = new Pho(); Pho bat3 = new Pho(); Pho bat4 = new Pho();
            Pho bat5 = new Pho(); Pho bat6 = new Pho(); Pho bat7 = new Pho(); Pho bat8 = new Pho();
            Pho bat9 = new Pho(); Pho bat10 = new Pho();
            bat1.Nhap(1); bat2.Nhap(2); bat3.Nhap(3); bat4.Nhap(4); bat5.Nhap(5);
            bat6.Nhap(6); bat7.Nhap(7); bat8.Nhap(8); bat9.Nhap(9); bat10.Nhap(10);
            Console.WriteLine("thong tin 10 bat pho vua nhap la: ");
            Console.WriteLine("STT   Thit   banhpho   hanh thanhtien");
            bat1.tinh(); bat2.tinh(); bat3.tinh(); bat4.tinh(); bat5.tinh();
            bat6.tinh(); bat7.tinh(); bat8.tinh(); bat9.tinh(); bat10.tinh();
            bat1.Show(1); bat2.Show(2); bat3.Show(3); bat4.Show(4); bat5.Show(5);
            bat6.Show(6); bat7.Show(7); bat8.Show(8); bat9.Show(9); bat10.Show(10);
            float[] mang = new float[10] { bat1.tinh(), bat2.tinh(), bat3.tinh(), bat4.tinh(),
            bat5.tinh(),bat6.tinh(), bat7.tinh(), bat8.tinh(), bat9.tinh(), bat10.tinh()};
            float min = mang.Min();
            Console.WriteLine("bat pho co gia tri thap nhat: " + min);
            float max = mang.Max();
            Console.WriteLine("bat pho co gia tri cao nhat: " + max);

            Console.ReadKey();
        }
    }
}
