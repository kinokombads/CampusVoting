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
    public class SchoolYearBl : IRetrieve<List<SchoolYearVm>, SchoolYearVm>, IManipulate<SchoolYearVm>, IDropDown<SchoolYearComboVm, SchoolYearVm>, IResetable
    {
         private readonly SchoolYearDal db = new SchoolYearDal();
        private ExceptionFound ef = new ExceptionFound();

        public SchoolYearVm VmItem { get; set; }

        public SchoolYearVm VmParams { get; set; }

        public List<SchoolYearVm> ListVm { get; set; }

        public List<SchoolYearComboVm> ComboItems { get; set; }

        public bool ChangeOccured { get; set; }


        public SchoolYearBl()
        {
            ResetVmItem();
            ResetVmParams();
            ResetVmList();
            ResetCombo();
            ChangeOccured = false;
        }

        public void ResetVmItem()
        {
            VmItem = new SchoolYearVm();
        }

        public void ResetVmParams()
        {
            VmParams = new SchoolYearVm();
        }

        public void ResetVmList()
        {
            ListVm = new List<SchoolYearVm>();
        }
        

        private SchoolYear MapProperties(SchoolYearVm p)
        {
            SchoolYear baseObj = new SchoolYear();
            baseObj.Id = p.Id.GetInt();
            baseObj.Title = p.Title.GetString();
            baseObj.Details = p.Details.GetString();
            baseObj.Active = p.Active.GetBool();
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
            VmParams = (SchoolYearVm)item;
        }

        
        public List<SchoolYearVm> GetList(SchoolYearVm p, ref string msg)
        {
            List<SchoolYearVm> items = new List<SchoolYearVm>();
            DataTable dt = db.GetList(MapProperties(p), ref msg);
            if (msg != "") return new List<SchoolYearVm>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    SchoolYearVm item = new SchoolYearVm();
                    item.Id = row["SchoolYearId"].GetString();
                    item.Title = row["title"].GetString();
                    item.Active = row["active"].GetString();
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
                return new List<SchoolYearVm>();
            }
        }

        public SchoolYearVm GetOne(SchoolYearVm p, ref string msg)
        {
            try
            {
                return GetList(p, ref msg).Single();
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new SchoolYearVm();
            }
        }
       
        public bool AddOne(SchoolYearVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotNullOrNotWhiteSpace(viewModel.Title, ref msg)) return false;
            return db.AddOne(MapProperties(viewModel), ref msg);
        }
        
        public bool EditOne(SchoolYearVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotNullOrNotWhiteSpace(viewModel.Title, ref msg)) return false;
            return db.EditOne(MapProperties(viewModel), ref msg);
        }

        public bool DeleteOne(SchoolYearVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotZeroOrNull(viewModel.Id.GetInt(), ref msg)) return false;
            return db.DeleteOne(MapProperties(viewModel), ref msg);
        }


        public void ResetCombo()
        {
            ComboItems = new List<SchoolYearComboVm>();
        }

        public List<SchoolYearComboVm> GetCombo(SchoolYearVm p, ref string msg)
        {
            List<SchoolYearComboVm> items = new List<SchoolYearComboVm>();
            DataTable dt = db.GetList(MapProperties(p), ref msg);
            if (msg != "") return new List<SchoolYearComboVm>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    SchoolYearComboVm item = new SchoolYearComboVm();
                    item.Id = row["schoolYearId"].GetString();
                    item.Title = row["title"].GetString();
                    item.Details = row["details"].GetString();

                    items.Add(item);
                }

                return items;
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new List<SchoolYearComboVm>();
            }
        }
    }
}