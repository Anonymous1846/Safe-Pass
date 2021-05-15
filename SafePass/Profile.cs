using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafePass
{
    public partial class Profile : UserControl
    {
        private static Profile profileInstance;
       
        Database database;
        String username, email, lastTime;
        public static Profile ProfileInstance {
            get
            {
                //if the profile User control instance is not created then new one is created !
                if (profileInstance == null)
                
                    profileInstance = new Profile();
                    return profileInstance;
                
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            //When The Profile is Loaded for the first time the user Information is Displayed !
            emailLabel.Text = email;
            //Last Time He/She Updated the Profile !
            lastUpdate.Text = lastTime;
            //Name of the Logged in User !
            
            userProfileInfo.Text = $"{username} Profile Information.";
        }

        private void editBtn_MouseEnter(object sender, EventArgs e)
        {
            editBtn.ForeColor = Color.Black;
            editBtn.BackColor = Color.White;
        }

        private void editBtn_MouseLeave(object sender, EventArgs e)
        {
            editBtn.ForeColor = Color.White;
            editBtn.BackColor = Color.Black;
        }
        //Opening the Form for Updating the User Information !
        private void editBtn_Click(object sender, EventArgs e)
        {
       //Opens the Profile Edit Option Without Closing The Current Application !
            EdituserProfile edituserProfile = new EdituserProfile();
            
            edituserProfile.ShowDialog();

        }
        //when the user clicks this btn, the parent form of the widget closes and login form is invoked !
        private void logBtn_Click(object sender, EventArgs e)
        {

            System.Environment.Exit(0);
            
        }

        private void logBtn_MouseLeave(object sender, EventArgs e)
        {
            logBtn.ForeColor = Color.White;
            logBtn.BackColor = Color.Black;
        }

        private void logBtn_MouseEnter(object sender, EventArgs e)
        {
            logBtn.ForeColor = Color.Black;
            logBtn.BackColor = Color.White;
        }

        public Profile()
        {
            InitializeComponent();
            database = new Database();
            //Getting the Username, Email and Last Updation Information !
            username = database.getUserInformation(Form1.username)[0];
            email = database.getUserInformation(Form1.username)[1];
            lastTime = database.getUserInformation(Form1.username)[3];
        }
      

        private void startTimer_Tick(object sender, EventArgs e)
        {
            //Updating the time at an interval of 100 milliseconds !
            currTime.Text = $"Current System Time: {DateTime.Now.ToString()}";
        }
    }
}
