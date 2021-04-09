using System;
using System.Data;
using CantStopServer;

namespace cantStop.Classes
{
    class Tabuleiro
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
            DataRow[] data = locais.Select("coluna = '" + i.ToString() + "'");

            DataTable dataTable = locais.Clone();
            foreach (DataRow linha in data)
            {
                dataTable.ImportRow(linha);
            }
            
            return dataTable;
        }
    }
}
