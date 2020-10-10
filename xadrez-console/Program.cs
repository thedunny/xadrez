﻿using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(3, 0));


            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();


        }
    }
}
