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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        WMPLib.WindowsMediaPlayer Wmp = new WMPLib.WindowsMediaPlayer();
        private void button1_Click(object sender, EventArgs e)
        {
            Wmp.URL = "1N.MP3";
            Wmp.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wmp.URL = "2N.MP3";
            Wmp.controls.play();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wmp.controls.play();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wmp.controls.pause();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wmp.controls.stop();
        }
    }
}
