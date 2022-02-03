using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace cantStop.Classes
{
    public class Inteligencia
    {
        public int jogadas;
        public Probabilidades probabilidade { get; set; }
        public int[] colunasDominadas { get; set; }
        public Tabuleiro tabuleiro { get; set; }
        private bool flagFator { get; set; }
        public float taxaLimite { get; set; }
        public int qntdJogadores { get; set; }

        public Inteligencia()
        {
            this.jogadas = 0;
            this.taxaLimite = 0;
            this.flagFator = true;
            this.probabilidade = new Probabilidades();
        }

        private int coeficienteLinear(int coluna)
        {
            int constante = coluna - 1;
            if (coluna > 7)
            {
                constante = 13 - coluna;
            }
            return constante;
        }

        private double calcularPeso(int coluna, DataTable alpinistasTable, DataTable basesTable, bool duplicado = false)
        {
            int x = 0;
            if (duplicado)
                x++;

            DataRow[] alpinistaRow = alpinistasTable.Select("coluna = '" + coluna + "'");
            if (alpinistaRow.Length != 0)
            {
                x = int.Parse(alpinistaRow[0].Field<string>("posicao")) + 1;
            }
            else
            {
                DataRow[] baseRow = basesTable.Select("coluna = '" + coluna + "'");
                if (baseRow.Length != 0)
                {
                    x = int.Parse(baseRow[0].Field<string>("posicao")) + 1;
                }
            }

            double coeficiente_linear = coeficienteLinear(coluna);
            double metade_trilha = ((FormTabuleiro.getQuantidadePosicao(coluna) - 1) / 2);
            double coeficiente_angular = (18 - coeficiente_linear) / (metade_trilha);

            return (coeficiente_angular * x) + coeficiente_linear;
        }

        internal int EscolherJogada(int idJogador, List<Dictionary<string, int[]>> combinacoes)
        {
            int jogada = 0;
            int count = 0;
            double peso = 0;

            DataTable alpinistasTable = tabuleiro.SelecioneJogador(idJogador, "A");
            DataTable basesTable = tabuleiro.SelecioneJogador(idJogador, "B");
            foreach (Dictionary<string, int[]> combinacao in combinacoes)
            {
                if (combinacao.ElementAt(0).Key != "")
                {
                    double novoPeso = 0;
                    if (combinacao.Count > 1)
                    {
                        double novoSubPeso1 = calcularPeso(combinacao.ElementAt(0).Value[0], alpinistasTable, basesTable);
                        double novoSubPeso2 = calcularPeso(combinacao.ElementAt(1).Value[0], alpinistasTable, basesTable);

                        if (novoSubPeso1 >= novoSubPeso2 && novoSubPeso1 > peso)
                        {
                            peso = novoSubPeso1;
                            jogada = count;
                        }

                        if (novoSubPeso2 >= novoSubPeso1 && novoSubPeso2 > peso)
                        {
                            peso = novoSubPeso2;
                            jogada = count + 3;
                        }
                    }
                    else
                    {
                        novoPeso = calcularPeso(combinacao.ElementAt(0).Value[0], alpinistasTable, basesTable);
                        if (combinacao.ElementAt(0).Value[1] >= 2)
                        {
                            if (combinacao.ElementAt(0).Value[0] == combinacao.ElementAt(0).Value[1])
                            {
                                novoPeso += calcularPeso(combinacao.ElementAt(0).Value[1], alpinistasTable, basesTable, true);
                            }
                            else
                            {
                                novoPeso += calcularPeso(combinacao.ElementAt(0).Value[1], alpinistasTable, basesTable);
                            }
                        }


                        if (novoPeso > peso)
                        {
                            peso = novoPeso;
                            jogada = count;
                        }
                    }


                }
                count++;
            }

            this.jogadas++;
            return jogada;
        }

        internal void atribuirListaColunasDominadas()
        {
            List<int> aux = new List<int>();
            for (int i = 2; i <= 12; i++)
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
            if (alpinistas.Rows.Count == 0) this.Resetar();
        }

        internal bool sePararAcaba(int idJogaador)
        {
            int contadorAlpinistasNoTopoEColunasDominadas = 0;
            for (int i = 2; i <= 12; i++)
            {
                if (this.tabuleiro.AlpinistasEColunasDominadas(i, idJogaador)) contadorAlpinistasNoTopoEColunasDominadas++;

            }
            if (contadorAlpinistasNoTopoEColunasDominadas >= 3)
            {
                return true;
            }
            return false;
        }

        internal bool Continuar(int idJogaador)
        {
            if (this.sePararAcaba(idJogaador))
            {
                return false;
            }
            else
            {
                this.atribuirListaColunasDominadas();

                DataTable alpinistas = this.tabuleiro.SelecioneJogador(idJogaador, "A");
                int[] colunasComAlpinistas = new int[alpinistas.Rows.Count];


                for (int i = 0; i < alpinistas.Rows.Count; i++)
                {
                    colunasComAlpinistas[i] = (int.Parse(alpinistas.Rows[i].Field<string>("coluna")));
                }

                this.probabilidade.resetarProbabilidade();

                if (colunasComAlpinistas.Length == 3)
                {
                    if (this.flagFator)
                    {
                        foreach (int coluna in colunasComAlpinistas)
                        {

                            this.taxaLimite += this.tabuleiro.calculaFator(coluna, idJogaador); // esse fator resulta um numero no intervalo de -1 e 1
                        }
                        this.taxaLimite /= colunasComAlpinistas.Length; // faz a media entre os 3 fatores
                        this.taxaLimite *= 10; // multiplica por 10 e pelo numero de jogadores para o intervalo ser de -10 a 10
                        this.flagFator = false;
                    }
                    if (this.tabuleiro.ExisteAlgumAlpinistaNoTopo(idJogaador))
                    {
                        List<int> trilhasDisponiveis = new List<int>();
                        foreach (int coluna in colunasComAlpinistas)
                        {
                            if (!this.tabuleiro.AlpinistaEstaNoTopo(coluna, idJogaador)) trilhasDisponiveis.Add(coluna);
                        }

                        if (trilhasDisponiveis.Count == 1)
                        {
                            this.probabilidade.calcularProbabilidadeCairUmAlpnistaDisponivel(trilhasDisponiveis[0], this.jogadas);
                        }
                        else
                        {
                            this.probabilidade.calcularProbabilidadeCairDoisAlpnistsaDisponiveis(trilhasDisponiveis[0], trilhasDisponiveis[1], this.jogadas);
                        }
                    }
                    else
                    {
                        this.probabilidade.calculaProbabilidadeCair3Alpinistas(colunasComAlpinistas[0], colunasComAlpinistas[1], colunasComAlpinistas[2], this.jogadas);
                    }
                }
                else if (this.colunasDominadas != null && this.colunasDominadas.Length > 0)
                {
                    this.probabilidade.calcularProbabilidadeCairApenasEmColunasDominadas(this.colunasDominadas, this.jogadas);
                }

                if (this.probabilidade.getProbabilidadeCair() < 50f + this.taxaLimite) return true;
                return false;
            }

        }

        internal void Resetar()
        {
            this.jogadas = 0;
            this.flagFator = true;
            this.taxaLimite = 0;
        }

    }
}
