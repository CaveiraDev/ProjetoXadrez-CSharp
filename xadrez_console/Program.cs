using System;
using tabuleiro;
using xadrez;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {


            /* try
             {

                 Tabuleiro tab = new Tabuleiro(8, 8);

                 tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                 tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
                 tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 9));
                 Tela.ImprimirTabuleiro(tab);


             }catch (TabuleiroException e)
             {
                 Console.WriteLine(e.Message);
             }
             Console.ReadLine();*/



            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos.toPosicao());
        }
    }
}