using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250411_5
{
    internal static class Program
    {

        static void Main()
        {
            string[] original2 = { "第1要素", "第2要素", "第3要素" };//配列の初期化
            
            string[] copy2 = new string[original2.Length];//コピー先の配列を作成

            Array.Copy(original2, copy2, original2.Length);//配列のコピー

            original2[2] = "末尾要素";

            for (int i = 0; i < original2.Length; i++)
            {
                Console.WriteLine(original2[i]);
            }

            for(int i = 0; i < copy2.Length; i++)
            {
                Console.WriteLine(copy2[i]);
            }
        }
    }
}
