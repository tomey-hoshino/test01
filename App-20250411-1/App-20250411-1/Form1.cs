namespace App_20250411_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score;

            score=Convert.ToInt32(textBox1.Text);

            switch (score)
            {
                case 5:
                    MessageBox.Show("Excellent","result");
                    break;
                case 4:
                    MessageBox.Show("Very Good","result");
                    break;
                case 3:
                    MessageBox.Show("Good", "result");
                    break;
                case 2:
                    MessageBox.Show("Satisfactory", "result");
                    break;
                case 1:
                    MessageBox.Show("Poor", "result");
                    break;
                default:
                    MessageBox.Show("Invalid score", "result");
                    break;
            }
        }
    }
}
