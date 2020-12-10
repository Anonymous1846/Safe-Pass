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

        
    }
}
