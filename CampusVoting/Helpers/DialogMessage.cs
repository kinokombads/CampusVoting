namespace CampusVoting.Helpers
{
    public static class DialogMessage
    {

        public static string RetrieveFail
        {
            get { return "Error Retrieving"; }
        }
        
        public static string NoCodeGenerated
        {
            get { return "Unable to generate employee code.\nPlease check if the server is running or there is connection."; }
        }

        public static string ItemNotFound
        {
            get { return "Item Not Found! Retrieving the latest list.\nPlease check if the server is running or there is connection."; }
        }
        
        public static string AddOk
        {
            get { return "Item successfully added."; }
        }

        public static string AddFail
        {
            get { return "Unable To AddOne item."; }
            
        }

        public static string EditOk
        {
            get { return "Item successfully updated."; }
        }

        public static string EditFail
        {
            get { return "Unable To Update Item."; }
        }

        public static string DeleteOk
        {
            get { return "Item successfully deleted"; }
        }

        public static string DeleteFail
        {
            get { return "Unable To Delete Item"; }
        }

        public static string AddOkHead
        {
            get { return "Adding Item"; }
            
        }

        public static string EditOkHead
        {
            get { return "Updating Item"; }
        }

        public static string DeleteOkHead
        {
            get { return "Deleting Item"; }
        }

        public static string Another
        {
            get { return "AddOne another?"; }
        }

        public static string FillAll
        {
            get { return "Some required fields were left blank."; }
            
        }

        public static string FillAllHead
        {
            get { return "Required Fields"; }
            
        }

        public static string AlreadyExists
        {
            get { return "This item already exists in the database."; }
        }

        public static string Duplicate
        {
            get { return "Duplicate Item"; }
        }
        
        //private static string addFail;
        //private static string editOk;
        //private static string editFail;
        //private static string deleteOk;
        //private static string deleteFail;
        //private static string editOkHead;
        //private static string deleteOkHead;

        //public int MyProperty
        //{
        //    get { return myVar; }   
        //    set { myVar = value; }
        //}
    }
}
