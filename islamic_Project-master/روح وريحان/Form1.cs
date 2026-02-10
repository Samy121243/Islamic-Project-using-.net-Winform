using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace روح_وريحان
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form2();
          
            frm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm2  = new Form3();
            frm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm4 = new Form5();
            frm4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm5 = new Form6();  
            frm5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm6 = new Form7();
            frm6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form fr = new Form12();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Form13();
            frm.Show();
        }
    }
}
