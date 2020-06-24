using System;
using Tabuleiro;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            XTabuleiro teste = new XTabuleiro (8,8);
            Tela.ImprimirTabuleiro(teste);

        }
    }
}
