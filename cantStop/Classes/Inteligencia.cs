using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantStop.Classes
{
    public class Inteligencia
    {
        public int Jogadas;
        public Probabilidades probabilidade { get; set; }
        public int[] colunasDominadas { get; set; }
        public Tabuleiro tabuleiro { get; set; }

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

        internal void atribuirListaColunasDominadas()
        {
            List<int> aux = new List<int>();
            for ( int i = 2; i <= 12; i++)
            {
                if (this.tabuleiro.ColunaDominada(i))
                {
                     aux.Add(i);
                }
            }
            this.colunasDominadas = aux.ToArray();
        }
        public void verificarJogada(int idJogaador)
        {
            DataTable alpinistas = this.tabuleiro.SelecioneJogador(idJogaador, "A");
            if ( alpinistas.Rows.Count == 0 ) this.Resetar();
        }

        internal bool Continuar(int idJogaador)
        {
            this.probabilidade.resetarProbabilidade();
            this.atribuirListaColunasDominadas();
           
            DataTable alpinistas = this.tabuleiro.SelecioneJogador(idJogaador, "A");
            int[] colunasComAlpinistas = new int[alpinistas.Rows.Count];
            
            for (int i = 0; i < alpinistas.Rows.Count; i++)
            {
                colunasComAlpinistas[i] = (int.Parse(alpinistas.Rows[i].Field<string>("coluna")));
            }
            if (colunasComAlpinistas.Length == 3)
            {
                this.probabilidade.calculaProbabilidadeCair3Alpinistas(colunasComAlpinistas[0], colunasComAlpinistas[1], colunasComAlpinistas[2], this.Jogadas);

            }else if (this.colunasDominadas != null && this.colunasDominadas.Length > 0)
            {
                this.probabilidade.calcularProbabilidadeCairApenasEmColunasDominadas(this.colunasDominadas, this.Jogadas);
            }
        
            if (this.probabilidade.getProbabilidadeCair() < 60) return true;
            return false;
        }

        internal void Resetar()
        {
            this.Jogadas = 0;
        }

    }
}
