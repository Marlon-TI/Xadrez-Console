
using Tabuleiro.Enum;
namespace Tabuleiro
{
    class XTabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public XTabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[Linhas, Colunas];
        }
        public Peca peca (int linha, int colunas)
        {
            return pecas[linha , colunas];
        }

        public void ColocarPeca (Peca p, Posicao pos)
        {
            pecas[pos.Linha, pos.Coluna]=p;
            p.Posicao = pos;
        }
    }
}
