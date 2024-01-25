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

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição.");
            }
            pecas[pos.linha, pos.coluna] = p; //jogando a peça p na matriz de pecas nessa posição
            p.posicao = pos;
        }

        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha<0 || pos.linha>=linhas || pos.coluna<0 || pos.coluna>=colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos) // se posicao nao for válida, lança exceção personalizada
        {
            if (!posicaoValida(pos)) // ! = não
            {
                throw new TabuleiroException("Posição inválida");
            }
        }
    }
}
