namespace ListBoxitemeAdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0,textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("�폜���鍀�ڂ�I�����Ă�������", "���I��");
            }

            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
