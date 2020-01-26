using System.Collections.Generic;

namespace CampusVoting.EnumsAndDictionaries
{
    public static class DictionItems
    {
        public static Dictionary<string, string> PositionTypeDictionaries()
        {
            Dictionary<string, string> coll = new Dictionary<string, string>();
            coll.Add("Regular", "Regular positions that has requires one winner");
            coll.Add("Representative", "Positions in which the required number of winner is based on the grade level population.");
            return coll;
        }
    }
}