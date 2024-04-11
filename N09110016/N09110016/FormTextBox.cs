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
    public partial class FormTextBox : Form
    {
        public FormTextBox()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Text Box 被改變了");
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            label1.Text = tbInput.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int add1, add2;
            try 
            { 
            add1 = Int32.Parse(tbAdd1.Text);
            add2 = Int32.Parse(tbAdd2.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數字");
                add1=0;
                add2=0;
            }
            lbAdd.Text = (add1+add2).ToString();
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            int reduce1, reduce2;
            try
            {
                reduce1 = Int32.Parse(tbReduce1.Text);
                reduce2 = Int32.Parse(tbReduce2.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數字");
                reduce1=0;
                reduce2=0;
            }
            lbAdd.Text = (reduce1-reduce2).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int multiply1, multiply2;
            try
            {
                multiply1 = Int32.Parse(tbMultiply1.Text);
                multiply2 = Int32.Parse(tbMultiply2.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數字");
                multiply1=0;
                multiply2=0;
            }
            lbAdd.Text = (multiply1*multiply2).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int divide1, divide2;
            try
            {
                divide1 = Int32.Parse(tbDivide1.Text);
                divide2 = Int32.Parse(tbDivide2.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數字");
                divide1=0;
                divide2=0;
            }
            lbAdd.Text = (divide1/divide2).ToString();
        }
    }
}
