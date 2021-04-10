using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CantStopServer;

namespace cantStop.Classes
{
    class ListaPartidas
    {
        public List<Partida> dadosPartidas { get; set; }

        ///<summary><paramref name="status"/> (T)odas, (A)bertas, (J)ogando, (E)ncerradas</summary>
        public ListaPartidas(string status)
        {
            string dados = Jogo.ListarPartidas(status);
            dados = dados.Replace("\r", "");
            string[] linhas = dados.Split('\n');

            List<Partida> aux = new List<Partida>();

            for (int i = 0; i < linhas.Length - 1; i++)
            {
                Partida partida = new Partida();
                string[] itens = linhas[i].Split(',');
                partida.Id = Convert.ToInt32(itens[0]);
                partida.Nome = itens[1];
                partida.Data = itens[2];
                switch (itens[3])
                {
                    case "A":
                        partida.Status = "Aberta";
                        break;
                    case "J":
                        partida.Status = "Jogando";
                        break;
                    case "E":
                        partida.Status = "Encerrada";
                        break;
                }
                aux.Add(partida);
            }

            this.dadosPartidas = aux;
        }

    }
}
