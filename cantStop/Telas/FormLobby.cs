using System;
using System.Collections.Generic;
using System.Windows.Forms;
using cantStop.Classes;
using cantStop.Telas;
using CantStopServer;

namespace cantStop
{
    public partial class FormLobby : Form
    {
        public bool entrou = false;

        public Jogador jogadorCriado { get; set; }
        public Partida partidaSelecionada { get; set; }

        public bool bot { get; set; }

        public FormLobby()
        {
            InitializeComponent();
            this.iniciarParametrosForm();
        }

        // metodos da classe
        private void iniciarParametrosForm()
        {
            this.listarPartidas();
            lblFeedbackCriarPartida.Text = "";
            txbSenhaCriarPartida.UseSystemPasswordChar = true;
            txbSenhaEntrarPartida.UseSystemPasswordChar = true;
            this.ActiveControl = txbNomeCriarPartida;
            this.bot = false;
        }

        private void atualizarDadosPartida()
        {
            lblNomePartidaSelecionada.Text = "Nome: " + this.partidaSelecionada.Nome;
            lblStatusPartidaSelecionada.Text = "Status: : " + this.partidaSelecionada.Status;
            this.atualizarListaJogadores();
        }
        private void atualizarListaJogadores()
        {
            partidaSelecionada.ListarJogadores();
            switch (partidaSelecionada.jogadores.Count)
            {
                case 0:
                    pcbIcon1.Visible = false;
                    pcbIcon2.Visible = false;
                    pcbIcon3.Visible = false;
                    pcbIcon4.Visible = false;

                    lblJogador1.Visible = false;
                    lblJogador3.Visible = false;
                    lblJogador4.Visible = false;
                    lblJogador2.Text = "A partida está vazia";
                    break;
                case 1:
                    pcbIcon1.Visible = true;
                    pcbIcon2.Visible = false;
                    pcbIcon3.Visible = false;
                    pcbIcon4.Visible = false;

                    lblJogador1.Visible = true;
                    lblJogador2.Visible = false;
                    lblJogador3.Visible = false;
                    lblJogador4.Visible = false;

                    lblJogador1.Text = partidaSelecionada.jogadores[0].nome;

                    break;
                case 2:
                    pcbIcon1.Visible = true;
                    pcbIcon2.Visible = true;
                    pcbIcon3.Visible = false;
                    pcbIcon4.Visible = false;

                    lblJogador1.Visible = true;
                    lblJogador2.Visible = true;
                    lblJogador3.Visible = false;
                    lblJogador4.Visible = false;

                    lblJogador1.Text = partidaSelecionada.jogadores[0].nome;
                    lblJogador2.Text = partidaSelecionada.jogadores[1].nome;

                    break;
                case 3:
                    pcbIcon1.Visible = true;
                    pcbIcon2.Visible = true;
                    pcbIcon3.Visible = true;
                    pcbIcon4.Visible = false;

                    lblJogador1.Visible = true;
                    lblJogador2.Visible = true;
                    lblJogador3.Visible = true;
                    lblJogador4.Visible = false;

                    lblJogador1.Text = partidaSelecionada.jogadores[0].nome;
                    lblJogador2.Text = partidaSelecionada.jogadores[1].nome;
                    lblJogador3.Text = partidaSelecionada.jogadores[2].nome;

                    break;
                case 4:
                    pcbIcon1.Visible = true;
                    pcbIcon2.Visible = true;
                    pcbIcon3.Visible = true;
                    pcbIcon4.Visible = true;

                    lblJogador1.Visible = true;
                    lblJogador2.Visible = true;
                    lblJogador3.Visible = true;
                    lblJogador4.Visible = true;

                    lblJogador1.Text = partidaSelecionada.jogadores[0].nome;
                    lblJogador2.Text = partidaSelecionada.jogadores[1].nome;
                    lblJogador3.Text = partidaSelecionada.jogadores[2].nome;
                    lblJogador4.Text = partidaSelecionada.jogadores[3].nome;

                    break;
            }
        }
        private void listarPartidas()
        {
            ListaPartidas listaPartidas = new ListaPartidas("T");

            dgvListaPartidas.DataSource = listaPartidas.dadosPartidas; // Atribuindo os dados do objeto ao dataSource do dvgListaPartidas

            dgvListaPartidas.Columns[0].Visible = false; // Ocultando id partida
            dgvListaPartidas.Columns[3].Visible = false; // Ocultando senha partida

            dgvListaPartidas.Columns[1].Width = 101;
            dgvListaPartidas.Columns[2].Width = 99;
            dgvListaPartidas.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.partidaSelecionada = (Partida)listaPartidas.dadosPartidas[0];
            this.atualizarDadosPartida();

        }

        private void atualizaPartidaSelecionada()
        {
            this.partidaSelecionada = (Partida)dgvListaPartidas.SelectedRows[0].DataBoundItem;

            int numLinhasAntes = dgvListaPartidas.Rows.Count;
            int indexLinhaSelecionada = dgvListaPartidas.SelectedRows[0].Index;

            ListaPartidas listaPartidas = new ListaPartidas("T");
            int numLinhasDepois = listaPartidas.dadosPartidas.Count;

            indexLinhaSelecionada += (numLinhasDepois - numLinhasAntes);

            dgvListaPartidas.DataSource = listaPartidas.dadosPartidas; // Atribuindo os dados do objeto ao dataSource do dvgListaPartidas
            dgvListaPartidas.Rows[indexLinhaSelecionada].Selected = true;
            this.partidaSelecionada = (Partida)dgvListaPartidas.SelectedRows[0].DataBoundItem;
            this.atualizarDadosPartida();
        }


        private void limparCamposDeTexto()
        {
            txbNomeCriarPartida.Clear();
            txbSenhaCriarPartida.Clear();
            txbNomeEntrarPartida.Clear();
            txbSenhaEntrarPartida.Clear();
        }


        // metodos baseados em eventos
        private void dgvListaPartidas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.atualizaPartidaSelecionada();
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nome = txbNomeCriarPartida.Text;
            string senha = txbSenhaCriarPartida.Text;
            string retorno = Jogo.CriarPartida(nome, senha);

            if (retorno[0] == 'E')
            {
                MessageBox.Show(retorno.Split(':')[1], "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblFeedbackCriarPartida.Text = "Partida criada com sucesso";
                listarPartidas();
                this.ActiveControl = txbNomeEntrarPartida;
                txbSenhaEntrarPartida.Text = senha;
            }
        }

        private void btnEntrarDev_Click(object sender, EventArgs e)
        {
            Partida partida = (Partida)dgvListaPartidas.SelectedRows[0].DataBoundItem;
            string nome = txbNomeEntrarPartida.Text;
            string senha = txbSenhaEntrarPartida.Text;
            int idPartida = (int)partida.Id;


            string retorno = Jogo.EntrarPartida(idPartida, nome, senha);
            if (retorno[0] == 'E') MessageBox.Show(retorno.Split(':')[1], "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                partidaSelecionada.ListarJogadores();
                this.jogadorCriado = new Jogador();
                this.jogadorCriado.entrandoPartida(retorno, txbNomeEntrarPartida.Text);

                this.entrou = true;
                tmrAtualizarPartidaSelecionada.Stop();

                FormTabuleiro tabuleiro = new FormTabuleiro(this.partidaSelecionada, this.jogadorCriado, this.bot, false);
                this.Hide();
                tabuleiro.ShowDialog();

                // apos voltar ao lobby(fechar o tabuleiro)
                tmrAtualizarPartidaSelecionada.Start();
                this.iniciarParametrosForm();
                this.limparCamposDeTexto();
                this.Show();
            }
        }

        private void btnEntrarBot_Click(object sender, EventArgs e)
        {
            this.bot = true;
            if (String.IsNullOrEmpty(this.txbNomeEntrarPartida.Text))
            {
                this.txbNomeEntrarPartida.Text = "Genebra Bot";
            }
            this.btnEntrarDev_Click(sender, e);
        }

        private void btnVisualizarPartida_Click(object sender, EventArgs e)
        {
            Jogador espectador = new Jogador();
            espectador.entrarPartidaSpec();
            FormTabuleiro formTabuleiro = new FormTabuleiro(this.partidaSelecionada, espectador, false, true);
            this.Hide();
            formTabuleiro.ShowDialog();
            this.Show();
        }

        private void btnSobreBot_Click(object sender, EventArgs e)
        {
            FormsobreBot sobreBot = new FormsobreBot();
            this.Hide();
            sobreBot.ShowDialog();
            this.Show();
        }

        // botoes baseados em eventos de pictureBox
        private void pcbSenhaEntrarPartida_Click(object sender, EventArgs e)
        {
            if (txbSenhaEntrarPartida.UseSystemPasswordChar == true)
            {
                pcbSenhaEntrarPartida.Image = Properties.Resources.icon_hide;
                txbSenhaEntrarPartida.UseSystemPasswordChar = false;
            }
            else
            {
                pcbSenhaEntrarPartida.Image = Properties.Resources.icon_visualize;
                txbSenhaEntrarPartida.UseSystemPasswordChar = true;
            }
        }

        private void pcbSenhaCriarPartida_Click(object sender, EventArgs e)
        {
            if (txbSenhaCriarPartida.UseSystemPasswordChar == true)
            {
                pcbSenhaCriarPartida.Image = Properties.Resources.icon_hide;
                txbSenhaCriarPartida.UseSystemPasswordChar = false;
            }
            else
            {
                pcbSenhaCriarPartida.Image = Properties.Resources.icon_visualize;
                txbSenhaCriarPartida.UseSystemPasswordChar = true;
            }
        }
        private void pcbAtualizarListaPartida_Click(object sender, EventArgs e)
        {
            this.listarPartidas();
        }

        private void pcbAtualizarPartidaSelecionada_Click(object sender, EventArgs e)
        {
            this.atualizaPartidaSelecionada();
        }

        // atalhos
        private void txbNomeCriarPartida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // enter
            {
                e.Handled = true;
                this.btnCriarPartida_Click(sender, e);
            }
        }

        private void txbSenhaCriarPartida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // enter
            {
                e.Handled = true;
                this.btnCriarPartida_Click(sender, e);
            }
        }

        private void txbNomeEntrarPartida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 10) // enter ou ctrl + enter
            {
                e.Handled = true;
                if (e.KeyChar == 13) this.btnEntrarDev_Click(sender, e);
                else this.btnEntrarBot_Click(sender, e);
            }
        }

        private void txbSenhaEntrarPartida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 10) // enter ou ctrl + enter
            {
                e.Handled = true;
                if (e.KeyChar == 13) this.btnEntrarDev_Click(sender, e);
                else this.btnEntrarBot_Click(sender, e);
            }
        }

        // timer
        private void tmrAtualizarPartidaSelecionada_Tick(object sender, EventArgs e)
        {
            this.atualizaPartidaSelecionada();
        }

    }
}