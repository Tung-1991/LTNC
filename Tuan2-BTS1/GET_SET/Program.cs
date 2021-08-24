using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GET_SET
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee2 john = new Employee2("E01", "John");
            Console.WriteLine("Employee Code = " + john.Code);
            Console.WriteLine("Employee Name = " + john.Name);
            Console.WriteLine("-------");
            john.Code = "E02";
            Console.WriteLine("Employee Code = " + john.Code);
            Console.WriteLine("Employee Name = " + john.Name);
            Console.ReadKey();
        }
    }
}
