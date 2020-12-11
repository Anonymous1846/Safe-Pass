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
    }
}
