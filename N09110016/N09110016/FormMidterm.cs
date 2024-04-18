using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace N09110016
{
    public partial class FormMidterm : Form
    {
        public FormMidterm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c;
            try
            {
                c = Int32.Parse(tbC.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數字");
                c=0;
            }
            double f = c*1.8 + 32;
            lbF.Text = f.ToString();
        }

       
    }
}
