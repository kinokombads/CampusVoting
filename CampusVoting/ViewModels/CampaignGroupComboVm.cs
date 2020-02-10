namespace CampusVoting.ViewModels
{
    public class CampaignGroupComboVm : ComboList
    {
        public string SchoolYearId { get; set; }
        public string SchoolYear { get; set; }

        public CampaignGroupComboVm()
        {
            SchoolYearId = "0";
            SchoolYear = "";
        }
    }
}