using System;
using System.Data;
using CampusVoting.Helpers;
using CampusVoting.Models;
using MySql.Data.MySqlClient;

namespace CampusVoting.DataAccess
{
    public class GradeDal : IRetrieve<DataTable, Grade>, IManipulate<Grade>
    {
        readonly ExceptionFound ef = new ExceptionFound();

        public DataTable GetList(Grade p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "GetGrades";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("intId", p.Id).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("strTitle", p.Title).Direction = ParameterDirection.Input;
            
            DataTable dt = MyHelper.GetData(command, ref msg);
            try
            {
                return dt.Rows.Count <= 0 ? new DataTable() : dt;
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new DataTable();
            }
        }
        
        public bool AddOne(Grade p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "AddGrade";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("strTitle", p.Title).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("strDetails", p.Details).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("intCreatedById", p.CreatedById).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("itExists", MySqlDbType.Bit).Direction = ParameterDirection.Output;

            try
            {
                MyHelper.ExecuteNonQuery(command, ref msg);
                if ((int) command.Parameters["itExists"].Value == 0) return true;
                msg = msg + "\nThis item is already in the database";
                return false;
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return false;
            }

        }

        public bool EditOne(Grade p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "EditGrade";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("intId", p.Id).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("strTitle", p.Title).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("strDetails", p.Details).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("intModifiedById", p.ModifiedById).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("itExists", MySqlDbType.Bit).Direction = ParameterDirection.Output;

            try
            {
                MyHelper.ExecuteNonQuery(command, ref msg);
                if ((int)command.Parameters["itExists"].Value == 0) return true;
                msg = msg + "\nThis item is already in the database";
                return false;
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return false;
            }
        }

        public bool DeleteOne(Grade p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DeleteGrade";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("intId", p.Id).Direction = ParameterDirection.Input;

            try
            {
                return MyHelper.ExecuteNonQuery(command, ref msg);
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return false;
            }
        }
        
    }
}
