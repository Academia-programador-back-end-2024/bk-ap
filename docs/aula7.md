# Aula 07

- Função
- Ref
- out

### Função

Uma função estática em C# é uma função associada a uma classe em vez de uma instância específica da classe. 
Isso significa que a função pode ser chamada sem precisar criar uma instância da classe. 
As funções estáticas são definidas usando a palavra-chave `static` antes da declaração do método.

#### Exemplo:
```csharp
public class MinhaClasse
{
    public static int Somar(int a, int b)
    {
        return a + b;
    }
}

// Usando uma função estática
int resultado = MinhaClasse.Somar(3, 5);
```

### Passagem de Parâmetros por Referência (`ref`)

A passagem de parâmetros por referência em C# permite que uma função modifique o valor de uma variável original passada como argumento, em vez de uma cópia do valor. Isso é feito usando a palavra-chave `ref` antes do parâmetro na definição do método e na chamada do método.

#### Exemplo:
```csharp
public static void Dobrar(ref int x)
{
    x *= 2;
}

// Chamando a função com parâmetro por referência
int numero = 5;
Dobrar(ref numero);
// O valor de 'numero' agora é 10
```
Se você não usar a palavra-chave `ref` ao definir o parâmetro da função `Dobrar`, o valor da variável `numero` não será modificado após a chamada da função. Sem a palavra-chave `ref`, o parâmetro é passado por valor, o que significa que a função recebe uma cópia do valor da variável, não a referência à variável original.

Veja o exemplo abaixo:

```csharp
public static void Dobrar(int x)
{
    x *= 2;
}

int numero = 5;
Dobrar(numero);
// O valor de 'numero' continua sendo 5
```

Nesse caso, mesmo que a função `Dobrar` dobre o valor da variável `x`, essa alteração é feita apenas na cópia local da variável e não afeta a variável original fora da função.

Portanto, se você deseja que a função modifique diretamente a variável original, você precisa usar a palavra-chave `ref` tanto na definição do método quanto na chamada do método, como no exemplo original que você forneceu.

### Passagem de Parâmetros por Referência de Saída (`out`)

A passagem de parâmetros por referência de saída (`out`) em C# é semelhante à passagem por referência (`ref`), mas é usada quando o método precisa retornar mais de um valor. Com `out`, você não precisa inicializar a variável antes de passá-la para o método, e o método é obrigado a atribuir um valor à variável antes de retornar.

#### Exemplo:
```csharp
public static void Dividir(int dividendo, int divisor, out int quociente, out int resto)
{
    quociente = dividendo / divisor;
    resto = dividendo % divisor;
}

// Chamando a função com parâmetros por referência de saída
int q, r;
Dividir(10, 3, out q, out r);
// O valor de 'q' será 3 e o valor de 'r' será 1
```

```
Exemplo de calculadora com função 

decimal primeiroNumerador;
decimal segundoNumerador;
decimal ResultadoOperacao;
const string saida = "exit";
string operacao = string.Empty;

while (operacao != saida)//Laço de repetição
{
    MenuDeOpcoes(operacao);//Função para verificar as opções

    if (!ValidarOpcaoMenu(operacao))//Verificar se a opção é valida
    {
        continue;//Pular código posterior e voltar ao menu
    }

    if (operacao == saida)//Verificar se deve encerrar
    {
        break;//Parar repetição
    }
    primeiroNumerador = LerValor();//Função para ler valor
    segundoNumerador = LerValor();//Função para ler valor
    
    //Função para realizar operação matematica
    RealizarOperacaoMatematica(
        primeiroNumerador, 
        segundoNumerador,
        out ResultadoOperacao,// Aqui o out obriga a ter alteração na função
        operacao);

    ImprimirResultado(ResultadoOperacao);
}


static void MenuDeOpcoes(string operacao)
{
    Console.Clear();//Limpar a tela
    Console.WriteLine(@"
            Para fazer uma soma digite 1\r\n
            Para fazer uma subtração digite 2\r\n
            Para fazer uma multiplicação digite 3\r\n
            Para fazer uma divisão digite 4\r\n\r\n
            Para sair, digite 'exit'");

    operacao = Console.ReadLine();
    operacao = operacao == null ? string.Empty : operacao.Trim();
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
    Console.WriteLine("Opção inválida. Por favor, escolha uma opção de 1 a 4.");
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
    return false;
}

static decimal LerValor()
{
    Console.WriteLine("Digite um valor:");
    var valor = Convert.ToDecimal(Console.ReadLine());
    return valor;
}

// Verificar se o segundo número é zero para evitar divisão por zero
static decimal VerificarZero(decimal segundoNumerador)
{
    do
    {
        if (segundoNumerador == 0)
        {
            Console.WriteLine("Não é possível dividir por zero. Escolha outro!");
            segundoNumerador = LerValor();
        }
    } while (segundoNumerador > 0);
    return segundoNumerador;
}

static void RealizarOperacaoMatematica(
    decimal primeiroNumerador, 
    decimal segundoNumerador,
    out decimal ResultadoOperacao,
    string operacao)
{
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
            segundoNumerador = VerificarZero(segundoNumerador);
            ResultadoOperacao = primeiroNumerador / segundoNumerador;
            break;
        default:
            Console.WriteLine("Não reconheço essa operação");
            ResultadoOperacao = 0;
            break;
    }
}

static void ImprimirResultado(decimal ResultadoOperacao)
{
    Console.WriteLine("Resultado da operação escolhida é de : " + ResultadoOperacao);
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
}
```

## Próximos

- [voltar](../README.md)
- [próximo](aula08.md)
