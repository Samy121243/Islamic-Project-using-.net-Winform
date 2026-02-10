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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        WMPLib.WindowsMediaPlayer Wmp = new WMPLib.WindowsMediaPlayer();
        private void button1_Click(object sender, EventArgs e)
        {
            Wmp.URL = "1.MP3";
            Wmp.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wmp.URL = "2.MP3";
            Wmp.controls.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wmp.URL = "3.MP3";
            Wmp.controls.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Wmp.URL = "4.MP3";
            Wmp.controls.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Wmp.URL = "5.MP3";
            Wmp.controls.play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Wmp.URL = "6.MP3";
            Wmp.controls.play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Wmp.URL = "7.MP3";
            Wmp.controls.play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Wmp.URL = "8.MP3";
            Wmp.controls.play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Wmp.URL = "9.MP3";
            Wmp.controls.play();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wmp.controls.stop();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wmp.controls.play();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wmp.controls.pause();
        }
    }
}
