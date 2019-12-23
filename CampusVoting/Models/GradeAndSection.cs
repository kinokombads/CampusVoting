using System;

namespace CampusVoting.Models
{
    public class GradeAndSection
    {
        public int Id { get; set; }
        public int GradeId { get; set; }
        public int SectionId { get; set; }
        public string Title { get; set; }
        public int StatId { get; set; }
        public int CreatedById { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int ModifiedById { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public GradeAndSection()
        {
            Id = 0;
            GradeId = 0;
            SectionId = 0;
            Title = "";
            StatId = 0;
            CreatedById = 02;
            CreatedOn = null;
            ModifiedById = 0;
            ModifiedOn = null;
        }
    }
}