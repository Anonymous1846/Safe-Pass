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
    public partial class Form1 : Form
    {
        bool is_mouse_down;
        Point offset;
        public Form1()
        {
            InitializeComponent();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //Current Position when mouse is Down
            offset.X = e.X;
            offset.Y = e.Y;
            is_mouse_down = true;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            //When The Mouse is Up
            is_mouse_down = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            //For Moving the Form, as The Form is Borderless we have to change the positin explicitly!
            if (is_mouse_down)
            {
                Point current_point = PointToScreen(e.Location);
                Location = new Point(current_point.X - offset.X, current_point.Y - offset.Y);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Equals(String.Empty))
            {
                usernameError.Text = "Username Not Entered";
            }
            if (passwordTextBox.Text.Equals(String.Empty))
            {
               passError.Text = "Password Not Entered";
            }
            if (!usernameTextBox.Text.Equals(String.Empty)&&!passwordTextBox.Text.Equals(String.Empty))
            {
                
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            passError.Text = "";
        }

        private void usernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            usernameError.Text = "";
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {

            SignUp signUp= new SignUp();    //Create the New Form Object
            this.Hide();    //Hide the Old Form
            signUp.ShowDialog();    //Show the New Form
            this.Close();
        }
    }
}
