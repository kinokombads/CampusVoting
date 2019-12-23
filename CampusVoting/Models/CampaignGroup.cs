using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusVoting.Models
{
    public class CampaignGroup : ConfigTable
    {
        public int SchoolYearId { get; set; }

        public CampaignGroup()
        {
            SchoolYearId = 0;
        }
    }
}
