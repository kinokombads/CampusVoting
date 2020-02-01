using System;
using System.Data;
using CampusVoting.Helpers;
using CampusVoting.Models;
using CampusVoting.ViewModels;
using MySql.Data.MySqlClient;

namespace CampusVoting.DataAccess
{
    public class VoterClearanceDal : IRetrieve<DataTable, VoterClearanceVm>, IManipulate<VoterClearance>
    {
        readonly ExceptionFound ef = new ExceptionFound();


        public DataTable GetList(VoterClearanceVm p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "GetVoterClearances";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("intId", p.Id.GetInt()).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("strPosition", p.Position).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("strGrade", p.Grade).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("boolActive", p.Active).Direction = ParameterDirection.Input;


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

        public bool AddOne(VoterClearance p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "AddVoterClearance";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("intGradeId", p.GradeId).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("intPositionId", p.PositionId).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("boolActive", p.Active).Direction = ParameterDirection.Input;
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

        public bool EditOne(VoterClearance p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "EditVoterClearance";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("intId", p.Id).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("intGradeId", p.GradeId).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("intPositionId", p.PositionId).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("boolActive", p.Active).Direction = ParameterDirection.Input;
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

        public bool DeleteOne(VoterClearance p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DeleteVoterClearance";
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