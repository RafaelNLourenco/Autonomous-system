using System.Collections.Generic;
using CantStopServer;

namespace cantStop
{
    public class Partida
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
        public string Senha { get; set; }
        public string Data { get; set; }
        public List<Jogador> jogadores { get; set; }

        public Jogador VerificarVez()
        {
            string retornoVez = Jogo.VerificarVez(this.Id);
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
