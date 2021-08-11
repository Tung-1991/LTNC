using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double a, b, x = 0;
                Console.Write("Nhap a: ");
                a = Convert.ToInt16(Console.ReadLine());
                Console.Write("Nhap b: ");
                b = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("ax + b = 0");
                if (a == 0 && b == 0)
                {
                    Console.WriteLine("x = vo so nghiem");
                }
                else if (a == 0 && b != 0)
                {
                    Console.WriteLine("x = vo nghiem");
                }
                else
                {
                    x = -b / a;
                    Console.WriteLine("x = " + x);
                }
                Console.ReadKey();
            }
        }
    }
}
