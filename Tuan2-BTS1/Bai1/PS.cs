using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class PS
    {
        public static void nhapPS(ref double a, ref double b)
        {
            Console.Write("nhap TS: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap MS: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PS vua nhap: " + a + "/" + b);
        }
        public static void rutgonPS(ref double a, ref double b)
        {
            if (Math.Abs(a) >= Math.Abs(b))
            {
                for (double i = 2; i <= a; i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        Console.WriteLine("rut gon: " + a / i + "/" + b / i);
                    }
                }
            }
            else
            {
                for (double i = 2; i <= a; i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        Console.WriteLine("rut gon: " + a / i + "/" + b / i);
                    }
                }
            }
        }
        public static void Tinh(ref double ts1, ref double ms1, ref double ts2, ref double ms2)
        {
            if (ms1 == ms2)
            {
                Console.WriteLine("+: " + (ts1 + ts2) + "/" + ms1);
                Console.WriteLine("-: " + (ts1 - ts2) + "/" + ms1);
                Console.WriteLine("x: " + (ts1 * ts2) + "/" + (ms1*ms2));
                Console.WriteLine("/: " + (ts1 * ms2) + "/" + (ms1*ts2));
            }
            else
            {
                Console.WriteLine("+: " + ((ts1 * ms2) + (ts2 * ms1)) + "/" + (ms1 * ms2));
                Console.WriteLine("-: " + ((ts1 * ms2) - (ts2 * ms1)) + "/" + (ms1 * ms2));
                Console.WriteLine("x: " + (ts1 * ts2) + "/" + (ms1 * ms2));
                Console.WriteLine("/: " + (ts1 * ms2) + "/" + (ms1 * ts2));
            }
        }
    }
}
