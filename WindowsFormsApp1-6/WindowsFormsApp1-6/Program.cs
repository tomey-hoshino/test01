using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_6//名前空間
{
    class FieldTest //FieldTestクラス
    {
        public int num = 55;//フィールドnumを定義
    }
    class Pro6//Pro6クラス
    {
        static void Main()//Mainメゾッド
        {
            FieldTest obj=new FieldTest();//FieldTestクラスのインスタンスobjを生成

            Console.WriteLine(obj.num);//フィールドnumの値を表示
            Console.WriteLine(obj.GetType().Name);//objの型名を表示

            var value = obj.num;
            Console.WriteLine(value);//フィールドnumの値を表示
            Console.WriteLine(value.GetType().Name);//valueの型名を表示
        }
    }
}
