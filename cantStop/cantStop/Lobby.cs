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

        private List<Partida> listaPartidas = new List<Partida>();
        public Lobby()
        {
            InitializeComponent();
            ListarPartidas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExibirJogadores_Click(object sender, EventArgs e)
        {
            //string linhaPartida = lsbPartidas.SelectedItem.ToString();
            //string[] itens = linhaPartida.Split(',');
            //int idPartida = Convert.ToInt32(itens[0]);
            //string jogadoresPartida = Jogo.ListarJogadores(idPartida);
            //txbJogadoresPartida.Text = jogadoresPartida;
            this.Hide();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ListarPartidas();
        }

        private void btnCriarSala_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void ListarPartidas()
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");
            string[] linhas = retorno.Split('\n');

            /*
            foreach (string linha in linhas) {
                string[] itens = linha.Split(',');
                partida.id = Convert.ToInt32(itens[0]);
                partida.nome = itens[0];
                partida.data = itens[2];
                partida.status = itens[3];
                listaPartidas.Add(partida);
            };
            */

            for (int i = 0; i < linhas.Length - 1; i++)
            {
                Partida partida = new Partida();
                string[] itens = linhas[i].Split(',');
                partida.id = Convert.ToInt32(itens[0]);
                partida.nome = itens[1];
                partida.data = itens[2];
                partida.status = itens[3];
                this.listaPartidas.Add(partida);
            }

            dgvListaPartidas.DataSource = this.listaPartidas;
            dgvListaPartidas.Columns[0].Visible = false;
            dgvListaPartidas.Columns[3].Visible = false;

            dgvListaPartidas.Columns[2].Width = 50;

        }

        private void dgvListaPartidas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = this.dgvListaPartidas.SelectedCells[0].RowIndex;

            List<Jogador> jogadores = new List<Jogador>();
            string retorno = Jogo.ListarJogadores(index);
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
            dgvJogadores.Columns[0].Width = 20;
            dgvJogadores.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
        }
    }
}