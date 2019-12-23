namespace CampusVoting.Models
{
    public class Winner
    {
        public int Id { get; set; }
        public int VotingSessionId { get; set; }
        public int SchoolYearId { get; set; }
        public int CandidateId { get; set; }
        public int TotalVotes { get; set; }
        
        public Winner()
        {
            Id = 0;
            VotingSessionId = 0;
            SchoolYearId = 0;
            CandidateId = 0;
            TotalVotes = 0;
        }
    }
}