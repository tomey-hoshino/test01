namespace App_0411_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("�`�F�b�N�{�b�N�X���`�F�b�N����Ă��܂�","�m�F");
            }
            else
            {
                MessageBox.Show("�`�F�b�N�{�b�N�X���`�F�b�N����Ă��܂���", "�m�F");
            }
        }
    }
}
