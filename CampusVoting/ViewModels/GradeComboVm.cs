namespace CampusVoting.ViewModels
{
    public class GradeComboVm
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }

        public GradeComboVm()
        {
            Id = "0";
            Title = "";
            Details = "";
        }
    }
}