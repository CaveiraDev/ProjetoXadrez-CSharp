using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;
namespace xadrez_console
{
    internal class Tela
    {

        public static void ImprimirPartida(PartidaDeXadrez partida)
        {
            
            
                ImprimirTabuleiro(partida.Tab);
                Console.WriteLine();
                ImprimirPecasCapturadas(partida);
                Console.WriteLine("Turno: " + partida.Turno);
                Console.WriteLine("Aguardando jogada: " + partida.JogadorAtual);
        }

        public static void ImprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Pecas Capturadas: ");
            Console.Write("Brancas: ");
            ImprimirConjunto(partida.PecasCapturadas(Cor.Branca));
            Console.Write("Pretas:  ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            ImprimirConjunto(partida.PecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }

        public static void ImprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");
            foreach (Peca x in conjunto)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine("]");
        }
        public static void ImprimirTabuleiro( Tabuleiro tab)
        {
            for (int i = 0; i<tab.Linhas; i++)
            {
                Console.Write( 8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {      
                    ImprimirPeca(tab.peca(i,j));                 
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] PossicoePossiveis)
        {
            ConsoleColor FundoOriginal = Console.BackgroundColor;
            ConsoleColor FundoAlterado = ConsoleColor.DarkGray;
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (PossicoePossiveis[i, j])
                    {
                        Console.BackgroundColor = FundoAlterado;
                    }else
                    {
                        Console.BackgroundColor = FundoOriginal;
                    }
                    ImprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = FundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = FundoOriginal;
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
           string s = Console.ReadLine();
            char Coluna = s[0];
            int Linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(Coluna,Linha);
        }
        public static void  ImprimirPeca(Peca peca)
        {
            if (peca == null){
                Console.Write("- ");
            }else
            {
                if (peca.Cor == Cor.Branca)
                {
                      Console.Write(peca);
                }else
                {
                      ConsoleColor aux = Console.ForegroundColor;
                      Console.ForegroundColor = ConsoleColor.Yellow;
                      Console.Write(peca);
                      Console.ForegroundColor = aux;
                }

                Console.Write(" ");
            }
            
        }
    }
}
