using System;
using Tabuleiro;
using Xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosicao());

        }
    }
}
