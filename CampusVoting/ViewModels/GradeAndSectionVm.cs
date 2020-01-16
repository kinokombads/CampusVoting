namespace CampusVoting.ViewModels
{
    public class GradeAndSectionVm
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string GradeId { get; set; }

        public string Grade { get; set; }

        public string SectionId { get; set; }

        public string Section { get; set; }
        
        public string LoggedUser { get; set; }

        public string CreatedById { get; set; }

        public string CreatedBy { get; set; }

        public string CreatedOn { get; set; }

        public string ModifiedById { get; set; }

        public string ModifiedBy { get; set; }

        public string ModifiedOn { get; set; }


        public GradeAndSectionVm()
        {
            Id = "0";
            Title = "";
            LoggedUser = "";
            CreatedById = "0";
            CreatedBy = "";
            CreatedOn = "";
            ModifiedById = "0";
            ModifiedBy = "";
            ModifiedOn = "";
        }
 
    }
}