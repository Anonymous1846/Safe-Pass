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
            //Closes the Current Window !
            this.Close();
        }
        //When the Del Button is clicked the User is deleted from the Database and is prompted to Login 
        private void delBtn_Click(object sender, EventArgs e)
        {
            database.deleteUserCredentials(Form1.username);
            //Deleting The Logged in User !
            if (database.deleteuser(Form1.username))
            {
                
                MessageBox.Show($"{Form1.username} Deleted Successfully !","Deletion Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //Hides the Window
                this.Hide();
                //Hides the Safepass Main Windows, whose Profile is User Control is The Child Level Entity
                ((Form)Profile.ProfileInstance.TopLevelControl).Hide();
                Form1 from = new Form1();
                //Closing Both Forms and User Control !
                ((Form)Profile.ProfileInstance.TopLevelControl).Close();
                this.Close();
                //Shows The Form Dialog Box i.e the Login !
                from.ShowDialog();
            }
            else
            {
                MessageBox.Show($"Could Not Delete {Form1.username} !", "Deletion Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //The Email and Password can be changed and the Time Stamp !
        private void upBtn_Click(object sender, EventArgs e)
        {
            //The Update will only be initiated if the Passwords Match 
            if (passwordEditUpdate.Text.Equals(confirmPasswordEditUpdate.Text))
            {
                if (database.updateUser(Form1.username,emailEditUpdate.Text,new DataEncryptPassword(passwordEditUpdate.Text).encryptData(),DateTime.Now.ToString()))
            {
               
                    //Show the Message Box Dialog that the user credentials is Updated !
                    MessageBox.Show("Successfully Updated !", "Updating Complete !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Hides the Window
                    this.Hide();
                    //Hides the Safepass Main Windows, whose Profile is User Control is The Child Level Entity
                    ((Form)Profile.ProfileInstance.TopLevelControl).Hide();
                    Form1 from = new Form1();
                    //Closing Both Forms and User Control !
                    ((Form)Profile.ProfileInstance.TopLevelControl).Close();
                    this.Close();
                    //Shows The Form Dialog Box i.e the Login !
                    from.ShowDialog();
                }

                else
                {
                    MessageBox.Show("An Error Occured While Updating !", "Updation Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
            else
            {
                MessageBox.Show("The Passwords Don't Match !", "Match Error !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //When the Profile Edit Dialog is Loaded The user information is Filled in the textboxes !
        private void EdituserProfile_Load(object sender, EventArgs e)
        {
            String decryptedPassword=new DataEncryptPassword().decryptData(database.getUserInformation(Form1.username)[2]);
            userEditProfileLabel.Text = database.getUserInformation(Form1.username)[0];
            emailEditUpdate.Text = database.getUserInformation(Form1.username)[1];
            confirmPasswordEditUpdate.Text = decryptedPassword;
            passwordEditUpdate.Text = decryptedPassword;
        }
        //Show the Password !
        private void showPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            toggle_password_visiblity(passwordEditUpdate);
        }

        private void toggle_password_visiblity(TextBox textBoxObject)
        {
            if (textBoxObject.PasswordChar == '*')
            {
                textBoxObject.PasswordChar = '\0';
            }
            else
            {
                textBoxObject.PasswordChar = '*';
            }
        }

        private void showConfirm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            toggle_password_visiblity(confirmPasswordEditUpdate);
        }

        private void confirmPasswordEditUpdate_TextChanged(object sender, EventArgs e)
        {
            check_whether_thepasswords_match();
        }

        private void passwordEditUpdate_TextChanged(object sender, EventArgs e)
        {

            check_whether_thepasswords_match();
        }
        private void check_whether_thepasswords_match()
        {
            if (passwordEditUpdate.Text.Equals(confirmPasswordEditUpdate.Text))
            {
                passwordsDontMatchLabel.Visible = false;

            }
            else
            {
                passwordsDontMatchLabel.Text = "Passwords Dont Match !";
                passwordsDontMatchLabel.Visible = true;
            }
        }
        //Hover color change for Both The Delete and Update Buttons ! 
        private void upBtn_MouseEnter(object sender, EventArgs e)
        {
            upBtn.ForeColor = Color.Black;
            upBtn.BackColor = Color.White;
        }

        private void delBtn_MouseEnter(object sender, EventArgs e)
        {
            delBtn.ForeColor = Color.Black;
            delBtn.BackColor = Color.White;
        }

        private void delBtn_MouseLeave(object sender, EventArgs e)
        {
            delBtn.ForeColor = Color.White;
            delBtn.BackColor = Color.Black;
        }

        private void upBtn_MouseLeave(object sender, EventArgs e)
        {
            upBtn.ForeColor = Color.White;
            upBtn.BackColor = Color.Black;
        }
        //End of Color Changing Events for Update and Delete Buttons !
    }
}
