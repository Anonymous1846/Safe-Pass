using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafePass
{
    class User
    {
        private String username, email, password;
        public User(String username,String email,String password)
        {
            this.username = username;
            this.email = email;
            this.password = password;
        }
        public String getUsername()
        {
            return username;
        }
        public String getPassword()
        {
            return password;
        }
        public String getEmail()
        {
            return email;
        }
    }
}
