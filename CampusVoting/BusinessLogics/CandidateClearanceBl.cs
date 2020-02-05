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
    public class CandidateClearanceBl
    {
        private readonly CandidateClearanceDal db = new CandidateClearanceDal();
        private ExceptionFound ef = new ExceptionFound();

        public CandidateClearanceVm VmItem { get; set; }

        public CandidateClearanceVm VmParams { get; set; }

        public List<CandidateClearanceVm> ListVm { get; set; }

        public List<CandidateClearanceComboVm> ComboItems { get; set; }

        public bool ChangeOccured { get; set; }


        public CandidateClearanceBl()
        {
            ResetVmItem();
            ResetVmParams();
            ResetVmList();
            ResetCombo();
            ChangeOccured = false;
        }

        public void ResetVmItem()
        {
            VmItem = new CandidateClearanceVm();
        }

        public void ResetVmParams()
        {
            VmParams = new CandidateClearanceVm();
        }

        public void ResetVmList()
        {
            ListVm = new List<CandidateClearanceVm>();
        }
        

        private CandidateClearance MapProperties(CandidateClearanceVm p)
        {
            CandidateClearance baseObj = new CandidateClearance();
            //baseObj.Id = p.Id.GetInt();
            baseObj.PositionId = p.PositionId.GetInt();
            baseObj.GradeId = p.GradeId.GetInt();
            baseObj.Active = p.Active.GetBool();

            return baseObj;
        }
        
        public void MapToViewModel(object item)
        {
            if (item == null) return;
            ResetVmParams();
            VmParams = (CandidateClearanceVm)item;
        }

        
        public List<CandidateClearanceVm> GetList(CandidateClearanceVm p, ref string msg)
        {
            List<CandidateClearanceVm> items = new List<CandidateClearanceVm>();
            DataTable dt = db.GetList(p, ref msg);
            if (msg != "") return new List<CandidateClearanceVm>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    CandidateClearanceVm item = new CandidateClearanceVm();
                    //item.Id = row["candidateClearanceId"].GetString();
                    item.PositionId = row["positionId"].GetString();
                    item.Position = row["positionName"].GetString();
                    item.GradeId = row["gradeId"].GetString();
                    item.Grade = row["gradeName"].GetString();
                    item.Active = row["active"].GetBool();

                    items.Add(item);
                }

                return items;
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new List<CandidateClearanceVm>();
            }
        }

        public CandidateClearanceVm GetOne(CandidateClearanceVm p, ref string msg)
        {
            try
            {
                return GetList(p, ref msg).Single();
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new CandidateClearanceVm();
            }
        }
       
        public bool AddOne(CandidateClearanceVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotZeroOrNull(viewModel.GradeId.GetNullableInt(), viewModel.PositionId.GetNullableInt(), ref msg)) return false;
            return db.AddOne(MapProperties(viewModel), ref msg);
        }
        
        public bool EditOne(CandidateClearanceVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotZeroOrNull(viewModel.GradeId.GetNullableInt(), viewModel.PositionId.GetNullableInt(), ref msg)) return false;
            return db.EditOne(MapProperties(viewModel), ref msg);
        }

        //todo
        public bool DeleteOne(CandidateClearanceVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotZeroOrNull(viewModel.PositionId.GetInt(), ref msg)) return false;
            return db.DeleteOne(MapProperties(viewModel), ref msg);
        }

        private void ResetCombo()
        {
            ComboItems = new List<CandidateClearanceComboVm>();
        }


        public List<CandidateClearanceComboVm> GetCombo(ref string msg)
        {
            List<CandidateClearanceComboVm> items = new List<CandidateClearanceComboVm>();
            DataTable dt = db.GetList(new CandidateClearanceVm(), ref msg);
            if (msg != "") return new List<CandidateClearanceComboVm>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    CandidateClearanceComboVm item = new CandidateClearanceComboVm();
                    item.GradeId = row["gradeId"].GetString();
                    item.Grade = row["gradeName"].GetString();
                    item.PositionId = row["positionId"].GetString();
                    item.Position = row["positionName"].GetString();
                    item.Active = row["active"].GetBool();

                    items.Add(item);
                }

                return items;
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new List<CandidateClearanceComboVm>();
            }
        }
    }
}