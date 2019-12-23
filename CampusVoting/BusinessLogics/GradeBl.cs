using System.Collections.Generic;
using CampusVoting.DataAccess;
using CampusVoting.Helpers;
using CampusVoting.Models;

namespace CampusVoting.BusinessLogics
{
    public class GradeBl
    {
        private readonly GradeDal db = new GradeDal();
        public Grade Item { get; set; }
        public Grade Params { get; set; }
        public List<Grade> Items { get; set; }
        public GradeBl()
        {
            ResetParams();
            ResetOne();
            ResetList();
        }

        public void ResetOne()
        {
            Item = new Grade();
        }

        public void ResetParams()
        {
            Params = new Grade();
        }

        public void ResetList()
        {
            Items = new List<Grade>();
        }
        
        public List<Grade> GetList(Grade p, ref string msg)
        {
            var ret = db.GetList(p, ref msg);
            return ret;
        }

        public Grade GetOne(Grade p, ref string msg)
        {
           return db.GetOne(p, ref msg);
        }
        
        public bool AddOne(Grade p, ref string msg)
        {
            return (EntryChecker.IsNotNullOrWhiteSpace(p.Title, ref msg)) 
                && db.AddOne(p, ref msg);
        }

        public bool EditOne(Grade p, ref string msg)
        {
            return (EntryChecker.IsNotNullOrWhiteSpace(p.Title, ref msg)) 
                && db.EditOne(p, ref msg);
        }

        public bool DeleteOne(Grade p, ref string msg)
        {
            return EntryChecker.IsNotZeroOrNull(p.Id, ref msg)
                && db.DeleteOne(p, ref msg);
        }
    }
}