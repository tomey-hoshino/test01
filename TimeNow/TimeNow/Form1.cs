using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeNow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MenuItem1_Click(object sender, EventArgs e)
        {
            DateTime dat = DateTime.Now;
            label1.Text = dat.ToLongDateString();
        }

        private void MenuItem2_Click(object sender, EventArgs e)
        {
            DateTime dat = DateTime.Now;
            label1.Text = dat.ToLongTimeString();
        }

        private void MenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
