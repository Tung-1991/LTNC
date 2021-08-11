using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int a, b;
                char c;
                do
                {
                    Console.Write("Nhap a: ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Nhap b: ");
                    b = Convert.ToInt16(Console.ReadLine());
                } while ((a <= 0) || (b <= 0));
                Console.Write("chon: ");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine("\n" + chon(a, b, c)); Console.ReadLine();
            }
        }
        static string chon(int a, int b, char c)
        {
            switch (c)
            {
                case '1': return "chu vi = " + ((a + b) * 2);
                case '2': return "dien tich = " + (a * b);
                default: return "Nhap phep toan khac";

            }
        }
    }
}
