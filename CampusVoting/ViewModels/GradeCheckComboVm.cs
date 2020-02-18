namespace CampusVoting.ViewModels
{
    public class GradeCheckComboVm : ComboList
    {
        public string Active { get; set; }

        public GradeCheckComboVm()
        {
            Active = "false";
        }
    }
}