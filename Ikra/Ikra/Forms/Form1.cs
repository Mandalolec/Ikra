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

namespace Ikra
{
    public partial class mainForm : Form
    {
        private Form activeForm;
        string path = @"D:\Projects\Практика\Ikra\login.txt";
       

        public mainForm()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
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

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            using (StreamReader stream = new StreamReader(path))
                label1.Text = stream.ReadToEnd();

           if(label1.Text == "looking\r\n")
            {
                buttonReport.Visible = false;
            }
            else if(label1.Text == "manager\r\n")
            {
                buttonFarm.Visible = false;
            }
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
                
            Application.Exit();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {                   
                OpenChildForm(new Forms.formReport(), sender);
                button1.Visible = true;
                lblTile.Text = buttonReport.Text;
           
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonFarm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.formFarm(), sender);
            button1.Visible = true;
            lblTile.Text = buttonFarm.Text;         
        }

        private void buttonManager_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.formManager(), sender);
            button1.Visible = true;
            lblTile.Text = buttonManager.Text;
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            lblTile.Text = "Домашняя страница ";
            button1.Visible = false;
        }


        private void Logo2_Click(object sender, EventArgs e)
        {
            
        }

        private void lblTile_Click(object sender, EventArgs e)
        {

        }

        private void logo1_Click(object sender, EventArgs e)
        {

        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(label1.Text == "admin\r\n")
            {
                System.Diagnostics.Process.Start("https://b24-s1zgpg.bitrix24.ru/sites/site/5/view/7/");
            }
            else                 
            System.Diagnostics.Process.Start("https://b24-l5fuia.bitrix24.site/");
        }
    }
}
