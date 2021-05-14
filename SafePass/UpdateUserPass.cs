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
        private bool isMouseDown;
        private Point offset;
       
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
            if (database.updateUserPassword(Form1.username,Vault.NickName,emailUpdate.Text,new CryptoConfig(passUpdate.Text).getHashedData(),DateTime.Now.ToString()))
            {
                MessageBox.Show("User Credentials Updated !","Updation Successful !",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //Calling the Vault Instance and Thereby Reloading The Contents of the Form to Show The Newly Updated Values !
                Vault.VaultInstance.Vault_Load(sender, e);
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
            passUpdate.Text = new CryptoConfig(database.getUserPasswordInformation(Form1.username, Vault.NickName)[3]).getDecryptedData();
            lastUpdationPassword.Text = $"Last Updation :{database.getUserPasswordInformation(Form1.username, Vault.NickName)[2]}";
        }

        private void togglePass_Click(object sender, EventArgs e)
        {
            if (passUpdate.PasswordChar.Equals('*'))
            {
                passUpdate.PasswordChar = '\0';
            }
            else
            {
                passUpdate.PasswordChar = '*';
            }
        }
        //Drag the Form on Mouse Events !
        private void UpdateUserPass_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void UpdateUserPass_MouseMove(object sender, MouseEventArgs e)
        {
            //For Moving the Form, as The Form is Borderless we have to change the positin explicitly!
            if (isMouseDown)
            {
                Point current_point = PointToScreen(e.Location);
                Location = new Point(current_point.X - offset.X, current_point.Y - offset.Y);
            }
        }

        private void UpdateUserPass_MouseDown(object sender, MouseEventArgs e)
        {
            //Current Position when mouse is Down
            offset.X = e.X;
            offset.Y = e.Y;
            isMouseDown = true;
        }
    }
}
