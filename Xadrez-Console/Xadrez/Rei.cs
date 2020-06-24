using Tabuleiro;
using Tabuleiro.Enum;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei (XTabuleiro tab, Cor cor) : base (cor, tab)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
