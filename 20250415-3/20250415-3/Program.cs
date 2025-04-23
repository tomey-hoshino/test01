using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250415_3
{
    class Fruit
    {
        public string name { get; set; }
        public int price { get; set; }
        public string code { get; set; }
    }

    internal static class Program
    {
        static void Main()
        {
            Fruit[] f = {
               new Fruit { name = "Apple", price = 200, code = "A110" },
               new Fruit { name = "Orange", price = 150, code = "G201" },
               new Fruit { name = "Grape", price = 450, code = "GR50" }
           };

            var q=from n in f select new {Name=n.name,Price=n.price, Code = n.code };

            foreach (var a in q)
            {
                Console.WriteLine("Name={0} Price={1} Code={2}", a.Name, a.Price, a.Code);
            }

            var que = f.Select((n) => new { Name = n.name, Price = n.price, Code = n.code });

            foreach (var a in que)
            {
                Console.WriteLine("Name={0} Price={1} Code={2}", a.Name, a.Price, a.Code);
            }
        }
    }
}
