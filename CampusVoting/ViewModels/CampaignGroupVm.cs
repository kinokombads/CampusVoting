namespace CampusVoting.ViewModels
{
    public class CampaignGroupVm : ConfigTableVm
    {
        public string SchoolYearId { get; set; }
        public string SchoolYear { get; set; }

        public CampaignGroupVm()
        {
            SchoolYearId = "0";
            SchoolYear = "";
        }
    }
}