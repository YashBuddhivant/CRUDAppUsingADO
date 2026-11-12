namespace CRUDAppUsingADO
{
    public static class ConnectionString
    {
        private static string cs = "Server=DESKTOP-8DM7RO6\\SQLEXPRESS; Database=CrudADOdb; Trusted_Connection=True; TrustServerCertificate=True;";
        public static string dbcs { get => cs; }
    }
}
