using System;
using System.Drawing;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                this.BackColor = Color.Red;
            if (radioButton2.Checked)
                this.BackColor = Color.Blue;
            if (radioButton3.Checked)
                this.BackColor = Color.Green;
        }
    }
}
