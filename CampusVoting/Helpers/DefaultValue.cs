using System;

namespace CampusVoting.Helpers
{
    public static class DefaultValue
    {
        //integrals
        public static byte GetByte(this object obj)
        {
            try
            {
                return Convert.ToByte(obj);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int GetInt(this object obj)
        {
            try
            {
                return Convert.ToInt32(obj);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int? GetNullableInt(this object obj)
        {
            try
            {
                return Convert.ToInt32(obj);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static short GetShort(this object obj)
        {
            try
            {
                return Convert.ToInt16(obj);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static long GetLong(this object obj)
        {
            try
            {
                return Convert.ToInt64(obj);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        //decimals
        public static float GetFloat(this object obj)
        {
            try
            {
                return float.Parse(obj.ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static double GetDouble(this object obj)
        {
            try
            {
                return Convert.ToDouble(obj);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static decimal GetDecimal(this object obj)
        {
            try
            {
                return Convert.ToDecimal(obj);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // dates
        public static DateTime GetDateTime(this object obj)
        {
            try
            {
                return Convert.ToDateTime(obj);
            }
            catch (Exception)
            {
                return new DateTime(1753,1,1);
            }
        }

        public static DateTime? GetNullableDateTime(this object obj)
        {
            try
            {
                return Convert.ToDateTime(obj);
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        // others
        public static bool GetBool(this object obj)
        {
            try
            {
                var kko = false;
                kko = Convert.ToBoolean(obj);
                return kko;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string GetString(this object obj)
        {
            try
            {
                return obj.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }



    }
}