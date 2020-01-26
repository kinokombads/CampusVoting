using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusVoting.ViewModels
{
    public abstract class ComboList
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }

        protected ComboList()
        {
            Id = "0";
            Title = "";
            Details = "";
        }
    }
}
