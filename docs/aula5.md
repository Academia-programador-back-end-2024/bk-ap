# Aula 05

- For
- Ternario
- Continuação exercicios
- FizzBuzz
- Menor que c


## Exemplo código

### Loop "for" em C#:

O loop "for" é uma estrutura de repetição utilizada para executar um bloco de código um número específico de vezes. A sua sintaxe básica é:

```csharp
for (inicialização; condição; incremento)
{
    // Bloco de código a ser repetido
}
```

- **Inicialização**: É onde você inicializa o contador do loop.
- **Condição**: É a expressão avaliada a cada iteração. Se for verdadeira, o bloco de código é executado; caso contrário, o loop termina.
- **Incremento**: É uma expressão que é executada após cada iteração do loop. Ela geralmente é usada para incrementar ou decrementar o contador.

Exemplo:

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("O valor de i é: " + i);
}
```

Este loop irá imprimir os valores de 0 a 4, já que o contador `i` começa em 0, continua enquanto `i` for menor que 5 e é incrementado de 1 em 1 em cada iteração.

### Operador Ternário em C#:

O operador ternário é uma forma compacta de escrever uma instrução condicional. Ele avalia uma expressão booleana e, com base no resultado dessa avaliação, retorna um dos dois valores fornecidos. Sua sintaxe é:

```csharp
condição ? valor_se_verdadeiro : valor_se_falso;
```

- **Condição**: A expressão a ser avaliada. Se for verdadeira, o valor após o "?" é retornado; caso contrário, o valor após ":" é retornado.

Exemplo:

```csharp
int a = 10;
int b = 5;

int maior = (a > b) ? a : b;
Console.WriteLine("O maior número é: " + maior);
```

Neste exemplo, se `a` for maior que `b`, o valor de `a` será atribuído à variável `maior`; caso contrário, o valor de `b` será atribuído.

## Próximos

- [voltar](../README.md)
- [próximo](aula06.md)
