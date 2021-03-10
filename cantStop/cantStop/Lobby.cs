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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnExibirPartidas_Click(object sender, EventArgs e)
        {
            List<Partida> listaPartidas = new List<Partida>();

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

            for (int i = 0; i < linhas.Length-1; i++)
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

        }

        private void btnExibirJogadores_Click(object sender, EventArgs e)
        {
            //string linhaPartida = lsbPartidas.SelectedItem.ToString();
            //string[] itens = linhaPartida.Split(',');
            //int idPartida = Convert.ToInt32(itens[0]);
            //string jogadoresPartida = Jogo.ListarJogadores(idPartida);
            //txbJogadoresPartida.Text = jogadoresPartida;
        }

    }
}