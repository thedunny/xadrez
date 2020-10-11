using System;
using System.Net.NetworkInformation;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i=0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j=0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- \t");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write("\t");
                    }
                }
                Console.WriteLine(); 
            }
            Console.Write("  A\tB\tC\tD\tE\tF\tG\tH\t");
        }

        public static void imprimirPeca (Peca peca)
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char l = s[0];
            int c = int.Parse(s[1] + "");
            return new PosicaoXadrez(l, c);
        }

    }
}
