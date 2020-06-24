using Tabuleiro;
using Tabuleiro.Enum;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre (XTabuleiro tab, Cor cor) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
