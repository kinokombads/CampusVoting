using System;
using System.Windows.Forms;

namespace CampusVoting.Models
{
    public class VotingSession
    {
        public int Id { get; set; }
        public int SchoolYearId { get; set; }
        public bool Active { get; set; }
        public int StatId { get; set; }
        public int CreatedById { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int StartedById { get; set; }
        public DateTime? StartedOn { get; set; }
        public int StoppedById { get; set; }
        public DateTime? StoppedOn { get; set; }

        public VotingSession()
        {
            Id = 0;
            SchoolYearId = 0;
            Active = false;
            StatId = 0;
            CreatedById = 0;
            CreatedOn = null;
            StartedById = 0;
            StartedOn = null;
            StoppedById = 0;
            StoppedOn = null;
        }
    }
}