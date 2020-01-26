using System.Data;

namespace CampusVoting.Helpers
{
    public interface IRetrieve<out T, in TParams>
    {
        T GetList(TParams p, ref string msg);
    }
}
