using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250411_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("モンスターたちがあらわれた！");
            Console.Write("お名前をどうぞ>>");

            string brave = Console.ReadLine();

            string prompt = brave + "の呪文>";
            string attack = "";

            if (!string.IsNullOrEmpty(brave))
            {
                while (attack != "ザラキン")
                {
                    Console.Write(prompt);
                    attack = Console.ReadLine();

                    Console.WriteLine(brave + "は" + attack + "を唱えた！");

                    if (attack != "ザラキン")
                    {
                        Console.WriteLine("モンスターたちは様子を伺っている");
                    }
                }
                Console.WriteLine("モンスターたちは全滅した");
            }
            else
            {
                Console.WriteLine("ゲーム終了");
            }
        }
    }

}
