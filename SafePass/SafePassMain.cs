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
        bool the_mouse_is_down;
        Point offset;
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
            //The User Control for Password Generator will Pop up !
            if (!main_panel.Controls.Contains(PassGen.PasGenInstance))
            {
                main_panel.Controls.Add(PassGen.PasGenInstance);
                PassGen.PasGenInstance.Dock = DockStyle.Fill;
                PassGen.PasGenInstance.BringToFront();
            }
            else
            {
                PassGen.PasGenInstance.BringToFront();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //The User Control for Profile  will Pop up !
            if (!main_panel.Controls.Contains(Profile.ProfileInstance))
            {
                main_panel.Controls.Add(Profile.ProfileInstance);
                Profile.ProfileInstance.Dock = DockStyle.Fill;
                Profile.ProfileInstance.BringToFront();
            }
            else
            {
                Profile.ProfileInstance.BringToFront();
            }
        }
        private void vaultBtn_Click(object sender, EventArgs e)
        {
            //The User Control for Vault will Pop up !
            if (!main_panel.Controls.Contains(Vault.VaultInstance))
            {
                main_panel.Controls.Add(Vault.VaultInstance);
                Vault.VaultInstance.Dock = DockStyle.Fill;
                Vault.VaultInstance.BringToFront();
            }
            else
            {
                Vault.VaultInstance.BringToFront();
            }
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
        //Begining of the Drag Events for the Panel 
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //For Moving the Form, as The Form is Borderless we have to change the positin explicitly!
            if (the_mouse_is_down)
            {
                Point current_point = PointToScreen(e.Location);
                Location = new Point(current_point.X - offset.X, current_point.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            the_mouse_is_down = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //Current Position when mouse is Down
            offset.X = e.X;
            offset.Y = e.Y;
            the_mouse_is_down = true;
        }

        private void SafePassMain_Load(object sender, EventArgs e)
        {
            //The User Control for Profile  will Pop up !
            if (!main_panel.Controls.Contains(Profile.ProfileInstance))
            {
                main_panel.Controls.Add(Profile.ProfileInstance);
                Profile.ProfileInstance.Dock = DockStyle.Fill;
                Profile.ProfileInstance.BringToFront();
            }
            else
            {
                Profile.ProfileInstance.BringToFront();
            }
        }
    }
}
