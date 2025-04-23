using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _20250414_0
{
    class Program
    {
        static void Main()
        {
            ;List<int> obj= new List<int>(10) { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            obj[1] = 111;
            obj[2] = 555;
            //obj.testArray[3] = 666;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Element {0} = {1}", i, obj[i]);
            }
        }
    }

    class Test
    {
        public int[] testArray = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        public int this[int index]
        {
            get { return testArray[index]; }
            set { testArray[index] = value; }
        }
    }
}