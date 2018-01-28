﻿namespace tabuleiro
{
    class Peca
    {
        //atributos
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtemovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor )
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qtemovimentos = 0;
        }

    }
}
