using System;
using System.Collections.Generic;
using System.Data;
using CantStopServer;

namespace cantStop.Classes
{
    public class Tabuleiro
    {
        public DataTable locais { get; set; }

        public Tabuleiro()
        {
            this.locais = new DataTable();
            this.locais.Columns.Add("coluna");
            this.locais.Columns.Add("posicao");
            this.locais.Columns.Add("jogador");
            this.locais.Columns.Add("tipo");
        }

        public void atualizarTabuleiro(int idPartida)
        {
            this.locais.Clear();

            string retorno = Jogo.ExibirTabuleiro(idPartida);
            if (String.IsNullOrEmpty(retorno)) return;

            retorno = retorno.Replace("\r\n", ";");
            retorno = retorno.Remove(retorno.Length - 1);
            string[] linhas = retorno.Split(';');

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(',');

                DataRow dadoLinha = this.locais.NewRow();
                dadoLinha["coluna"] = dados[0];
                dadoLinha["posicao"] = dados[1];
                dadoLinha["jogador"] = dados[2];
                dadoLinha["tipo"] = dados[3];

                this.locais.Rows.Add(dadoLinha);
            }
        }

        public DataTable SelecioneColuna(int i)
        {
            DataTable dataTable = this.locais.Clone();
            DataRow[] data = this.locais.Select("coluna = '" + i.ToString() + "'");
            foreach (DataRow linha in data)
            {
                dataTable.ImportRow(linha);
            }
            
            return dataTable;
        }

        public DataTable SelecioneJogador(int id, string tipo)
        {
            DataTable dataTable = this.locais.Clone();
            DataRow[] data = this.locais.Select("jogador = '" + id.ToString() + "' AND tipo = '" + tipo + "'");
            foreach (DataRow linha in data)
            {
                dataTable.ImportRow(linha);
            }
            return dataTable;
        }

        public bool ColunaDominada(int coluna)
        {
            DataRow[] data = this.locais.Select("coluna = '" + coluna.ToString() + "' AND posicao = '" + FormTabuleiro.getQuantidadePosicao(coluna) + "' AND tipo = 'B'");
            return data.Length > 0;
        }

        public bool FaltaUmParaDominar(int i, int[,] ordemValor, int idJogador)
        {
            int coluna1 = ordemValor[i, 0] + ordemValor[i, 1];
            int coluna2 = ordemValor[i, 2] + ordemValor[i, 3];

            if (coluna1 == coluna2) { 
                DataRow[] data = this.locais.Select("coluna = '" + coluna1.ToString() + "' AND jogador = '"+ idJogador.ToString() + "' AND tipo = 'A'");
                foreach(DataRow linha in data)
                {
                    if( FormTabuleiro.getQuantidadePosicao(coluna1) - int.Parse(linha.Field<string>("posicao")) == 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool AlpinistaEstaNoTopo(int coluna, int idJogador)
        {
            DataRow[] data = this.locais.Select("coluna = '" + coluna.ToString() + "' AND jogador = '" + idJogador.ToString() + "' AND posicao = '" + FormTabuleiro.getQuantidadePosicao(coluna) + "' AND tipo = 'A'");
            return data.Length > 0;
        }

        public bool AlpinistasEColunasDominadas(int coluna, int idJogador)
        {
            DataRow[] data = this.locais.Select("coluna = '" + coluna.ToString() + "' AND jogador = '" + idJogador.ToString() + "' AND posicao = '" + FormTabuleiro.getQuantidadePosicao(coluna) + "'");
            return data.Length > 0;
        }

        public List<Dictionary<string, int[]>> MontarCombinacoes(int idJogador, List<int> dados)
        {
            DataTable alpinistas = this.SelecioneJogador(idJogador, "A");
            int quantidadeAlpinistas = 3 - alpinistas.Rows.Count;
            List<Dictionary<string, int[]>> combinacoes = new List<Dictionary<string, int[]>>();

            string[,] ordemDados =
            {
                {"1","2","3","4"},
                {"1","3","2","4"},
                {"1","4","2","3"}
            };

            int[,] ordemValor =
            {
                {dados[0], dados[1], dados[2], dados[3]},
                {dados[0], dados[2], dados[1], dados[3]},
                {dados[0], dados[3], dados[1], dados[2]}
            };

            for (int i = 0; i < 3; i++)
            {
                bool colunaDominada1 = this.ColunaDominada(ordemValor[i, 0] + ordemValor[i, 1]);
                bool colunaDominada2 = this.ColunaDominada(ordemValor[i, 2] + ordemValor[i, 3]);

                bool faltaUmParaDominar = this.FaltaUmParaDominar(i, ordemValor, idJogador);

                bool estaNoTopoColuna1 = this.AlpinistaEstaNoTopo(ordemValor[i, 0] + ordemValor[i, 1], idJogador);
                bool estaNoTopoColuna2 = this.AlpinistaEstaNoTopo(ordemValor[i, 2] + ordemValor[i, 3], idJogador);

                Dictionary<string, int[]> movimento = new Dictionary<string, int[]>();

                if (quantidadeAlpinistas >= 2 && !(estaNoTopoColuna1 && estaNoTopoColuna2))
                {
                    if (!(colunaDominada1 || colunaDominada2) && !(estaNoTopoColuna1 || estaNoTopoColuna2) && !faltaUmParaDominar)
                    {
                        string ordem = ordemDados[i, 0] + ordemDados[i, 1] + ordemDados[i, 2] + ordemDados[i, 3];
                        movimento.Add(ordem, new[] { ordemValor[i, 0] + ordemValor[i, 1], ordemValor[i, 2] + ordemValor[i, 3] });
                    }
                    else
                    {
                        if ((!colunaDominada1 && colunaDominada2 && !estaNoTopoColuna1) || faltaUmParaDominar)
                        {
                            string ordem = ordemDados[i, 0] + ordemDados[i, 1] + ordemDados[i, 2] + ordemDados[i, 3];
                            movimento.Add(ordem, new[] { ordemValor[i, 0] + ordemValor[i, 1], 0 });
                        }
                        else
                        {
                            if (colunaDominada1 && !colunaDominada2 && !estaNoTopoColuna2)
                            {
                                string ordem = ordemDados[i, 2] + ordemDados[i, 3] + ordemDados[i, 0] + ordemDados[i, 1];
                                movimento.Add(ordem, new[] { ordemValor[i, 2] + ordemValor[i, 3], 0 });
                            }
                            else
                            {
                                movimento.Add("", new[] { 0, 0 });
                            }
                        }
                    }
                }
                else
                {
                    DataRow[] alpinistas1 = alpinistas.Select("coluna = '" + (ordemValor[i, 0] + ordemValor[i, 1]) + "'");
                    DataRow[] alpinistas2 = alpinistas.Select("coluna = '" + (ordemValor[i, 2] + ordemValor[i, 3]) + "'");

                    if (quantidadeAlpinistas == 1)
                    {
                        if (!(colunaDominada1 || colunaDominada2) && !(estaNoTopoColuna1 || estaNoTopoColuna2) && !faltaUmParaDominar)
                        {
                            if (alpinistas1.Length != 0 || alpinistas2.Length != 0 || (ordemValor[i, 0] + ordemValor[i, 1] == ordemValor[i, 2] + ordemValor[i, 3]))
                            {
                                string ordem = ordemDados[i, 0] + ordemDados[i, 1] + ordemDados[i, 2] + ordemDados[i, 3];
                                movimento.Add(ordem, new[] { ordemValor[i, 0] + ordemValor[i, 1], ordemValor[i, 2] + ordemValor[i, 3] });
                            }
                            else
                            {
                                string ordem1 = ordemDados[i, 0] + ordemDados[i, 1] + ordemDados[i, 2] + ordemDados[i, 3];
                                movimento.Add(ordem1, new[] { ordemValor[i, 0] + ordemValor[i, 1], 0 });

                                string ordem2 = ordemDados[i, 2] + ordemDados[i, 3] + ordemDados[i, 0] + ordemDados[i, 1];
                                movimento.Add(ordem2, new[] { ordemValor[i, 2] + ordemValor[i, 3], 0 });
                            }
                        }
                        else
                        {
                            if ((!colunaDominada1 && !estaNoTopoColuna1) || faltaUmParaDominar)
                            {
                                string ordem = ordemDados[i, 0] + ordemDados[i, 1] + ordemDados[i, 2] + ordemDados[i, 3];
                                movimento.Add(ordem, new[] { ordemValor[i, 0] + ordemValor[i, 1], 0 });
                            }
                            else
                            {
                                if (!colunaDominada2 && !estaNoTopoColuna2)
                                {
                                    string ordem = ordemDados[i, 2] + ordemDados[i, 3] + ordemDados[i, 0] + ordemDados[i, 1];
                                    movimento.Add(ordem, new[] { ordemValor[i, 2] + ordemValor[i, 3], 0 });
                                }
                                else
                                {
                                    movimento.Add("", new[] { 0, 0 });
                                }
                            }
                        }
                        
                    }
                    else
                    {
                        if ((alpinistas1.Length != 0 || alpinistas2.Length != 0) && !(estaNoTopoColuna1 && estaNoTopoColuna2))
                        {
                            if (alpinistas1.Length != 0 && alpinistas2.Length != 0 && !faltaUmParaDominar && !(estaNoTopoColuna1 || estaNoTopoColuna2))
                            {
                                string ordem = ordemDados[i, 0] + ordemDados[i, 1] + ordemDados[i, 2] + ordemDados[i, 3];
                                movimento.Add(ordem, new[] { ordemValor[i, 0] + ordemValor[i, 1], ordemValor[i, 2] + ordemValor[i, 3] });
                            }
                            else
                            {
                                if ((alpinistas1.Length != 0 && !estaNoTopoColuna1) || faltaUmParaDominar)
                                {
                                    string ordem = ordemDados[i, 0] + ordemDados[i, 1] + ordemDados[i, 2] + ordemDados[i, 3];
                                    movimento.Add(ordem, new[] { ordemValor[i, 0] + ordemValor[i, 1], 0 });
                                }
                                else
                                {
                                    if (alpinistas2.Length != 0  && !estaNoTopoColuna2) { 
                                        string ordem = ordemDados[i, 2] + ordemDados[i, 3] + ordemDados[i, 0] + ordemDados[i, 1];
                                        movimento.Add(ordem, new[] { ordemValor[i, 2] + ordemValor[i, 3], 0 });
                                    }
                                    else
                                    {
                                        movimento.Add("", new[] { 0, 0 });
                                    }
                                }
                            }
                        }
                        else
                        {
                            movimento.Add("", new[] { 0, 0 });
                        }
                    }
                }
                combinacoes.Add(movimento);
            }

            

            return combinacoes;
        }

        public bool ExisteAlgumAlpinistaNoTopo(int idJogador)
        {
            for ( int i = 2; i <=12; i++)
            {
                if (this.AlpinistaEstaNoTopo(i, idJogador)) return true; 
            }
            return false;
        }

        public float calculaFator(int coluna, int idJogador)
        {
            DataRow[] bases = this.locais.Select("coluna = '" + coluna.ToString() + "' AND tipo = 'B' AND jogador <> '" + idJogador + "'");
            DataRow[] alpinista = this.locais.Select("coluna = '" + coluna.ToString() + "' AND tipo = 'A'");
            int posicaoAlp = int.Parse(alpinista[0].Field<string>("posicao"));
            int diff = 0;
            float res = 0;
            
            if (bases.Length > 0)
            {
                int maiorPosicaoBase = 0;
                foreach( DataRow b in  bases)
                {
                    int posicao = int.Parse(b.Field<string>("posicao"));
                    maiorPosicaoBase = Math.Max(maiorPosicaoBase, posicao);
                }
                diff = maiorPosicaoBase - posicaoAlp;

            }
            res = (float)diff / (float)FormTabuleiro.getQuantidadePosicao(coluna);
            return res;
        }
    }
}
