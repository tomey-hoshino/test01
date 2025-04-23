using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250411_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("モンスターが現れた");
            Console.Write("お名前をどうぞ>>");

            string brave = Console.ReadLine();

            string brave1 = brave + "の攻撃";
            string brave2 = brave + "は呪文を唱えた";
            string monster1= "モンスターはひるんでいる";
            string monster2 = "モンスターは攻撃してきた";
            string monster3 = "モンスターは逃げた";

            Random rnd = new Random();

            if(!string.IsNullOrEmpty(brave))
            {
                Console.WriteLine(brave1);

                for (int i = 0; i < 10; i++)
                {
                  System.Threading.Thread.Sleep(1000);//1秒待つ
                  int num = rnd.Next(1, 10);

                    if (num <= 2)
                    {
                        Console.WriteLine(brave1);
                    }
                    else if (num >= 3 && num <=5)
                    {
                        Console.WriteLine(brave2);
                    }
                    else if ((num >=6 && num<=8))
                    {
                        Console.WriteLine(monster1);
                    }
                    else
                    {
                        Console.WriteLine(monster2);
                        break;
                    }
                }
                Console.WriteLine(monster3);
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("ゲーム終了");
            }
        }
    }
}
