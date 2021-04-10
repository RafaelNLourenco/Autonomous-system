using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using cantStop.Classes;
using CantStopServer;


namespace cantStop
{
    public partial class FormTabuleiro : Form
    {
        private Jogador jogador;
        private Partida partida;
        private Tabuleiro tabuleiro;
        private FormLobby lobby;

        private List<PictureBox> pecas;
        List<PictureBox> pcbDados;

        private bool fazendoJogada;

        public FormTabuleiro()
        {
            lobby = new FormLobby();
            lobby.ShowDialog();

            InitializeComponent();
            if (!lobby.entrou) this.Hide();
            else
            {
                this.tabuleiro = new Tabuleiro();
                this.partida = lobby.partidaSelecionada;
                this.jogador = lobby.jogadorCriado;

                this.pecas = new List<PictureBox>();

                this.lblVersao.Text = Jogo.Versao;

                this.lblJogador.Text = this.jogador.nome;
                this.lblCorJogador.Text = this.jogador.cor;
                this.lblSenha.Text = this.jogador.senha;

                this.fazendoJogada = false;

                this.tmrPartidaIniciada.Start();

                this.pcbDados = new List<PictureBox>();
                this.pcbDados.Add(pcbDado1);
                this.pcbDados.Add(pcbDado2);
                this.pcbDados.Add(pcbDado3);
                this.pcbDados.Add(pcbDado4);
            }
            
        }

        private void Tabuleiro_Load(object sender, EventArgs e)
        {
            if (!this.lobby.entrou) 
            {
                this.Close();
                return;
            }
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.IniciarPartida((int)this.jogador.id, this.jogador.senha);
            if (retorno[0] == 'E'){
                MessageBox.Show(retorno.Split(':')[1], "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                this.iniciar();
            }
        }

        private void iniciar()
        {
            this.tmrPartidaIniciada.Stop();

            this.btnIniciarPartida.Hide();
            this.lblPartidaIniciada.Location = new Point(12, 612);
            this.lblPartidaIniciada.Text = "Iniciada";

            this.tmrPartidaJogando.Start();
        }

        private void tmrPartidaIniciada_Tick(object sender, EventArgs e)
        {
            ListaPartidas partidas = new ListaPartidas("J");

            foreach (Partida partida in partidas.dadosPartidas)
            {
                if (partida.Id == this.partida.Id)
                {
                    this.iniciar();
                    return;
                }
            }
        }

        private void tmrPartidaJogando_Tick(object sender, EventArgs e)
        {
            if (this.partida.VerificarVez().id == this.jogador.id && !this.fazendoJogada){
                this.setBotoes(true);
            }

            this.tabuleiro.atualizarTabuleiro((int)this.partida.Id);

            foreach (PictureBox peca in this.pecas)
            {
                this.Controls.Remove(peca);
                peca.Dispose();
            }
            this.pecas.Clear();

            for (int i = 2; i <= 12; i++)
            {
                DataTable coluna = this.tabuleiro.SelecioneColuna(i);

                for (int j = 1; j <= getQuantidadePosicao(i) && coluna.Rows.Count > 0; j++)
                {
                    DataRow[] linhas = coluna.Select("posicao = '" + j.ToString() + "' AND tipo = 'B'");

                    if (linhas.Length > 0) 
                    {
                        string cor = "";
                        foreach (DataRow linha in linhas)
                        {
                            switch (int.Parse(linha.Field<string>("jogador")))
                            {
                                case 1:
                                    cor += "r";
                                    break;
                                case 2:
                                    cor += "b";
                                    break;
                                case 3:
                                    cor += "g";
                                    break;
                                case 4:
                                    cor += "y";
                                    break;
                            }
                        }

                        PictureBox baseAlpinista = this.adicionarBase(cor, i, j);
                        this.pecas.Add(baseAlpinista);
                        this.Controls.Add(baseAlpinista);
                        baseAlpinista.BringToFront();
                    }

                    linhas = coluna.Select("posicao = '" + j.ToString() + "' AND tipo = 'A'");
                    if(linhas.Length > 0)
                    {
                        PictureBox alpinista = new PictureBox();
                        alpinista.Image = cantStop.Properties.Resources.pointW;
                        alpinista.Size = new Size(12, 12);
                        alpinista.SizeMode = PictureBoxSizeMode.StretchImage;

                        Point posicao = this.pegarPositacao(i, j);
                        posicao.X = posicao.X - (12 / 2) + (35 / 2);
                        posicao.Y = posicao.Y - (12 / 2) + (35 / 2);
                        alpinista.Location = posicao;

                        this.pecas.Add(alpinista);
                        this.Controls.Add(alpinista);
                        alpinista.BringToFront();
                    }
                }
            }
        }

        private void btnRolarDados_Click(object sender, EventArgs e)
        {
            this.setBotoes(false);
            this.fazendoJogada = true;
            List<int> dados = jogador.RolarDados();

            for(int i = 0; i < 4; i++)
            {
                switch (dados[i])
                {
                    case 1:
                        this.pcbDados[i].Image = cantStop.Properties.Resources.dado1;
                        break;
                    case 2:
                        this.pcbDados[i].Image = cantStop.Properties.Resources.dado2;
                        break;
                    case 3:
                        this.pcbDados[i].Image = cantStop.Properties.Resources.dado3;
                        break;
                    case 4:
                        this.pcbDados[i].Image = cantStop.Properties.Resources.dado4;
                        break;
                    case 5:
                        this.pcbDados[i].Image = cantStop.Properties.Resources.dado5;
                        break;
                    case 6:
                        this.pcbDados[i].Image = cantStop.Properties.Resources.dado6;
                        break;
                }
            }

            this.rbxOpcao1.Text = (dados[0] + dados[1]).ToString() + " e " + (dados[2] + dados[3]).ToString();
            this.rbxOpcao2.Text = (dados[0] + dados[2]).ToString() + " e " + (dados[1] + dados[3]).ToString();
            this.rbxOpcao3.Text = (dados[0] + dados[3]).ToString() + " e " + (dados[1] + dados[2]).ToString();

            this.gbxJogadas.Visible = true;
            this.gbxJogadas.Enabled = true;
        }

        private void btnPassarVez_Click(object sender, EventArgs e)
        {
            this.setBotoes(false);
            jogador.Parar();
        }

        private void setBotoes(bool valor)
        {
            this.btnRolarDados.Enabled = valor;
            this.btnPassarVez.Enabled = valor;
        }

        private int getQuantidadePosicao(int coluna)
        {
            return 13 - ((coluna <= 7) ? (2 * (7 - coluna)) : (2 * (coluna - 7)));
        }

        private PictureBox adicionarBase(string cor, int coluna, int posicao)
        {
            PictureBox retorno = new PictureBox();
            retorno.Name = "pictureBox";
            retorno.Size = new Size(35, 35);
            retorno.SizeMode = PictureBoxSizeMode.StretchImage;
            retorno.Location = pegarPositacao(coluna, posicao);

            // Uma base
            if (cor.Contains("b") && cor.Length == 1) retorno.Image = cantStop.Properties.Resources.jgdB;
            if (cor.Contains("g") && cor.Length == 1) retorno.Image = cantStop.Properties.Resources.jgdG;
            if (cor.Contains("r") && cor.Length == 1) retorno.Image = cantStop.Properties.Resources.jgdR;
            if (cor.Contains("y") && cor.Length == 1) retorno.Image = cantStop.Properties.Resources.jgdY;

            // Duas bases
            if (cor.Contains("g") && cor.Contains("b") && cor.Length == 2) retorno.Image = cantStop.Properties.Resources.jgdGB;
            if (cor.Contains("g") && cor.Contains("y") && cor.Length == 2) retorno.Image = cantStop.Properties.Resources.jgdGY;
            if (cor.Contains("r") && cor.Contains("b") && cor.Length == 2) retorno.Image = cantStop.Properties.Resources.jgdRB;
            if (cor.Contains("r") && cor.Contains("g") && cor.Length == 2) retorno.Image = cantStop.Properties.Resources.jgdRG;
            if (cor.Contains("r") && cor.Contains("y") && cor.Length == 2) retorno.Image = cantStop.Properties.Resources.jgdRY;
            if (cor.Contains("y") && cor.Contains("b") && cor.Length == 2) retorno.Image = cantStop.Properties.Resources.jgdYB;

            // Três bases
            if (cor.Contains("r") && cor.Contains("b") && cor.Contains("g") && cor.Length == 3) retorno.Image = cantStop.Properties.Resources.jgdRBG;
            if (cor.Contains("r") && cor.Contains("b") && cor.Contains("y") && cor.Length == 3) retorno.Image = cantStop.Properties.Resources.jgdRBY;
            if (cor.Contains("r") && cor.Contains("y") && cor.Contains("g") && cor.Length == 3) retorno.Image = cantStop.Properties.Resources.jgdRYG;
            if (cor.Contains("y") && cor.Contains("b") && cor.Contains("g") && cor.Length == 3) retorno.Image = cantStop.Properties.Resources.jgdYBG;

            // Quatro bases
            if (cor.Contains("r") && cor.Contains("b") && cor.Contains("y") && cor.Contains("g")) retorno.Image = cantStop.Properties.Resources.jgdRBYG;

            return retorno;
        }

        private Point pegarPositacao(int coluna, int posicao)
        {
            Point ponto = new Point();

            if (coluna == 2 || coluna == 12)
            {
                ponto.X = (coluna == 2) ? 357 : 772;
                switch (posicao)
                {
                    case 1:
                        ponto.Y = 354;
                        break;
                    case 2:
                        ponto.Y = 308;
                        break;
                    case 3:
                        ponto.Y = 260;
                        break;
                }
            }

            if (coluna == 3 || coluna == 11)
            {
                ponto.X = (coluna == 3) ? 397 : 732;
                switch (posicao)
                {
                    case 1:
                        ponto.Y = 396;
                        break;
                    case 2:
                        ponto.Y = 350;
                        break;
                    case 3:
                        ponto.Y = 307;
                        break;
                    case 4:
                        ponto.Y = 262;
                        break;
                    case 5:
                        ponto.Y = 217;
                        break;
                }
            }
            
            if (coluna == 4 || coluna == 10)
            {
                ponto.X = (coluna == 4) ? 439 : 690;
                switch (posicao)
                {
                    case 1:
                        ponto.Y = 436;
                        break;
                    case 2:
                        ponto.Y = 390;
                        break;
                    case 3:
                        ponto.Y = 350;
                        break;
                    case 4:
                        ponto.Y = 308;
                        break;
                    case 5:
                        ponto.Y = 262;
                        break;
                    case 6:
                        ponto.Y = 220;
                        break;
                    case 7:
                        ponto.Y = 177;
                        break;
                }
            }

            if (coluna == 5 || coluna == 9)
            {
                ponto.X = (coluna == 5) ? 479 : 650;
                switch (posicao)
                {
                    case 1:
                        ponto.Y = 478;
                        break;
                    case 2:
                        ponto.Y = 432;
                        break;
                    case 3:
                        ponto.Y = 390;
                        break;
                    case 4:
                        ponto.Y = 350;
                        break;
                    case 5:
                        ponto.Y = 308;
                        break;
                    case 6:
                        ponto.Y = 263;
                        break;
                    case 7:
                        ponto.Y = 220;
                        break;
                    case 8:
                        ponto.Y = 177;
                        break;
                    case 9:
                        ponto.Y = 134;
                        break;
                }
            }

            if (coluna == 6 || coluna == 8)
            {
                ponto.X = (coluna == 6) ? 522 : 607;
                switch (posicao)
                {
                    case 1:
                        ponto.Y = 520;
                        break;
                    case 2:
                        ponto.Y = 474;
                        break;
                    case 3:
                        ponto.Y = 432;
                        break;
                    case 4:
                        ponto.Y = 390;
                        break;
                    case 5:
                        ponto.Y = 350;
                        break;
                    case 6:
                        ponto.Y = 308;
                        break;
                    case 7:
                        ponto.Y = 265;
                        break;
                    case 8:
                        ponto.Y = 222;
                        break;
                    case 9:
                        ponto.Y = 178;
                        break;
                    case 10:
                        ponto.Y = 138;
                        break;
                    case 11:
                        ponto.Y = 92;
                        break;
                }
            }

            if (coluna == 7)
            {
                ponto.X = 565;
                switch (posicao)
                {
                    case 1:
                        ponto.Y = 563;
                        break;
                    case 2:
                        ponto.Y = 517;
                        break;
                    case 3:
                        ponto.Y = 474;
                        break;
                    case 4:
                        ponto.Y = 432;
                        break;
                    case 5:
                        ponto.Y = 390;
                        break;
                    case 6:
                        ponto.Y = 350;
                        break;
                    case 7:
                        ponto.Y = 308;
                        break;
                    case 8:
                        ponto.Y = 265;
                        break;
                    case 9:
                        ponto.Y = 223;
                        break;
                    case 10:
                        ponto.Y = 180;
                        break;
                    case 11:
                        ponto.Y = 138;
                        break;
                    case 12:
                        ponto.Y = 95;
                        break;
                    case 13:
                        ponto.Y = 51;
                        break;
                }
            }

            return ponto;
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (this.rbxOpcao1.Checked)
            {

            }
            else
            {
                if (this.rbxOpcao2.Checked)
                {

                }
                else
                {
                    if (this.rbxOpcao3.Checked)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Escolha uma das jogadas", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            this.rbxOpcao1.Checked = false;
            this.rbxOpcao2.Checked = false;
            this.rbxOpcao3.Checked = false;

            this.gbxJogadas.Enabled = false;
            this.gbxJogadas.Visible = false;

            this.fazendoJogada = false;
        }
    }
}
