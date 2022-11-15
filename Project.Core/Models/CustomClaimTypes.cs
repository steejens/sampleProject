namespace Project.Core.Models
{
    public static class CustomClaimTypes
    {
        internal const string ClaimTypeNamespace = "http://schemas.microsoft.com/ws/2008/06/identity/claims";
        public const string Application = ClaimTypeNamespace + "/application";


        public static List<string> Types = new()
        {
            Application,

        };
    }
}
