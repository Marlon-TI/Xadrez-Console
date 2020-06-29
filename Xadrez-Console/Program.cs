using System;
using Tabuleiro;
using Xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            XTabuleiro tab = new XTabuleiro(8, 8);
            tab.ColocarPeca(new Torre(tab, Tabuleiro.Enum.Cor.Preta), new Posicao(0, 1));
            tab.ColocarPeca(new Torre(tab, Tabuleiro.Enum.Cor.Preta), new Posicao(1, 4));
            tab.ColocarPeca(new Rei(tab, Tabuleiro.Enum.Cor.Preta), new Posicao(7, 3));
            tab.ColocarPeca(new Torre(tab, Tabuleiro.Enum.Cor.Branca), new Posicao(2, 7));
            tab.ColocarPeca(new Rei(tab, Tabuleiro.Enum.Cor.Branca), new Posicao(3, 5));
            tab.ColocarPeca(new Torre(tab, Tabuleiro.Enum.Cor.Branca), new Posicao(2, 1));
            Tela.ImprimirTabuleiro(tab);

        }
    }
}
