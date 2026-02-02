namespace NorthstarCollection_portal
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Setup the PostgreSQL tables
            DatabaseHelper.InitializeDatabase();

            Application.Run(new Login());
        }
    }
}