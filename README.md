# Campo minado 💣

## Introdução 👾
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
#
