namespace CampusVoting.Models
{
    public class VoterClearance
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        public int GradeId { get; set; }
        public bool Active { get; set; }

        public VoterClearance()
        {
            Id = 0;
            PositionId = 0;
            GradeId = 0;
            Active = false;
        } 
    }
}