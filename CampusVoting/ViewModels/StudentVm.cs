namespace CampusVoting.ViewModels
{
    public class StudentVm
    {
        public string Id { get; set; }

        public string LRN { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string SectionId { get; set; }

        public string Section { get; set; }

        public string GradeId { get; set; }

        public string Grade { get; set; }

        public string SchoolYearId { get; set; }

        public string SchoolYear { get; set; }

        public string CurrentGradeAndSectionId { get; set; }

        public string CurrentSectionName { get; set; }
        

        public StudentVm()
        {
            Id = "0";
            LRN = "";
            LastName = "";
            FirstName = "";
            MiddleName = "";
            SectionId = "0"; 
            Section = "";
            GradeId = "0";
            Grade = "";
            SchoolYearId = "0";
            SchoolYear = "";
            CurrentGradeAndSectionId = "0";
            CurrentSectionName = "";
        }
    }
}