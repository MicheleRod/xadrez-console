using tabuleiro;
using xadrez;
using xadrez_console;

internal class Program
{
    private static void Main(string[] args)
    {
        Tabuleiro tab = new Tabuleiro(8, 8); // instaciou tabuleiro vazio

        tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
        tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
        tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

        Tela.imprimirTabuleiro(tab); // chamando método p imprimir

        Console.ReadLine();
    }
}