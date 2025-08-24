using Xabe.FFmpeg;
using Vosk;
using System.Text.Json;
using Python.Runtime;
using System.Diagnostics;

namespace TranscritorApp;
public partial class Form1 : Form
{
    private string _selectedVideoPath = string.Empty; // Variável para guardar o caminho do vídeo
    public Form1()
    {
        InitializeComponent();
        
        // --- CONECTE SEUS EVENTOS AQUI ---
        // Sintaxe: nomeDoComponente.NomeDoEvento += nomeDoSeuMetodo;

        btnStart.Click += btnStart_Click;
        btnSelectVideo.Click += BtnSelectVideo_Click;
        linkRvw.LinkClicked += linkRvw_LinkClicked;

        // Dica Pro: Ambos os RadioButtons podem usar o MESMO método de evento!
        radioEnglish.CheckedChanged += Language_CheckedChanged;
        radioPortuguese.CheckedChanged += Language_CheckedChanged;
    }

    // --- CRIE SEUS MÉTODOS AQUI ---
    // Agora, você cria os métodos que serão executados

    private async void btnStart_Click(object? sender, EventArgs e)
    {
         if (string.IsNullOrEmpty(_selectedVideoPath))
        {
            MessageBox.Show("Por favor, selecione um arquivo de vídeo primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string outputPath = Path.Combine(Path.GetTempPath(), "extracted_audio.wav");

        try
        {
            // --- FASE 2: EXTRAÇÃO DE ÁUDIO COM FFmpeg (Lógica Ajustada) ---
            this.Text = "Extraindo áudio, por favor aguarde...";
            FFmpeg.SetExecutablesPath("ffmpeg"); // Avisa a biblioteca para procurar na pasta ffmpeg

            // Comando ajustado para garantir compatibilidade com a Vosk (16kHz, mono)
            IConversion conversion = FFmpeg.Conversions.New()
                .AddParameter($"-i \"{_selectedVideoPath}\"")
                .AddParameter("-ac 1")
                .AddParameter("-ar 16000")
                .SetOutput(outputPath)
                .SetOverwriteOutput(true);
            
            await conversion.Start();

            // --- FASE 3: TRANSCRIÇÃO DE ÁUDIO COM VOSK ---
            this.Text = "Transcrevendo áudio...";

            // Decide qual caminho de modelo usar com base na seleção do usuário
            string modelPath = radioPortuguese.Checked
                ? Path.Combine("models", "model-pt")
                : Path.Combine("models", "model-en");

            // Chama o método de transcrição
            string transcribedText = TranscribeAudio(outputPath, modelPath);

            // Exibe o resultado na caixa de texto
            this.Invoke((MethodInvoker)delegate
            {
                txtTranscription.Text = transcribedText;
                MessageBox.Show("Transcrição concluída!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Text = "RVWtech Transcritor";
            });
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro no processo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Text = "RVWtech Transcritor";
        }
        finally
        {
            // Opcional: Limpa o arquivo de áudio temporário após o uso
            if(File.Exists(outputPath))
            {
                File.Delete(outputPath);
            }
        }
    }

    private void BtnSelectVideo_Click(object? sender, EventArgs e)
    {
        // Cria uma nova janela de diálogo para abrir arquivos
        using (OpenFileDialog dialog = new OpenFileDialog())
        {
            dialog.Title = "Selecione um arquivo de vídeo";
            // Filtro para mostrar apenas os tipos de vídeo mais comuns
            dialog.Filter = "Arquivos de Vídeo|*.mp4;*.mkv;*.avi;*.mov;*.wmv|Todos os Arquivos|*.*";

            // Se o usuário clicar em "OK" na janela...
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Guarda o caminho completo do arquivo na nossa variável
                _selectedVideoPath = dialog.FileName;

                // Atualiza o rótulo na tela para mostrar o nome do arquivo
                lblFileName.Text = Path.GetFileName(_selectedVideoPath);
            }
        }
    }

    private void linkRvw_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
    {
        try
        {
            // Define o link que será aberto
            string url = "http://www.rvwtech.com.br";

            // Abre o link no navegador padrão do usuário
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
        catch (Exception ex)
        {
            // Mostra uma mensagem de erro caso não seja possível abrir o link
            MessageBox.Show($"Não foi possível abrir o link. Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void Language_CheckedChanged(object? sender, EventArgs e)
    {
        // Como ambos os radios chamam este método, podemos ter uma lógica central
        // para mostrar ou esconder a checkbox de tradução.
        checkTranslate.Visible = radioEnglish.Checked;
    }
    
    private string TranscribeAudio(string audioPath, string modelPath)
    {
        using (var model = new Model(modelPath))
        using (var recognizer = new VoskRecognizer(model, 16000.0f))
        {
            using (var stream = File.OpenRead(audioPath))
            {
                byte[] buffer = new byte[4096];
                int bytesRead;
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    recognizer.AcceptWaveform(buffer, bytesRead);
                }
            }

            string finalResultJson = recognizer.FinalResult();

            // A forma correta e segura de ler o JSON
            using (JsonDocument jsonDoc = JsonDocument.Parse(finalResultJson))
            {
                // Tenta obter a propriedade "text"
                if (jsonDoc.RootElement.TryGetProperty("text", out JsonElement textElement))
                {
                    // Se encontrar, retorna seu valor como string
                    return textElement.GetString() ?? string.Empty;
                }
            }
        }
        // Retorna uma string vazia se a propriedade "text" não for encontrada
        return string.Empty;
    }
 
    private async Task<string> TranslateText(string textToTranslate)
    {
        return await Task.Run(() =>
        {
            string result = string.Empty;
            try
            {
                // 1. Adquire o "Global Interpreter Lock" do Python. Essencial para interagir com Python.
                using (Py.GIL())
                {
                    // 2. Importa o módulo de tradução do argostranslate
                    dynamic argos = Py.Import("argostranslate.translate");

                    // 3. Pega a tradução específica de Inglês para Português
                    // O Python.NET converte a lista de objetos Python para um tipo que podemos usar
                    PyObject installed_translations = argos.get_installed_translations();
                    dynamic en_to_pt_translation = installed_translations.InvokeMethod("get_translation_from_codes", new PyObject[] { new PyString("en"), new PyString("pt") });

                    // 4. Se a tradução foi encontrada, chama o método "translate" dela
                    if (en_to_pt_translation != null)
                    {
                        result = en_to_pt_translation.InvokeMethod("translate", new PyObject[] { new PyString(textToTranslate) }).ToString();
                    }
                    else
                    {
                        result = "ERRO: Modelo de tradução EN->PT não instalado no ambiente Python.";
                    }
                }
            }
            catch(Exception ex)
            {
                result = $"ERRO ao chamar o Python: {ex.Message}";
            }
            return result;
        });
    
    }
}