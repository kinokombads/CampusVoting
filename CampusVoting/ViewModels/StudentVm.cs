namespace CampusVoting.ViewModels
{
    public class StudentVm
    {
        public string Id { get; set; }
        public string Lrn { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SectionName { get; set; }
        public string GradeName { get; set; }
        public string CurrentGradeAndSection { get; set; }

        public StudentVm()
        {
            Id = "";
            Lrn = "";
            LastName = "";
            FirstName = "";
            MiddleName = "";
            SectionName = "";
            GradeName = "";
            CurrentGradeAndSection = "";
        }
    }
}