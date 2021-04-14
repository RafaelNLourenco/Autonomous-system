using System;
using System.Collections.Generic;
using CantStopServer;

namespace cantStop
{
    public class Partida
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string status { get; set; }
        public string senha { get; set; }
        public string data { get; set; }
        public List<Jogador> jogadores { get; set; }

        public Partida()
        {
            this.jogadores = new List<Jogador>();
        }

        public void ListarJogadores()
        {
            string retorno = Jogo.ListarJogadores(this.id);
            retorno = retorno.Replace("\r", "");
            string[] linhas = retorno.Split('\n');

            for (int i = 0; i < linhas.Length - 1; i++)
            {
                Jogador jogador = new Jogador();
                string[] itens = linhas[i].Split(',');

                jogador.id = Convert.ToInt32(itens[0]);
                jogador.nome = itens[1];
                jogador.cor = itens[2];

                this.jogadores.Add(jogador);
            }
        }

        public Jogador VerificarVez()
        {
            string retornoVez = Jogo.VerificarVez(this.id);
            retornoVez = retornoVez.Replace("\r\n", "");
            string[] retornoVezProcessado = retornoVez.Split(',');

            foreach(Jogador jogador in this.jogadores)
            {
                if (jogador.id == int.Parse(retornoVezProcessado[1])) return jogador;
            }

            return null;
        }
    }
}
