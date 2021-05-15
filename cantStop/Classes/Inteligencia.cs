using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantStop.Classes
{
    public class Inteligencia
    {
        private int Jogadas;
        private Probabilidades probabilidade;

        public Inteligencia()
        {
            Jogadas = 0;
            this.probabilidade = new Probabilidades();

        }

        internal int EscolherJogada(List<Dictionary<string, int[]>> combinacoes)
        {
            bool fezJogada = false;
            Random randomJogada = new Random();
            int jogada = 0;
            while (!fezJogada)
            {
                jogada = randomJogada.Next(0, 3);
                if (combinacoes[jogada].ElementAt(0).Key != "")
                {
                    if (combinacoes[jogada].Count > 1)
                    {
                        int subjogada = randomJogada.Next(0, 2);

                        if (subjogada >= 1)
                        {
                            jogada += 3;
                        }
                    }
                    fezJogada = true;
                }
            }
            this.Jogadas++;
            return jogada;
        }

        internal bool Continuar()
        {
            bool retorno = this.Jogadas <= 3;
            if (!retorno)
            {
                this.Jogadas = 0;
            }
            return retorno;
        }

        internal void Resetar()
        {
            this.Jogadas = 0;
        }

        internal bool escolherContuniarParar(int coluna1, int coluna2, int coluna3)
        {
            this.probabilidade.calculaProbabilidadePerderVez(coluna1, coluna2, coluna3, this.Jogadas);
            if (this.probabilidade.getProbabilidadeCair() < 49) return true;
            return false;   
        }
    }
}
