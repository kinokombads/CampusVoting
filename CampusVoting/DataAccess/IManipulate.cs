namespace CampusVoting.DataAccess
{
    public interface IManipulate<T>
    {
        bool AddOne(T p, ref string msg);

        bool EditOne(T p, ref string msg);

        bool DeleteOne(T p, ref string msg);
    }
}