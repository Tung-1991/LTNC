using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** TRO CHOI TINH NHANH**");
            Console.WriteLine("** +: phep cong **");
            Console.WriteLine("** -: phep tru  **");
            Console.WriteLine("** x: phep nhan **");
            Console.WriteLine("** /: phep chia **");
            int a, b;
            char c, kt;
            Console.Write("nhap a: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("nhap b: ");
            b = Convert.ToInt16(Console.ReadLine());
            do
            {
                Console.Write("\n chon: ");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine("\n" + chon(a, b, c));

                Console.Write("\n nhap n de dung: ");
                kt = Console.ReadKey().KeyChar;

            } while (kt != 'n');

        }

        static string chon(int a, int b, char c)
        {
            switch (c)
            {
                case '+': return "a + b = " + (a + b);
                case '-': return "a - b = " + (a - b);
                case '*': return "a * b = " + (a * b);
                case '/':
                    if (b != 0) return "a / b = " + (a / b); else return "Nhap b khac khong";
                default: return "Nhap phep toan khac";
            }
        }
    }
}
