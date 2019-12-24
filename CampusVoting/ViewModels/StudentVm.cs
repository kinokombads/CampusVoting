namespace CampusVoting.ViewModels
{
    public class StudentVm
    {
        public string Id { get; set; }
        public string Lrn { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SectionId { get; set; }
        public string SectionName { get; set; }
        public string GradeId { get; set; }
        public string GradeName { get; set; }
        public string CurrentGradeAndSectionId { get; set; }
        public string CurrentSectionName { get; set; }
        

        public StudentVm()
        {
            Id = "0";
            Lrn = "";
            LastName = "";
            FirstName = "";
            MiddleName = "";
            SectionId = "0"; 
            SectionName = "";
            GradeId = "0";
            GradeName = "";
            CurrentGradeAndSectionId = "0";
            CurrentSectionName = "";
        }
    }
}