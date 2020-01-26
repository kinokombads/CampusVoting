namespace CampusVoting.ViewModels
{
    public class PositionVm : ConfigTableVm
    {
        public string PositionType { get; set; }

        public PositionVm()
        {
            PositionType = "";
        }
    }
}