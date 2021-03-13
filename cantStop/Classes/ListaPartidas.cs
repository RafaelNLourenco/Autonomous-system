using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantStop.Classes
{
    class ListaPartidas
    {
        public List<Partida> dadosPartidas { get; set; }

        public ListaPartidas(string dados)
        {
            dados = dados.Replace("\r", "");
            string[] linhas = dados.Split('\n');

            List<Partida> aux = new List<Partida>();

            for (int i = 0; i < linhas.Length - 1; i++)
            {
                Partida partida = new Partida();
                string[] itens = linhas[i].Split(',');
                partida.id = Convert.ToInt32(itens[0]);
                partida.nome = itens[1];
                partida.data = itens[2];
                switch (itens[3])
                {
                    case "A":
                        partida.status = "Aberta";
                        break;
                    case "J":
                        partida.status = "Jogando";
                        break;
                    case "E":
                        partida.status = "Encerrada";
                        break;
                }
                aux.Add(partida);
            }

            this.dadosPartidas = aux;
        }

    }
}
