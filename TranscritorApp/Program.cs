using Python.Runtime;
using System.Threading;

namespace TranscritorApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // --- CÓDIGO DE CAPTURA DE ERRO ---
            // Adiciona um "tratador" para erros na thread principal da UI
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);

            // Adiciona um "tratador" para erros em outras threads
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            // --- FIM DO CÓDIGO DE CAPTURA DE ERRO ---


            // O resto do seu código Main
            // Verifique se a versão da DLL do Python está correta para sua instalação
            Runtime.PythonDLL = Path.Combine("Python", "python311.dll"); 
            PythonEngine.Initialize();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            PythonEngine.Shutdown();
        }

        // --- MÉTODOS "SALVA-VIDAS" QUE ESTAVAM FALTANDO ---

        // Este método será chamado se um erro acontecer na UI
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show($"Ocorreu um erro inesperado na aplicação:\n\n{e.Exception.Message}\n\nDetalhes:\n{e.Exception.StackTrace}", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Este método será chamado se um erro acontecer fora da UI
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            MessageBox.Show($"Ocorreu um erro fatal na aplicação:\n\n{ex?.Message}\n\nDetalhes:\n{ex?.StackTrace}", "Erro Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}