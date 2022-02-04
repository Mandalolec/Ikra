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
    public partial class FormZapros : Form
    {
        public FormZapros()
        {
            InitializeComponent();
            saveFileDialog1.Filter =
            "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
               
            }
            string fileName = saveFileDialog1.FileName;
            File.WriteAllText(fileName,richTextBox1.Text);
            MessageBox.Show("Запрос отправлен ");
            Close();
        }
    }
}
