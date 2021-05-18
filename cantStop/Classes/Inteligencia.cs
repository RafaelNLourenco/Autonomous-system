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
        public Probabilidades probabilidade { get; set; }
        public int[] colunasComAlpinistas { get; set; }

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
            this.probabilidade.calculaProbabilidadePerderVez(this.colunasComAlpinistas[0], this.colunasComAlpinistas[1], this.colunasComAlpinistas[2], this.Jogadas);
            if (this.probabilidade.getProbabilidadeCair() < 60) return true;
            return false;
        }

        internal void Resetar()
        {
            this.Jogadas = 0;
        }

    }
}
