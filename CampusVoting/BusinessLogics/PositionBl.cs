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
    public class PositionBl
    {
         private readonly PositionDal db = new PositionDal();
        private ExceptionFound ef = new ExceptionFound();

        public PositionVm VmItem { get; set; }

        public PositionVm VmParams { get; set; }

        public List<PositionVm> ListVm { get; set; }

        public List<PositionComboVm> ComboItems { get; set; }

        public List<PositionTypeComboVm> PositionTypes { get; set; }

        public bool ChangeOccured { get; set; }


        public PositionBl()
        {
            ResetVmItem();
            ResetVmParams();
            ResetVmList();
            ResetCombo();
            PositionTypes = new List<PositionTypeComboVm>();
            GetPositionTypes();
            ChangeOccured = false;
        }

        public void ResetVmItem()
        {
            VmItem = new PositionVm();
        }

        public void ResetVmParams()
        {
            VmParams = new PositionVm();
        }

        public void ResetVmList()
        {
            ListVm = new List<PositionVm>();
        }
        

        private Position MapProperties(PositionVm p)
        {
            Position baseObj = new Position();
            baseObj.Id = p.Id.GetInt();
            baseObj.Title = p.Title.GetString();
            baseObj.PositionType = p.PositionType.GetString();
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
            VmParams = (PositionVm)item;
        }

        
        public List<PositionVm> GetList(PositionVm p, ref string msg)
        {
            List<PositionVm> items = new List<PositionVm>();
            DataTable dt = db.GetList(MapProperties(p), ref msg);
            if (msg != "") return new List<PositionVm>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    PositionVm item = new PositionVm();
                    item.Id = row["PositionId"].GetString();
                    item.Title = row["title"].GetString();
                    item.PositionType = row["positionType"].GetString();
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
                return new List<PositionVm>();
            }
        }

        public PositionVm GetOne(PositionVm p, ref string msg)
        {
            try
            {
                return GetList(p, ref msg).Single();
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new PositionVm();
            }
        }
       
        public bool AddOne(PositionVm viewModel, ref string msg, ref int newId)
        {
            if (!EntryChecker.IsNotNullOrNotWhiteSpace(viewModel.Title, ref msg)) return false;
            return db.AddOne(MapProperties(viewModel), ref msg, ref newId);
        }
        
        public bool EditOne(PositionVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotNullOrNotWhiteSpace(viewModel.Title, ref msg)) return false;
            return db.EditOne(MapProperties(viewModel), ref msg);
        }

        public bool DeleteOne(PositionVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotZeroOrNull(viewModel.Id.GetInt(), ref msg)) return false;
            return db.DeleteOne(MapProperties(viewModel), ref msg);
        }


        public void ResetCombo()
        {
            ComboItems = new List<PositionComboVm>();
        }

        public List<PositionComboVm> GetCombo(PositionVm p, ref string msg)
        {
            List<PositionComboVm> items = new List<PositionComboVm>();
            DataTable dt = db.GetList(MapProperties(p), ref msg);
            if (msg != "") return new List<PositionComboVm>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    PositionComboVm item = new PositionComboVm();
                    item.Id = row["PositionId"].GetString();
                    item.Title = row["title"].GetString();
                    item.PositionType = row["positionType"].GetString();
                    item.Details = row["details"].GetString();

                    items.Add(item);
                }

                return items;
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new List<PositionComboVm>();
            }
        }

        private void GetPositionTypes()
        {
            PositionTypes.Add(new PositionTypeComboVm
            {
                Id = "Regular",
                Title = "Regular",
                Details = "Regular positions that has requires one winner."
            });

            PositionTypes.Add(new PositionTypeComboVm
            {
                Id = "Representative",
                Title = "Representative",
                Details = "Positions in which the required number of winner is based on the grade level population."
            });


        }
    }
}