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
    public partial class SignInForm : Form
    {
        bool passwordVisble = true;

        string path = @"D:\Projects\Практика\Ikra\login.txt";

        public SignInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(passwordVisble)
            {
                passwordBox.UseSystemPasswordChar = false;
                passwordVisble = false;
            }
            else
            {
                passwordBox.UseSystemPasswordChar = true;
                passwordVisble = true;
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            using (StreamReader reader1 = new StreamReader(@"D:\Projects\Практика\Ikra\log1.txt"))
            using (StreamReader reader2 = new StreamReader(@"D:\Projects\Практика\Ikra\log2.txt"))
            using (StreamReader reader3 = new StreamReader(@"D:\Projects\Практика\Ikra\log3.txt"))
            {
                string r1 = reader1.ReadLine();
                string r2 = reader2.ReadLine();
                string r3 = reader3.ReadLine();
                if (loginBox.Text == r1 && passwordBox.Text == r1)
                {
                    using (StreamWriter stream = new StreamWriter(path, false))
                        stream.WriteLine("admin");
                    Form mainForm = new mainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else if (loginBox.Text == r2 && passwordBox.Text == r2)
                {
                    using (StreamWriter stream = new StreamWriter(path, false))
                        stream.WriteLine("manager");
                    Form mainForm = new mainForm();
                    mainForm.Show();
                    this.Hide();

                }
                else if (loginBox.Text == r3 && passwordBox.Text == r3)
                {
                    using (StreamWriter stream = new StreamWriter(path, false))
                        stream.WriteLine("looking");
                    Form mainForm = new mainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else MessageBox.Show("Неправильно введен логин или пароль. ");
            }
        }

        private void SingInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
