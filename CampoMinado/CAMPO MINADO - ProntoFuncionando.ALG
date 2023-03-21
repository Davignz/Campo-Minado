Algoritmo "Campo Minado"
// Disciplina   : [Lógica de Programação]
// Professor   : Aline Firmino
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Davi e Carlos
// Data atual  : 15/03/2023

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