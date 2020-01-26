using System;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace CampusVoting.Helpers
{
    public static class MyHelper
    {
        private static string ConString = ConfigurationManager.ConnectionStrings["VoteContext"].ConnectionString;
        private const int ComTym = 500;
       
        

        public static DataTable GetData(MySqlCommand command, ref string msg)
        {
            MySqlConnection conn = new MySqlConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                conn.ConnectionString = ConString;
                command.CommandTimeout = ComTym;
                command.Connection = conn;    
                adapter.SelectCommand = command;
                adapter.Fill(dt);

                return dt;
                    
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    msg = string.Format("Conn Error: {0} \nConn Inner Error: {1}", ex.Message, ex.InnerException.Message);
                }
                else
                {
                    msg = string.Format("Conn Error: {0}", ex.Message);
                }
                
                return new DataTable();
            }

        }

        public static bool ExecuteNonQuery(MySqlCommand command, ref string msg)
        {
            MySqlConnection con = new MySqlConnection();

            try
            {
                con.ConnectionString = ConString;
                command.CommandTimeout = ComTym;

                con.Open();
                command.Connection = con;
                var rowsAffected = command.ExecuteNonQuery();

                return rowsAffected.GetBool();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    msg = string.Format("Conn Error: {0} \nConn Inner Error: {1}", ex.Message, ex.InnerException.Message);
                }
                else
                {
                    msg = string.Format("Conn Error: {0}", ex.Message);
                }

                return false;
            }
        }
    }
}
