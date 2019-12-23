namespace CampusVoting.Models
{
    public class CastedVote
    {
        public int Id { get; set; }
        public int VotingSessionId { get; set; }
        public int StudentId { get; set; }
        public int CandidateId { get; set; }
        public int StatId { get; set; }

        public CastedVote()
        {
            Id = 0;
            VotingSessionId = 0;
            StudentId = 0;
            CandidateId = 0;
            StatId = 0;
        }
    }
}