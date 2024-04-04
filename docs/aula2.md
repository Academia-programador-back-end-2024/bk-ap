# Aula 02 

## Parte 1

- Criado primeiro programa
- Variáveis primitivas ou simples
- Escrita de dados no console
- Entendimento de projeto com e sem program
- Interpolação de texto e variáveis

[Projeto](https://github.com/drhamann/bk-ap-calculadora/tree/main/src/Console.OlaC%23)

## Exemplo código

```
internal class Program
{
    static void Main(string[] args)
    {
        string nome = "George";
        char primeiraLetraDoNome = 'A';
        int idade = 36;
        bool tenhoPet = true;
        decimal quantoTenhoNaCarteira = 0.75m;

        Console.WriteLine("Hello, World!");

       Console.WriteLine(
        $@"Sou o {nome} tenho a primeira letra {primeiraLetraDoNome} com idade {idade}
         e possuou pet {tenhoPet} com dinheiro na carteira {quantoTenhoNaCarteira}");
    }
}

```

## Exercício

- Escrever o código em sua maquina


## Parte 2

- Projeto guiado calculadora
- Entendimento requisitos
- Estrutura de repetição

[Projeto](https://github.com/drhamann/bk-ap-calculadora/blob/main/src/Calculadora.Console/Program.cs)

## Exemplo código

```
int primeiroNumerador;//camelCase
int segundoNumerador;

int SubtracaoNumeros;//PascalCase
int SomaNumeros;//PascalCase

string saida = "exit";
string operacao;

do // Estrutura repetição que sempre executa uma vez
{
    Console.WriteLine("Digite o primeiro valor:");
    primeiroNumerador = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor:");
    segundoNumerador = Convert.ToInt16(Console.ReadLine());


    Console.WriteLine("Deseja fazer uma soma? (add)");
    Console.WriteLine("Deseja fazer uma subtracao? (sub)");
    Console.WriteLine("Para sair, digite 'exit'");

    operacao = Console.ReadLine();


    if (operacao == "add") // Estrutura de repetição
    {
        SomaNumeros = primeiroNumerador + segundoNumerador;
        Console.WriteLine("Soma dos valores :" + SomaNumeros);
    }
    else if (operacao == "sub")
    {
        SubtracaoNumeros = primeiroNumerador - segundoNumerador;
        Console.WriteLine("Subtração dos valores :" + SubtracaoNumeros);
    }
    else
    {
        Console.WriteLine("Nao reconheço essa operacao");
    }
} while (operacao != saida);//expressão para avaliar de deve ou não continuar o laço de repetição


```

## Exercício

- Escrever da sua maneira os requisitos da calculadora


## Próximos

- [voltar](../README.md)
- [próximo](aula3.md)