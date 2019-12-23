using System;

namespace CampusVoting.Models
{
    public abstract class ConfigTable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public int StatId { get; set; }
        public int CreatedById { get; set; }
        public string CreatedByName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int ModifiedById { get; set; }
        public string ModifiedByName { get; set; }
        public DateTime? ModifiedOn { get; set; }

        protected ConfigTable()
        {
            Id = 0;
            Title = "";
            Details = "";
            StatId = 0;
            CreatedById = 0;
            CreatedByName = "";
            CreatedOn = null;
            ModifiedById = 0;
            ModifiedByName = "";
            ModifiedOn = null;
        }
        
    }
}
