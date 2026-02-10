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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you Sure to Logout ?", "Logout", MessageBoxButtons.OKCancel , MessageBoxIcon.Information , MessageBoxDefaultButton.Button2);
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar1.Value.ToString();   
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Should be enter the Frist Name ! ");

            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {

            if(string.IsNullOrWhiteSpace(textBox3.Text))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Should be enter the PassWord !");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(textBox3, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Show();
        }

        private void changeForeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
                textBox2.ForeColor = colorDialog1.Color;
                textBox3.ForeColor = colorDialog1.Color;
            }
        }

        private void changeBackColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
                textBox2.BackColor = colorDialog1.Color;
                textBox3.BackColor = colorDialog1.Color;
            }
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox2.Font = fontDialog1.Font;
                textBox3.Font = fontDialog1.Font;
            }
        }
    }
}
