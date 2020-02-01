namespace CampusVoting.ViewModels
{
    public class VoterClearanceVm
    {
        public string Id { get; set; }
        public string PositionId { get; set; }
        public string Position { get; set; }
        public string GradeId { get; set; }
        public string Grade { get; set; }
        public string Active { get; set; }

        public VoterClearanceVm()
        {
            Id = "0";
            PositionId = "0";
            Position = "";
            GradeId = "0";
            Grade = "";
            Active = "";
        } 
    }
}