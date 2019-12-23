namespace CampusVoting.Models
{
    public class User : Person
    {
        public string UserName { get; set; }

        public User()
        {
            UserName = "";
        }
    }
}