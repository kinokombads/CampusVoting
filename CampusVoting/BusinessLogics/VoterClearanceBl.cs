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
    public class VoterClearanceBl
    {
        private readonly VoterClearanceDal db = new VoterClearanceDal();
        private ExceptionFound ef = new ExceptionFound();

        public VoterClearanceVm VmItem { get; set; }

        public VoterClearanceVm VmParams { get; set; }

        public List<VoterClearanceVm> ListVm { get; set; }

        //public List<VoterClearanceComboVm> ComboItems { get; set; }

        public bool ChangeOccured { get; set; }


        public VoterClearanceBl()
        {
            ResetVmItem();
            ResetVmParams();
            ResetVmList();
            //ResetCombo();
            ChangeOccured = false;
        }

        public void ResetVmItem()
        {
            VmItem = new VoterClearanceVm();
        }

        public void ResetVmParams()
        {
            VmParams = new VoterClearanceVm();
        }

        public void ResetVmList()
        {
            ListVm = new List<VoterClearanceVm>();
        }
        

        private VoterClearance MapProperties(VoterClearanceVm p)
        {
            VoterClearance baseObj = new VoterClearance();
            baseObj.Id = p.Id.GetInt();
            baseObj.PositionId = p.PositionId.GetInt();
            baseObj.GradeId = p.GradeId.GetInt();
            baseObj.Active = p.Active.GetBool();

            return baseObj;
        }
        
        public void MapToViewModel(object item)
        {
            if (item == null) return;
            ResetVmParams();
            VmParams = (VoterClearanceVm)item;
        }

        
        public List<VoterClearanceVm> GetList(VoterClearanceVm p, ref string msg)
        {
            List<VoterClearanceVm> items = new List<VoterClearanceVm>();
            DataTable dt = db.GetList(p, ref msg);
            if (msg != "") return new List<VoterClearanceVm>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    VoterClearanceVm item = new VoterClearanceVm();
                    item.Id = row["voterClearanceId"].GetString();
                    item.PositionId = row["positionId"].GetString();
                    item.Position = row["positionName"].GetString();
                    item.GradeId = row["gradeId"].GetString();
                    item.Grade = row["gradeName"].GetString();

                    items.Add(item);
                }

                return items;
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new List<VoterClearanceVm>();
            }
        }

        public VoterClearanceVm GetOne(VoterClearanceVm p, ref string msg)
        {
            try
            {
                return GetList(p, ref msg).Single();
            }
            catch (Exception ex)
            {
                msg = ef.GetExceptionMessage(ex, msg);
                return new VoterClearanceVm();
            }
        }
       
        public bool AddOne(VoterClearanceVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotZeroOrNull(viewModel.GradeId.GetInt(), viewModel.PositionId.GetInt(), ref msg)) return false;
            return db.AddOne(MapProperties(viewModel), ref msg);
        }
        
        public bool EditOne(VoterClearanceVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotZeroOrNull(viewModel.Id.GetInt(), viewModel.GradeId.GetInt(), viewModel.PositionId.GetInt(), ref msg)) return false;
            return db.EditOne(MapProperties(viewModel), ref msg);
        }

        public bool DeleteOne(VoterClearanceVm viewModel, ref string msg)
        {
            if (!EntryChecker.IsNotZeroOrNull(viewModel.Id.GetInt(), ref msg)) return false;
            return db.DeleteOne(MapProperties(viewModel), ref msg);
        } 
    }
}