namespace App_0411_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                MessageBox.Show("使える金額を入力しよう！");
            }
            else 
            { 
                int pocket=Convert.ToInt32(textBox1.Text);
                string caption= "どっちか選ぼう！";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result1;
                DialogResult result2;

                string message1 = "甘いのにする？";

                string message2 = "カロリーは気になる？";

                if (pocket < 300)
                {
                    label2.Text = "「カリカリシュークリーム」一択だ！";
                }
                else 
                {
                    result1 = MessageBox.Show(message1, caption, buttons);
                    result2 = MessageBox.Show(message2, caption, buttons);

                    if (result1 == DialogResult.Yes & result1 == DialogResult.Yes)
                    {
                        label2.Text = "「ぷるぷるコーヒーゼリー」にしましょう！";
                    }

                    else if (result1 == DialogResult.Yes & result2 == DialogResult.No)
                    {
                        label2.Text = "「濃厚キャラメルチーズタルト」にしましょう！";
                    }

                    else if (result1 == DialogResult.No & result2 == DialogResult.Yes)
                    {
                        label2.Text = "「プロテインゼリー」だね！";
                    }
                    else
                    {
                        label2.Text = "「ビターカカオエクレア」にしましょう！";
                    }

                }
            }
        }
    }
}
