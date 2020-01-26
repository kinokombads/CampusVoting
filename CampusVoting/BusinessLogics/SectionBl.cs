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
    public class SectionBl : IRetrieve<List<SectionVm>, SectionVm>, IManipulate<SectionVm>, IDropDown<SectionComboVm, SectionVm>, IResetable
    {
        private readonly SectionDal db = new SectionDal();
        private ExceptionFound ef = new ExceptionFound();

        public SectionVm VmItem { get; set; }

        public SectionVm VmParams { get; set; }

        public List<SectionVm> ListVm { get; set; }

        public List<SectionComboVm> ComboItems { get; set; }

        public bool ChangeOccured { get; set; }


        public SectionBl()
        {
            ResetVmItem();
            ResetVmParams();
            ResetVmList();
            ResetCombo();
            ChangeOccured = false;
        }

        public void ResetVmItem()
        {
            VmItem = new SectionVm();
        }

        public void ResetVmParams()
        {
            VmParams = new SectionVm();
        }

        public void ResetVmList()
        {
            ListVm = new List<SectionVm>();
        }
        
        

        private Section MapProperties(SectionVm p)
        {
            Section baseObj = new Section();
            baseObj.Id = p.Id.GetInt();
            baseObj.Title = p.Title.GetString();
            baseObj.Details = p.Details.GetString();
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
            VmParams = (SectionVm)item;
        }
        
        public List<SectionVm> GetList(SectionVm p, ref string msg)
        {
            List<SectionVm> items = new List<SectionVm>();
            DataTable dt = db.GetList(MapProperties(p), ref msg);
            if (msg != "") return new List<SectionVm>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    SectionVm item = new SectionVm();
                    item.Id = row["sectionId"].GetString();
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
                return new List<SectionVm>();
            }
        }

        public SectionVm GetOne(SectionVm p, ref string msg)
        {
            try
            {
                return GetList(p, ref msg).Single();
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new SectionVm();
            }
        }
       
        public bool AddOne(SectionVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotNullOrNotWhiteSpace(viewModel.Title, ref msg)) return false;
            return db.AddOne(MapProperties(viewModel), ref msg);
        }
        
        public bool EditOne(SectionVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotNullOrNotWhiteSpace(viewModel.Title, ref msg)) return false;
            return db.EditOne(MapProperties(viewModel), ref msg);
        }

        public bool DeleteOne(SectionVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotZeroOrNull(viewModel.Id.GetInt(), ref msg)) return false;
            return db.DeleteOne(MapProperties(viewModel), ref msg);
        }


        public void ResetCombo()
        {
            ComboItems = new List<SectionComboVm>();
        }

        public List<SectionComboVm> GetCombo(SectionVm p, ref string msg)
        {
            List<SectionComboVm> items = new List<SectionComboVm>();
            DataTable dt = db.GetList(MapProperties(p), ref msg);
            if (msg != "") return new List<SectionComboVm>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    SectionComboVm item = new SectionComboVm();
                    item.Id = row["sectionId"].GetString();
                    item.Title = row["title"].GetString();
                    item.Details = row["details"].GetString();

                    items.Add(item);
                }

                return items;
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new List<SectionComboVm>();
            }
        }
 
    }
}