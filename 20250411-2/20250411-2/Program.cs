using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250411_2
{
    class Program
    {
        static void Main()
        {
            string s1 = "";
            for (int i = 0; i < 50000; i++)
            {
                s1 = s1 + "ABCDEFG";
            } 
            Console.WriteLine("処理が終了しました");
        }
    }
}
