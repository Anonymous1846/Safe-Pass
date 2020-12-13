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
    public partial class AddPasswordToDb : Form
    {
        public AddPasswordToDb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtnAdding_Click(object sender, EventArgs e)
        {
            if (usernameAdding.Text.Equals(String.Empty))
            {
                errorForUseernameAdding.Text = "Cannot Be Left Blank";
            }
            if (userPasswordAdding.Text.Equals(String.Empty))
            {
                errorForPasswordAdding.Text = "Cannot Be Left Blank";
            }
            if (nickName.Text.Equals(String.Empty))
            {
                nickNameError.Text = "Cannot Be Left Blank";
            }
            if (!nickName.Text.Equals(String.Empty)&&!usernameAdding.Text.Equals(String.Empty) && !userPasswordAdding.Text.Equals(String.Empty))
            {
                if (new Database().addUserPasswordToDatabase(Form1.username,nickName.Text,usernameAdding.Text,new DataEncryptPassword(userPasswordAdding.Text).encryptData(),DateTime.Now.ToString()))
                {
                    MessageBox.Show("Password Saved Successfully !","Saved Successfully !",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    //Calling the Vault Instance and Thereby Reloading The Contents of the Form to Show The Newly Added Values !
                    Vault.VaultInstance.Vault_Load(sender,e);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong  !", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (userPasswordAdding.PasswordChar.Equals('*'))
            {
                userPasswordAdding.PasswordChar = '\0';
            }
            else
            {
                userPasswordAdding.PasswordChar = '*';
               
            }
        }
    }
}
