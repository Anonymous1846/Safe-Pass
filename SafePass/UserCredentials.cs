using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafePass
{
    class UserCredentials
    {
        String nickname, email_username, password;
        public UserCredentials(String nickname,String email_username,String password)
        {
            this.nickname = nickname;
            this.email_username = email_username;
            this.password = password;
        }
       public String getNickName() { return nickname; }
        public String getEmailUsername() { return email_username; }
        public String getPassword() { return password; }

    }
}
