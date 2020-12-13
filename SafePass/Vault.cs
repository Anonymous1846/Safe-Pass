using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;

namespace SafePass
{
    public partial class Vault : UserControl
    {
       
        Database database;
        private static Vault vaultInstance;
        public static String NickName;
       
        DataGridViewRow dataGridViewRow;
        public static Vault VaultInstance
        {
            //Getting the Instance !
            get
            {
                if (vaultInstance == null)
                    vaultInstance = new Vault();
                return vaultInstance;

            }
        }
        public Vault()
        {
            InitializeComponent();
            database = new Database();
            
           
        }
        //Shows the usernam as soon as the Form Loads/user Control Loads !
        public void Vault_Load(object sender, EventArgs e)
        {
           //Clearing the Rows and upgarde new Data !
            passwordGrid.Rows.Clear();
            //Diplay the currently logged in person !
            usernameForVault.Text = $"{Form1.username}'s Password Vault";
            
            ArrayList nicknames = database.getUserInfoNickName(Form1.username);
            ArrayList emails_username = database.getUserInfoEmailUsername(Form1.username);
            ArrayList passwords = database.getUserInfoPasswords(Form1.username);
            for (int i=0;i<nicknames.Count;i++)
            {
                //A new is created for every new password credential !
                 dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(passwordGrid);
                dataGridViewRow.Cells[0].Value = nicknames[i];
                dataGridViewRow.Cells[1].Value = emails_username[i];
                dataGridViewRow.Cells[2].Value = new DataEncryptPassword().decryptData(passwords[i].ToString());
                //buttons and Label for Delete,Update and Copy !
                dataGridViewRow.Cells[3].Value = "Delete";
                dataGridViewRow.Cells[4].Value = "Copy";
                dataGridViewRow.Cells[5].Value = "Update";
                passwordGrid.Rows.Add(dataGridViewRow);
            }
            
        }
        //Show the Form to Add the User Password Details and the Username/Password !
        private void addPassword_Click(object sender, EventArgs e)
        {
            new AddPasswordToDb().Show();
            
        }
        //used to handle the cell click !

        private void passwordGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==4)
            {
                
                //When the Copy button of the Corresponding row is pressed the password is feteched from the column!
                Clipboard.SetText(passwordGrid[2,e.RowIndex].Value.ToString());
            }
            //If the Delete Cell Option of the Data grid view is Selected then the Corresponding Row will be Deleted Along with the Databse Information !
            if (e.ColumnIndex==3)
            {
                if (database.deleteUserPassword(Form1.username,passwordGrid[0,e.RowIndex].Value.ToString()))
                {
                    passwordGrid.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Password Infomation Deleted !","Deleted !",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something Went Wrong !", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (e.ColumnIndex==5)
            {
                //When the Update option is selected the update pop up come up and you can update the Nickname,password and email
                NickName = passwordGrid[0,e.RowIndex].Value.ToString();
                UpdateUserPass updateUserPass = new UpdateUserPass();
                updateUserPass.Show();
            }
        }
        
       
        //Function to show the passwords as *
        private void passwordGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value!=null && e.ColumnIndex==2)
            {
                e.Value = new string('*',e.Value.ToString().Length);
            }
                    
        }

        private void addPassword_MouseEnter(object sender, EventArgs e)
        {
            addPassword.ForeColor = Color.Black;
            addPassword.BackColor = Color.White;
        }

        private void addPassword_MouseLeave(object sender, EventArgs e)
        {
            addPassword.ForeColor = Color.White;
            addPassword.BackColor = Color.Black;
        }
       
    }
}
