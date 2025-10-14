namespace HMS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Guest());
            //Application.Run(new Booking());
            //  Application.Run(new AdminMain());
            // Application.Run(new AdminDashboard());
            //Application.Run(new admin_addUser());
            //Application.Run(new admin_rooms());
            Application.Run(new Login());


        }
    }
}