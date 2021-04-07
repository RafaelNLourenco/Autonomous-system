
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
            this.pcbDado4 = new System.Windows.Forms.PictureBox();
            this.pcbDado3 = new System.Windows.Forms.PictureBox();
            this.pcbDado1 = new System.Windows.Forms.PictureBox();
            this.pcbDado2 = new System.Windows.Forms.PictureBox();
            this.pcbTabuleiro = new System.Windows.Forms.PictureBox();
            this.gbxJogadas = new System.Windows.Forms.GroupBox();
            this.rbxOpcao3 = new System.Windows.Forms.RadioButton();
            this.rbxOpcao2 = new System.Windows.Forms.RadioButton();
            this.btnJogar = new System.Windows.Forms.Button();
            this.rbxOpcao1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTabuleiro)).BeginInit();
            this.gbxJogadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.ForeColor = System.Drawing.Color.White;
            this.lblVersao.Location = new System.Drawing.Point(1097, 612);
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
            this.lblJogador.Location = new System.Drawing.Point(1061, 33);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(45, 13);
            this.lblJogador.TabIndex = 9;
            this.lblJogador.Text = "Jogador";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(1061, 20);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(76, 13);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "SenhaJogador";
            // 
            // lblCorJogador
            // 
            this.lblCorJogador.AutoSize = true;
            this.lblCorJogador.ForeColor = System.Drawing.Color.White;
            this.lblCorJogador.Location = new System.Drawing.Point(1061, 7);
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
            // gbxJogadas
            // 
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
            this.rbxOpcao3.Text = "Opção 3";
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
            this.rbxOpcao2.Text = "Opção 2";
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
            this.rbxOpcao1.Text = "Opção 1";
            this.rbxOpcao1.UseVisualStyleBackColor = true;
            // 
            // FormTabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1149, 646);
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
            this.MaximizeBox = false;
            this.Name = "FormTabuleiro";
            this.Text = "Tabuleiro";
            this.Load += new System.EventHandler(this.Tabuleiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTabuleiro)).EndInit();
            this.gbxJogadas.ResumeLayout(false);
            this.gbxJogadas.PerformLayout();
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
    }
}