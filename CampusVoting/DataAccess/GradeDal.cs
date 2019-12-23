using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using CampusVoting.Helpers;
using CampusVoting.Models;
using CampusVoting.ViewModels;
using MySql.Data.MySqlClient;
using Vota.Helpers;

namespace CampusVoting.DataAccess
{
    public class GradeDal
    {
        readonly ExceptionFound ef = new ExceptionFound();

        public List<Grade> GetList(Grade p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "GetGrades";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("intId", p.Id.GetInt()).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("strTitle", p.Title).Direction = ParameterDirection.Input;

            List<Grade> items = new List<Grade>();
            DataTable dt = MyHelper.GetData(command, ref msg);
            try
            {
                if (dt.Rows.Count <= 0) return items;
                foreach (DataRow row in dt.Rows)
                {
                    Grade item = new Grade();
                    item.Id = row["gradeId"].GetInt();
                    item.Title = row["title"].GetString();
                    item.Details = row["details"].GetString();
                    item.CreatedById = row["createdById"].GetInt();
                    item.CreatedByName = row["createdByName"].GetString();
                    item.CreatedOn = row["createdOn"].GetDateTime();
                    item.ModifiedById = row["modifiedById"].GetInt();
                    item.ModifiedByName = row["modifiedByName"].GetString();
                    item.ModifiedOn = row["modifiedOn"].GetNullableDateTime();
                    

                    items.Add(item);
                }

                return items;

            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new List<Grade>();
            }
        }

        public Grade GetOne(Grade p, ref string msg)
        {
            try
            {
                var x = GetList(p, ref msg).Single();
                return x;
            }
            catch (Exception)
            {
                return new Grade();
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
            command.Parameters.AddWithValue("intUserId", p.ModifiedById).Direction = ParameterDirection.Input;

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
