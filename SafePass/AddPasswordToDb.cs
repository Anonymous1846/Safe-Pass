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
        private bool isMouseDown;
        private Point offset;
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
                if (new Database().addUserPasswordToDatabase(Form1.username,nickName.Text,usernameAdding.Text,new DataEncryptPassword(userPasswordAdding.Text).encryptData(),DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")))
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

        private void AddPasswordToDb_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            isMouseDown = true;
        }

        private void AddPasswordToDb_MouseMove(object sender, MouseEventArgs e)
        {
            //For Moving the Form, as The Form is Borderless we have to change the positin explicitly!
            if (isMouseDown)
            {
                Point current_point = PointToScreen(e.Location);
                Location = new Point(current_point.X - offset.X, current_point.Y - offset.Y);
            }
        }

        private void AddPasswordToDb_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void addBtnAdding_MouseEnter(object sender, EventArgs e)
        {
            addBtnAdding.ForeColor = Color.Black;
            addBtnAdding.BackColor = Color.White;
        }

        private void addBtnAdding_MouseLeave(object sender, EventArgs e)
        {
            addBtnAdding.ForeColor = Color.White;
            addBtnAdding.BackColor = Color.Black;
        }
    }
}
