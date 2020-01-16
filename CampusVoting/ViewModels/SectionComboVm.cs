namespace CampusVoting.ViewModels
{
    public class SectionComboVm
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }


        public SectionComboVm()
        {
            Id = "0";
            Title = "";
            Details = "";
        }
    }
}