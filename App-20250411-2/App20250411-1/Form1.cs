using System.Diagnostics;

namespace App20250411_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            control.BackColor = System.Drawing.Color.Purple;
        }
    }
}
