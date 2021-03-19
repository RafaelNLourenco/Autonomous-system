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
    public partial class Lobby : Form
    {
        public Jogador jogadorCriado { get; set; }
        public Partida PartidaSelecionada { get; set; }

        public Lobby()
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

            if (retorno[0] == 'E')
            {
                MessageBox.Show(retorno.Split(':')[1], "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Partida partida = (Partida)dgvListaPartidas.SelectedRows[0].DataBoundItem;
            string nome = txbNome.Text;
            string senha = txbSenha.Text;
            int idPartida = (int)partida.id;
            string retorno = Jogo.EntrarPartida(idPartida,nome, senha);
            if(retorno[0] == 'E')
            {
                MessageBox.Show(retorno.Split(':')[1], "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Jogador aux = new Jogador();
                aux.entrandoPartida(retorno);
                aux.nome = txbNome.Text;
                this.jogadorCriado = aux;
                this.Close();
            }
        }

        private void ListarPartidas()
        {
            string retorno = Jogo.ListarPartidas("T");
            ListaPartidas listaPartidas = new ListaPartidas(retorno);

            dgvListaPartidas.DataSource = listaPartidas.dadosPartidas; // atribuindo os dados do objeto ao dataSource do dvgListaPartidas
            dgvListaPartidas.Columns[0].Visible = false; //ocultando id partida
            dgvListaPartidas.Columns[3].Visible = false; //ocultando senha partida

            dgvListaPartidas.Columns[1].Width = 101;
            dgvListaPartidas.Columns[2].Width = 99;
            dgvListaPartidas.Columns[4].Width = 101;

        }

        private void dgvListaPartidas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Partida partidaClicada = (Partida)dgvListaPartidas.SelectedRows[0].DataBoundItem; //pegando o objeto da partida clicada
            string retorno = Jogo.ListarJogadores((int)partidaClicada.id); //pegando o retorno da requisicao de listar jogadores

            ListaJogadores listaJogadores = new ListaJogadores(retorno); //instanciando o objeto ListaJogadores e passando o retorno como parametro

            dgvJogadores.DataSource = listaJogadores.dadosJogadores; //direcionando o dataSource do dvgJogadores
            dgvJogadores.Columns[0].Visible = false; //ocultando id jogador
            dgvJogadores.Columns[1].Width = 139;
            dgvJogadores.Columns[2].Width = 138;
        }
    }
}