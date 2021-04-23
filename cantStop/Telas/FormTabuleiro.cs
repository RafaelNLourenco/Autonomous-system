using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private List<PictureBox> pcbDados;
        private List<RadioButton> radios;
        private List<Label> labels;
        private List<int> dados;

        private bool fazendoJogada;
        private bool flag;
        private List<Dictionary<string, int[]>> Combinacoes;

        private String[] historico;

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

                this.lblVersao.Text = "Versão DLL: " + Jogo.Versao;
                this.atualizarHistorico();

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

                this.radios = new List<RadioButton>();
                this.radios.Add(rbxOpcao1);
                this.radios.Add(rbxOpcao2);
                this.radios.Add(rbxOpcao3);
                this.radios.Add(rbxOpcao4);
                this.radios.Add(rbxOpcao5);
                this.radios.Add(rbxOpcao6);

                this.labels = new List<Label>();
                this.labels.Add(lblOu1);
                this.labels.Add(lblOu2);
                this.labels.Add(lblOu3);

                this.dados = new List<int>();

                this.Combinacoes = new List<Dictionary<string, int[]>>();
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
            this.partida.ListarJogadores();
            this.atualizarHistorico();

            foreach (Partida partida in partidas.dadosPartidas)
            {
                if (partida.Id == this.partida.Id)
                {
                    this.partida.ListarJogadores();
                    this.iniciar();
                    return;
                }
            }
        }

        private void atualizarHistorico()
        {
            this.historico = this.partida.pegarHistorico();
            if (this.historico.Length == 1 ){
                lblUltimaJogada.Text = this.historico[0];
                lblPenultinaJogada.Text = "";
                lblAntipenultimaJogada.Text = "";
            }
            else if (this.historico.Length == 2)
            {
                lblUltimaJogada.Text = this.historico[0];
                lblPenultinaJogada.Text = this.historico[1];
                lblAntipenultimaJogada.Text = "";
            }
            else
            {
                lblUltimaJogada.Text = this.historico[0];
                lblPenultinaJogada.Text = this.historico[1];
                lblAntipenultimaJogada.Text = this.historico[2];
            }
        }

        private void tmrPartidaJogando_Tick(object sender, EventArgs e)
        {
            if (this.partida.VerificarVez().id == this.jogador.id && !this.fazendoJogada){
                this.setBotoes(true);
            }

            this.tabuleiro.atualizarTabuleiro((int)this.partida.Id);
            this.atualizarHistorico();
                
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
                            Jogador player = this.partida.jogadores.Find(x => x.id == long.Parse(linha.Field<string>("jogador")));
                            switch (player.cor)
                            {
                                case "Vermelho":
                                    cor += "r";
                                    break;
                                case "Azul":
                                    cor += "b";
                                    break;
                                case "Verde":
                                    cor += "g";
                                    break;
                                case "Amarelo":
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

        private void btnPassarVez_Click(object sender, EventArgs e)
        {
            this.setBotoes(false);
            jogador.Parar();
            this.tmrPartidaJogando_Tick(sender, e);
        }

        private void setBotoes(bool valor)
        {
            this.btnRolarDados.Enabled = valor;
            this.btnPassarVez.Enabled = valor;
        }

        public static int getQuantidadePosicao(int coluna)
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

        private void btnRolarDados_Click(object sender, EventArgs e)
        {
            this.setBotoes(false);
            this.fazendoJogada = true;

            this.dados.Clear();
            this.dados = jogador.RolarDados();

            for (int i = 0; i < 4; i++)
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

            this.Combinacoes = this.tabuleiro.MontarCombinacoes((int)this.jogador.id, this.dados);

            for (int i = 0; i < 3; i++)
            {
                if(this.Combinacoes[i].ElementAt(0).Key != "") {
                    if(this.Combinacoes[i].Count > 1)
                    {
                        this.radios[i].Text = this.Combinacoes[i].ElementAt(0).Value[0].ToString();
                        this.radios[i + 3].Text = this.Combinacoes[i].ElementAt(1).Value[0].ToString();
                    }
                    else
                    {
                        if(this.Combinacoes[i].ElementAt(0).Value[1] == 0)
                        {
                            this.radios[i].Text = this.Combinacoes[i].ElementAt(0).Value[0].ToString();
                        }
                        else
                        {
                            this.radios[i].Text = this.Combinacoes[i].ElementAt(0).Value[0].ToString() + " e " + this.Combinacoes[i].ElementAt(0).Value[1].ToString();
                        }
                    }
                }
            }

            this.gbxJogadas.Visible = true;
            this.gbxJogadas.Enabled = true;

            this.rbxOpcao1.Visible = this.rbxOpcao1.Enabled = !(rbxOpcao1.Text == "Opcao 1");
            this.rbxOpcao2.Visible = this.rbxOpcao2.Enabled = !(rbxOpcao2.Text == "Opcao 2");
            this.rbxOpcao3.Visible = this.rbxOpcao3.Enabled = !(rbxOpcao3.Text == "Opcao 3");

            this.rbxOpcao4.Visible = this.rbxOpcao4.Enabled = this.lblOu1.Visible = !(rbxOpcao4.Text == "Opcao 4");
            this.rbxOpcao5.Visible = this.rbxOpcao5.Enabled = this.lblOu2.Visible = !(rbxOpcao5.Text == "Opcao 5");
            this.rbxOpcao6.Visible = this.rbxOpcao6.Enabled = this.lblOu3.Visible = !(rbxOpcao6.Text == "Opcao 6");

            if(!this.rbxOpcao1.Visible && !this.rbxOpcao2.Visible && !this.rbxOpcao3.Visible)
            {
                this.rbxOpcao1.Checked =
                this.rbxOpcao2.Checked =
                this.rbxOpcao3.Checked =
                this.rbxOpcao4.Checked =
                this.rbxOpcao5.Checked =
                this.rbxOpcao6.Checked = false;

                this.gbxJogadas.Enabled = false;
                this.gbxJogadas.Visible = false;

                this.fazendoJogada = false;
                this.tmrPartidaJogando_Tick(sender, e);
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            bool haSelecionado = false;
            for (int i = 0; i < 3; i++)
            {
                if(this.radios[i].Checked || this.radios[i + 3].Checked) { 
                    if (this.radios[i + 3].Enabled)
                    {
                        if (this.radios[i].Checked)
                        {
                            jogador.Mover(this.Combinacoes[i].ElementAt(0).Key, this.Combinacoes[i].ElementAt(0).Value);
                            haSelecionado = true;
                        }
                        else
                        {
                            jogador.Mover(this.Combinacoes[i].ElementAt(1).Key, this.Combinacoes[i].ElementAt(1).Value);
                            haSelecionado = true;
                        }
                    }
                    else
                    {
                        jogador.Mover(this.Combinacoes[i].ElementAt(0).Key, this.Combinacoes[i].ElementAt(0).Value);
                        haSelecionado = true;
                    }

                    break;
                }
            }

            if (!haSelecionado)
            {
                MessageBox.Show("Selecione uma das opções!", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.rbxOpcao1.Checked =
            this.rbxOpcao2.Checked =
            this.rbxOpcao3.Checked =
            this.rbxOpcao4.Checked =
            this.rbxOpcao5.Checked =
            this.rbxOpcao6.Checked = false;

            this.gbxJogadas.Enabled = false;
            this.gbxJogadas.Visible = false;

            this.fazendoJogada = false;

            this.rbxOpcao1.Text = "Opcao 1";
            this.rbxOpcao2.Text = "Opcao 2";
            this.rbxOpcao3.Text = "Opcao 3";
            this.rbxOpcao4.Text = "Opcao 4";
            this.rbxOpcao5.Text = "Opcao 5";
            this.rbxOpcao6.Text = "Opcao 6";

            this.tmrPartidaJogando_Tick(sender, e);
        }


    }
}
