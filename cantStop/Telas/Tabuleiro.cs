using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cantStop.Classes;
using CantStopServer;


namespace cantStop
{
    public partial class Tabuleiro : Form
    {
        public Jogador meuJogador = new Jogador();
        public Tabuleiro()
        {
            Lobby lobby = new Lobby();
            lobby.ShowDialog();
            InitializeComponent();
            this.meuJogador = lobby.jogadorCriado;
            lblVersao.Text = Jogo.Versao;
            if (this.meuJogador != null)
            {
                lblJogador.Text = this.meuJogador.nome;
                lblCorJogador.Text = this.meuJogador.cor;
                lblSenha.Text = this.meuJogador.senha;
            }
            timer1.Start();
        }

        private void Tabuleiro_Load(object sender, EventArgs e)
        {
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.IniciarPartida((int)this.meuJogador.id, this.meuJogador.senha);
            
            if (retorno[0] == 'E')
            {
                MessageBox.Show(retorno.Split(':')[1], "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnIniciarPartida.Hide();
                lblPartidaIniciada.Text = "Iniciada";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
