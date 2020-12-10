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
        private String username;
        Database database;
        String usernameLabel, email, lastTime;
        public static Profile ProfileInstance {
            get
            {
                if (profileInstance == null)
                
                    profileInstance = new Profile();
                    return profileInstance;
                
            }
        }
        public Profile()
        {
            InitializeComponent();
        }
      

        private void startTimer_Tick(object sender, EventArgs e)
        {
            currTime.Text = $"Current System Time: {DateTime.Now.ToString()}";
        }
    }
}
