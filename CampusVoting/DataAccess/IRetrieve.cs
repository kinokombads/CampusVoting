using System.Data;

namespace CampusVoting.DataAccess
{
    public interface IRetrieve<T>
    {
        DataTable GetList(T p, ref string msg);
    }
}
