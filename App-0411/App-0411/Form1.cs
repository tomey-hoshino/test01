namespace App_0411
{
    public partial class Form1 : Form//Form1�̃N���X���`
    {
        public Form1()//Form1�̃R���X�g���N�^
        {
            InitializeComponent();//InitializeComponent���\�b�h���Ăяo��
        }

        private void button1_Click(object sender, EventArgs e)//�{�^�����N���b�N���ꂽ�Ƃ��̏���
        {
            int price, quantity, subtotal, tax, total;//�ϐ��̐錾

            const double TAX_RATE = 0.1;//�萔�̐錾

            price = Convert.ToInt32(textBox1.Text);//�e�L�X�g�{�b�N�X���牿�i���擾

            quantity = Convert.ToInt32(textBox2.Text);//�e�L�X�g�{�b�N�X���琔�ʂ��擾

            subtotal = price * quantity;//���v���v�Z

            tax =(int)(subtotal * TAX_RATE);//�ŋ����v�Z

            total = subtotal + tax;//���v���v�Z

            label6.Text = Convert.ToString(subtotal);//���v�����x���ɕ\��
            label7.Text = Convert.ToString(tax);//�ŋ������x���ɕ\��
            label8.Text = Convert.ToString(total);//���v�����x���ɕ\��
        }
    }
}
