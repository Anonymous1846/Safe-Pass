using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace SafePass
{
    public partial class SignUp : Form
    {
        private bool isMouseDown;
        private Point offset;
        Database database;

        public SignUp()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //For Moving the Form, as The Form is Borderless we have to change the positin explicitly!
            if (isMouseDown)
            {
                Point current_point = PointToScreen(e.Location);
                Location = new Point(current_point.X - offset.X, current_point.Y - offset.Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //Current Position when mouse is Down
            offset.X = e.X;
            offset.Y = e.Y;
            isMouseDown = true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void signUpBtn_MouseEnter(object sender, EventArgs e)
        {
            signUpBtn.ForeColor = Color.Black;
            signUpBtn.BackColor = Color.White;
        }

        private void signUpBtn_MouseLeave(object sender, EventArgs e)
        {
            signUpBtn.ForeColor = Color.White;
            signUpBtn.BackColor = Color.Black;
        }

        private void signUpBtn_MouseHover(object sender, EventArgs e)
        {
            signUpBtn.ForeColor = Color.Black;
            signUpBtn.BackColor = Color.White;
        }
        //First of all we check the null values in the Text boxes !
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (userSignUp.Text.Equals(String.Empty))
            {
                usernameSignWarn.Text = "Enter Username";
            }
            if (emailSignUp.Text.Equals(String.Empty))
            {
                emailSignWarn.Text = "Enter a Valid Email";
            }
            if (passSignUp.Text.Equals(String.Empty))
            {
                passSignWarn.Text = "Enter A Valid Password !";
            }
            if (!userSignUp.Text.Equals(String.Empty) && !emailSignUp.Text.Equals(String.Empty) && !passSignUp.Text.Equals(String.Empty))
            {
               
                database = new Database();
                
                //Checking whether the user already exists 
                if (database.checkForUser(userSignUp.Text))
                {
                    usernameSignWarn.Text = "User name Already Exits !";
                }
                else
                {
                   //Regex for Password is Upper Letters, Lower case, Symbols(Atleast One !) and Numbers !
                    Regex regex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
                    //Testing If the Password Meets the Strength Parameters !
                    if (regex.IsMatch(passSignUp.Text))
                    {
                        String passwordEncrypted = new DataEncryptPassword(passSignUp.Text).encryptData();
                        if (database.addUserToDatabase(userSignUp.Text, emailSignUp.Text, passwordEncrypted, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")))
                        {
                            MessageBox.Show("User Registration Complete !","Please Login !",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            this.Hide();
                            Form1 login = new Form1();
                            login.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Unexpected Error !","Error !",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        passSignWarn.Text = "Master Password Should Be Stronger !";
                    }
                }
            }
        }

        private void passSignUp_KeyDown(object sender, KeyEventArgs e)
        {
            passSignWarn.Text = "";
        }

        private void emailSignUp_KeyDown(object sender, KeyEventArgs e)
        {
            emailSignWarn.Text = "";
        }

        private void userSignUp_KeyDown(object sender, KeyEventArgs e)
        {
            usernameSignWarn.Text = "";
        }

    }
}
