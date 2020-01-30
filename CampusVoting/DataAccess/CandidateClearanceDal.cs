using System;
using System.Data;
using CampusVoting.Helpers;
using CampusVoting.Models;
using CampusVoting.ViewModels;
using MySql.Data.MySqlClient;

namespace CampusVoting.DataAccess
{
    public class CandidateClearanceDal : IRetrieve<DataTable, CandidateClearanceVm>, IManipulate<CandidateClearanceVm>
    {
        readonly ExceptionFound ef = new ExceptionFound();


        public DataTable GetList(CandidateClearanceVm p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "GetCandidateClearances";
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

        public bool AddOne(CandidateClearanceVm p, ref string msg)
        {
            throw new System.NotImplementedException();
        }

        public bool EditOne(CandidateClearanceVm p, ref string msg)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteOne(CandidateClearanceVm p, ref string msg)
        {
            throw new System.NotImplementedException();
        }
    }
}