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
            double TS1=0,MS1=0,TS2=0,MS2=0;
            PS.nhapPS(ref TS1,ref MS1);
            PS.nhapPS(ref TS2, ref MS2);
            PS.rutgonPS(ref TS1, ref MS1);
            PS.rutgonPS(ref TS2, ref MS2);
            PS.Tinh(ref TS1, ref MS1, ref TS2, ref MS2);
            Console.ReadKey();
        } 
    }
}
