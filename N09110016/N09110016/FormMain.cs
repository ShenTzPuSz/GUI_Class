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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            Form form = new FormButton();
            form.Show(this);

        }

        private void btnTextBox_Click(object sender, EventArgs e)
        {
            Form form = new FormTextBox();
            form.Show(this);
        }

        private void btnMidterm_Click(object sender, EventArgs e)
        {
            Form form = new FormMidterm();
            form.Show(this);
        }

        private void btnTryCatch_Click(object sender, EventArgs e)
        {
            Form form = new FormTryCatch();
            form.Show(this);
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            Form form = new FormTimer();
            form.Show(this);
        }

        private void btnFinalPassword_Click(object sender, EventArgs e)
        {
            Form form = new FormFinalPassword();
            form.Show(this);
        }

        private void btnCheckBox_Click(object sender, EventArgs e)
        {
            Form form = new FormCheckBox();
            form.Show(this);
        }

        private void btnFinalExam_Click(object sender, EventArgs e)
        {
            Form form = new FormFinalExam();
            form.Show(this);
        }
    }
}
