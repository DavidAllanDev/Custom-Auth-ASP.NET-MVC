namespace Custom_Auth.Security.Web
{
    public static class CustomSesstings
    {
        private static string _index = "Index";

        //Access Denied
        public static string AccessDeniedController = "AccessDenied";
        public static string AccessDeniedAction = _index;

        //Account
        public static string AccountController = "Account";
        public static string AccountAction = _index;
    }
}
