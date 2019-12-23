namespace CampusVoting.Models
{
    public class Student : Person
    {
        public string Lrn { get; set; }
        public int GradeAndSectionId { get; set; }
        public string CurrentGradeAndSection { get; set; }
        public int SchoolYearId { get; set; }
        
        public Student()
        {
            Lrn = "";
            GradeAndSectionId = 0;
            CurrentGradeAndSection = "";
            SchoolYearId = 0;
        }
    }
}