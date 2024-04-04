# Aula 03

- Projeto guiado da calculadora
- Continu��o explica��o de condicional
- Continua��o explica��o de repeti��o
- Versionamento de c�digo

## Materiais
[Calculadora](https://github.com/drhamann/bk-ap-calculadora?authuser=0)

## Exemplo c�digo

```
using System;

class Calculadora
{
    static void Main()
    {
        decimal primeiroNumerador;
        decimal segundoNumerador;
        decimal ResultadoOperacao = 0;

        string saida = "exit";
        string operacao = "";

        while (operacao != saida)
        {
            Console.Clear();

            Console.WriteLine("Para fazer uma soma digite 1");
            Console.WriteLine("Para fazer uma subtração digite 2");
            Console.WriteLine("Para fazer uma multiplicação digite 3");
            Console.WriteLine("Para fazer uma divisão digite 4");
            Console.WriteLine("Para sair, digite 'exit'");

            operacao = Console.ReadLine();

            if (operacao == saida)
            {
                break;
            }

            // Validar se a entrada do usuário é um número de 1 a 4
            if (!ValidarOpcaoMenu(operacao))
            {
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção de 1 a 4.");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            Console.WriteLine("Digite o primeiro valor:");
            primeiroNumerador = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            segundoNumerador = Convert.ToDecimal(Console.ReadLine());
            switch (operacao)
            {
                case "1"://Somar
                    ResultadoOperacao = primeiroNumerador + segundoNumerador;
                    break;
                case "2"://Subtração
                    ResultadoOperacao = primeiroNumerador - segundoNumerador;
                    break;
                case "3"://Multiplicação
                    ResultadoOperacao = primeiroNumerador * segundoNumerador;
                    break;
                case "4"://Divisão
                    // Verificar se o segundo número é zero para evitar divisão por zero
                    if (segundoNumerador == 0)
                    {
                        Console.WriteLine("Não é possível dividir por zero.");
                        continue;
                    }
                    ResultadoOperacao = primeiroNumerador / segundoNumerador;
                    break;
                default:
                    Console.WriteLine("Não reconheço essa operação");
                    break;
            }
            Console.WriteLine("Resultado da operação escolhida é de : " + ResultadoOperacao);

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    // Função para validar se a entrada do usuário é um número de 1 a 4
    static bool ValidarOpcaoMenu(string opcao)
    {
        int numero;
        if (int.TryParse(opcao, out numero))
        {
            if (numero >= 1 && numero <= 4)
            {
                return true;
            }
        }
        return false;
    }
}
```



## Próximos

- [voltar](../README.md)
- [pr�ximo](aula4.md)
