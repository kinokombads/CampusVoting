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
    public class GradeAndSectionBl : IRetrieve<List<GradeAndSectionVm>, GradeAndSectionVm>, IManipulate<GradeAndSectionVm>, IDropDown<GradeAndSectionComboVm>, IResetable
    {
        private readonly GradeAndSectionDal db = new GradeAndSectionDal();
        private ExceptionFound ef = new ExceptionFound();

        public GradeAndSectionVm VmItem { get; set; }

        public GradeAndSectionVm VmParams { get; set; }

        public List<GradeAndSectionVm> ListVm { get; set; }

        public List<GradeAndSectionComboVm> ComboItems { get; set; }

        public bool ChangeOccured { get; set; }


        public GradeAndSectionBl()
        {
            ResetVmItem();
            ResetVmParams();
            ResetVmList();
            ResetCombo();
            ChangeOccured = false;
        }

        public void ResetVmItem()
        {
            VmItem = new GradeAndSectionVm();
        }

        public void ResetVmParams()
        {
            VmParams = new GradeAndSectionVm();
        }

        public void ResetVmList()
        {
            ListVm = new List<GradeAndSectionVm>();
        }

        
        private GradeAndSection MapProperties(GradeAndSectionVm p)
        {
            GradeAndSection baseObj = new GradeAndSection();
            baseObj.Id = p.Id.GetInt();
            baseObj.Title = p.Title.GetString();
            baseObj.GradeId = p.GradeId.GetInt();
            baseObj.SectionId = p.SectionId.GetInt();
            baseObj.CreatedById = p.CreatedById.GetInt();
            baseObj.CreatedOn = p.CreatedOn.GetDateTime();
            baseObj.ModifiedById = p.ModifiedById.GetInt();
            baseObj.ModifiedOn = p.ModifiedOn.GetNullableDateTime();

            return baseObj;
        }
        
        public void MapToViewModel(object item)
        {
            if (item == null) return;
            ResetVmParams();
            VmParams = (GradeAndSectionVm)item;
        }

        
        public List<GradeAndSectionVm> GetList(GradeAndSectionVm p, ref string msg)
        {
            List<GradeAndSectionVm> items = new List<GradeAndSectionVm>();
            DataTable dt = db.GetList(p, ref msg);
            if (msg != "") return new List<GradeAndSectionVm>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    GradeAndSectionVm item = new GradeAndSectionVm();
                    item.Id = row["gradeAndSectionId"].GetString();
                    item.Title = row["title"].GetString();
                    item.GradeId = row["gradeId"].GetString();
                    item.Grade = row["gradeName"].GetString();
                    item.SectionId = row["sectionId"].GetString();
                    item.Section = row["sectionName"].GetString();
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
                return new List<GradeAndSectionVm>();
            }
        }

        public GradeAndSectionVm GetOne(GradeAndSectionVm p, ref string msg)
        {
            try
            {
                return GetList(p, ref msg).Single();
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new GradeAndSectionVm();
            }
        }
       
        public bool AddOne(GradeAndSectionVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotNullOrNotWhiteSpace(viewModel.Title, ref msg) 
                && !EntryChecker.IsNotZeroOrNull(viewModel.GradeId.GetInt(), 
                viewModel.SectionId.GetInt(), ref msg)) return false;

            return db.AddOne(MapProperties(viewModel), ref msg);
        }
        
        public bool EditOne(GradeAndSectionVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotNullOrNotWhiteSpace(viewModel.Title, ref msg)) return false;
            return db.EditOne(MapProperties(viewModel), ref msg);
        }

        public bool DeleteOne(GradeAndSectionVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotZeroOrNull(viewModel.Id.GetInt(), ref msg)) return false;
            return db.DeleteOne(MapProperties(viewModel), ref msg);
        }


        public void ResetCombo()
        {
            ComboItems = new List<GradeAndSectionComboVm>();
        }

        public List<GradeAndSectionComboVm> GetCombo(ref string msg)
        {
            List<GradeAndSectionComboVm> items = new List<GradeAndSectionComboVm>();
            DataTable dt = db.GetList(new GradeAndSectionVm(), ref msg);
            if (msg != "") return new List<GradeAndSectionComboVm>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    GradeAndSectionComboVm item = new GradeAndSectionComboVm();
                    item.Id = row["gradeAndSectionId"].GetString();
                    item.Title = row["title"].GetString();
                    item.GradeId = row["gradeId"].GetString();
                    item.Grade = row["gradeName"].GetString();
                    item.SectionId = row["sectionId"].GetString();
                    item.Section = row["sectionName"].GetString();

                    items.Add(item);
                }

                return items;
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new List<GradeAndSectionComboVm>();
            }
        }
    }
}