namespace CampusVoting.Helpers
{
    public static class EntryChecker
    {
        //private static void ErrorMessage()
        //{
        //    MessageBox.Show(DialogMessage.FillAll, DialogMessage.FillAllHead, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        private static string ErrorMessage2()
        {
            return DialogMessage.FillAll;
        }

        //public static bool IsNotNullOrNotWhiteSpace(string p1 )
        //{
        //    if (!string.IsNullOrWhiteSpace(p1)) return true;
        //    ErrorMessage();
        //    return false;
        //}

        public static bool IsNotNullOrNotWhiteSpace(string p1, ref string msg)
        {
            if (!string.IsNullOrWhiteSpace(p1)) return true;
            msg = ErrorMessage2();
            return false;
        }

        //public static bool IsNotNullOrNotWhiteSpace(string p1, string p2)
        //{
        //    if (!(string.IsNullOrWhiteSpace(p1) && string.IsNullOrWhiteSpace(p2))) return true;
        //    ErrorMessage();
        //    return false;
        //}

        public static bool IsNotNullOrNotWhiteSpace(string p1, string p2, ref string msg)
        {
            if (!(string.IsNullOrWhiteSpace(p1) && string.IsNullOrWhiteSpace(p2))) return true;
            msg = ErrorMessage2();
            return false;
        }

        //public static bool IsNotNullOrNotWhiteSpace(string p1, string p2, string p3)
        //{
        //    if (!(string.IsNullOrWhiteSpace(p1) && string.IsNullOrWhiteSpace(p2) && string.IsNullOrWhiteSpace(p3))) return true;
        //    ErrorMessage();
        //    return false;
        //}

        public static bool IsNotNullOrNotWhiteSpace(string p1, string p2, string p3, ref string msg)
        {
            if (!(string.IsNullOrWhiteSpace(p1) && string.IsNullOrWhiteSpace(p2) && string.IsNullOrWhiteSpace(p3))) return true;
            msg = ErrorMessage2();
            return false;
        }

        //public static bool IsNotNullOrNotWhiteSpace(string p1, int p2, int p3, ref string msg)
        //{
        //    if (!(string.IsNullOrWhiteSpace(p1) && IsNotZeroOrNull(p2, p3, ref msg))) return true;
        //    msg = ErrorMessage2();
        //    return false;
        //}

        public static bool IsNotNullOrNotWhiteSpace(string p1, string p2, string p3, string p4, ref string msg)
        {
            if (!(string.IsNullOrWhiteSpace(p1) && string.IsNullOrWhiteSpace(p2) && string.IsNullOrWhiteSpace(p3) && string.IsNullOrWhiteSpace(p4))) return true;
            msg = ErrorMessage2();
            return false;
        }

        //public static bool IsNotNullOrNotWhiteSpace(string p1, string p2, string p3, string p4, string p5)
        //{
        //    if (!(string.IsNullOrWhiteSpace(p1) && string.IsNullOrWhiteSpace(p2) && string.IsNullOrWhiteSpace(p3) && string.IsNullOrWhiteSpace(p4) && string.IsNullOrWhiteSpace(p5))) return true;
        //    ErrorMessage();
        //    return false;
        //}

        public static bool IsNotNullOrNotWhiteSpace(string p1, string p2, string p3, string p4, string p5, ref string msg)
        {
            if (!(string.IsNullOrWhiteSpace(p1) && string.IsNullOrWhiteSpace(p2) && string.IsNullOrWhiteSpace(p3) && string.IsNullOrWhiteSpace(p4) && string.IsNullOrWhiteSpace(p5))) return true;
            msg = ErrorMessage2();
            return false;
        }

        //public static bool IsNotZeroOrNull(int? p1)
        //{
        //    if (p1 != 0 && p1.HasValue) return true;
        //    ErrorMessage();
        //    return false;
        //}

        public static bool IsNotZeroOrNull(int? p1, ref string msg)
        {
            if (p1 != 0 && p1.HasValue) return true;
            msg = ErrorMessage2();
            return false;
        }

        //public static bool IsNotZeroOrNull(int? p1, int? p2)
        //{
        //    if ((p1 != 0 && p1.HasValue) && (p2 != 0 && p2.HasValue)) return true;
        //    ErrorMessage();
        //    return false;
        //}

        public static bool IsNotZeroOrNull(int? p1, int? p2, ref string msg)
        {
            if (!(p1.HasValue && p2.HasValue) || (p1 == 0) || (p2 == 0) )
            {
                msg = ErrorMessage2();
                return false;
            }

            return true;
        }

        public static bool IsNotZeroOrNull(int? p1, int? p2, int? p3, ref string msg)
        {
            if (p1.HasValue && p2.HasValue && p3.HasValue && (p1 != 0) && (p2 != 0) && (p3 != 0)) return true;
            msg = ErrorMessage2();
            return false;
        }

        //public static bool IsNotZeroOrNull(int? p1, int? p2, int? p3)
        //{
        //    if ((p1 != 0 && p1.HasValue) && (p2 != 0 && p2.HasValue) && (p3 != 0 && p3.HasValue)) return true;
        //    ErrorMessage();
        //    return false;
        //}

        //public static bool IsNotZeroOrNull(int? p1, int? p2, int? p3, ref string msg)
        //{
        //    if ((p1 != 0 && p1.HasValue) && (p2 != 0 && p2.HasValue) && (p3 != 0 && p3.HasValue)) return true;
        //    msg = ErrorMessage2();
        //    return false;
        //}

        //public static bool IsNotZero(decimal p1)
        //{
        //    if (p1 != 0) return true;
        //    ErrorMessage();
        //    return false;
        //}

        public static bool IsNotZero(decimal p1, ref string msg)
        {
            if (p1 != 0) return true;
            msg = ErrorMessage2();
            return false;
        }
    }
}