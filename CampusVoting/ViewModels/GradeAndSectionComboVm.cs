namespace CampusVoting.ViewModels
{
    public class GradeAndSectionComboVm
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string GradeId { get; set; }

        public string Grade { get; set; }

        public string SectionId { get; set; }

        public string Section { get; set; }


        public GradeAndSectionComboVm()
        {
            SectionId = "0";
            Title = "";
            GradeId = "0";
            Grade = "";
            SectionId = "0";
            Section = "";
        } 
    }
}