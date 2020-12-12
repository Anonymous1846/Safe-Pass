﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SafePass
{
    class Database
    {
        MySqlConnection mySqlConnection;
        public Database()
        {
            try
            {
                mySqlConnection = new MySqlConnection("datasource=localhost;port=3306;database=safepass;username=root;password=MySql@2546");
                mySqlConnection.Open();
                if (mySqlConnection.State==System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Connected to DB !");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An Error Occured While Connecting To DB");
            }
            
           
        }
        //Method to Delete Teh user From the Data base !
        public Boolean deleteuser(string username)
        {
            String sql_for_delete = "delete from users where username = '"+username+"'";
            using (MySqlCommand mySqlCommand = new MySqlCommand(sql_for_delete, mySqlConnection))
            {
               
                    return mySqlCommand.ExecuteNonQuery()==1;
                
            }
        }

        //Selecting the User from the Database and also used to check whether the user is present in the 
        //Db so that it is to be decided whether he/she is to be added or not !
        public Boolean checkForUser(String username)
        {
            bool flag = false;
            
            using (MySqlCommand mySqlCommandForReading = new MySqlCommand("select * from users where username ='" + username + "'", mySqlConnection))
            {
                using (var usernameReader = mySqlCommandForReading.ExecuteReader())
                {
                    if (usernameReader.Read())
                    {
                        flag = true;
                    }
                }
            }
            return flag;
        }
        //Authenticate the user by first checking the username and then checking the password whether they match or not !
       
        public Boolean authForUser(String username,String password)
        {
            Boolean flag = false;
            
            using (MySqlCommand mySqlCommandForReading = new MySqlCommand("select * from users where username ='" + username + "' and password='"+password+"'", mySqlConnection))
            {
                using (var usernameReader = mySqlCommandForReading.ExecuteReader())
                {
                    if (usernameReader.Read())
                    {
                        flag = true;
                    }
                }
            }
            return flag;
        }
        //Adding the User Details to The database !
        public Boolean addUserToDatabase(String username,String email,String password,String timeStamp)
        {
            bool flag = false;
            String sql_for_insert = "INSERT INTO users(username,email,password,time_stamp) VALUES ('"+username+"', '"+email+"', '"+password+"', '"+timeStamp+"')";
            using (MySqlCommand mySqlCommand=new MySqlCommand(sql_for_insert,mySqlConnection))
            {
                if (mySqlCommand.ExecuteNonQuery()==1)
                {
                    return true;
                }
            }
                return flag;
        }
        //getting the User credentials like Password, email, and username !
        public String [] getUserInformation(String username)
        {
            String[] userinfo = new string[4];
            using (MySqlCommand mySqlCommandForReading = new MySqlCommand("select * from users where username ='" + username+"'", mySqlConnection))
            {
                using (var usernameReader = mySqlCommandForReading.ExecuteReader())
                {
                    while (usernameReader.Read())
                    {
                        userinfo[0] = usernameReader.GetString(0);
                        userinfo[1] = usernameReader.GetString(1);
                        userinfo[2] = usernameReader.GetString(2);
                        userinfo[3] = usernameReader.GetString(3);
                    }
                }
            }
            return userinfo;
        }
        //Updating the User Credentials !
        public Boolean updateUser(String username, String email, String password, String timeStamp)
        {
            bool flag = false;
            String sql_for_update = "UPDATE users SET  email='"+email+"', password='"+password+"', time_stamp ='"+timeStamp+"' where username='"+username+"'";
            using (MySqlCommand mySqlCommand = new MySqlCommand(sql_for_update, mySqlConnection))
            {
                if (mySqlCommand.ExecuteNonQuery() == 1)
                {
                    return true;
                }
            }
            return flag;
        }
        //Code to add the User Data(Website Pasword to the Database ! the Table name is user_passwords)
        public Boolean addUserPasswordToDatabase(String username,String nickname, String email_username, String password, String timeStamp)
        {
            bool flag = false;
            String sql_for_insert = "INSERT INTO user_passwords(username,nickname,email_username,password,time_stamp) VALUES ('" + username + "','"+nickname+"' , '" + email_username + "', '" + password + "', '" + timeStamp + "')";
            using (MySqlCommand mySqlCommand = new MySqlCommand(sql_for_insert, mySqlConnection))
            {
                if (mySqlCommand.ExecuteNonQuery() == 1)
                {
                    return true;
                }
            }
            return flag;
        }
    }
}
