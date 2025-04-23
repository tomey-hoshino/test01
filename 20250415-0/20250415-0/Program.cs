using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace _20250415_0
{
    internal static class Program
    {
        static void Main()
        {
            foreach (string val in Show())
            {
                Console.WriteLine(val);
            }
        }

        static System.Collections.Generic.IEnumerable<string> Show()
        {
            yield return "Hello";
            yield return "World";
            yield return "!";
        }
    }
}

