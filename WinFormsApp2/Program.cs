namespace WinFormsApp2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Main method is running");  // Check if this gets printed
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
