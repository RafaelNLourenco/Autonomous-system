using System;
using System.Collections.Generic;

namespace cantStop
{
    public class Jogador
    {
        public long id { get; set; }
        public string nome { get; set; }
        public string cor { get; set; }
        public string senha { get; set; }

        public void entrandoPartida(string dadosJogador)
        {
            string[] itens = dadosJogador.Split(',');
            this.id = Convert.ToInt32(itens[0]);
            this.senha = itens[1];
            this.cor = itens[2];
        } 
    }
}