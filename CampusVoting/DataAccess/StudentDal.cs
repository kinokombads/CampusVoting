using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampusVoting.Helpers;
using CampusVoting.Models;
using CampusVoting.ViewModels;
using MySql.Data.MySqlClient;
using Vota.Helpers;

namespace CampusVoting.DataAccess
{
    public class StudentDal
    {
        readonly ExceptionFound ef = new ExceptionFound();

        public List<StudentVm> GetList(StudentVm p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "GetStudents";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("intId", p.Id.GetInt()).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("strLrn", p.Lrn).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("strLastName", p.LastName).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("strFirstName", p.FirstName).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("strMiddleName", p.MiddleName).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("strSectionName", p.SectionName).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("strGradeName", p.GradeName).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("strCurrentSectionName", p.CurrentSectionName).Direction = ParameterDirection.Input;

            List<StudentVm> items = new List<StudentVm>();
            DataTable dt = MyHelper.GetData(command, ref msg);
            try
            {
                if (dt.Rows.Count <= 0) return items;
                foreach (DataRow row in dt.Rows)
                {
                    StudentVm item = new StudentVm();
                    item.Id = row["StudentId"].GetString();
                    item.Lrn = row["Lrn"].GetString();item.LastName = row["LastName"].GetString();
                    item.FirstName = row["FirstName"].GetString();
                    item.MiddleName = row["MiddleName"].GetString();
                    item.GradeId = row["Id"].GetString();
                    item.GradeName = row["GradeName"].GetString();
                    item.SectionId = row["Id"].GetString();
                    item.SectionName = row["SectionName"].GetString();
                    item.CurrentGradeAndSectionId = row["Id"].GetString();
                    item.CurrentSectionName = row["CurrentSectionName"].GetString();
                    
                    items.Add(item);
                }

                return items;

            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new List<StudentVm>();
            }
        }

        public StudentVm GetOne(StudentVm p, ref string msg)
        {
            try
            {
                var x = GetList(p, ref msg).Single();
                return x;
            }
            catch (Exception)
            {
                return new StudentVm();
            }
        }

        public bool AddOne(Student p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "AddStudent";
            command.CommandType = CommandType.StoredProcedure;

            //command.Parameters.AddWithValue("strTitle", p.Title).Direction = ParameterDirection.Input;
            //command.Parameters.AddWithValue("strDetails", p.Details).Direction = ParameterDirection.Input;
            //command.Parameters.AddWithValue("intCreatedById", p.CreatedById).Direction = ParameterDirection.Input;
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

        public bool EditOne(Student p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "EditStudent";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("intId", p.Id).Direction = ParameterDirection.Input;
            //command.Parameters.AddWithValue("strTitle", p.Title).Direction = ParameterDirection.Input;
            //command.Parameters.AddWithValue("strDetails", p.Details).Direction = ParameterDirection.Input;
            //command.Parameters.AddWithValue("intModifiedById", p.ModifiedById).Direction = ParameterDirection.Input;
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

        public bool DeleteOne(Student p, ref string msg)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DeleteStudent";
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
