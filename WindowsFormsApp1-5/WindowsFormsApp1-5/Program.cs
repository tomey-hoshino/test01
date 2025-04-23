using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_5
{
    class Pro5
    {
        static void Main(string[] args)
        {
            string str1 = "Micro";
            string str2 = "soft";
            str1 += str2;
            Console.WriteLine(str1);

            int var1=10;
            int var2 = 3;
            var1 -= var2;
            Console.WriteLine(var1);

            int var3 = 10;
            int var4 = 3;
            var3 *= var4;
            Console.WriteLine(var3);

            int var5 = 25;
            int var6 = 5;
            var5 /= var6;
            Console.WriteLine(var5);

            bool b1 = true;
            b1 &= true;
            Console.WriteLine(b1);
            b1 &= false;
            Console.WriteLine(b1);

            int a = 5;
            int b = 2;
            int c = 1;
            bool check;
            check = a > b && b > c;
            check = b > a && b > c;

            int bt = 255;
            int shift = 4;
            bt >>= shift;
            Console.WriteLine(bt);

            int bt2 = 255;
            int shift2 = 4;
            bt2 <<= shift2;
            Console.WriteLine(bt2);

            var str3="C#";
            var str4 = "C++";
            var str5 = "Microsoft Visual C#";

            Console.WriteLine(str3 == str4);
            Console.WriteLine(str3 != str4);

            Console.WriteLine(str5.Contains(str3));
            Console.WriteLine(str5.Contains(str4));
        }
    }
}
