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

namespace N09110016
{
    public partial class FormFinalExam : Form
    {
        public FormFinalExam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItems = "";
            foreach(Control control in panel1.Controls) 
            {
                if(control is   CheckBox checkBox && checkBox.Checked) 
                {
                    selectedItems += "主食："+checkBox.Text + "\n";
                } 
            }
            foreach (Control control in panel2.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    selectedItems += "配餐："+checkBox.Text + "\n";
                }
            }

            if (selectedItems !="") 
            {
                MessageBox.Show("您選擇的餐點是：\n\n" + selectedItems, "訂單內容");
                SaveToCSV(selectedItems);
            }
            else
            {
                MessageBox.Show("請選擇至少一個餐點!", "提示");
            }
        }
        private void SaveToCSV(string content) 
        {
            string filePath = "menu.csv";
            int count = 1;
            while(File.Exists(filePath)) 
            {
                filePath = $"menu({count})";
                count++;
            }
            File.WriteAllText(filePath, content);
            MessageBox.Show($"以儲存為{filePath}","CSV檔案已儲存");
        }

        
    }
}
