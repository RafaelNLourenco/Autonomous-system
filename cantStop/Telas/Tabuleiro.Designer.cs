﻿
namespace cantStop
{
    partial class Tabuleiro
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPartidaIniciada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(1280, 624);
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
            this.lblJogador.Location = new System.Drawing.Point(12, 69);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(45, 13);
            this.lblJogador.TabIndex = 9;
            this.lblJogador.Text = "Jogador";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(12, 39);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(76, 13);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "SenhaJogador";
            // 
            // lblCorJogador
            // 
            this.lblCorJogador.AutoSize = true;
            this.lblCorJogador.Location = new System.Drawing.Point(12, 9);
            this.lblCorJogador.Name = "lblCorJogador";
            this.lblCorJogador.Size = new System.Drawing.Size(61, 13);
            this.lblCorJogador.TabIndex = 11;
            this.lblCorJogador.Text = "CorJogador";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPartidaIniciada
            // 
            this.lblPartidaIniciada.AutoSize = true;
            this.lblPartidaIniciada.Location = new System.Drawing.Point(147, 612);
            this.lblPartidaIniciada.Name = "lblPartidaIniciada";
            this.lblPartidaIniciada.Size = new System.Drawing.Size(100, 13);
            this.lblPartidaIniciada.TabIndex = 12;
            this.lblPartidaIniciada.Text = "Partida não iniciada";
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 646);
            this.Controls.Add(this.lblPartidaIniciada);
            this.Controls.Add(this.lblCorJogador);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblVersao);
            this.Name = "Tabuleiro";
            this.Text = "Tabuleiro";
            this.Load += new System.EventHandler(this.Tabuleiro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCorJogador;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPartidaIniciada;
    }
}