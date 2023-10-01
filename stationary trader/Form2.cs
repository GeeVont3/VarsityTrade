using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace stationary_trader
{
    public partial class registerpage : Form
    {
        public registerpage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            loginpage login = new loginpage();
            login.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fullname.Text.Length <= 0)
            {
                fullnameerrors.Text = "enter your name above ";
            }
            else if (fullname.Text.Length < 3)
            {
                fullnameerrors.Text = "name is too short";

            
            }
            else if (fullname.Text.Length > 20)
            {
                fullnameerrors.Text = "name can have more than 20 characters";
            }
            else
            {
                fullnameerrors.ForeColor = Color.Green;
                fullnameerrors.Text = "correct";
            }
            string valid = email.Text;

            if (valid.Length == 0)
            {
                emailerrors.Text = "enter your email above";
            }
            else
            {
                for (int a = 0; a < valid.Length; a++)
                {
                    if (valid[a].ToString() == "@".ToString())
                    {
                        emailerrors.ForeColor = Color.Green;
                        emailerrors.Text = "correct";
                    }


                    else
                    {
                        emailerrors.Text = "invalid email";
                    }
                }

            }

            if (phonenumber.Text.Length > 0)
            {
                if (phonenumber.Text.Length == 10)
                {
                    try
                    {
                        int phonenumbe = int.Parse(phonenumber.Text);
                        phoneerrors.ForeColor = Color.Green;
                        phoneerrors.Text = "correct";

                    }
                    catch
                    {
                        phoneerrors.Text = "enter a valid phone number";
                    }
                }
                else if (phonenumber.Text.Length == 0)
                {
                    phoneerrors.Text = "enter a  phone number above";
                }else
                {
                    phoneerrors.Text = "enter a valid phone number";
                }
            }
            else
            {
                phoneerrors.Text = "enter a phone number above";
            }

            bool name2 = IsPasswordValid(registerpassword.Text);
            
            if (name2)
            {
                passworderrors.Text = "correct";
                passworderrors.ForeColor = Color.Green;
            }else
            { 
                if (registerpassword.Text.Length == 0)
                {
                    passworderrors.Text = "enter a password above";
                }else
                {
                    passworderrors.Text = "passwork weak as hell";
                }
                
            }






        }

        public static bool IsPasswordValid(string password)
        {
            // Check if the password has at least 8 characters
            if (password.Length < 8)
            {
                return false;
            }

            // Check if the password contains at least one special character
            if (!Regex.IsMatch(password, @"[!@#$%^&*()_+{}\[\]:;<>,.?~\\-]"))
            {
                return false;
            }

            // Check if the password contains at least one capital letter
            if (!password.Any(char.IsUpper))
            {
                return false;
            }

            // Check if the password contains at least one number
            if (!password.Any(char.IsDigit))
            {
                return false;
            }

            // If all criteria are met, the password is considered valid
            return true;
        }



    }
}
