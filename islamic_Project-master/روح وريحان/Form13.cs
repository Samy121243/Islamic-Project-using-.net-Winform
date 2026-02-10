using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace روح_وريحان
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        int Counter  = 1;
        int Counter1 = 1;
        int Counter2 = 1;
        int Counter3 = 1;
        int Counter4 = 1;
        int Counter5 = 1;
        int Counter6 = 1;
        int Counter7 = 1;
        int Counter8 = 1;
        int Counter9 = 1;
        int Counter10 = 1;
        int Counter11 = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = Counter++.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Counter = 1;
            label1.Text = 0.ToString(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            label2.Text = Counter1++.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            label4.Text = Counter2++.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = Counter3++.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label5.Text = Counter4++.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label6.Text = Counter5++.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label7.Text = Counter6++.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label8.Text = Counter7++.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label9.Text = Counter8++.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label10.Text = Counter9++.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label11.Text = Counter10++.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label12.Text = Counter11++.ToString(); ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Counter1 = 1;
            label2.Text = 0.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Counter2 = 1;
            label4.Text = 0.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Counter3 = 1;
            label3.Text = 0.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Counter4 = 1;
            label5.Text = 0.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Counter5 = 1;
            label6.Text = 0.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Counter6 = 1;
            label7.Text = 0.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Counter7 = 1;
            label8.Text = 0.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Counter8 = 1;
            label9.Text = 0.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Counter9 = 1;
            label10.Text = 0.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Counter10 = 1;
            label11.Text = 0.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Counter11 = 1;
            label12.Text = 0.ToString();
        }
    }
}
