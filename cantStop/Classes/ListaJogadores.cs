using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantStop.Classes
{
    class ListaJogadores
    {
        public List<Jogador> dadosJogadores { get; set; }

        public ListaJogadores(string dados)
        {
            dados = dados.Replace("\r", "");
            string[] linhas = dados.Split('\n');
            List<Jogador> aux = new List<Jogador>();

            for (int i = 0; i < linhas.Length - 1; i++)
            {
                Jogador jogador = new Jogador();
                string[] itens = linhas[i].Split(',');
                jogador.id = Convert.ToInt32(itens[0]);
                jogador.nome = itens[1];
                jogador.cor = itens[2];
                aux.Add(jogador);
            }

            this.dadosJogadores = aux;
        }

    }
}
