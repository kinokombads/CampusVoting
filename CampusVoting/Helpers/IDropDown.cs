using System.Collections.Generic;

namespace CampusVoting.Helpers
{
    public interface IDropDown<T>
    {
        void ResetCombo();
        List<T> GetCombo(ref string msg);
    }
}