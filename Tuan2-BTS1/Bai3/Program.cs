using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tcomplex sp1 = new Tcomplex();
            Tcomplex sp2 = new Tcomplex();
            Tcomplex sp3 = new Tcomplex();
            float T1, T2, A1, A2;
            T1 = sp1.Nhapthuc(1); A1 = sp1.Nhapao();
            T2 = sp2.Nhapthuc(2); A2 = sp2.Nhapao();
            sp1.Show("sp1"); sp2.Show("sp2");
            Console.WriteLine("sp3 = " + (T1 - T2) + "+" + (A1 - A2) + "i");
            Console.WriteLine("sp4 = " + (T1 + T2) + "+" + (A1 + A2) + "i");
            Console.WriteLine("sp5 = " + ((T1 - T2) * (T1 + T2)) + "+" + ((A1 - A2) * (A1 + A2)) + "i");
            Console.ReadKey();
        }
    }
}
