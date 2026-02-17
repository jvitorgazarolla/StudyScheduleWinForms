using StudySchedule.Infrastructure.Data;

namespace StudySchedule
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
            if(!DbHealthCheck.canConnect(out var err))
            {
                MessageBox.Show("Falha ao conectar no banco:\n" + err, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                System.Windows.Forms.Application.Run(new LoginForm());


            }
        }
    }
}