using System;
using System.Data;
using CampusVoting.Helpers;
using CampusVoting.Models;
using CampusVoting.ViewModels;
using MySql.Data.MySqlClient;

namespace CampusVoting.DataAccess
{
    public class CandidateClearanceDal : IRetrieve<DataTable, CandidateClearanceVm>, IManipulate<CandidateClearance>
    {
        readonly ExceptionFound ef = new ExceptionFound();


        public DataTable GetList(CandidateClearanceVm p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "GetCandidateClearances";
            command.CommandType = CommandType.StoredProcedure;

            //command.Parameters.AddWithValue("intId", p.Id.GetInt()).Direction = ParameterDirection.Input;
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

        public bool AddOne(CandidateClearance p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "AddCandidateClearance";
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

        public bool EditOne(CandidateClearance p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "EditCandidateClearance";
            command.CommandType = CommandType.StoredProcedure;

            //command.Parameters.AddWithValue("intId", p.Id).Direction = ParameterDirection.Input;
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

        public bool DeleteOne(CandidateClearance p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DeleteCandidateClearance";
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