# Campo minado 💣

## Introdução 👾
* Progamado por Carlos Eduardo e Davi Gonzaga - 3º Jogos Digitais
* Jogo desenvolvido em C# e em Português estruturado
* Tecnologias utilizadas: C# Console, VisualG;

## Descrição

# Campo Minado

* Se o jogador descobrir uma bomba, o jogo acaba, se aparecer “1” em meio aos
zeros, é porque ele encontrou um bloco vazio, o jogo continua. 

* O jogador deve escolher uma linha e uma coluna de acordo com a tabela do jogo, e as instruções
dadas durante o jogo. 

* O jogador só vence depois de encontrar todos os espaços
vazios, logo se encontrar todos os espaços vazios, saberá as posições das
bombas. Assim que ele conseguir é apresentado uma mensagem de vitória ao
jogador.

* É importante que o jogador preste atenção na dica dada pelo jogo!

* Bomba = “B”
* Espaço vazio = “1”.

## Análise do jogo
* O jogo foi criado com dois vetores formando uma matriz de 10 posições cada
uma, foi usado dois laços de repetição para mostrar o tabuleiro na tela. Os
espaços da tela foram preenchidos com “0”, a cada jogada, a posição
selecionada pelo jogador de “0”, muda para ”1”, caso o jogador acertasse a
bomba a posição do vetor muda para “B”. As bombas foram pré-determinadas,
no visualg por meio de condicional e no visual studio, as bombas foram
declaradas por meio de um método. O tabuleiro de jogo é mostrado toda vez que
o jogador joga, com todas as alterações e jogadas anteriores, utilizando um
(do/while)/(repita), dessa forma, até cair na condição do jogador vencer ou
perder.

# Código do Jogo em VisualG

Var
   tabuleiro: vetor[1..10,1..10] de caracter
   linha, coluna, l, c, bomba, possi: inteiro

Inicio
   bomba := 1
   possi := 0
   // imprimir o tabuleiro

   escreval(" ------------------------------------------------------------- ")
   escreval(" |                      CAMPO MINADO                         |")
   escreval(" ------------------------------------------------------------- ")
   escreval("    1     2     3     4     5     6     7     8     9     10")
   escreval(" ------------------------------------------------------------- ")
   para linha de 1 ate 10 faca
      para coluna de 1 ate 10 faca
         //deixa o tabuleiro vazio
         tabuleiro[linha,coluna] := "0"
         escreva (" | ", tabuleiro[linha, coluna], " ")
      fimpara
      escreval (" | ", linha, "  ")
      escreval (" ")
   fimpara
   escreval(" ------------------------------------------------------------ ")
   escreval("   1    2    3    4    5    6    7    8    9    10")
   escreval(" ")

   // Fim imprimeTabuleiro

   repita
      //escolhendo posicao pra jogar
      escreval(" ")
      escreval(" ")
      escreval(" ")
      escreval("DIGITE SOMENTE NÚMEROS DE 1 A 10, OU APERTE ESC PARA SAIR")
      escreval("----------------------------------------")
      escreval("TODAS AS LIHNAS POSSUEM BOMBAS, CUIDADO!")
      escreval("----------------------------------------")
      escreval("Digite a linha")
      leia(l)
      escreval("Digite a coluna")
      leia(c)
      escreval(" ")
      //mostra a linha escolhida
      tabuleiro[l,c] := "1"

      se (l = 1) E (c = 6) entao
         bomba := 2
         tabuleiro[l,c] := "B"
      fimse

      se (l = 2) E (c = 5) entao
         bomba := 2
         tabuleiro[l,c] := "B"
      fimse

      se (l = 3) E (c = 4) entao
         bomba := 2
         tabuleiro[l,c] := "B"
      fimse

      se (l = 4) E (c = 3) entao
         bomba := 2
         tabuleiro[l,c] := "B"
      fimse

      se (l = 5) E (c = 2) entao
         bomba := 2
         tabuleiro[l,c] := "B"
      fimse

      se (l = 6) E (c = 1) entao
         bomba := 2
         tabuleiro[l,c] := "B"
      fimse

      se (l = 7) E (c = 10) entao
         bomba := 2
         tabuleiro[l,c] := "B"
      fimse

      se (l = 8) E (c = 9) entao
         bomba := 2
         tabuleiro[l,c] := "B"
      fimse

      se (l = 9) E (c = 10) entao
         bomba := 2
         tabuleiro[l,c] := "B"
      fimse

      se (l = 10) E (c = 9) entao
         bomba := 2
         tabuleiro[l,c] := "B"
      fimse

      se bomba = 1 entao
         possi := possi+1
      fimse

      para linha de 1 ate 10 faca
         para coluna de 1 ate 10 faca


            escreva (" | ", tabuleiro[linha, coluna], " ")
         fimpara
         escreval (" | ", linha, "  ")
         escreval (" ")
      fimpara
      escreval(" ------------------------------------------------------------ ")
      escreva("   1    2    3    4    5    6    7    8    9    10")
      escreval(" ")
      escreval(" ")
      escreval(" ")

      se (possi = 90) entao
         escreval("----------------------------------------------------------------------------------------------------------------------------------")
         escreval("-------------------------------------------------------VOCÊ VENCEU!!!-------------------------------------------------------------")
         escreval("----------------------------------------------------------------------------------------------------------------------------------")
         interrompa
      fimse
   ate (tabuleiro[linha,coluna] = bomba)


   se (tabuleiro[l,c] = bomba) entao
      escreval(" ")
      escreval(" ")
      escreval("|-----------------------------------------------------------BOMBA!---------------------------------------------------------------|")
      timer 100
      escreval("|-----------------------------------------------------------------------------------------------------------------------------|")
      escreval("|                                                            \|/                                                              |")
      escreval("|                                                          `--+--'                                                            |")
      escreval("|                                                            /|\                                                              |")
      escreval("|                                                           ' | '                                                             |")
      escreval("|                                                             |                                                               |")
      escreval("|                                                             |                                                               |")
      escreval("|                                                         ,--'#`--.                                                           |")
      escreval("|                                                         |#######|                                                           |")
      escreval("|                                                      _.-'#######`-._                                                        |")
      escreval("|                                                   ,-'###############`-.                                                     |")
      escreval("|                                                 ,'#####################`,                                                   |")
      escreval("|                                                /#########################\                                                  |")
      escreval("|                                               |###########################|                                                 |")
      escreval("|                                              |#############################|                                                |")
      escreval("|                                              |#############################|                                                |")
      escreval("|                                              |#############################|                                                |")
      escreval("|                                              |#############################|                                                |")
      escreval("|                                               |###########################|                                                 |")
      escreval("|                                                \#########################/                                                  |")
      escreval("|                                                 `.#####################,'                                                   |")
      escreval("|                                                   `._###############_,'                                                     |")
      escreval("|                                                      `--..#####..--'                                                        |")
      escreval("|                                                                                                                             |")
      escreval("|                                                   VOCÊ PERDEU SEU BETA                                                      |")
      escreval("|-----------------------------------------------------------------------------------------------------------------------------|")
      timer 0
      escreval
   fimse



Fimalgoritmo
