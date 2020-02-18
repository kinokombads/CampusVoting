using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using CampusVoting.DataAccess;
using CampusVoting.Helpers;
using CampusVoting.Models;
using CampusVoting.ViewModels;

namespace CampusVoting.BusinessLogics
{
    public class StudentBl
    {
        private readonly StudentDal db = new StudentDal();
        private ExceptionFound ef = new ExceptionFound();
        private GradeAndSectionBl gasBl = new GradeAndSectionBl();

        public StudentVm VmItem { get; set; }

        public StudentVm VmParams { get; set; }

        public List<StudentVm> ListVm { get; set; }
        
        public bool ChangeOccured { get; set; }


        public StudentBl()
        {
            ResetVmItem();
            ResetVmParams();
            ResetVmList();
            
            ChangeOccured = false;
        }

        public void ResetVmItem()
        {
            VmItem = new StudentVm();
        }

        public void ResetVmParams()
        {
            VmParams = new StudentVm();
        }

        public void ResetVmList()
        {
            ListVm = new List<StudentVm>();
        }

        private int LoadGradeAndSections(string grade, string section)
        {
            string msgs = "";
            gasBl.VmParams.Grade = grade;
            gasBl.VmParams.Section = section;
            return gasBl.GetOne(gasBl.VmParams, ref msgs).Id.GetInt();
        }

        private Student MapProperties(StudentVm p)
        {
            
            Student baseObj = new Student();
            baseObj.Id = p.Id.GetInt();
            baseObj.Lrn = p.LRN.GetString();
            baseObj.LastName = p.LastName.GetString();
            baseObj.FirstName = p.FirstName.GetString();
            baseObj.MiddleName = p.MiddleName.GetString();
            baseObj.GradeAndSectionId = LoadGradeAndSections(p.Grade, p.Section);
            baseObj.SchoolYearId = p.SchoolYearId.GetInt();
            
            return baseObj;
        }
        
        public void MapToViewModel(object item)
        {
            if (item == null) return;
            ResetVmParams();
            VmParams = (StudentVm)item;
        }

        
        public List<StudentVm> GetList(StudentVm p, ref string msg)
        {
            List<StudentVm> items = new List<StudentVm>();
            DataTable dt = db.GetList(MapProperties(p), ref msg);
            if (msg != "") return new List<StudentVm>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    StudentVm item = new StudentVm();
                    item.Id = row["studentId"].GetString();
                    item.Title = row["title"].GetString();
                    item.Details = row["details"].GetString();
                    item.CreatedById = row["createdById"].GetString();
                    item.CreatedBy = row["createdByName"].GetString();
                    item.CreatedOn = row["createdOn"].GetDateTime().GetString();
                    item.ModifiedById = row["modifiedById"].GetString();
                    item.ModifiedBy = row["modifiedByName"].GetString();
                    item.ModifiedOn = row["modifiedOn"].GetNullableDateTime().GetString();

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
                return GetList(p, ref msg).Single();
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new StudentVm();
            }
        }
       
        public bool AddOne(StudentVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotNullOrNotWhiteSpace(viewModel.Title, ref msg)) return false;
            return db.AddOne(MapProperties(viewModel), ref msg);
        }
        
        public bool EditOne(StudentVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotNullOrNotWhiteSpace(viewModel.Title, ref msg)) return false;
            return db.EditOne(MapProperties(viewModel), ref msg);
        }

        public bool DeleteOne(StudentVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotZeroOrNull(viewModel.Id.GetInt(), ref msg)) return false;
            return db.DeleteOne(MapProperties(viewModel), ref msg);
        }



        
    }
}