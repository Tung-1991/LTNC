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
            int n;
            Console.Write("Nhap vao so nguyen: ");
            n = Convert.ToInt16(Console.ReadLine());
            while (n > 10000 || n < 0)
            {
                Console.WriteLine("{0} khong hop le", n);
                Console.WriteLine("Nhap vao so nguyen: ");
                n = Convert.ToInt16(Console.ReadLine());
            }
            //CP
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if ((j * j) == i)
                    {
                        Console.WriteLine("so chinh phuong: " + i);
                    }

                }
            }
            //SNT
            for (int i = 2; i <= n; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("so nguyen to: " + i);
                        break;
                    }
                }
            }
            //DX
            int r, t, s = 0;
            for (int i = 0; i <= n; i++)
            {
                for (t = i; i != 0; i = i / 10)
                {
                    r = i % 10;
                    s = s * 10 + r;
                }
                if (t == s)
                    Console.WriteLine("So doi xung {0}: ", t);
            }
            //amstrong
            for (int i = 0; i <= n; i++)
            {
                for (t = i; i != 0; i = i / 10)
                {
                    r = i % 10;
                    s = s + (r * r * r);
                }
                if (t == s)
                    Console.Write("So Armstrong {0}: ", t);
            }
            //SHH
            for (int i = 0; i <= n; i++)
            {
                if (n % i == 0)
                {
                    s = s + i;
                }
                if (s == n)
                    Console.Write("so hoan hao {0}: ");
            }
        }
    }
}
