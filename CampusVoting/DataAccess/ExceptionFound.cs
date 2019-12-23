using System;

namespace CampusVoting.DataAccess
{
    public class ExceptionFound
    {
        public string GetExceptionMessage(Exception ex, string msg)
        {
            if (msg != "")
            {
                msg = string.Format("DAL Error: {0}\n{1}", ex.Message, msg);
            }
            else if (ex.InnerException != null)
            {
                msg = string.Format("DAL Error: {0}\n{1}\nInner Exception: {2}", ex.Message, msg, ex.InnerException.Message);
            }
            else
            {
                msg = string.Format("DAL Error: {0}", ex.Message);
            }

            return msg;
        }
    }
}