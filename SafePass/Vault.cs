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

namespace SafePass
{
    public partial class Vault : UserControl
    {
        DataView dataviewForSearch;
        Database database;
        private static Vault vaultInstance;
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
        private void Vault_Load(object sender, EventArgs e)
        {
            passwordGrid.Rows.Clear();
            usernameForVault.Text = $"{Form1.username}'s Password Vault";
            DataEncryptPassword data = new DataEncryptPassword();
            ArrayList nicknames = database.getUserInfoNickName(Form1.username);
            ArrayList emails_username = database.getUserInfoEmailUsername(Form1.username);
            ArrayList passwords = database.getUserInfoPasswords(Form1.username);
            for (int i=0;i<nicknames.Count;i++)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(passwordGrid);
                dataGridViewRow.Cells[0].Value = nicknames[i];
                dataGridViewRow.Cells[1].Value = emails_username[i];
                dataGridViewRow.Cells[2].Value = data.decryptData(passwords[i].ToString());
                
                dataGridViewRow.Cells[3].Value = "Toggle";
                dataGridViewRow.Cells[4].Value = "Copy";
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
        }

        private void searchNickName_TextChanged(object sender, EventArgs e)
        {
            dataviewForSearch = passwordGrid.D
            dataviewForSearch.RowFilter = String.Format("nickname like '%{0}%'",searchNickName.Text);
            passwordGrid.DataSource = dataviewForSearch.ToTable();
        }
    }
}
