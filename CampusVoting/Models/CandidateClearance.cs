namespace CampusVoting.Models
{
    public class CandidateClearance
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        public int GradeId { get; set; }
        public bool Active { get; set; }

        public CandidateClearance()
        {
            Id = 0;
            PositionId = 0;
            GradeId = 0;
            Active = false;
        }
    }
}