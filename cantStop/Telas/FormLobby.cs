using System;
using System.Windows.Forms;
using cantStop.Classes;
using CantStopServer;

namespace cantStop
{
    public partial class FormLobby : Form
    {
        public bool entrou = false;

        public Jogador jogadorCriado { get; set; }
        public Partida partidaSelecionada { get; set; }

        public FormLobby()
        {
            InitializeComponent();
            ListarPartidas();
        
        }

         private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ListarPartidas();
        }

        private void btnCriarSala_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text;
            string senha = txbSenha.Text;
            string retorno = Jogo.CriarPartida(nome, senha);

            if (retorno[0] == 'E') MessageBox.Show(retorno.Split(':')[1], "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else ListarPartidas();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Partida partida = (Partida)dgvListaPartidas.SelectedRows[0].DataBoundItem;
            string nome = txbNome.Text;
            string senha = txbSenha.Text;
            int idPartida = (int)partida.id;

            string retorno = Jogo.EntrarPartida(idPartida, nome, senha);
            if(retorno[0] == 'E') MessageBox.Show(retorno.Split(':')[1], "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else 
            {
                partidaSelecionada.jogadores = Jogador.ListarJogadores(partidaSelecionada.id);

                this.jogadorCriado = new Jogador();
                this.jogadorCriado.entrandoPartida(retorno, txbNome.Text);

                this.entrou = true;

                this.Close();
            }
        }

        private void ListarPartidas()
        {
            ListaPartidas listaPartidas = new ListaPartidas("T");

            dgvListaPartidas.DataSource = listaPartidas.dadosPartidas; // Atribuindo os dados do objeto ao dataSource do dvgListaPartidas

            dgvListaPartidas.Columns[0].Visible = false; // Ocultando id partida
            dgvListaPartidas.Columns[3].Visible = false; // Ocultando senha partida

            dgvListaPartidas.Columns[1].Width = 101;
            dgvListaPartidas.Columns[2].Width = 99;
            dgvListaPartidas.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvListaPartidas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            partidaSelecionada = (Partida)dgvListaPartidas.SelectedRows[0].DataBoundItem;
            partidaSelecionada.jogadores = Jogador.ListarJogadores(partidaSelecionada.id);

            dgvJogadores.DataSource = partidaSelecionada.jogadores;
            dgvJogadores.Columns[0].Visible = false;
            dgvJogadores.Columns[1].Width = 139;
            dgvJogadores.Columns[2].Width = 138;
        }
    }
}