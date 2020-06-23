using Tabuleiro.Enum;

namespace Tabuleiro
{
    class Peca
    {
        public Posicao Posicao  { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public XTabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, XTabuleiro tab)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            QteMovimentos = 0;
        }
    }
}
