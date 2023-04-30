﻿using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;
namespace xadrez_console
{
    internal class Tela
    {
        public static void ImprimirTabuleiro( Tabuleiro tab)
        {
            for (int i = 0; i<tab.Linhas; i++)
            {
                Console.Write( 8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {   
                    if (tab.peca(i,j)== null)
                    {
                        Console.Write("- ");
                    }else
                    {
                        ImprimirPeca(tab.peca(i,j));
                        Console.Write(" ");
                    }
                   
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
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
        }
    }
}
