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
    public partial class FormButton : Form
    {
        public FormButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (btnButton.Text == "點我")
                  btnButton.Text = "（〉~〈）";
             else if (btnButton.Text == "（〉~〈）")
                 btnButton.Text = "（〉▽〈）";
            else if (btnButton.Text == "（〉▽〈）")
                btnButton.Text = "（〉~〈）";
        }

        private void btnLabel_Click(object sender, EventArgs e)
        {
            label1.Text = "按鈕被按過了";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String count = label_Add.Text;
            int sum = Int32.Parse(count)+1;
            label_Add.Text = sum.ToString();
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            String count = label_Add.Text;
            int sum = Int32.Parse(count)-1;
            label_Add.Text = sum.ToString();
        }
    }
}
