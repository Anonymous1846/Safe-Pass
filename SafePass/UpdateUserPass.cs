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
    public partial class UpdateUserPass : Form
    {
        Database database;
        public UpdateUserPass()
        {
            InitializeComponent();
            database = new Database();
        }

        private void closeBtnForUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBtnuser_Click(object sender, EventArgs e)
        {
            if (database.updateUserPassword(Form1.username,Vault.NickName,emailUpdate.Text,passUpdate.Text,DateTime.Now.ToString()))
            {
                MessageBox.Show("User Credentials Updated !","Updation Successful !",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Operation Failed !", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void updateBtnuser_MouseLeave(object sender, EventArgs e)
        {
            updateBtnuser.ForeColor = Color.White;
            updateBtnuser.BackColor = Color.Black;
        }
        //Mouse Enter Color Change !
        private void updateBtnuser_MouseEnter(object sender, EventArgs e)
        {
            updateBtnuser.ForeColor = Color.Black;
            updateBtnuser.BackColor = Color.White;
        }
        //The Preloaded Data shown !
        private void UpdateUserPass_Load(object sender, EventArgs e)
        {
            //Pre load the data in the user Control
            nicknameUpdate.Text = Vault.NickName;
            emailUpdate.Text = database.getUserPasswordInformation(Form1.username,Vault.NickName)[2];
            //We get the Encrypted Password from the data base, to show the Decrypted version We Use the Decrypt Method !
            passUpdate.Text = new DataEncryptPassword().decryptData(database.getUserPasswordInformation(Form1.username, Vault.NickName)[3]);
            lastUpdationPassword.Text = $"Last Updation :{database.getUserPasswordInformation(Form1.username, Vault.NickName)[4]}";
        }
    }
}
