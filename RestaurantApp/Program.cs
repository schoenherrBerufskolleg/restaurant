using RestaurantApp;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseManager manager = new DatabaseManager();
            manager.Connect();
            string command = "INSERT INTO Employee (FirstName, LastName, Username, password, Role) VALUES(\'Maik\', \'Bösert\', \'Nova Mane\', \'test123\', \'Waiter\')";
            string query = "SELECT * FROM Employee";
            manager.ExecuteQuery(query);
            //manager.ExecuteCommand(command);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            
        }
    }
}