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

            // Mostrar el formulario de Login como di�logo
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Si el di�logo devuelve OK (la autenticaci�n es exitosa), abrir Form1
                Application.Run(new Form1());
            }
        }
    }
}
