using System;

namespace CampusVoting.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public int PictureId { get; set; }
        public int StudentId { get; set; }
        public int PositionId { get; set; }
        public int CampaignGroupId { get; set; }
        public string Propaganda { get; set; }
        public int StatId { get; set; }
        public int CreatedById { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int ModifiedById { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public Candidate()
        {
            Id = 0;
            PictureId = 0;
            StudentId = 0;
            PositionId = 0;
            CampaignGroupId = 0;
            Propaganda = "";
            StatId = 0;
            CreatedById = 0;
            CreatedOn = null;
            ModifiedById = 0;
            ModifiedOn = null;
        }
    }
}