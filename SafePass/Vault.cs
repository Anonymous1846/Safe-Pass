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
        }
        //Shows the usernam as soon as the Form Loads/user Control Loads !
        private void Vault_Load(object sender, EventArgs e)
        {
            usernameForVault.Text = $"{Form1.username}'s Password Vault";
            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow.CreateCells(passwordGrid);
            ArrayList array = new Database().getUserInfo(Form1.username);
            
            for (int i=0;i<array.Count;i++)
            {
                dataGridViewRow.Cells[0].Value = array[i];
                dataGridViewRow.Cells[1].Value = array[i];
                dataGridViewRow.Cells[2].Value = array[i];
                dataGridViewRow.Cells[3].Value = "Toggle";
                dataGridViewRow.Cells[4].Value = "Copy";
            }
            passwordGrid.Rows.Add(dataGridViewRow);
        }
        //Show the Form to Add the User Password Details and the Username/Password !
        private void addPassword_Click(object sender, EventArgs e)
        {
            new AddPasswordToDb().Show();
        }
    }
}
