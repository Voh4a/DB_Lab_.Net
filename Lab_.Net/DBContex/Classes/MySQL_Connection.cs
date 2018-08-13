using MySql.Data.MySqlClient;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContex.Classes
{
    public class MySQL_Connection
    {
        const string ConnectionString = "server=localhost;database=DB_4;user id=root;password=root;sslmode=None";
        
        public MySqlConnection MySqlConnect { get; set; }

        public MySQL_Connection()
        {
            try
            {
                //Console.WriteLine(ConnectionString);
                MySqlConnect = new MySqlConnection(ConnectionString);
                MySqlConnect.Open();
                //Console.WriteLine("Connection successful!");
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server");
                        Console.WriteLine(ex.Message);
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                    default:
                        Console.WriteLine(ex.Message);
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
