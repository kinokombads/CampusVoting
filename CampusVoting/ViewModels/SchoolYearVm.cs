namespace CampusVoting.ViewModels
{
    public class SchoolYearVm : ConfigTableVm
    {
        public string Active { get; set; }

        public SchoolYearVm()
        {
            Active = "";
        }
    }
}