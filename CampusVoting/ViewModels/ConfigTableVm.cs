namespace CampusVoting.ViewModels
{
    public abstract class ConfigTableVm
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string LoggedUser { get; set; }
        public string CreatedById { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string ModifiedById { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }


        protected ConfigTableVm()
        {
            Id = "0";
            Title = "";
            Details = "";
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