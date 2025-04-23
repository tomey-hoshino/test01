using System;//名前空間Systemを使用
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_2//名前空間WindowsFormsApp1_2
{
    static class Program//Programクラス
    {
            static void Main(string[] args)//Mainメゾッド
            {
                int x;
                x = 100;//xに100を代入

                Console.WriteLine(x);

                int y;
                y = x;//yにxの値を代入

                Console.WriteLine(y);

                y = 10;//yに10を代入
                Console.WriteLine(y);
            }
        
    }
}
