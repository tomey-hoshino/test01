using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _20250414_2
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>
            {
                { "プログラム", "プログラムの説明" },
                { "コード", "コードの説明" }
            };

            string key = "プログラム";

            if (dic.ContainsKey(key))
            {
                Console.WriteLine("キーは存在します");
            }
            else
            {
                Console.WriteLine("キーは存在しません");
            }
        }
    }
}
