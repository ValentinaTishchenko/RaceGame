namespace Race
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            using var welcomeForm = new WelcomeForm();
            var result = welcomeForm.ShowDialog();

            if (result == DialogResult.OK)
            {                
                Application.Run(new RaceGame(welcomeForm.PlayerName));
            }
        }
	}
}