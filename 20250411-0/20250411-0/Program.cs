using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250411_0
{
    class Pro_1
    {
        static void Main()
        {
            byte x = 5;
            byte y = 10;

           int total;

            total = x + y;

            Console.WriteLine("合計は" + total + "です。");

            int n = 10;
            double d1;
            double d2 = 0.05;

            d1 = d2 * n;

            Console.WriteLine("d1の値は" + d1 + "です。");

            int num = 100;
            object obj;

            obj=(object)num;

            Console.WriteLine("objの値は" + obj + "です。");

            int n1 = 100;
            object o = (object)n1;
            int n2 = (int)o;

            Console.WriteLine("n2の値は" + n2 + "です。");                     
        }
    }
}
