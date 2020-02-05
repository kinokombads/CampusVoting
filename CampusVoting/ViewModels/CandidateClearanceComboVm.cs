namespace CampusVoting.ViewModels
{
    public class CandidateClearanceComboVm
    {
        public string Id { get; set; }
        public string PositionId { get; set; }
        public string Position { get; set; }
        public string GradeId { get; set; }
        public string Grade { get; set; }
        public bool Active { get; set; }

        public CandidateClearanceComboVm()
        {
            Id = "0";
            PositionId = "0";
            Position = "";
            GradeId = "0";
            Grade = "";
            Active = false;
        }
    }
}