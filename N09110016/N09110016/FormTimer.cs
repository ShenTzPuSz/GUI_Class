using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N09110016
{
    public partial class FormTimer : Form
    {
        int second;
        public FormTimer()
        {
            InitializeComponent();

            this.second = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;  
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            second = 0;
            label1.Text = $"0秒";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = second.ToString()+"秒";
            label1.Text = String.Format("{0}秒", this.second);
            this.second++;
        }
    }
}
