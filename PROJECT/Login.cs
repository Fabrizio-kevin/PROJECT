using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="abcde" && txtPassword.Text=="abcde") 
            {
                new HomePage().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("The User name or password is incorrect, try again");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 exit = new Form1();
            exit.Show();
            this.Hide();
        }
    }
}
