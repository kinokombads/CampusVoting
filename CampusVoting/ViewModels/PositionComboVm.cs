namespace CampusVoting.ViewModels
{
    public class PositionComboVm : ComboList
    {
        public string PositionType { get; set; }

        public PositionComboVm()
        {
            PositionType = "";
        }
    }
}