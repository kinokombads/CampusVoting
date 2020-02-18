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
    public class CampaignGroupBl : IRetrieve<List<CampaignGroupVm>, CampaignGroupVm>, IManipulate<CampaignGroupVm>, IResetable
    {
         private readonly CampaignGroupDal db = new CampaignGroupDal();
        private ExceptionFound ef = new ExceptionFound();

        public CampaignGroupVm VmItem { get; set; }

        public CampaignGroupVm VmParams { get; set; }

        public List<CampaignGroupVm> ListVm { get; set; }

        public List<CampaignGroupComboVm> ComboItems { get; set; }

        public bool ChangeOccured { get; set; }


        public CampaignGroupBl()
        {
            ResetVmItem();
            ResetVmParams();
            ResetVmList();
            ResetCombo();
            ChangeOccured = false;
        }

        public void ResetVmItem()
        {
            VmItem = new CampaignGroupVm();
        }

        public void ResetVmParams()
        {
            VmParams = new CampaignGroupVm();
        }

        public void ResetVmList()
        {
            ListVm = new List<CampaignGroupVm>();
        }
        

        private CampaignGroup MapProperties(CampaignGroupVm p)
        {
            CampaignGroup baseObj = new CampaignGroup();
            baseObj.Id = p.Id.GetInt();
            baseObj.Title = p.Title.GetString();
            baseObj.Details = p.Details.GetString();
            baseObj.SchoolYearId = p.SchoolYearId.GetInt();
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
            VmParams = (CampaignGroupVm)item;
        }

        
        public List<CampaignGroupVm> GetList(CampaignGroupVm p, ref string msg)
        {
            List<CampaignGroupVm> items = new List<CampaignGroupVm>();
            DataTable dt = db.GetList(MapProperties(p), ref msg);
            if (msg != "") return new List<CampaignGroupVm>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    CampaignGroupVm item = new CampaignGroupVm();
                    item.Id = row["campaignGroupId"].GetString();
                    item.Title = row["title"].GetString();
                    item.SchoolYearId = row["schoolYearId"].GetString();
                    item.SchoolYear = row["schoolYearName"].GetString();
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
                return new List<CampaignGroupVm>();
            }
        }

        public CampaignGroupVm GetOne(CampaignGroupVm p, ref string msg)
        {
            try
            {
                return GetList(p, ref msg).Single();
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new CampaignGroupVm();
            }
        }
       
        public bool AddOne(CampaignGroupVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotNullOrNotWhiteSpace(viewModel.Title, ref msg)) return false;
            return db.AddOne(MapProperties(viewModel), ref msg);
        }
        
        public bool EditOne(CampaignGroupVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotNullOrNotWhiteSpace(viewModel.Title, ref msg)) return false;
            return db.EditOne(MapProperties(viewModel), ref msg);
        }

        public bool DeleteOne(CampaignGroupVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotZeroOrNull(viewModel.Id.GetInt(), ref msg)) return false;
            return db.DeleteOne(MapProperties(viewModel), ref msg);
        }


        public void ResetCombo()
        {
            ComboItems = new List<CampaignGroupComboVm>();
        }

        public List<CampaignGroupComboVm> GetCombo(string activeId, ref string msg)
        {
            List<CampaignGroupComboVm> items = new List<CampaignGroupComboVm>();
            DataTable dt = db.GetList(MapProperties(new CampaignGroupVm { SchoolYearId = activeId }), ref msg);
            if (msg != "") return new List<CampaignGroupComboVm>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    CampaignGroupComboVm item = new CampaignGroupComboVm();
                    item.Id = row["campaignGroupId"].GetString();
                    item.Title = row["title"].GetString();
                    item.Details = row["details"].GetString();

                    items.Add(item);
                }

                return items;
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new List<CampaignGroupComboVm>();
            }
        }
    }
}