using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantStop.Classes
{
    public class Probabilidades
    {
        private int[][] listaCombinacoesPossiveis { get; set; }
        private double[][] probabilidadeSomaColunas { get; set; }
        private double probabilidadeCair { get; set; }

        public Probabilidades()
        {
            var facesDado = new[] { 1, 2, 3, 4, 5, 6 };

            /*
             * para obter todas combinações de dados possiveis podemos
             * fazer o produto cartesiano entre as faces do dado
             * imaginando as faces como conjuntos ficaria
             * FaceDado1 X FaceDado2 X FaceDado3 X FaceDado4
             */
            IEnumerable<int[]> produtoCartesiano =
                (from dado1 in facesDado
                from dado2 in facesDado
                from dado3 in facesDado
                from dado4 in facesDado
                select new[] { dado1, dado2, dado3, dado4 });

            this.listaCombinacoesPossiveis = produtoCartesiano.ToArray();

            this.calcularPossibilidadeSomaColunas();
        }

        public double pegarProbabilidadeColunaUnica(int numeroColunaDesejada)
        {
            int i;
            for (i = 0; i < this.probabilidadeSomaColunas.Length || this.probabilidadeSomaColunas[i][0] == numeroColunaDesejada; i++);
            return this.probabilidadeSomaColunas[i][1];
        }
         
        private void calcularProbabilidadeUmaColuna(int colunaSelecionada)
        {
            int countPossibilidadesFavoraveis = 0;
            double porcentagemColuna = 0;
            foreach (int[] linha in this.listaCombinacoesPossiveis)
            {

                if (

                // combinação dado 1 com dado 2 e dado 3 com dado 4
                linha[0] + linha[1] == colunaSelecionada || linha[0] + linha[1] == colunaSelecionada || linha[0] + linha[1] == colunaSelecionada || linha[2] + linha[3] == colunaSelecionada || linha[2] + linha[3] == colunaSelecionada || linha[2] + linha[3] == colunaSelecionada ||

                // combinação dado 1 com dado 3 e dado 2 com dado 4
                linha[0] + linha[2] == colunaSelecionada || linha[0] + linha[2] == colunaSelecionada || linha[0] + linha[2] == colunaSelecionada || linha[1] + linha[3] == colunaSelecionada || linha[1] + linha[3] == colunaSelecionada || linha[1] + linha[3] == colunaSelecionada ||

                // combinação dado 1 com dado 4 e dado 2 com dado 3
                linha[0] + linha[3] == colunaSelecionada || linha[0] + linha[3] == colunaSelecionada || linha[0] + linha[3] == colunaSelecionada || linha[1] + linha[2] == colunaSelecionada || linha[1] + linha[2] == colunaSelecionada || linha[1] + linha[2] == colunaSelecionada
                )
                {
                    countPossibilidadesFavoraveis++;
                }

            }

            porcentagemColuna = ((double)countPossibilidadesFavoraveis / (double)this.listaCombinacoesPossiveis.Length) * 100;

            if (this.probabilidadeSomaColunas is null) this.probabilidadeSomaColunas = new double[11][];

           this.probabilidadeSomaColunas[colunaSelecionada-2] = new double[] { colunaSelecionada, porcentagemColuna };

        }

        private void calcularPossibilidadeSomaColunas()
        {
            for ( int coluna = 2; coluna <=7; coluna++)
            {
                this.calcularProbabilidadeUmaColuna(coluna);
            }

            /* 
             * há colunas equiprovaveis, ou seja, que tem a mesma porcentagem de combinações (probabilidade de os dados derem aquela soma)
             * coluna 2 é equiprovavel com a 12
             * coluna 3 é equiprovavel com a 11
             * coluna 4 é equiprovavel com a 10
             * coluna 5 é equiprovavel com a 9
             * coluna 6 é equiprovavel com a 8
             */
            int colunaB = 8;
            for (int colunaA = 6; colunaA >= 2; colunaA--)
            {
                this.probabilidadeSomaColunas[colunaB - 2] = new double[] { colunaB , this.probabilidadeSomaColunas[colunaA-2][1] };
                colunaB++;
            }

        }

        private double calcularProbalidadeCairEntreSomente2Colunas(int a, int b)
        {
            double countPossibilidadesFavoraveis = 0;

            foreach (int[] linha in this.listaCombinacoesPossiveis)
            {
                if (
                /*
                // combinação dado 1 com dado 2 e dado 3 com dado 4
                linha[0] + linha[1] == a && linha[2] + linha[3] == b || linha[0] + linha[1] == b && linha[2] + linha[3] == a||

                // combinação dado 1 com dado 3 e dado 2 com dado 4
                linha[0] + linha[2] == a && linha[1] + linha[3] == b || linha[0] + linha[2] == b && linha[1] + linha[3] == a ||

                // combinação dado 1 com dado 4 e dado 2 com dado 3
                linha[0] + linha[3] == a && linha[1] + linha[2] == b || linha[0] + linha[3] == b && linha[1] + linha[2] == a
                */
                // combinação dado 1 com dado 2 e dado 3 com dado 4
                linha[0] + linha[1] == a && linha[2] + linha[3] == b ||

                // combinação dado 1 com dado 3 e dado 2 com dado 4
                linha[0] + linha[2] == a && linha[1] + linha[3] == b ||

                // combinação dado 1 com dado 4 e dado 2 com dado 3
                linha[0] + linha[3] == a && linha[1] + linha[2] == b 
                )
                {
                    countPossibilidadesFavoraveis++;
                }
            }

            return countPossibilidadesFavoraveis;
        }

        private double calcularProbalidadeCairEntre3Colunas(int a, int b, int c)
        {
            double countPossibilidadesFavoraveis = 0;
            
            foreach (int[] linha in this.listaCombinacoesPossiveis)
            {

                if (

                // combinação dado 1 com dado 2 e dado 3 com dado 4
                linha[0] + linha[1] == a || linha[0] + linha[1] == b || linha[0] + linha[1] == c || linha[2] + linha[3] == a || linha[2] + linha[3] == b || linha[2] + linha[3] == c ||

                // combinação dado 1 com dado 3 e dado 2 com dado 4
                linha[0] + linha[2] == a || linha[0] + linha[2] == b || linha[0] + linha[2] == c || linha[1] + linha[3] == a || linha[1] + linha[3] == b || linha[1] + linha[3] == c ||

                // combinação dado 1 com dado 4 e dado 2 com dado 3
                linha[0] + linha[3] == a || linha[0] + linha[3] == b || linha[0] + linha[3] == c || linha[1] + linha[2] == a || linha[1] + linha[2] == b || linha[1] + linha[2] == c
                )
                {
                    countPossibilidadesFavoraveis++;
                }

            }

            return countPossibilidadesFavoraveis;
        }

        public void calculaProbabilidadeCair3Alpinistas(int coluna1, int coluna2, int coluna3, int qntdJogadasNaRodadaJaFeitas)
        {
            // eh uma hipotese da proxima jogada
            double countPossibilidadesFavoraveis = this.calcularProbalidadeCairEntre3Colunas(coluna1, coluna2, coluna3);
            double probabilidadeFavoraveis = ((Math.Pow(countPossibilidadesFavoraveis, qntdJogadasNaRodadaJaFeitas + 1) / Math.Pow(this.listaCombinacoesPossiveis.Length , qntdJogadasNaRodadaJaFeitas + 1))*100);
            this.probabilidadeCair = 100 - probabilidadeFavoraveis;
        }

        public void calculaProbabilidadeCair1Alpinista(int colunaDeasejada, int qntdJogadasNaRodadaJaFeitas)
        {
            // eh uma hipotese da proxima jogada
            double countPossibilidadesFavoraveis = this.pegarProbabilidadeColunaUnica(colunaDeasejada);
            double probabilidadeFavoraveis = ((Math.Pow(countPossibilidadesFavoraveis, qntdJogadasNaRodadaJaFeitas + 1) / Math.Pow(this.listaCombinacoesPossiveis.Length, qntdJogadasNaRodadaJaFeitas + 1)) * 100);
            this.probabilidadeCair = 100 - probabilidadeFavoraveis;
        }

        public void calcularProbabilidadeCairApenasEmColunasDominadas(int[] colunasDominadas, int qntdJogadasNaRodadaJaFeitas)
        {
            /*
            * produto cartesiano entre as colunas dominadas resulta em todas possibilidades entre elas
            * ou seja, que somente caira nestas
            * é preciso apenas dois pois é o maximo de colunas a progredir em uma escolhas
            */
            IEnumerable<int[]> produtoCartesiano =
                (from coluna1 in colunasDominadas
                 from coluna2 in colunasDominadas
                 select new[] { coluna1, coluna2 });

            int[][] possibilidadesDeProgresso = produtoCartesiano.ToArray();

            // eh um calculo da chance de nao cair somente nas colunas ja dominadas
            double countPossibilidadeParaCair = 0;
            foreach ( int[]umaEscolha in possibilidadesDeProgresso)
            {
                countPossibilidadeParaCair += this.calcularProbalidadeCairEntreSomente2Colunas(umaEscolha[0], umaEscolha[1]);
            }
            double probabilidadeFavoraveis = this.listaCombinacoesPossiveis.Length - countPossibilidadeParaCair;
            probabilidadeFavoraveis = ((Math.Pow(probabilidadeFavoraveis, qntdJogadasNaRodadaJaFeitas + 1) / Math.Pow(this.listaCombinacoesPossiveis.Length, qntdJogadasNaRodadaJaFeitas + 1)) * 100);
            this.probabilidadeCair = 100 - probabilidadeFavoraveis;
        }

        public double getProbabilidadeCair()
        {
            return this.probabilidadeCair;
        }

        public void resetarProbabilidade()
        {
            this.probabilidadeCair = 0;
        }
    }
}
