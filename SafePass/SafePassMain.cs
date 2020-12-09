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
    public partial class SafePassMain : Form
    {
        public SafePassMain()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        //Mouse Enter Hover Color Cange for all Buttons !
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            button1.BackColor = Color.White;
        }

        private void vaultBtn_MouseEnter(object sender, EventArgs e)
        {
            vaultBtn.ForeColor = Color.Black;
            vaultBtn.BackColor = Color.White;
        }
        private void passGen_MouseEnter(object sender, EventArgs e)
        {
            passGen.ForeColor = Color.Black;
            passGen.BackColor = Color.White;
        }
        //Button Color change for all Buttons !
        private void passGen_Click(object sender, EventArgs e)
        {

        }
        //Button Color Back to normal when the mouse leaves Events !
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            button1.BackColor = Color.Black;
        }

        private void vaultBtn_MouseLeave(object sender, EventArgs e)
        {
            vaultBtn.ForeColor = Color.White;
            vaultBtn.BackColor = Color.Black;
        }

        private void passGen_MouseLeave(object sender, EventArgs e)
        {
            passGen.ForeColor = Color.White;
            passGen.BackColor = Color.Black;
        }
        //End of Mouse Leave Events !
    }
}
