using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250411_1
{
    class Program
    {
        static void Main()
        {
            byte x, y, z;
            x = 10; y = 20;
            z=Convert.ToByte(x + y);
            Console.WriteLine("x + y = " + z); 

            int num= 2147483647;
            num = num + 1;
            Console.WriteLine("num = " + num); // Overflow occurs here

            int num2 = -2147483648;
            num2= num2 - 1;
            Console.WriteLine("num2 = " + num2); // Underflow occurs here

            string str1 = "ABC";
            string str2 = str1;
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            str1 = "DEF";
            Console.WriteLine("str変更後のstr1の値" + str1);
            Console.WriteLine("str変更後のstr2の値" + str2);
        }
    }
}
