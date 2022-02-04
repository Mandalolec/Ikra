using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ikra.Forms
{
    public partial class formReport : Form
    {
        
        public formReport()
        {
            InitializeComponent();
            
        }

        private void ReportBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
         
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var helper = new WordHelper("pattern.doc");

            var items = new Dictionary<string, string>
            {
                { "<ORG>", textBox1.Text },
                { "<FIO>", textBox2.Text },
                { "<DATE>", dateTimePicker1.Value.ToString("dd.MM.yyyy") },
                { "<NUMBER_PRODUCT>", numericUpDown2.Value.ToString() },
                { "<NUMBER_CONTRACT>", numericUpDown1.Value.ToString() },
                { "<DATE_FROM>", dateTimePicker3.Value.ToString("dd.MM.yyyy") },
                { "<DATE_TO>", dateTimePicker2.Value.ToString("dd.MM.yyyy") },
                { "<PRODUCT_LIST>", textBox3.Text }
            };


            helper.Process(items);

                  
            
            
            


        }
    }
}
