using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_3//WindowsFormApp1_3名前空間
{
    class Value//Valueのクラス
    {
        public int value;
    }

    internal static class Pro3//Pro3のクラス
    {
        static void Main(string[] args)//Mainメソッド
        {
            Value x;//Value型の変数xを宣言
            x =new Value();//インスタンスを生成してxに代入（インスタンス：クラスを基にして作られた具体的なオブジェクトのこと）
            x.value = 10;//valueフィールドに10を代入

            Value y;//Value型の変数yを宣言
            y =new Value();//インスタンスを生成してyに代入
            y =x;//xの参照をyに代入
            y.value = 20;//yのvalueフィールドに20を代入

            // 出力
            MessageBox.Show("xが参照するインスタンスのvalueの値: " + x.value);//xのvalueフィールドの値を表示
            MessageBox.Show("yが参照するインスタンスのvalueの値: " + y.value);//yのvalueフィールドの値を表示
        }
    }
}
