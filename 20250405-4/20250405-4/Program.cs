using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250405_4
{
    internal static class Program
    {
        static void Main()
        {
            GenericTest<string> gen1 = new GenericTest<string>(); // 修正: 明示的に型を指定  
            gen1.AddItem("1番目の要素です");

            gen1.AddItem("2番目の要素です");

            gen1[2] = "3番目の要素です";

            Console.WriteLine(gen1[0]);
            Console.WriteLine(gen1[1]);
            Console.WriteLine(gen1[2]);

            GenericTest<DateTime>gen2= new GenericTest<DateTime>(); // 修正: 明示的に型を指定

            gen2.AddItem(DateTime.Today);

            Console.WriteLine(gen2[0]);
        }

        class GenericTest<T>
        {
            private T[] arr = new T[100];
            private int index;

            public void AddItem(T item)
            {
                arr[index++] = item;
            }

            public T this[int index]
            {
                get=>arr[index];
                set => arr[index] = value;  
            }
        }
    }
}
