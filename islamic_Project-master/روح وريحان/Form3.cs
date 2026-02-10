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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        WMPLib.WindowsMediaPlayer Wmp = new WMPLib.WindowsMediaPlayer();
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void مكتوبهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm3 = new Form4();
            frm3.Show();
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wmp.URL = "114.MP3";
            Wmp.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wmp.URL = "113.MP3";
            Wmp.controls.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wmp.URL = "112.MP3";
            Wmp.controls.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Wmp.URL = "111.MP3";
            Wmp.controls.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Wmp.URL = "110.MP3";
            Wmp.controls.play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Wmp.URL = "109.MP3";
            Wmp.controls.play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Wmp.URL = "108.MP3";
            Wmp.controls.play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Wmp.URL = "107.MP3";
            Wmp.controls.play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Wmp.URL = "106.MP3";
            Wmp.controls.play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Wmp.URL = "105.MP3";
            Wmp.controls.play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Wmp.URL = "104.MP3";
            Wmp.controls.play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Wmp.URL = "103.MP3";
            Wmp.controls.play();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Wmp.URL = "102.MP3";
            Wmp.controls.play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Wmp.URL = "101.MP3";
            Wmp.controls.play();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Wmp.URL = "100.MP3";
            Wmp.controls.play();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Wmp.URL = "099.MP3";
            Wmp.controls.play();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Wmp.URL = "098.MP3";
            Wmp.controls.play();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Wmp.URL = "097.MP3";
            Wmp.controls.play();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Wmp.URL = "096.MP3";
            Wmp.controls.play();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Wmp.URL = "095.MP3";
            Wmp.controls.play();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Wmp.controls.pause();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Wmp.controls.play();
        }

        private void stToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wmp.controls.stop();
        }
    }
}
