
namespace cantStop
{
    partial class FormTabuleiro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabuleiro));
            this.lblVersao = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.lblJogador = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCorJogador = new System.Windows.Forms.Label();
            this.lblPartidaIniciada = new System.Windows.Forms.Label();
            this.tmrPartidaIniciada = new System.Windows.Forms.Timer(this.components);
            this.tmrPartidaJogando = new System.Windows.Forms.Timer(this.components);
            this.btnRolarDados = new System.Windows.Forms.Button();
            this.btnPassarVez = new System.Windows.Forms.Button();
            this.gbxJogadas = new System.Windows.Forms.GroupBox();
            this.lblOu3 = new System.Windows.Forms.Label();
            this.lblOu2 = new System.Windows.Forms.Label();
            this.lblOu1 = new System.Windows.Forms.Label();
            this.rbxOpcao4 = new System.Windows.Forms.RadioButton();
            this.rbxOpcao5 = new System.Windows.Forms.RadioButton();
            this.rbxOpcao6 = new System.Windows.Forms.RadioButton();
            this.rbxOpcao3 = new System.Windows.Forms.RadioButton();
            this.rbxOpcao2 = new System.Windows.Forms.RadioButton();
            this.btnJogar = new System.Windows.Forms.Button();
            this.rbxOpcao1 = new System.Windows.Forms.RadioButton();
            this.pcbDado4 = new System.Windows.Forms.PictureBox();
            this.pcbDado3 = new System.Windows.Forms.PictureBox();
            this.pcbDado1 = new System.Windows.Forms.PictureBox();
            this.pcbDado2 = new System.Windows.Forms.PictureBox();
            this.pcbTabuleiro = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUltimasJogadas = new System.Windows.Forms.Label();
            this.lblUltimaJogada = new System.Windows.Forms.Label();
            this.lblAntipenultimaJogada = new System.Windows.Forms.Label();
            this.lblPenultinaJogada = new System.Windows.Forms.Label();
            this.gbxJogadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTabuleiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.ForeColor = System.Drawing.Color.White;
            this.lblVersao.Location = new System.Drawing.Point(1095, 621);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(40, 13);
            this.lblVersao.TabIndex = 0;
            this.lblVersao.Text = "Versão";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(15, 602);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(126, 32);
            this.btnIniciarPartida.TabIndex = 8;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.ForeColor = System.Drawing.Color.White;
            this.lblJogador.Location = new System.Drawing.Point(1123, 39);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(45, 13);
            this.lblJogador.TabIndex = 9;
            this.lblJogador.Text = "Jogador";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(1123, 26);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(76, 13);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "SenhaJogador";
            // 
            // lblCorJogador
            // 
            this.lblCorJogador.AutoSize = true;
            this.lblCorJogador.ForeColor = System.Drawing.Color.White;
            this.lblCorJogador.Location = new System.Drawing.Point(1123, 13);
            this.lblCorJogador.Name = "lblCorJogador";
            this.lblCorJogador.Size = new System.Drawing.Size(61, 13);
            this.lblCorJogador.TabIndex = 11;
            this.lblCorJogador.Text = "CorJogador";
            // 
            // lblPartidaIniciada
            // 
            this.lblPartidaIniciada.AutoSize = true;
            this.lblPartidaIniciada.ForeColor = System.Drawing.Color.White;
            this.lblPartidaIniciada.Location = new System.Drawing.Point(147, 612);
            this.lblPartidaIniciada.Name = "lblPartidaIniciada";
            this.lblPartidaIniciada.Size = new System.Drawing.Size(100, 13);
            this.lblPartidaIniciada.TabIndex = 12;
            this.lblPartidaIniciada.Text = "Partida não iniciada";
            // 
            // tmrPartidaIniciada
            // 
            this.tmrPartidaIniciada.Interval = 5000;
            this.tmrPartidaIniciada.Tick += new System.EventHandler(this.tmrPartidaIniciada_Tick);
            // 
            // tmrPartidaJogando
            // 
            this.tmrPartidaJogando.Interval = 2500;
            this.tmrPartidaJogando.Tick += new System.EventHandler(this.tmrPartidaJogando_Tick);
            // 
            // btnRolarDados
            // 
            this.btnRolarDados.Enabled = false;
            this.btnRolarDados.Location = new System.Drawing.Point(15, 7);
            this.btnRolarDados.Name = "btnRolarDados";
            this.btnRolarDados.Size = new System.Drawing.Size(106, 32);
            this.btnRolarDados.TabIndex = 14;
            this.btnRolarDados.Text = "Rolar Dados";
            this.btnRolarDados.UseVisualStyleBackColor = true;
            this.btnRolarDados.Click += new System.EventHandler(this.btnRolarDados_Click);
            // 
            // btnPassarVez
            // 
            this.btnPassarVez.Enabled = false;
            this.btnPassarVez.Location = new System.Drawing.Point(141, 7);
            this.btnPassarVez.Name = "btnPassarVez";
            this.btnPassarVez.Size = new System.Drawing.Size(106, 32);
            this.btnPassarVez.TabIndex = 15;
            this.btnPassarVez.Text = "Passar Vez";
            this.btnPassarVez.UseVisualStyleBackColor = true;
            this.btnPassarVez.Click += new System.EventHandler(this.btnPassarVez_Click);
            // 
            // gbxJogadas
            // 
            this.gbxJogadas.Controls.Add(this.lblOu3);
            this.gbxJogadas.Controls.Add(this.lblOu2);
            this.gbxJogadas.Controls.Add(this.lblOu1);
            this.gbxJogadas.Controls.Add(this.rbxOpcao4);
            this.gbxJogadas.Controls.Add(this.rbxOpcao5);
            this.gbxJogadas.Controls.Add(this.rbxOpcao6);
            this.gbxJogadas.Controls.Add(this.rbxOpcao3);
            this.gbxJogadas.Controls.Add(this.rbxOpcao2);
            this.gbxJogadas.Controls.Add(this.btnJogar);
            this.gbxJogadas.Controls.Add(this.rbxOpcao1);
            this.gbxJogadas.Enabled = false;
            this.gbxJogadas.ForeColor = System.Drawing.Color.White;
            this.gbxJogadas.Location = new System.Drawing.Point(15, 284);
            this.gbxJogadas.Name = "gbxJogadas";
            this.gbxJogadas.Size = new System.Drawing.Size(232, 130);
            this.gbxJogadas.TabIndex = 23;
            this.gbxJogadas.TabStop = false;
            this.gbxJogadas.Tag = "jogadas";
            this.gbxJogadas.Text = "Jogadas";
            this.gbxJogadas.Visible = false;
            // 
            // lblOu3
            // 
            this.lblOu3.AutoSize = true;
            this.lblOu3.Location = new System.Drawing.Point(87, 67);
            this.lblOu3.Name = "lblOu3";
            this.lblOu3.Size = new System.Drawing.Size(19, 13);
            this.lblOu3.TabIndex = 8;
            this.lblOu3.Text = "ou";
            this.lblOu3.Visible = false;
            // 
            // lblOu2
            // 
            this.lblOu2.AutoSize = true;
            this.lblOu2.Location = new System.Drawing.Point(87, 44);
            this.lblOu2.Name = "lblOu2";
            this.lblOu2.Size = new System.Drawing.Size(19, 13);
            this.lblOu2.TabIndex = 7;
            this.lblOu2.Text = "ou";
            this.lblOu2.Visible = false;
            // 
            // lblOu1
            // 
            this.lblOu1.AutoSize = true;
            this.lblOu1.Location = new System.Drawing.Point(87, 19);
            this.lblOu1.Name = "lblOu1";
            this.lblOu1.Size = new System.Drawing.Size(19, 13);
            this.lblOu1.TabIndex = 6;
            this.lblOu1.Text = "ou";
            this.lblOu1.Visible = false;
            // 
            // rbxOpcao4
            // 
            this.rbxOpcao4.AutoSize = true;
            this.rbxOpcao4.ForeColor = System.Drawing.Color.White;
            this.rbxOpcao4.Location = new System.Drawing.Point(126, 19);
            this.rbxOpcao4.Name = "rbxOpcao4";
            this.rbxOpcao4.Size = new System.Drawing.Size(66, 17);
            this.rbxOpcao4.TabIndex = 5;
            this.rbxOpcao4.TabStop = true;
            this.rbxOpcao4.Tag = "jogada";
            this.rbxOpcao4.Text = "Opcao 4";
            this.rbxOpcao4.UseVisualStyleBackColor = true;
            // 
            // rbxOpcao5
            // 
            this.rbxOpcao5.AutoSize = true;
            this.rbxOpcao5.ForeColor = System.Drawing.Color.White;
            this.rbxOpcao5.Location = new System.Drawing.Point(126, 42);
            this.rbxOpcao5.Name = "rbxOpcao5";
            this.rbxOpcao5.Size = new System.Drawing.Size(66, 17);
            this.rbxOpcao5.TabIndex = 4;
            this.rbxOpcao5.TabStop = true;
            this.rbxOpcao5.Tag = "jogada";
            this.rbxOpcao5.Text = "Opcao 5";
            this.rbxOpcao5.UseVisualStyleBackColor = true;
            // 
            // rbxOpcao6
            // 
            this.rbxOpcao6.AutoSize = true;
            this.rbxOpcao6.ForeColor = System.Drawing.Color.White;
            this.rbxOpcao6.Location = new System.Drawing.Point(126, 65);
            this.rbxOpcao6.Name = "rbxOpcao6";
            this.rbxOpcao6.Size = new System.Drawing.Size(66, 17);
            this.rbxOpcao6.TabIndex = 3;
            this.rbxOpcao6.TabStop = true;
            this.rbxOpcao6.Tag = "jogada";
            this.rbxOpcao6.Text = "Opcao 6";
            this.rbxOpcao6.UseVisualStyleBackColor = true;
            // 
            // rbxOpcao3
            // 
            this.rbxOpcao3.AutoSize = true;
            this.rbxOpcao3.ForeColor = System.Drawing.Color.White;
            this.rbxOpcao3.Location = new System.Drawing.Point(9, 65);
            this.rbxOpcao3.Name = "rbxOpcao3";
            this.rbxOpcao3.Size = new System.Drawing.Size(66, 17);
            this.rbxOpcao3.TabIndex = 2;
            this.rbxOpcao3.TabStop = true;
            this.rbxOpcao3.Tag = "jogada";
            this.rbxOpcao3.Text = "Opcao 3";
            this.rbxOpcao3.UseVisualStyleBackColor = true;
            // 
            // rbxOpcao2
            // 
            this.rbxOpcao2.AutoSize = true;
            this.rbxOpcao2.ForeColor = System.Drawing.Color.White;
            this.rbxOpcao2.Location = new System.Drawing.Point(9, 42);
            this.rbxOpcao2.Name = "rbxOpcao2";
            this.rbxOpcao2.Size = new System.Drawing.Size(66, 17);
            this.rbxOpcao2.TabIndex = 1;
            this.rbxOpcao2.TabStop = true;
            this.rbxOpcao2.Tag = "jogada";
            this.rbxOpcao2.Text = "Opcao 2";
            this.rbxOpcao2.UseVisualStyleBackColor = true;
            // 
            // btnJogar
            // 
            this.btnJogar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnJogar.Location = new System.Drawing.Point(6, 88);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(220, 32);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // rbxOpcao1
            // 
            this.rbxOpcao1.AutoSize = true;
            this.rbxOpcao1.ForeColor = System.Drawing.Color.White;
            this.rbxOpcao1.Location = new System.Drawing.Point(9, 19);
            this.rbxOpcao1.Name = "rbxOpcao1";
            this.rbxOpcao1.Size = new System.Drawing.Size(66, 17);
            this.rbxOpcao1.TabIndex = 0;
            this.rbxOpcao1.TabStop = true;
            this.rbxOpcao1.Tag = "jogada";
            this.rbxOpcao1.Text = "Opcao 1";
            this.rbxOpcao1.UseVisualStyleBackColor = true;
            // 
            // pcbDado4
            // 
            this.pcbDado4.Image = global::cantStop.Properties.Resources.dado1;
            this.pcbDado4.Location = new System.Drawing.Point(153, 183);
            this.pcbDado4.Name = "pcbDado4";
            this.pcbDado4.Size = new System.Drawing.Size(80, 80);
            this.pcbDado4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDado4.TabIndex = 22;
            this.pcbDado4.TabStop = false;
            // 
            // pcbDado3
            // 
            this.pcbDado3.Image = global::cantStop.Properties.Resources.dado1;
            this.pcbDado3.Location = new System.Drawing.Point(29, 183);
            this.pcbDado3.Name = "pcbDado3";
            this.pcbDado3.Size = new System.Drawing.Size(80, 80);
            this.pcbDado3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDado3.TabIndex = 21;
            this.pcbDado3.TabStop = false;
            // 
            // pcbDado1
            // 
            this.pcbDado1.Image = global::cantStop.Properties.Resources.dado1;
            this.pcbDado1.Location = new System.Drawing.Point(29, 60);
            this.pcbDado1.Name = "pcbDado1";
            this.pcbDado1.Size = new System.Drawing.Size(80, 80);
            this.pcbDado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDado1.TabIndex = 20;
            this.pcbDado1.TabStop = false;
            // 
            // pcbDado2
            // 
            this.pcbDado2.Image = global::cantStop.Properties.Resources.dado1;
            this.pcbDado2.Location = new System.Drawing.Point(153, 60);
            this.pcbDado2.Name = "pcbDado2";
            this.pcbDado2.Size = new System.Drawing.Size(80, 80);
            this.pcbDado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDado2.TabIndex = 19;
            this.pcbDado2.TabStop = false;
            // 
            // pcbTabuleiro
            // 
            this.pcbTabuleiro.Image = global::cantStop.Properties.Resources.tabuleiroleiro;
            this.pcbTabuleiro.Location = new System.Drawing.Point(267, 7);
            this.pcbTabuleiro.Name = "pcbTabuleiro";
            this.pcbTabuleiro.Size = new System.Drawing.Size(630, 630);
            this.pcbTabuleiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTabuleiro.TabIndex = 13;
            this.pcbTabuleiro.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(953, 372);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // lblUltimasJogadas
            // 
            this.lblUltimasJogadas.AutoSize = true;
            this.lblUltimasJogadas.ForeColor = System.Drawing.Color.White;
            this.lblUltimasJogadas.Location = new System.Drawing.Point(903, 416);
            this.lblUltimasJogadas.Name = "lblUltimasJogadas";
            this.lblUltimasJogadas.Size = new System.Drawing.Size(81, 13);
            this.lblUltimasJogadas.TabIndex = 24;
            this.lblUltimasJogadas.Text = "Ultimas jogadas";
            // 
            // lblUltimaJogada
            // 
            this.lblUltimaJogada.AutoSize = true;
            this.lblUltimaJogada.ForeColor = System.Drawing.Color.White;
            this.lblUltimaJogada.Location = new System.Drawing.Point(903, 441);
            this.lblUltimaJogada.Name = "lblUltimaJogada";
            this.lblUltimaJogada.Size = new System.Drawing.Size(74, 13);
            this.lblUltimaJogada.TabIndex = 25;
            this.lblUltimaJogada.Text = "Ultima Jogada";
            // 
            // lblAntipenultimaJogada
            // 
            this.lblAntipenultimaJogada.AutoSize = true;
            this.lblAntipenultimaJogada.ForeColor = System.Drawing.Color.White;
            this.lblAntipenultimaJogada.Location = new System.Drawing.Point(903, 489);
            this.lblAntipenultimaJogada.Name = "lblAntipenultimaJogada";
            this.lblAntipenultimaJogada.Size = new System.Drawing.Size(106, 13);
            this.lblAntipenultimaJogada.TabIndex = 27;
            this.lblAntipenultimaJogada.Text = "Antipenultina Jogada";
            // 
            // lblPenultinaJogada
            // 
            this.lblPenultinaJogada.AutoSize = true;
            this.lblPenultinaJogada.ForeColor = System.Drawing.Color.White;
            this.lblPenultinaJogada.Location = new System.Drawing.Point(903, 464);
            this.lblPenultinaJogada.Name = "lblPenultinaJogada";
            this.lblPenultinaJogada.Size = new System.Drawing.Size(91, 13);
            this.lblPenultinaJogada.TabIndex = 26;
            this.lblPenultinaJogada.Text = "Penultima Jogada";
            // 
            // FormTabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1211, 646);
            this.Controls.Add(this.lblAntipenultimaJogada);
            this.Controls.Add(this.lblPenultinaJogada);
            this.Controls.Add(this.lblUltimaJogada);
            this.Controls.Add(this.lblUltimasJogadas);
            this.Controls.Add(this.gbxJogadas);
            this.Controls.Add(this.pcbDado4);
            this.Controls.Add(this.pcbDado3);
            this.Controls.Add(this.pcbDado1);
            this.Controls.Add(this.pcbDado2);
            this.Controls.Add(this.btnPassarVez);
            this.Controls.Add(this.btnRolarDados);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.pcbTabuleiro);
            this.Controls.Add(this.lblPartidaIniciada);
            this.Controls.Add(this.lblCorJogador);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.btnIniciarPartida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTabuleiro";
            this.Text = "Tabuleiro";
            this.Load += new System.EventHandler(this.Tabuleiro_Load);
            this.gbxJogadas.ResumeLayout(false);
            this.gbxJogadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTabuleiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCorJogador;
        private System.Windows.Forms.Label lblPartidaIniciada;
        private System.Windows.Forms.Timer tmrPartidaIniciada;
        private System.Windows.Forms.Timer tmrPartidaJogando;
        private System.Windows.Forms.PictureBox pcbTabuleiro;
        private System.Windows.Forms.Button btnRolarDados;
        private System.Windows.Forms.Button btnPassarVez;
        private System.Windows.Forms.PictureBox pcbDado2;
        private System.Windows.Forms.PictureBox pcbDado1;
        private System.Windows.Forms.PictureBox pcbDado3;
        private System.Windows.Forms.PictureBox pcbDado4;
        private System.Windows.Forms.GroupBox gbxJogadas;
        private System.Windows.Forms.RadioButton rbxOpcao3;
        private System.Windows.Forms.RadioButton rbxOpcao2;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.RadioButton rbxOpcao1;
        private System.Windows.Forms.RadioButton rbxOpcao4;
        private System.Windows.Forms.RadioButton rbxOpcao5;
        private System.Windows.Forms.RadioButton rbxOpcao6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblOu3;
        private System.Windows.Forms.Label lblOu2;
        private System.Windows.Forms.Label lblOu1;
        private System.Windows.Forms.Label lblUltimasJogadas;
        private System.Windows.Forms.Label lblUltimaJogada;
        private System.Windows.Forms.Label lblAntipenultimaJogada;
        private System.Windows.Forms.Label lblPenultinaJogada;
    }
}