using System.Collections.Generic;
using CampusVoting.DataAccess;
using CampusVoting.Helpers;
using CampusVoting.Models;
using CampusVoting.ViewModels;

namespace CampusVoting.BusinessLogics
{
    public class StudentBl
    {
         private readonly StudentDal db = new StudentDal();
        public Student Item { get; set; }
        public Student Params { get; set; }
        public List<Student> Items { get; set; }
        public StudentVm Parameters { get; set; }
        public List<StudentVm> ViewModels { get; set; }

        public StudentBl()
        {
            ResetParams();
            ResetOne();
            ResetParameters();
            ResetList();
            ResetViewModels();
        }

        public void ResetOne()
        {
            Item = new Student();
        }

        public void ResetParams()
        {
            Params = new Student();
        }

        public void ResetParameters()
        {
            Parameters = new StudentVm();
        }

        public void ResetList()
        {
            Items = new List<Student>();
        }

        public void ResetViewModels()
        {
            ViewModels = new List<StudentVm>();
        }
        
        public List<StudentVm> GetList(StudentVm p, ref string msg)
        {
            var ret = db.GetList(p, ref msg);
            return ret;
        }

        public StudentVm GetOne(StudentVm p, ref string msg)
        {
           return db.GetOne(p, ref msg);
        }
        
        public bool AddOne(Student p, ref string msg)
        {
            return (EntryChecker.IsNotNullOrNotWhiteSpace(p.Lrn, ref msg)) 
                && db.AddOne(p, ref msg);
        }

        public bool EditOne(Student p, ref string msg)
        {
            return (EntryChecker.IsNotNullOrNotWhiteSpace(p.Lrn, ref msg)) 
                && db.EditOne(p, ref msg);
        }

        public bool DeleteOne(Student p, ref string msg)
        {
            return EntryChecker.IsNotZeroOrNull(p.Id, ref msg)
                && db.DeleteOne(p, ref msg);
        }
    }
}