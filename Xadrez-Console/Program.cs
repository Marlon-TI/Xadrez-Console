using System;
using Tabuleiro;
using Xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XTabuleiro teste = new XTabuleiro(8, 8);

                teste.ColocarPeca(new Torre(teste, Tabuleiro.Enum.Cor.Preta), new Posicao(0, 0));
                teste.ColocarPeca(new Torre(teste, Tabuleiro.Enum.Cor.Preta), new Posicao(2, 0));
                teste.ColocarPeca(new Torre(teste, Tabuleiro.Enum.Cor.Preta), new Posicao(0, 5));
                teste.ColocarPeca(new Torre(teste, Tabuleiro.Enum.Cor.Preta), new Posicao(3, 4));
                teste.ColocarPeca(new Rei(teste, Tabuleiro.Enum.Cor.Preta), new Posicao(2, 5));
                teste.ColocarPeca(new Rei(teste, Tabuleiro.Enum.Cor.Preta), new Posicao(1, 5));


                Tela.ImprimirTabuleiro(teste);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
