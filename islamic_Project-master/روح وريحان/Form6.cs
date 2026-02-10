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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player1.URL = "11.MP4";
            Player1.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player1.URL = "12.MP4";
            Player1.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player1.URL = "13.MP4";
            Player1.Ctlcontrols.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player1.URL = "14.MP4";
            Player1.Ctlcontrols.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Player1.URL = "15.MP4";
            Player1.Ctlcontrols.play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Player1.URL = "16.MP4";
            Player1.Ctlcontrols.play();
        }
    }
}
