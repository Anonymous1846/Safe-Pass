using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafePass
{
    public partial class EdituserProfile : Form
    {
        Database database;
        public EdituserProfile()
        {
            InitializeComponent();
            database = new Database();

        }

        private void closeEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //When the Del Button is clicked the User is deleted from the Database and is prompted to Login 
        private void delBtn_Click(object sender, EventArgs e)
        {

        }
        //The Email and Password can be changed and the Time Stamp !
        private void upBtn_Click(object sender, EventArgs e)
        {
            if (database.updateUser(Form1.username,emailEditUpdate.Text,passwordEditUpdate.Text,DateTime.Now.ToString()))
            {
                MessageBox.Show("Successfully Updated !", "Updating Complete !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SafePassMain safe = new SafePassMain();
                safe.Close();
                this.Close();
                Form1 from = new Form1();
                from.Show();
                
            }
            else
            {
                MessageBox.Show("An Error Occured While Updating !","Updation Error !",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void EdituserProfile_Load(object sender, EventArgs e)
        {
            userEditProfileLabel.Text = database.getUserInformation(Form1.username)[0];
            emailEditUpdate.Text = database.getUserInformation(Form1.username)[1];
            confirmPasswordEditUpdate.Text = database.getUserInformation(Form1.username)[2];
            passwordEditUpdate.Text = database.getUserInformation(Form1.username)[2];
        }
        //Show the Password !
        private void showPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (passwordEditUpdate.PasswordChar=='*')
            {
                passwordEditUpdate.PasswordChar = '\0';
            }
            else
            {
                passwordEditUpdate.PasswordChar = '*';
            }
        }

        private void showConfirm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (confirmPasswordEditUpdate.PasswordChar == '*')
            {
                confirmPasswordEditUpdate.PasswordChar = '\0';
            }
            else
            {
                confirmPasswordEditUpdate.PasswordChar = '*';
            }
        }

        private void confirmPasswordEditUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (confirmPasswordEditUpdate.Text.Equals(passwordEditUpdate.Text))
            {
                passwordsDontMatchLabel.Visible = false;
               

            }
            else
            {
                passwordsDontMatchLabel.Visible = true;
                passwordsDontMatchLabel.Text = "Passwords Dont Match !";
            }
        }
    }
}
