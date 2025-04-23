using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250411_6
{
    internal static class Program
    {
        static void Main()
        {
            char[] char1 = { 'a', 'b', 'c' }; // 配列1
            char[] char2 = { 'd', 'e', 'f' };// 配列2

            char[] joinArr = new char[char1.Length + char2.Length];//配列結合用

            Array.Copy(char1,joinArr,char1.Length);//配列1を結合用配列にコピー
            Array.Copy(char2,0,joinArr,char1.Length, char2.Length);//配列2を結合用配列にコピー

            for (int i = 0; i < joinArr.Length; i++)
            {
                Console.WriteLine(joinArr[i]);
            }

            int[,] dim2Array = new int[2, 3];

            dim2Array[0, 0] = 10;
            dim2Array[0, 1] = 20;
            dim2Array[0, 2] = 30;

            dim2Array[1, 0] = 40;
            dim2Array[1, 1] = 50;
            dim2Array[1, 2] = 60;

            for (int i = 0; i < dim2Array.GetLength(0); i++)
            {
                for (int j = 0; j < dim2Array.GetLength(1); j++)
                {
                    System.Console.WriteLine("[{0},{1}]の要素の値は{2}", i, j, dim2Array[i, j]);
                }
            }

        }
    }
}
