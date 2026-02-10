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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form10();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Form11();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new Form8();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new Form9();
            frm.Show();
        }
    }
}
