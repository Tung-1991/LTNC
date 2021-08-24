using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Pho
    {
        double thit, banh, hanh, tong;

        /*public Pho()
        {
            Console.WriteLine("????");
        }
        public Pho(float thit, float banh, float hanh, float tong)
        {
            this.thit = thit;
            this.banh = banh;
            this.hanh = hanh;
            this.tong = tong;
        }*/
        public void Nhap(double stt)
        {
            Console.WriteLine("Nhap du lieu cho bat pho thu {0}",stt);
            Console.Write("nhap thit: ");
            double x;
            if (Double.TryParse(Console.ReadLine(),out x))
            {
                thit = x;
            }
            else
            Console.Write("nhap thit khong phai la so ");

            Console.Write("nhap banh pho: ");
            if (Double.TryParse(Console.ReadLine(), out x))
            {
                banh = x;
            }
            else
                Console.Write("nhap hanh khong phai la so ");

            Console.Write("nhap hanh: ");
            if (Double.TryParse(Console.ReadLine(), out x))
            {
                hanh = x;
            }
            else
                Console.Write("nhap banh khong phai la so ");

        }
        public double tinh()
        {
            tong = thit * 15000 + banh * 10000 + hanh * 2000;
            return tong;
        }
        public void Show(float stt)
        {
            Console.WriteLine(stt+"\t"+thit+"\t"+banh+"\t"+hanh+"\t"+tong);
        }
    }
}
