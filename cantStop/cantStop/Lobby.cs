using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantStopServer;

namespace cantStop
{
    public partial class Lobby : Form
    {
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
            Jogo.CriarPartida(nome, senha);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Partida partida = (Partida)dgvListaPartidas.SelectedRows[0].DataBoundItem;
            string nome = txbNome.Text;
            string senha = txbSenha.Text;
            int idPartida = (int)partida.id;
            string erro = Jogo.EntrarPartida(idPartida,nome, senha);
            if(erro[0] == 'E')
            {
                MessageBox.Show(erro.Split(':')[1], "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarPartidas()
        {
            List<Partida> listaPartidas = new List<Partida>();
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");
            string[] linhas = retorno.Split('\n');

            for (int i = 0; i < linhas.Length - 1; i++)
            {
                Partida partida = new Partida();
                string[] itens = linhas[i].Split(',');
                partida.id = Convert.ToInt32(itens[0]);
                partida.nome = itens[1];
                partida.data = itens[2];
                partida.status = itens[3];
                listaPartidas.Add(partida);
            }

            dgvListaPartidas.DataSource = listaPartidas;
            dgvListaPartidas.Columns[0].Visible = false;
            dgvListaPartidas.Columns[3].Visible = false;

            dgvListaPartidas.Columns[1].Width = 101;
            dgvListaPartidas.Columns[2].Width = 99;
            dgvListaPartidas.Columns[4].Width = 101;

        }

        private void dgvListaPartidas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Jogador> jogadores = new List<Jogador>();
            Partida partida = (Partida)dgvListaPartidas.SelectedRows[0].DataBoundItem;

            string retorno = Jogo.ListarJogadores((int)partida.id);
            retorno = retorno.Replace("\r", "");
            string[] linhas = retorno.Split('\n');

            for (int i = 0; i < linhas.Length - 1; i++)
            {
                Jogador jogador = new Jogador();
                string[] itens = linhas[i].Split(',');
                jogador.id = Convert.ToInt32(itens[0]);
                jogador.nome = itens[1];
                jogador.cor = itens[2];
                jogadores.Add(jogador);
            }

            dgvJogadores.DataSource = jogadores;
            dgvJogadores.Columns[0].Visible = false;
            dgvJogadores.Columns[1].Width = 139;
            dgvJogadores.Columns[2].Width = 138;

        }
    }
}