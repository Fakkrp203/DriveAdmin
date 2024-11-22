namespace CRUD_TEST
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Crear una instancia del formulario de Login
            Login loginForm = new Login();

            // Mostrar el formulario de Login como diálogo
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Si el diálogo devuelve OK (la autenticación es exitosa), abrir Form1
                Application.Run(new Form1());
            }
        }
    }
}
