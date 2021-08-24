using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, m, y;
            Console.Write("nhap nam:");
            y = Convert.ToInt16(Console.ReadLine());
            if ((y % 4 == 0) || ((y % 4 == 0) & (y % 100 != 0)))
            {
                Console.WriteLine("la nam nhuan");

                Console.Write("nhap thang:");
                m = Convert.ToInt16(Console.ReadLine());
                while (m > 12 || m < 1)
                {
                    Console.WriteLine("{0}/{1} ko hop le", m, y);
                    Console.Write("nhap lai thang:");
                    m = Convert.ToInt16(Console.ReadLine());
                }
                if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                {
                    Console.Write("nhap ngay:");
                    d = Convert.ToInt16(Console.ReadLine());
                    while (d > 31 || d < 1)
                    {
                        Console.WriteLine("{0}/{1}/{2} khong hop le", d, m, y);
                        Console.Write("nhap lai ngay:");
                        d = Convert.ToInt16(Console.ReadLine());
                    }
                    Console.WriteLine("{0}/{1}/{2} ", d, m, y);
                }
                else if (m == 2)
                {
                    Console.Write("nhap ngay:");
                    d = Convert.ToInt16(Console.ReadLine());
                    while (d > 29 || d < 1)
                    {
                        Console.WriteLine("{0}/{1}/{2} khong hop le", d, m, y);
                        Console.Write("nhap lai ngay:");
                        d = Convert.ToInt16(Console.ReadLine());
                    }
                    Console.WriteLine("{0}/{1}/{2} ", d, m, y);
                }
                else
                {
                    Console.Write("nhap ngay:");
                    d = Convert.ToInt16(Console.ReadLine());
                    while (d > 30 || d < 1)
                    {
                        Console.WriteLine("{0}/{1}/{2} khong hop le", d, m, y);
                        Console.Write("nhap lai ngay:");
                        d = Convert.ToInt16(Console.ReadLine());
                    }
                    Console.WriteLine("{0}/{1}/{2} ", d, m, y);
                }
                Console.WriteLine("ngay tiep theo");
                if (d == 31)
                {
                    int m1 = m + 1;
                    if (m1 <= 12)
                    {
                        Console.WriteLine("{0}/{1}/{2} ", 1, m1, y);
                    }
                    else
                    {
                        int y1 = y + 1;
                        Console.WriteLine("{0}/{1}/{2} ", 1, 1, y1);
                    }
                }
                else if (d == 29)
                {
                    Console.WriteLine("{0}/{1}/{2} ", 1, 3, y);
                }
                else
                {
                    Console.WriteLine("{0}/{1}/{2} ", d + 1, m, y);
                }
                Console.ReadKey();
            }
            //nam ko nhuan
            else
            {
                Console.WriteLine("ko la nam nhuan");

                Console.Write("nhap thang:");
                m = Convert.ToInt16(Console.ReadLine());
                while (m > 12 || m < 1)
                {
                    Console.WriteLine("{0}/{1} ko hop le", m, y);
                    Console.Write("nhap lai thang:");
                    m = Convert.ToInt16(Console.ReadLine());
                }
                if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                {
                    Console.Write("nhap ngay:");
                    d = Convert.ToInt16(Console.ReadLine());
                    while (d > 31 || d < 1)
                    {
                        Console.WriteLine("{0}/{1}/{2} khong hop le", d, m, y);
                        Console.Write("nhap lai ngay:");
                        d = Convert.ToInt16(Console.ReadLine());
                    }
                    Console.WriteLine("{0}/{1}/{2} ", d, m, y);
                }
                else if (m == 2)
                {
                    Console.Write("nhap ngay:");
                    d = Convert.ToInt16(Console.ReadLine());
                    while (d > 28 || d < 1)
                    {
                        Console.WriteLine("{0}/{1}/{2} khong hop le", d, m, y);
                        Console.Write("nhap lai ngay:");
                        d = Convert.ToInt16(Console.ReadLine());
                    }
                    Console.WriteLine("{0}/{1}/{2} ", d, m, y);
                }
                else
                {
                    Console.Write("nhap ngay:");
                    d = Convert.ToInt16(Console.ReadLine());
                    while (d > 30 || d < 1)
                    {
                        Console.WriteLine("{0}/{1}/{2} khong hop le", d, m, y);
                        Console.Write("nhap lai ngay:");
                        d = Convert.ToInt16(Console.ReadLine());
                    }
                    Console.WriteLine("{0}/{1}/{2} ", d, m, y);
                }
                Console.WriteLine("ngay tiep theo");
                if (d == 31)
                {
                    int m1 = m + 1;
                    if (m1 <= 12)
                    {
                        Console.WriteLine("{0}/{1}/{2} ", 1, m1, y);
                    }
                    else
                    {
                        int y1 = y + 1;
                        Console.WriteLine("{0}/{1}/{2} ", 1, 1, y1);
                    }
                }
                else if (d == 28)
                {
                    Console.WriteLine("{0}/{1}/{2} ", 1, 3, y);
                }
                else
                {
                    Console.WriteLine("{0}/{1}/{2} ", d + 1, m, y);
                }

                Console.ReadKey();
            }
        }
    }
}
