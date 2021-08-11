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
            int a, b;   //Toán hạng
            char ch;    //Phép toán
            Console.Write("Nhap A: ");
            a = Convert.ToInt16(Console.ReadLine());

            Console.Write("Nhap B: ");
            b = Convert.ToInt16(Console.ReadLine());

            Console.Write("Nhap phep toan: ");
            ch = Console.ReadKey().KeyChar;

            Console.WriteLine("\n" + TinhToan(a, b, ch)); Console.ReadLine();
        }
        static string TinhToan(int a, int b, char ch)
        {
            switch (ch)
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
