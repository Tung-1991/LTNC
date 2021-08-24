using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Tcomplex
    {
        float T, A;
        public Tcomplex()
        {

        }
        public Tcomplex(float T, float A)
        {
            this.T = T;
            this.A = A;
        }
        public float Nhapthuc(int a)
        {
            Console.WriteLine("Nhap du lieu cho so phuc thu {0}", a);
            Console.Write("nhap phan thuc: ");
            T = Convert.ToInt32(Console.ReadLine());
            return T;
        }
        public float Nhapao()
        {
            Console.Write("nhap phan ao: ");
            A = Convert.ToInt32(Console.ReadLine());
            return A;
        }
        public void Show(string a)
        {
            Console.WriteLine(a + ":" + T + "+" + A + "i");
        }
    }
}
