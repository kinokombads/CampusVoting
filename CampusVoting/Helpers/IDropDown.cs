using System.Collections.Generic;

namespace CampusVoting.Helpers
{
    public interface IDropDown<T, TParams>
    {
        void ResetCombo();
        List<T> GetCombo(TParams p, ref string msg);
    }
}