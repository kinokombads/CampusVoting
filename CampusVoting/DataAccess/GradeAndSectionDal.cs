using System;
using System.Data;
using CampusVoting.Helpers;
using CampusVoting.Models;
using MySql.Data.MySqlClient;

namespace CampusVoting.DataAccess
{
    public class GradeAndSectionAndSectionDal
    {
        readonly ExceptionFound ef = new ExceptionFound();

        public DataTable GetList(GradeAndSection p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "GetGradeAndSections";
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

        public bool AddOne(GradeAndSection p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "AddGradeAndSection";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("strTitle", p.Title).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("intGradeId", p.GradeId).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("intSectionId", p.SectionId).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("intCreatedById", p.CreatedById).Direction = ParameterDirection.Input;
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

        public bool EditOne(GradeAndSection p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "EditGradeAndSection";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("intId", p.Id).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("strTitle", p.Title).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("intGradeId", p.GradeId).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("intSectionId", p.SectionId).Direction = ParameterDirection.Input;
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

        public bool DeleteOne(GradeAndSection p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DeleteGradeAndSection";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("intGradeAndSectionId", p.Id).Direction = ParameterDirection.Input;

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