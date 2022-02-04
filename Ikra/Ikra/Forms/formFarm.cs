using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikra.Forms
{
    public partial class formFarm : Form
    {
        public formFarm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var helper = new WordHelper("farm.doc");

            var items = new Dictionary<string, string>
            {
                { "<DATA1>", dateTimePicker1.Value.ToString("dd.MM.yyyy") },
                { "<STATF>", textBox1.Text },
                { "<STATW>", textBox2.Text },
                { "<STATK>", textBox3.Text },
                { "<CLEANINGW>", textBox4.Text },
                { "<COLLCAV>", textBox5.Text },
                { "<SELCAV>", textBox6.Text },
                { "<INCUBCAV>", textBox7.Text }


            };
            helper.Process2(items);
        }
    }
}
