using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250415_1
{
    internal static class Program
    {
        /// <summary>
        /// Generates a sequence of dates starting from today.
        /// </summary>
        /// <param name="days">The number of days to generate.</param>
        /// <returns>An IEnumerable of DateTime objects.</returns>
        static IEnumerable<DateTime> Test(int days)
        {
            DateTime dt = DateTime.Today;
            for (int i = 0; i < days; i++)
            {
                if((dt.DayOfWeek!=DayOfWeek.Saturday)&&(dt.DayOfWeek!=DayOfWeek.Sunday))
                {
                    yield return dt;
                    i++;
                }
                dt = dt.AddDays(1);
            }
        }

        static void Main()
        {
            foreach (DateTime dt in Test(10))
            {
                Console.WriteLine(dt.ToString("yyyy年MM月dd日(ddd)"));
            }
        }
    }
}
