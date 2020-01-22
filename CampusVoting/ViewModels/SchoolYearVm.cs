namespace CampusVoting.ViewModels
{
    public class SchoolYearVm : ConfigTableVm
    {
        public bool Active { get; set; }

        public SchoolYearVm()
        {
            Active = false;
        }
    }
}