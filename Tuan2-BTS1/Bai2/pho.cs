using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Pho
    {
        float thit, banh, hanh, tong;

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
        public void Nhap(float stt)
        {
            Console.WriteLine("Nhap du lieu cho bat pho thu {0}",stt);
            Console.Write("nhap thit: ");
            thit = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap banh: ");
            banh = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap hanh: ");
            hanh = Convert.ToInt32(Console.ReadLine());
        }
        public float tinh()
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
