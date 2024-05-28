# Aula 08

- Aula divida em três vídeos, que consiste do seguinte:
  1. Resolução de exercícios do repo: https://github.com/drhamann/bk-ap-lista02/tree/main
  2. (A preencher)


# Exercício 02
## Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, mostre o maior e menor valor.
  -  A resolução começa no primeiro minuto do primeiro vídeo.
  -  2:04, professor comenta que prefere o foreach para percorrer vetores, como indicado na imagem abaixo, onde "vector" é um vetor (perguntar pra ele o porque e complementar aqui).
  -  ![image](https://github.com/blissful-bonsai/bk-ap/assets/142542734/8a0d4ff3-f205-409a-91fe-c4377ca739d9).
  -  4:26, professor mostra o método .Max() e .Min(), que podem ser utilizados com objetos do tipo vetor, que definem o maior e menor valor de um vetor, respectivamente.
  -  .Max() e .Min() também podem ser usados com outras estruturas de dados, como Dicionários, Sets e Listas.
  -  Existem outros métodos que podem ser utilizados, isso fica para a gente descobrir.

# Exercício 03
## Crie um programa que preencha uma matriz 3x3 com valores inteiros informados pelo usuário e depois exiba essa matriz na tela. 
  -  Começa aos 06:40
  -  Até esse momento, tranquilamente podemos percorrer vetores utilizando for loops com o método .Length:
  -  Para descobrir o número de elementos de um *vetor*, podemos simplesmente usar o método .Length
  -  ```
      // Declaracao de um vetor com 2 elementos
      int[] vetor = new int[2];
      
      // Inicializacao de cada elemento
      vetor[0] = 1;
      vetor[1] = 2;
      
      // Utilizacao do metodo .Length para descobrir o *numero de elementos* do vetor
      Console.WriteLine(vetor.Length); // Output = 2
      
      // Utilizacao do .Length para mostrar todos os elementos do vetor
      for (int i = 0; i < vetor.Length; i++)
      {
          Console.WriteLine($"O valor do elemento é: {vetor[i]}");
      }
     ```
  - Porém, no enunciado, é especificado que temos uma matriz 3x3, que se trata de um *vetor multidimensional*
  - Portanto, temos 3 linhas e 3 colunas, totalizando 9 elementos. O método .Length nos retornaria um valor de 9, de maneira que o loop utilizado anteriormente não é mais útil.
  - Parei aos 09:35
  - 

  - Aos 08:00, o professor aponta um método chamado GetLength, utilizado quando temos mais de uma linha (ou, quando temos uma matriz).
  -  



