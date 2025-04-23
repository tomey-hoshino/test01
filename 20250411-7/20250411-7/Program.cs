using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250411_7
{
    internal static class Program
    {
        static void Main()
        {
            int[,] numberTable=new int[3, 4] {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };

            for (int i = 0; i < numberTable.GetLength(0); i++)
            {
                for (int j = 0; j < numberTable.GetLength(1); j++)
                {
                    Console.Write("[{0},{1}]の要素の値は{2}\n", i, j, numberTable[i,j]);
                }
            }

            int[] numbers = {-3,-2,-1, 0, 1, 2, 3 };//一次元配列
            foreach (int i in numbers)
            {
                System.Console.WriteLine("{0}", i);
            }

            int[,] numbers2D= new int[3, 2] {
                {1, 2},
                {5, 6},
                {9, 10}
            };//二次元配列

            foreach (int i in numbers2D)
            {
                System.Console.WriteLine("{0}", i);
            }
        }
    }
}
