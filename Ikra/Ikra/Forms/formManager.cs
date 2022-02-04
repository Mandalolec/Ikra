using System;
using System.IO;
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
    public partial class formManager : Form
    {
        private Form activeForm;
        string path = @"D:\Projects\Практика\Ikra\login.txt";
        public formManager()
        {
            InitializeComponent();      
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormZapros(), sender);
        }

        private void formManager_Load(object sender, EventArgs e)
        {          
            using (StreamReader stream = new StreamReader(path))
               if (stream.ReadToEnd() == "manager\r\n")
                {
                    button1.Visible = false;
                }
        }
    }
}
