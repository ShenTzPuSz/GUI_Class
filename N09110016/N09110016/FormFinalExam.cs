using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace N09110016
{
    public partial class FormFinalExam : Form
    {
        string food, drink;
        public FormFinalExam()
        {
            if (!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv", "時間,主食,飲料\n", Encoding.UTF8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        food = food + ((CheckBox)c).Text + " ";
                    }
                }
            }

            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        drink = drink + ((CheckBox)c).Text + " ";
                    }
                }
            }

            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("yyyy/MM/dd HH:mm");
            File.AppendAllText("OrderData.csv", formattedDateTime + "," + food + "," + drink + "\n", Encoding.UTF8);

            MessageBox.Show("主食：" + food + Environment.NewLine + "飲料：" + drink);

            food = string.Empty;
            drink = string.Empty;
        }
    }
}
