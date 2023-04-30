using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;


namespace xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQteMovimento();
            Peca PecaCapturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(p, destino);
        }

        private void ColocarPecas()
        {
            Tab.ColocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('c', 1).toPosicao());
            Tab.ColocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('c', 2).toPosicao());
            Tab.ColocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('d', 2).toPosicao());
            Tab.ColocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('e', 2).toPosicao());
            Tab.ColocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('e', 1).toPosicao());
            Tab.ColocarPeca(new Rei(Cor.Branca, Tab), new PosicaoXadrez('d', 1).toPosicao());

            Tab.ColocarPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('c', 7).toPosicao());
            Tab.ColocarPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('c', 8).toPosicao());
            Tab.ColocarPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('d', 7).toPosicao());
            Tab.ColocarPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('e', 7).toPosicao());
            Tab.ColocarPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('e', 8).toPosicao());
            Tab.ColocarPeca(new Rei(Cor.Preta, Tab), new PosicaoXadrez('d', 8).toPosicao());
        }


    }
}
