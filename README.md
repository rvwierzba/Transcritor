TRANSCRITOR APP by [RVWtech](https://www.rvwtech.com.br)

Uma aplicação de desktop para Windows, desenvolvida pela RVWtech, que automatiza o processo de transcrição e tradução de áudio de vídeos, funcionando de forma 100% offline após a instalação.

📜 Sobre o Projeto

Este programa foi criado para simplificar e acelerar o fluxo de trabalho de quem precisa extrair o conteúdo falado de arquivos de vídeo. Ele utiliza tecnologias de reconhecimento de fala e tradução automática para converter o áudio de um vídeo em texto, tanto no idioma original quanto traduzido.

✨ Funcionalidades Principais

    Transcrição de vídeos em Português.

    Transcrição de vídeos em Inglês.

    Tradução automática da transcrição em Inglês para Português.

    Interface simples e direta.

    Funcionalidade 100% offline após a configuração inicial.

🚀 Instalação

O programa é distribuído através de um instalador único que configura todas as dependências necessárias automaticamente.

⬇️ Download

➡️ [CLIQUE AQUI PARA BAIXAR O INSTALADOR (v1.0.0)](https://github.com/rvwierzba/Transcritor/releases/download/v1.0.0/Setup-Transcritor-RVWtech.exe)

📋 Passo a Passo da Instalação

    Execute o Instalador

        Após baixar, dê um duplo-clique no arquivo Setup-Transcritor-RVWtech.exe.

    Aviso de Segurança do Windows

        O Windows pode mostrar um aviso de segurança em uma tela azul ("O Windows protegeu o computador"). Isso é normal para programas de novos desenvolvedores.

        Clique na frase "Mais informações".

        Em seguida, clique no botão "Executar assim mesmo".

    Instalação das Dependências

        O instalador irá agora configurar o ambiente necessário. Ele irá:

            Instalar o .NET 8 Desktop Runtime.

            Instalar o Python.

            Instalar as bibliotecas de tradução.

        Este processo pode levar alguns minutos. Apenas aguarde a conclusão.

    Primeiro Uso do Programa

        Após a instalação, um ícone do programa aparecerá na sua Área de Trabalho.

        Na primeira vez que você abrir o programa, ele pode precisar instalar o modelo de tradução. Se uma mensagem sobre isso aparecer, apenas aguarde e clique em "OK" quando terminar.

⚙️ Como Funciona & Tecnologias Utilizadas

O instalador configura um ecossistema de ferramentas que trabalham em conjunto. O fluxo do programa é o seguinte:

    O usuário seleciona um arquivo de vídeo.

    O FFmpeg, uma poderosa ferramenta de manipulação de mídia, extrai o áudio do vídeo de forma silenciosa.

    A API Vosk (offline) processa o arquivo de áudio e realiza a transcrição de alta precisão para texto.

    Se a tradução for solicitada, a biblioteca Python.NET atua como uma ponte, permitindo que o programa chame a biblioteca Argos Translate (em Python) para realizar a tradução do texto.

    Os textos finalizados são exibidos na tela.

O instalador gerencia as seguintes dependências automaticamente:

    .NET 8 Desktop Runtime: O ambiente de execução principal para a aplicação.

    Python: Instalado de forma silenciosa para servir como base para a biblioteca de tradução.

    FFmpeg: Integrado ao projeto para extração de áudio.

    Vosk API: Biblioteca de reconhecimento de fala offline.

    Python.NET: A ponte que conecta o mundo C# e Python.

    Argos Translate: A biblioteca Python que realiza as traduções.

✒️ Autor

Desenvolvido por [RVWtech](https://www.rvwtech.com.br).
