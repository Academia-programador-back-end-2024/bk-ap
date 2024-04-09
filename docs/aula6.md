# Aula 06

- Vector ou Array
- Matriz


### Vetores em C#
Vetores em C# (também conhecidos como arrays unidimensionais) são estruturas de dados que permitem armazenar uma coleção de elementos de um mesmo tipo em uma única dimensão.

#### Declaração de um vetor:
```csharp
Tipo[] nomeDoVetor = new Tipo[tamanho];
```

#### Atribuir valores a um vetor:
```csharp
nomeDoVetor[indice] = valor;
```

#### Acessar elementos do vetor:
```csharp
Tipo elemento = nomeDoVetor[indice];
```

#### Iterar sobre um vetor:
```csharp
for (int i = 0; i < nomeDoVetor.Length; i++)
{
    Tipo elemento = nomeDoVetor[i];
    // Faça algo com o elemento
}
```

### Matrizes em C#
Matrizes em C# (ou arrays multidimensionais) são estruturas de dados que permitem armazenar elementos em múltiplas dimensões.

#### Declaração de uma matriz:
```csharp
Tipo[,] nomeDaMatriz = new Tipo[linhas, colunas];
```

#### Atribuir valores a uma matriz:
```csharp
nomeDaMatriz[linha, coluna] = valor;
```

#### Acessar elementos da matriz:
```csharp
Tipo elemento = nomeDaMatriz[linha, coluna];
```

#### Iterar sobre uma matriz:
```csharp
for (int i = 0; i < linhas; i++)
{
    for (int j = 0; j < colunas; j++)
    {
        Tipo elemento = nomeDaMatriz[i, j];
        // Faça algo com o elemento
    }
}
```

## Próximos

- [voltar](../README.md)
- [próximo](aula07.md)
