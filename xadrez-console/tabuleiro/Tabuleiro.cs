using System;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this .linhas = linhas;
            this .colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna) // método p retornar uma peça, já que a matriz não pode ser acessada.
        {
            return pecas[linha, coluna]; // esse método vai acessar a peça na linha linha e coluna coluna.
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            pecas[pos.linha, pos.coluna] = p; //jogando a peça p na matriz de pecas nessa posição
            p.posicao = pos;
        }
    }
}
