namespace TranscritorApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        btnSelectVideo = new System.Windows.Forms.Button();
        lblFileName = new System.Windows.Forms.Label();
        SelectIdiomaVideo = new System.Windows.Forms.GroupBox();
        radioEnglish = new System.Windows.Forms.RadioButton();
        checkTranslate = new System.Windows.Forms.CheckBox();
        radioPortuguese = new System.Windows.Forms.RadioButton();
        btnStart = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        txtTranslation = new System.Windows.Forms.TextBox();
        txtTranscription = new System.Windows.Forms.TextBox();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        linkRvw = new System.Windows.Forms.LinkLabel();
        label3 = new System.Windows.Forms.Label();
        SelectIdiomaVideo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // btnSelectVideo
        // 
        btnSelectVideo.Location = new System.Drawing.Point(38, 226);
        btnSelectVideo.Name = "btnSelectVideo";
        btnSelectVideo.Size = new System.Drawing.Size(170, 49);
        btnSelectVideo.TabIndex = 0;
        btnSelectVideo.Text = "Selecionar Vídeo...";
        btnSelectVideo.UseVisualStyleBackColor = true;
        // 
        // lblFileName
        // 
        lblFileName.Location = new System.Drawing.Point(234, 243);
        lblFileName.Name = "lblFileName";
        lblFileName.Size = new System.Drawing.Size(487, 48);
        lblFileName.TabIndex = 1;
        lblFileName.Text = "Nenhum vídeo selecionado";
        // 
        // SelectIdiomaVideo
        // 
        SelectIdiomaVideo.Controls.Add(radioEnglish);
        SelectIdiomaVideo.Controls.Add(checkTranslate);
        SelectIdiomaVideo.Controls.Add(radioPortuguese);
        SelectIdiomaVideo.Location = new System.Drawing.Point(32, 294);
        SelectIdiomaVideo.Name = "SelectIdiomaVideo";
        SelectIdiomaVideo.Size = new System.Drawing.Size(304, 70);
        SelectIdiomaVideo.TabIndex = 2;
        SelectIdiomaVideo.TabStop = false;
        SelectIdiomaVideo.Text = "Idioma do Vídeo";
        // 
        // radioEnglish
        // 
        radioEnglish.Location = new System.Drawing.Point(106, 19);
        radioEnglish.Name = "radioEnglish";
        radioEnglish.Size = new System.Drawing.Size(65, 38);
        radioEnglish.TabIndex = 4;
        radioEnglish.TabStop = true;
        radioEnglish.Text = "Inglês";
        radioEnglish.UseVisualStyleBackColor = true;
        // 
        // checkTranslate
        // 
        checkTranslate.Location = new System.Drawing.Point(172, 11);
        checkTranslate.Name = "checkTranslate";
        checkTranslate.Size = new System.Drawing.Size(117, 56);
        checkTranslate.TabIndex = 3;
        checkTranslate.Text = "Traduzir para o Português";
        checkTranslate.UseVisualStyleBackColor = true;
        checkTranslate.Visible = false;
        // 
        // radioPortuguese
        // 
        radioPortuguese.Location = new System.Drawing.Point(6, 22);
        radioPortuguese.Name = "radioPortuguese";
        radioPortuguese.Size = new System.Drawing.Size(103, 32);
        radioPortuguese.TabIndex = 3;
        radioPortuguese.TabStop = true;
        radioPortuguese.Text = "Português";
        radioPortuguese.UseVisualStyleBackColor = true;
        // 
        // btnStart
        // 
        btnStart.Location = new System.Drawing.Point(375, 312);
        btnStart.Name = "btnStart";
        btnStart.Size = new System.Drawing.Size(391, 41);
        btnStart.TabIndex = 4;
        btnStart.Text = "INICIAR TRANSCRIÇÃO";
        btnStart.UseVisualStyleBackColor = true;
        btnStart.Click += btnStart_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(55, 397);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(320, 38);
        label1.TabIndex = 5;
        label1.Text = "Transcrição Original";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(506, 397);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(135, 24);
        label2.TabIndex = 6;
        label2.Text = " Transcrição Traduzida";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtTranslation
        // 
        txtTranslation.Location = new System.Drawing.Point(418, 423);
        txtTranslation.Multiline = true;
        txtTranslation.Name = "txtTranslation";
        txtTranslation.ReadOnly = true;
        txtTranslation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtTranslation.Size = new System.Drawing.Size(320, 318);
        txtTranslation.TabIndex = 0;
        // 
        // txtTranscription
        // 
        txtTranscription.Location = new System.Drawing.Point(55, 423);
        txtTranscription.Multiline = true;
        txtTranscription.Name = "txtTranscription";
        txtTranscription.ReadOnly = true;
        txtTranscription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtTranscription.Size = new System.Drawing.Size(320, 318);
        txtTranscription.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(422, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(366, 176);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        pictureBox1.TabIndex = 7;
        pictureBox1.TabStop = false;
        // 
        // linkRvw
        // 
        linkRvw.Cursor = System.Windows.Forms.Cursors.Hand;
        linkRvw.Location = new System.Drawing.Point(422, 193);
        linkRvw.Name = "linkRvw";
        linkRvw.Size = new System.Drawing.Size(366, 24);
        linkRvw.TabIndex = 8;
        linkRvw.TabStop = true;
        linkRvw.Text = "Desenvolvido por RVWtech\r\n";
        linkRvw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        linkRvw.LinkClicked += linkRvw_LinkClicked;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
        label3.Location = new System.Drawing.Point(23, 23);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(340, 147);
        label3.TabIndex = 9;
        label3.Text = "Transcritor App\r\n";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
       
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 753);
        Controls.Add(label3);
        Controls.Add(linkRvw);
        Controls.Add(pictureBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(txtTranscription);
        Controls.Add(txtTranslation);
        Controls.Add(btnStart);
        Controls.Add(SelectIdiomaVideo);
        Controls.Add(lblFileName);
        Controls.Add(btnSelectVideo);
        Text = "Transcritor App by RVWtech";
        SelectIdiomaVideo.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.LinkLabel linkRvw;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.TextBox txtTranscription;

    private System.Windows.Forms.TextBox txtTranslation;

    

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    

    private System.Windows.Forms.Button btnStart;

    private System.Windows.Forms.CheckBox checkTranslate;

    private System.Windows.Forms.RadioButton radioPortuguese;
    private System.Windows.Forms.RadioButton radioEnglish;

    private System.Windows.Forms.GroupBox SelectIdiomaVideo;

    private System.Windows.Forms.Label lblFileName;

    private System.Windows.Forms.Button btnSelectVideo;

    #endregion
}