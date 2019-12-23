namespace CampusVoting.Models
{
    public class Position : ConfigTable
    {
        public string PositionType { get; set; }

        public Position()
        {
            PositionType = "";
        }
    }
}