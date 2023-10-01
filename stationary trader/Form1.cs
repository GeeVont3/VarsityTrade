using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stationary_trader
{
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text.Length > 0  && password.Text.Length > 0)
            {
                
                if (loggingin(username.Text, password.Text))
                {
                    
                }
                else
                {
                    incorrectpassword.Text = "invalid password or username";
                    incorrectpassword.ForeColor = Color.Red;
                    username.Clear();
                    password.Clear();
                }

                
            }

            if (username.Text.Length == 0)
            {
                icorrectlogin.Text = "please fill in above";
                icorrectlogin.ForeColor = Color.Red;
            }else
            {
                icorrectlogin.Text = " ";
            }
            if (password.Text.Length == 0)
            {
                incorrectpassword.Text = "please fill in your above";
                incorrectpassword.ForeColor = Color.Red;
            }
            else
            {
                incorrectpassword.Text = " ";
            }
        }

        private bool loggingin(string a,string b)
        {
            string[] username = { "thabang" };
            string[] pswd = { "thabang" };

            if (username[0] == a && pswd[0] == b)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the registration page (Form2)
            registerpage register = new registerpage();
            register.ShowDialog();

        }
    }
}
