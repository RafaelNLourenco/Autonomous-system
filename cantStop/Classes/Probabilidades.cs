using System;
using System.Collections.Generic;
using System.Linq;

namespace cantStop.Classes
{
    public class Probabilidades
    {
        private int[][] listaCombinacoesPossiveis { get; set; }
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

        }

        // calcula a probabilida de cair quando se tem 3 alpinistas usando
        public void calculaProbabilidadeCair3Alpinistas(int coluna1, int coluna2, int coluna3, int qntdJogadasNaRodadaJaFeitas)
        {
            // eh uma hipotese da proxima jogada
            double countPossibilidadesFavoraveis = this.calcularProbalidadeCairEntre3Colunas(coluna1, coluna2, coluna3);
            double probabilidadeFavoraveis = ((Math.Pow(countPossibilidadesFavoraveis, qntdJogadasNaRodadaJaFeitas + 1) / Math.Pow(this.listaCombinacoesPossiveis.Length, qntdJogadasNaRodadaJaFeitas + 1)) * 100);
            this.probabilidadeCair = 100 - probabilidadeFavoraveis;
        }

        // metodo auxiliar ao calculaProbabilidadeCair3Alpinistas
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

        // metodo que pega a probabilidade quando tem um alpinista para ser utilizado e 2 travados/concluiu a coluna
        public void calcularProbabilidadeCairUmAlpnistaDisponivel(int colunaDisponivel, int qntdJogadasNaRodadaJaFeitas)
        {
            int countPossibilidadesFavoraveis = 0;
            foreach (int[] linha in this.listaCombinacoesPossiveis)
            {

                if (

                // combinação dado 1 com dado 2 e dado 3 com dado 4
                linha[0] + linha[1] == colunaDisponivel || linha[2] + linha[3] == colunaDisponivel ||

                // combinação dado 1 com dado 3 e dado 2 com dado 4
                linha[0] + linha[2] == colunaDisponivel || linha[1] + linha[3] == colunaDisponivel ||

                // combinação dado 1 com dado 4 e dado 2 com dado 3
                linha[0] + linha[3] == colunaDisponivel || linha[1] + linha[2] == colunaDisponivel
                )
                {
                    countPossibilidadesFavoraveis++;
                }

            }

            // eh uma hipotese da proxima jogada
            double probabilidadeFavoraveis = ((Math.Pow(countPossibilidadesFavoraveis, qntdJogadasNaRodadaJaFeitas + 1) / Math.Pow(this.listaCombinacoesPossiveis.Length, qntdJogadasNaRodadaJaFeitas + 1)) * 100);
            this.probabilidadeCair = 100 - probabilidadeFavoraveis;
        }

        // metodo que pega a probabilidade quando tem dois alpinistas para ser utilizado e 1 travados/concluiu a coluna
        public void calcularProbabilidadeCairDoisAlpnistsaDisponiveis(int colunaA, int colunaB, int qntdJogadasNaRodadaJaFeitas)
        {
            double countPossibilidadesFavoraveis = 0;

            foreach (int[] linha in this.listaCombinacoesPossiveis)
            {
                if (
                    //combinação dado 1 com dado 2 e dado 3 com dado 4
                    linha[0] + linha[1] == colunaA || linha[2] + linha[3] == colunaB || linha[0] + linha[1] == colunaB || linha[2] + linha[3] == colunaA ||

                    // combinação dado 1 com dado 3 e dado 2 com dado 4
                    linha[0] + linha[2] == colunaA || linha[1] + linha[3] == colunaB || linha[0] + linha[2] == colunaB || linha[1] + linha[3] == colunaA ||

                    //combinação dado 1 com dado 4 e dado 2 com dado 3
                    linha[0] + linha[3] == colunaA || linha[1] + linha[2] == colunaB || linha[0] + linha[3] == colunaB || linha[1] + linha[2] == colunaA
                )
                {
                    countPossibilidadesFavoraveis++;
                }

            }

            // eh uma hipotese da proxima jogada
            double probabilidadeFavoraveis = ((Math.Pow(countPossibilidadesFavoraveis, qntdJogadasNaRodadaJaFeitas + 1) / Math.Pow(this.listaCombinacoesPossiveis.Length, qntdJogadasNaRodadaJaFeitas + 1)) * 100);
            this.probabilidadeCair = 100 - probabilidadeFavoraveis;
        }

        // metodo para calcular probabilidade quando há chance de cair apenas com colunas dominadas
        public void calcularProbabilidadeCairApenasEmColunasDominadas(int[] colunasDominadas, int qntdJogadasNaRodadaJaFeitas)
        {
            /*
            * produto cartesiano entre as colunas dominadas e suas respectivas
            * combinações, toda vez que se joga os dados voce pode ter ate 3 combinações
            * de pares, no total até 6 colunas
            * isso guarda o produto cartesiano dessas 6 colunas
            * obs: é possivel construir linhas invalidas ao jogo
            * por exemplo: 2,7 7,7 7,7
            */
            IEnumerable<int[]> produtoCartesianoPares =
                (from par1Coluna1 in colunasDominadas
                 from par1Coluna2 in colunasDominadas

                 from par2Coluna1 in colunasDominadas
                 from par2Coluna2 in colunasDominadas

                 from par3Coluna1 in colunasDominadas
                 from par3Coluna2 in colunasDominadas

                 select new[] { par1Coluna1, par1Coluna2, par2Coluna1, par2Coluna2, par3Coluna1, par3Coluna2 });


            int[][] combinacoesPossiveisParaCair = produtoCartesianoPares.ToArray();


            // eh um calculo da chance de nao cair somente nas colunas ja dominadas
            double countPossibilidadeParaCair = 0;

            /*
             * checa quantas possibilidades de cair existem
             */
            foreach (int[] coluna in combinacoesPossiveisParaCair)
            {
                foreach (int[] dados in this.listaCombinacoesPossiveis)
                {
                    if (
                        dados[0] + dados[1] == coluna[0] &&
                        dados[2] + dados[3] == coluna[1]
                        &&
                        dados[0] + dados[1] == coluna[2] &&
                        dados[2] + dados[3] == coluna[3]
                        &&
                        dados[0] + dados[1] == coluna[4] &&
                        dados[2] + dados[3] == coluna[5]
                        )
                    {
                        countPossibilidadeParaCair++;
                    }
                }
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
