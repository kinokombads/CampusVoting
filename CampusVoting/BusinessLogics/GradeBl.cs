using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using CampusVoting.DataAccess;
using CampusVoting.Helpers;
using CampusVoting.Models;
using CampusVoting.ViewModels;
using Vota.Helpers;

namespace CampusVoting.BusinessLogics
{
    public class GradeBl
    {
        private readonly GradeDal db = new GradeDal();
        private ExceptionFound ef = new ExceptionFound();

        public Grade Item { get; set; }
        public Grade Params { get; set; }

        public GradeVm VmItem { get; set; }
        public GradeVm VmParams { get; set; }
        public List<Grade> Items { get; set; }
        public List<GradeVm> ListVm { get; set; }
        public bool ChangeOccured { get; set; }

        public GradeBl()
        {
            ResetParams();
            ResetOne();
            ResetVmParams();
            ResetList();
            ChangeOccured = false;
        }

        public void ResetOne()
        {
            Item = new Grade();
        }

        public void ResetVmItem()
        {
            VmItem = new GradeVm();
        }

        public void ResetParams()
        {
            Params = new Grade();
        }

        public void ResetVmParams()
        {
            VmParams = new GradeVm();
        }

        public void ResetList()
        {
            Items = new List<Grade>();
        }

        public void ResetVmList()
        {
            ListVm = new List<GradeVm>();
        }

        private Grade MapProperties(GradeVm p)
        {
            Grade baseObj = new Grade();
            baseObj.Id = p.Id.GetInt();
            baseObj.Title = p.Title.GetString();
            baseObj.Details = p.Details.GetString();
            baseObj.CreatedById = p.CreatedById.GetInt();
            baseObj.CreatedByName = p.CreatedBy.GetString();
            baseObj.CreatedOn = p.CreatedOn.GetDateTime();
            baseObj.ModifiedById = p.ModifiedById.GetInt();
            baseObj.ModifiedByName = p.ModifiedBy.GetString();
            baseObj.ModifiedOn = p.ModifiedOn.GetNullableDateTime();

            return baseObj;
        }
        
        public void MapToViewModel(object item)
        {
            if (item == null) return;
            ResetVmParams();
            VmParams = (GradeVm)item;
        }
        
        public List<GradeVm> GetList(GradeVm p, ref string msg)
        {
            List<GradeVm> items = new List<GradeVm>();
            Grade param = MapProperties(p);
            DataTable dt = db.GetList(param, ref msg);
            if (msg != "") return new List<GradeVm>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    GradeVm item = new GradeVm();
                    item.Id = row["gradeId"].GetString();
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
                return new List<GradeVm>();
            }
        }

        public GradeVm GetOne(GradeVm p, ref string msg)
        {
            try
            {
                return GetList(p, ref msg).Single();
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new GradeVm();
            }
        }

        public bool AddOne(Grade p, ref string msg)
        {
            return (EntryChecker.IsNotNullOrNotWhiteSpace(p.Title, ref msg))
                && db.AddOne(p, ref msg);
        }

        public bool AddOne(GradeVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotNullOrNotWhiteSpace(viewModel.Title, ref msg)) return false;
            return db.AddOne(MapProperties(viewModel), ref msg);
        }

        public bool EditOne(Grade p, ref string msg)
        {
            return (EntryChecker.IsNotNullOrNotWhiteSpace(p.Title, ref msg))
                && db.EditOne(p, ref msg);
        }

        public bool EditOne(GradeVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotNullOrNotWhiteSpace(viewModel.Title, ref msg)) return false;
            return db.EditOne(MapProperties(viewModel), ref msg);
        }

        public bool DeleteOne(Grade p, ref string msg)
        {
            return EntryChecker.IsNotZeroOrNull(p.Id, ref msg)
                && db.DeleteOne(p, ref msg);
        }

        public bool DeleteOne(GradeVm viewModel, ref string msg)
        {
            //var isZero = EntryChecker.IsNotZeroOrNull(viewModel.Id.GetInt(), ref msg);
            if (!EntryChecker.IsNotZeroOrNull(viewModel.Id.GetInt(), ref msg)) return false;
            return db.DeleteOne(MapProperties(viewModel), ref msg);
        }

        
    }
}