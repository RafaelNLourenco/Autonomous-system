using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
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

        private List<PictureBox> pecas;
        private List<PictureBox> pcbDados;
        private List<RadioButton> radios;
        private List<Label> labels;
        private List<int> dados;

        private bool fazendoJogada;
        private bool flagContinuar;
        private List<Dictionary<string, int[]>> Combinacoes;

        private String[] historico;

        private bool spec; 

        private bool bot;
        private Inteligencia inteligencia;

        private bool FlagBotJogada;

        private bool ProximoPasso;
        
        private bool FlagEsperarAtualizarTabuleiro;

        private bool ProcessandoJogar;

        public FormTabuleiro(Partida partidaSelecionada, Jogador jogadorCriado, bool bot, bool spec)
        {
            InitializeComponent();

            this.tabuleiro = new Tabuleiro();
            this.partida = partidaSelecionada;
            this.jogador = jogadorCriado;
            this.spec = spec;

            if (spec) this.Text = "Assistindo ";
            this.Text += " - " + this.partida.Nome;

            this.pecas = new List<PictureBox>();

            this.lblVersao.Text = "Versão DLL: " + Jogo.Versao;
            if ( this.spec) this.atualizarHistorico();

           
            this.lblSenha.Text = this.jogador.senha;

            this.fazendoJogada = false;

            this.tmrPartidaIniciada.Start();
          

                this.pcbDados = new List<PictureBox>
                {
                    pcbDado1,
                    pcbDado2,
                    pcbDado3,
                    pcbDado4
                };

                this.radios = new List<RadioButton>
                {
                    rbxOpcao1,
                    rbxOpcao2,
                    rbxOpcao3,
                    rbxOpcao4,
                    rbxOpcao5,
                    rbxOpcao6
                };

                this.labels = new List<Label>
                {
                    lblOu1,
                    lblOu2,
                    lblOu3
                };

                this.dados = new List<int>();

                this.Combinacoes = new List<Dictionary<string, int[]>>();

                this.flagContinuar = true;

                // this.gbxBotDebug.Visible = this.gbxBotDebug.Enabled =
                this.nmrDelay.Visible = this.nmrDelay.Enabled =
                this.chbPorPasso.Visible = this.chbPorPasso.Enabled =
                this.btnContinuar.Visible =
                this.bot = bot;

                this.FlagBotJogada = false;
                if (this.bot == true)
                {
                    this.tmrJogadaBot.Start();
                    this.inteligencia = new Inteligencia();
                }

            this.ProximoPasso = false;

            this.FlagEsperarAtualizarTabuleiro = false;

            this.ProcessandoJogar = false;
        }

        private void Tabuleiro_Load(object sender, EventArgs e)
        {
            if (this.spec)
            {
                this.pcbStatusBot.Visible = false;
                this.lblSistemaAutonomo.Text = "Espectador";
                this.btnIniciarPartida.Visible = false;
                this.pcbTabuleiro.Location = new Point(40, 7);
                this.lblUltimasJogadas.Visible = this.lblUltimaJogada.Visible =
                this.lblPenultinaJogada.Visible = this.lblAntipenultimaJogada.Visible = true;

                this.lblUltimasJogadas.Location = new Point(700, 250);
                this.lblUltimaJogada.Location = new Point(700, 290);
                this.lblPenultinaJogada.Location = new Point(700, 310);
                this.lblAntipenultimaJogada.Location = new Point(700, 335);

                if (this.partida.Status != "Aberta")
                {
                    this.tabuleiro.atualizarTabuleiro((int)this.partida.Id);
                    this.DesenharTabuleiro();
                    this.iniciar();
                }
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
            if (this.spec) this.lblPartidaIniciada.Visible = false;

            this.lblJogadorVez.Visible = true;
            this.tmrPartidaJogando.Start();
            
        }

        private void tmrPartidaIniciada_Tick(object sender, EventArgs e)
        {
            this.partida.atualizarStatus("J");
            this.partida.ListarJogadores();
            if ( this.spec) this.atualizarHistorico();

            if (this.partida.Status == "Jogando")
            {
                this.partida.ListarJogadores();
                this.iniciar();
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
            if (this.spec) this.atualizarHistorico();

            this.partida.atualizarStatus("E");
            if (this.partida.Status == "Encerrada")
            {
                this.tabuleiro.atualizarTabuleiro((int)this.partida.Id);
                this.tmrJogadaBot.Stop();
                this.tmrPartidaJogando.Stop();
                MessageBox.Show("A partida foi finalizada", "Partida finalizada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            Jogador jogadorVez = this.partida.VerificarVez();
            this.lblJogadorVez.Text = jogadorVez.nome;

            if (jogadorVez.id == this.jogador.id && !this.fazendoJogada && !this.spec && !this.ProcessandoJogar)
            {
                this.tabuleiro.atualizarTabuleiro((int)this.partida.Id);
                if (this.bot)
                {
                    this.setBotoes(false);
                    if (this.flagContinuar)
                    {
                        this.flagContinuar = false;
                        this.btnRolarDados_Click(sender, e);
                    }
                }
                else
                {
                    this.setBotoes(true);
                }
            }
            else
            {
                this.tabuleiro.atualizarTabuleiro((int)this.partida.Id);
            }

            if (jogadorVez.id == this.jogador.id && !this.spec) this.estaJogando(true);
            else this.estaJogando(false);


            if (this.FlagEsperarAtualizarTabuleiro)
            {
                this.FlagEsperarAtualizarTabuleiro = false;
            }

            this.DesenharTabuleiro();
        }

        private void DesenharTabuleiro()
        {
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
                        this.pcbTabuleiro.Controls.Add(baseAlpinista);
                        baseAlpinista.BringToFront();
                    }

                    linhas = coluna.Select("posicao = '" + j.ToString() + "' AND tipo = 'A'");
                    if (linhas.Length > 0)
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
                        this.pcbTabuleiro.Controls.Add(alpinista);
                        alpinista.BringToFront();
                    }
                }
            }
        }

        private void btnPassarVez_Click(object sender, EventArgs e)
        {
            this.setBotoes(false);
            jogador.Parar();
            this.flagContinuar = true;
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
            retorno.BackColor = Color.Transparent;

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
                ponto.X = (coluna == 2) ? 90 : 505;
                switch (posicao)
                {
                    case 1:
                        ponto.Y = 347;
                        break;
                    case 2:
                        ponto.Y = 300;
                        break;
                    case 3:
                        ponto.Y = 253;
                        break;
                }
            }

            if (coluna == 3 || coluna == 11)
            {
                ponto.X = (coluna == 3) ? 130 : 465;
                switch (posicao)
                {
                    case 1:
                        ponto.Y = 389;
                        break;
                    case 2:
                        ponto.Y = 343;
                        break;
                    case 3:
                        ponto.Y = 299;
                        break;
                    case 4:
                        ponto.Y = 256;
                        break;
                    case 5:
                        ponto.Y = 210;
                        break;
                }
            }
            
            if (coluna == 4 || coluna == 10)
            {
                ponto.X = (coluna == 4) ? 172 : 423;
                switch (posicao)
                {
                    case 1:
                        ponto.Y = 429;
                        break;
                    case 2:
                        ponto.Y = 383;
                        break;
                    case 3:
                        ponto.Y = 343;
                        break;
                    case 4:
                        ponto.Y = 300;
                        break;
                    case 5:
                        ponto.Y = 255;
                        break;
                    case 6:
                        ponto.Y = 213;
                        break;
                    case 7:
                        ponto.Y = 170;
                        break;
                }
            }

            if (coluna == 5 || coluna == 9)
            {
                ponto.X = (coluna == 5) ? 212 : 383;
                switch (posicao)
                {
                    case 1:
                        ponto.Y = 471;
                        break;
                    case 2:
                        ponto.Y = 425;
                        break;
                    case 3:
                        ponto.Y = 384;
                        break;
                    case 4:
                        ponto.Y = 343;
                        break;
                    case 5:
                        ponto.Y = 301;
                        break;
                    case 6:
                        ponto.Y = 257;
                        break;
                    case 7:
                        ponto.Y = 213;
                        break;
                    case 8:
                        ponto.Y = 172;
                        break;
                    case 9:
                        ponto.Y = 127;
                        break;
                }
            }

            if (coluna == 6 || coluna == 8)
            {
                ponto.X = (coluna == 6) ? 255 : 340;
                switch (posicao)
                {
                    case 1:
                        ponto.Y = 513;
                        break;
                    case 2:
                        ponto.Y = 468;
                        break;
                    case 3:
                        ponto.Y = 426;
                        break;
                    case 4:
                        ponto.Y = 384;
                        break;
                    case 5:
                        ponto.Y = 343;
                        break;
                    case 6:
                        ponto.Y = 301;
                        break;
                    case 7:
                        ponto.Y = 260;
                        break;
                    case 8:
                        ponto.Y = 217;
                        break;
                    case 9:
                        ponto.Y = 173;
                        break;
                    case 10:
                        ponto.Y = 132;
                        break;
                    case 11:
                        ponto.Y = 85;
                        break;
                }
            }

            if (coluna == 7)
            {
                ponto.X = 298;
                switch (posicao)
                {
                    case 1:
                        ponto.Y = 556;
                        break;
                    case 2:
                        ponto.Y = 510;
                        break;
                    case 3:
                        ponto.Y = 468;
                        break;
                    case 4:
                        ponto.Y = 425;
                        break;
                    case 5:
                        ponto.Y = 384;
                        break;
                    case 6:
                        ponto.Y = 343;
                        break;
                    case 7:
                        ponto.Y = 301;
                        break;
                    case 8:
                        ponto.Y = 259;
                        break;
                    case 9:
                        ponto.Y = 218;
                        break;
                    case 10:
                        ponto.Y = 174;
                        break;
                    case 11:
                        ponto.Y = 131;
                        break;
                    case 12:
                        ponto.Y = 89;
                        break;
                    case 13:
                        ponto.Y = 44;
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

            try
            {
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
                    if (this.Combinacoes[i].ElementAt(0).Key != "")
                    {
                        if (this.Combinacoes[i].Count > 1)
                        {
                            this.radios[i].Text = this.Combinacoes[i].ElementAt(0).Value[0].ToString();
                            this.radios[i + 3].Text = this.Combinacoes[i].ElementAt(1).Value[0].ToString();
                        }
                        else
                        {
                            if (this.Combinacoes[i].ElementAt(0).Value[1] == 0)
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

                int j = 1;
                foreach (var radio in this.radios)
                {
                    if (j <= 3)
                    {
                        radio.Visible = radio.Enabled = !(radio.Text == "Opcao " + j.ToString());
                    }
                    else
                    {
                        radio.Visible = radio.Enabled = this.labels[j - 4].Visible = !(radio.Text == "Opcao " + j.ToString());
                    }
                    j++;
                }

                if (!this.rbxOpcao1.Visible && !this.rbxOpcao2.Visible && !this.rbxOpcao3.Visible)
                {
                    this.fazendoJogada = false;
                    this.setJogadasView(false);

                    this.flagContinuar = true;
                }
                else
                {
                    if (this.bot)
                    {
                        this.FlagBotJogada = true;
                    }
                }
            }
            catch
            {
                this.btnVoltar_Click(sender, e);
                // MessageBox.Show("Ocooreu um erro de sincronia", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            this.fazendoJogada = false;
            this.setJogadasView(false);
        }

        private async void tmrJogadaBot_Tick(object sender, EventArgs e)
        {
            if (!this.FlagBotJogada) return;
            this.FlagBotJogada = false;
            if (this.inteligencia.tabuleiro is null) this.inteligencia.tabuleiro = this.tabuleiro;
            
            this.inteligencia.verificarJogada((int)this.jogador.id);

            int delay = 100 * ((int)this.nmrDelay.Value);
            int jogada = this.inteligencia.EscolherJogada((int)this.jogador.id, this.Combinacoes);

            this.FlagEsperarAtualizarTabuleiro = true;
            while (this.FlagEsperarAtualizarTabuleiro)
            {
                await Task.Delay(50);
            }

            await Task.Delay(delay);

            this.radios[jogada].Checked = true;

            this.btnJogar_Click(sender, e);
            this.ProcessandoJogar = true;

            while (!this.ProximoPasso && this.chbPorPasso.Checked)
            {
                await Task.Delay(50);
            }
            this.ProximoPasso = false;

            this.flagContinuar = this.inteligencia.Continuar((int)jogador.id);

            lblProbabilidadeCair.Text = this.inteligencia.probabilidade.getProbabilidadeCair() + "%";
            lblLimite.Text = "Limite ~" + Convert.ToString(((float)this.inteligencia.taxaLimite + (float)50));

            await Task.Delay(delay);

            if (!this.flagContinuar) { 
                this.btnPassarVez_Click(sender, e);
            }

            this.ProcessandoJogar = false;
        }

        private void setJogadasView(bool valor)
        {
            this.rbxOpcao1.Checked =
            this.rbxOpcao2.Checked =
            this.rbxOpcao3.Checked =
            this.rbxOpcao4.Checked =
            this.rbxOpcao5.Checked =
            this.rbxOpcao6.Checked = valor;

            this.rbxOpcao1.Visible =
            this.rbxOpcao2.Visible =
            this.rbxOpcao3.Visible =
            this.rbxOpcao4.Visible =
            this.rbxOpcao5.Visible =
            this.rbxOpcao6.Visible = valor;

            this.lblOu1.Visible =
            this.lblOu2.Visible =
            this.lblOu3.Visible = valor;

            this.gbxJogadas.Enabled = valor;

            this.gbxJogadas.Visible = valor;

            if (this.bot)
            {
                this.btnJogar.Enabled = false;
            }
            else
            {
                this.btnJogar.Enabled = valor;
            }

            if (!valor)
            {
                this.rbxOpcao1.Text = "Opcao 1";
                this.rbxOpcao2.Text = "Opcao 2";
                this.rbxOpcao3.Text = "Opcao 3";
                this.rbxOpcao4.Text = "Opcao 4";
                this.rbxOpcao5.Text = "Opcao 5";
                this.rbxOpcao6.Text = "Opcao 6";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            tmrJogadaBot.Stop();
            tmrPartidaIniciada.Stop();
            tmrPartidaJogando.Stop();
            this.Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.ProximoPasso = true;
        }

        private void estaJogando(bool flag)
        {
            pcbDado1.Visible = pcbDado2.Visible =
            pcbDado3.Visible = pcbDado4.Visible =
            btnRolarDados.Visible = btnPassarVez.Visible =
            lblTituloProbabilidadeCair.Visible =
            lblProbabilidadeCair.Visible = lblLimite.Visible = flag;

            if (flag) this.pcbStatusBot.Image = cantStop.Properties.Resources.pointG;
            else this.pcbStatusBot.Image = cantStop.Properties.Resources.pointR;
        }

        private void chbPorPasso_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbPorPasso.Checked)
            {
                this.btnContinuar.Enabled = true;
            }
            else
            {
                this.btnContinuar.Enabled = false;
            }
        }
    }
}
