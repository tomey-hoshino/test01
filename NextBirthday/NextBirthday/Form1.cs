namespace NextBirthday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "�I���������t" + dateTimePicker1.Value.ToString("yyyy/MM/dd");

            int birthday=dateTimePicker1.Value.Subtract(DateTime.Today).Days;

            label3.Text = "�{�����玟�̒a�����܂ł���"+birthday.ToString() + "��";
        }
    }
}
