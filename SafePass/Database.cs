using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SafePass
{
    class Database
    {
        public Database()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=MySql@2546");
                mySqlConnection.Open();
                if (mySqlConnection.State==System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Connected !");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Connected To DB");
            }
        }
    }
}
