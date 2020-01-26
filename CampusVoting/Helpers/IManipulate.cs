namespace CampusVoting.Helpers
{
    public interface IManipulate<in T>
    {
        bool AddOne(T p, ref string msg);

        bool EditOne(T p, ref string msg);

        bool DeleteOne(T p, ref string msg);
    }
}