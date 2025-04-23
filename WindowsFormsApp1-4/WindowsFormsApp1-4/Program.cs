using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_4//名前空間の指定
{
    internal static class Pro4// Programクラスの定義
    {
        static int num = 100;
        static void Test()// Testメソッドの定義
        {
            //int num = 100;
            Console.WriteLine(num);
            num = 101;
        }
        static void Main(string[] args)//Mainメゾッドの定義
        {
            //int num = 1;
            Console.WriteLine(num);
            Test();// Testメソッドの呼び出し
            Console.WriteLine(num);

        }
    }
}
