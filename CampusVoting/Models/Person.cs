using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusVoting.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int StatId { get; set; }

        protected Person()
        {
            Id = 0;
            Password = "";
            LastName = "";
            FirstName = "";
            MiddleName = "";
            StatId = 0;
        }
        
    }
}
