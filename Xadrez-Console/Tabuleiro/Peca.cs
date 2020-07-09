﻿using Tabuleiro.Enum;
using Tabuleiro;

namespace Tabuleiro
{
   abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public XTabuleiro Tab { get; protected set; }

        public Peca(Cor cor, XTabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QteMovimentos = 0;
        }

        public abstract bool[,] MovimentosPossiveis();
        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }
    }
}
