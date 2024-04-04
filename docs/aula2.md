# Aula 02 

## Parte 1

- Criado primeiro programa
- Vari�veis primitivas ou simples
- Escrita de dados no console
- Entendimento de projeto com e sem program
- Interpola��o de texto e vari�veis

[Projeto](https://github.com/drhamann/bk-ap-calculadora/tree/main/src/Console.OlaC%23)

## Exemplo c�digo

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

## Exerc�cio

- Escrever o c�digo em sua maquina


## Parte 2

- Projeto guiado calculadora
- Entendimento requisitos
- Estrutura de repeti��o

[Projeto](https://github.com/drhamann/bk-ap-calculadora/blob/main/src/Calculadora.Console/Program.cs)

## Exemplo c�digo

```
int primeiroNumerador;//camelCase
int segundoNumerador;

int SubtracaoNumeros;//PascalCase
int SomaNumeros;//PascalCase

string saida = "exit";
string operacao;

do // Estrutura repeti��o que sempre executa uma vez
{
    Console.WriteLine("Digite o primeiro valor:");
    primeiroNumerador = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor:");
    segundoNumerador = Convert.ToInt16(Console.ReadLine());


    Console.WriteLine("Deseja fazer uma soma? (add)");
    Console.WriteLine("Deseja fazer uma subtracao? (sub)");
    Console.WriteLine("Para sair, digite 'exit'");

    operacao = Console.ReadLine();


    if (operacao == "add") // Estrutura de repeti��o
    {
        SomaNumeros = primeiroNumerador + segundoNumerador;
        Console.WriteLine("Soma dos valores :" + SomaNumeros);
    }
    else if (operacao == "sub")
    {
        SubtracaoNumeros = primeiroNumerador - segundoNumerador;
        Console.WriteLine("Subtra��o dos valores :" + SubtracaoNumeros);
    }
    else
    {
        Console.WriteLine("Nao reconhe�o essa operacao");
    }
} while (operacao != saida);//express�o para avaliar de deve ou n�o continuar o la�o de repeti��o


```

## Exerc�cio

- Escrever da sua maneira os requisitos da calculadora


## Pr�ximos

- [voltar](../README.md)
- [pr�ximo](aula3.md)