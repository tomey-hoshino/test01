using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250414_1
{
    class Program
    {
        static void Main()
        {
            string[] src = { "Tokyo", "Osaka", "Fukuoka" };

            List<string> strList = new List<string>();

            strList.AddRange(src);

            foreach(string e in strList)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine(strList.Count);

            Console.WriteLine(strList.GetType());

            Console.WriteLine(strList[0].GetType());
        }
    }
}
