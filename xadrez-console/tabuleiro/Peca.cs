﻿using System;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdeMovimentos { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca( Tabuleiro tab, Cor cor)
        {
            this .posicao = null;
            this .tab = tab;
            this .cor = cor;
            this.qtdeMovimentos = 0;
        }

        public void incrementarQtdeMovimentos()
        {
            qtdeMovimentos++;
        }

        public void decrementarQtdeMovimentos()
        {
            qtdeMovimentos--;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossíveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j]) { return true; }
                }
            }
            return false;
        }

        public bool movimentoPossivel(Posicao pos)
        {
            return movimentosPossíveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossíveis(); //método abstrato não é implementado na classe
    }
}
