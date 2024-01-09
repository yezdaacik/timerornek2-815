using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_örneği_815
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString(@"R");
            label2.Text = DateTime.Now.ToString(@"U");
            label3.Text = DateTime.Now.ToString(@"yyyy-MM-dd HH:mm");
            label4.Text = DateTime.Now.ToString(@"t");
            label5.Text = DateTime.Now.ToString(@"zzz");
            label6.Text = DateTime.Now.ToString(@"d");
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }
    }
}
