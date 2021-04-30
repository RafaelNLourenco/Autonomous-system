using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantStop.Classes
{
    public class Inteligencia
    {
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
            return jogada;
        }
    }
}
