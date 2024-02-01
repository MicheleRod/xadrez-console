using System.Threading.Channels;
using tabuleiro;
using xadrez;
using xadrez_console;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            
            //Tabuleiro tab = new Tabuleiro(8, 8); // instaciou tabuleiro vazio

            PartidaDeXadrez partida = new PartidaDeXadrez();
            
            while (!partida.terminada)
            {
                try
                {
                    Console.Clear();
                    Tela.imprimirPartida(partida);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosicaoDeOrigem(origem);

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossíveis(); //analisa os movimentos possíveis e guardar na matriz de posições possíveis

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.WriteLine();

                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosicaoDestino(origem, destino);

                    partida.realizaJogada(origem, destino);
                }
                catch (TabuleiroException e) {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }

            
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadLine();
    }
}