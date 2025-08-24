using Python.Runtime;


namespace TranscritorApp;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
 
        // Inicializa o motor Python.NET
        PythonEngine.Initialize();
       
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
        
        // Desliga o motor Python ao fechar
        PythonEngine.Shutdown();
    }
}