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
        //Boolean value to check whether the mouse key is pressed or not !
        bool is_mouse_down;
        //To record the current point/location
        Point offset;
        public Form1()
        {
            InitializeComponent();
        }

     
        //Close Button Action !
        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        //to record the current position of the panel/Form when th mouse is pressed down !
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
        //The position will be updated as soon as the mouse is dragged !
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
            //If Either password or Username is Empty of Both are empty then, red Label will show, to fill the information !
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
                SafePassMain safePassMain = new SafePassMain();
                this.Hide();
                safePassMain.ShowDialog();
                this.Close();
            }
        }
        //When the password textbox is invoked the warning will go 
        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            passError.Text = "";
        }
        //When the username textbox is invoked the warning will go 
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

        //Starting of the Login Button color change !
        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            //When the Mouse leaves the Button, the Color of the Button comes back to normal
            loginBtn.ForeColor = Color.White;
            loginBtn.BackColor = Color.Black;
        }

        private void loginBtn_MouseHover(object sender, EventArgs e)
        {
            //When the mouse enters the Button area, the Color Chnages to white(Back) and foreground to Black
            loginBtn.ForeColor = Color.Black;
            loginBtn.BackColor = Color.White;
           
        }
        
        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            //Instant Color Change For Button 
            loginBtn.ForeColor = Color.Black;
            loginBtn.BackColor = Color.White;
        }

        //End of Hover Color Change for The Login Button !
    }
}
