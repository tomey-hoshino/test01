namespace App_0411
{
    public partial class Form1 : Form//Form1のクラスを定義
    {
        public Form1()//Form1のコンストラクタ
        {
            InitializeComponent();//InitializeComponentメソッドを呼び出す
        }

        private void button1_Click(object sender, EventArgs e)//ボタンがクリックされたときの処理
        {
            int price, quantity, subtotal, tax, total;//変数の宣言

            const double TAX_RATE = 0.1;//定数の宣言

            price = Convert.ToInt32(textBox1.Text);//テキストボックスから価格を取得

            quantity = Convert.ToInt32(textBox2.Text);//テキストボックスから数量を取得

            subtotal = price * quantity;//小計を計算

            tax =(int)(subtotal * TAX_RATE);//税金を計算

            total = subtotal + tax;//合計を計算

            label6.Text = Convert.ToString(subtotal);//小計をラベルに表示
            label7.Text = Convert.ToString(tax);//税金をラベルに表示
            label8.Text = Convert.ToString(total);//合計をラベルに表示
        }
    }
}
