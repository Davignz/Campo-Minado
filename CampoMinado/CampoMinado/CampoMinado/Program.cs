using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampoMinado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] tabuleiro = new string[11, 11];
            int linha, coluna, l, c, possi;

            possi = 0;

            Console.WriteLine(" ------------------------------------------------------------- ");
            Console.WriteLine(" |                      CAMPO MINADO                         | ");
            Console.WriteLine(" ------------------------------------------------------------- ");
            Console.WriteLine("    1     2     3     4     5     6     7     8     9     10");
            Console.WriteLine(" ------------------------------------------------------------- ");

            //Escrevendo tabuleiro zerado
            for (linha = 1; linha < 11; linha++)
            {
                for (coluna = 1; coluna < 11; coluna++)
                {
                    tabuleiro[linha, coluna] = "0";
                    Console.Write(" | " + tabuleiro[linha, coluna] + "  ");
                }
                Console.WriteLine(" | " + linha + "  ");
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ------------------------------------------------------------- ");
            Console.WriteLine("    1     2     3     4     5     6     7     8     9     10");
            Console.WriteLine(" ");

            do
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("DIGITE SOMENTE NÚMEROS DE 1 A 10, OU APERTE ESC PARA SAIR");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("TODAS AS LIHNAS POSSUEM BOMBAS, CUIDADO!");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Digite a linha");
                l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a coluna");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                //Escrever no tabuleiro a posição selecionada (muda de 0 pra 1)
                tabuleiro[l, c] = "1";

                //Somando pontuação
                possi++;

                //Definindo lugar da bomba através do método
                tabuleiro = definirBomba(tabuleiro, 1, 6, l, c);
                tabuleiro = definirBomba(tabuleiro, 2, 5, l, c);
                tabuleiro = definirBomba(tabuleiro, 3, 4, l, c);
                tabuleiro = definirBomba(tabuleiro, 4, 3, l, c);
                tabuleiro = definirBomba(tabuleiro, 5, 7, l, c);
                tabuleiro = definirBomba(tabuleiro, 6, 1, l, c);
                tabuleiro = definirBomba(tabuleiro, 7, 9, l, c);
                tabuleiro = definirBomba(tabuleiro, 8, 3, l, c);
                tabuleiro = definirBomba(tabuleiro, 9, 8, l, c);
                tabuleiro = definirBomba(tabuleiro, 10, 2, l, c);


                Console.WriteLine("Jogada efetuada: " + l + " - " + c);
                Console.WriteLine("");


                for (linha = 1; linha < 11; linha++)
                {
                    for (coluna = 1; coluna < 11; coluna++)
                    {
                        Console.Write(" | " + tabuleiro[linha, coluna] + "  ");
                    }
                    Console.WriteLine(" | " + linha + "  ");
                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ------------------------------------------------------------- ");
                Console.WriteLine("    1     2     3     4     5     6     7     8     9     10");
                Console.WriteLine(" ");

                //acertou todas as possibilidades, ganhou
                if (possi == 90)
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("-------------------------------------------------------VOCÊ VENCEU!!!-------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Digite enter para sair");
                    Console.ReadLine();
                    break;
                }


            }
            while (tabuleiro[l, c] != "B");//até o jogador errar

            //se o jogador acertar uma bomba ele apresenta o fim do game
            if (tabuleiro[l, c] == "B"){
              Console.WriteLine(" ");
              Console.WriteLine(" ");
              Console.WriteLine("|-----------------------------------------------------------BOMBA!---------------------------------------------------------------|");


              Console.WriteLine("|-----------------------------------------------------------------------------------------------------------------------------|");
              Console.WriteLine("|                                                            |||                                                             |");
              Console.WriteLine("|                                                          `--+--'                                                            |");
              Console.WriteLine("|                                                            /||                                                              |");
              Console.WriteLine("|                                                           ' | '                                                             |");
              Console.WriteLine("|                                                             |                                                               |");
              Console.WriteLine("|                                                             |                                                               |");
                Console.WriteLine("|                                                         ,--'#`--.                                                           |");
              Console.WriteLine("|                                                         |#######|                                                           |");
              Console.WriteLine("|                                                      _.-'#######`-._                                                        |");
                Console.WriteLine("|                                                   ,-'###############`-.                                                     |");
              Console.WriteLine("|                                                 ,'#####################`,                                                   |");
              Console.WriteLine("|                                                /#########################|                                                  |");
              Console.WriteLine("|                                               |###########################|                                                 |");
              Console.WriteLine("|                                              |#############################|                                                |");
              Console.WriteLine("|                                              |#############################|                                                |");
              Console.WriteLine("|                                              |#############################|                                                |");
              Console.WriteLine("|                                              |#############################|                                                |");
              Console.WriteLine("|                                               |###########################|                                                 |");
              Console.WriteLine("|                                                |#########################/                                                  |");
              Console.WriteLine("|                                                 `.#####################,'                                                   |");
              Console.WriteLine("|                                                   `._###############_,'                                                     |");
              Console.WriteLine("|                                                      `--..#####..--'                                                        |");
              Console.WriteLine("|                                                                                                                             |");
              Console.WriteLine("|                                                   VOCÊ PERDEU SEU BETA                                                      |");
              Console.WriteLine("|-----------------------------------------------------------------------------------------------------------------------------|");
              Console.WriteLine("Pressione enter para sair");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }


        }



        public static string[,] definirBomba(string[,] vetorTabuleiro, int linhaBomba, int colunaBomba, int linhaJogada, int colunaJogada)
        {
            //verifica se a linha e coluna da bomba é a mesma escolhida pelo jogador
            if ((linhaBomba == linhaJogada) && (colunaBomba == colunaJogada))
            {
                //Substituindo pra bomba
                vetorTabuleiro[linhaJogada, colunaJogada] = "B";
                Console.WriteLine("VOCÊ ACERTOU UMA BOMBA");
            }

            return vetorTabuleiro;
        }
    }
}
