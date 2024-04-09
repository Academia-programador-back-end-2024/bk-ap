namespace Funcoes;

public partial class Program
{
    static void Main(string[] args)
    {
        // void não vai retornar nada 
        Console.WriteLine(OlaFuncao());

        //DRY -> Don´t reapeat your self
        //
        OlaFuncaoVoid();

        Exercicio20();
        OlaFuncaoVoid4();


        string[,] animais =
{
    { "Fido", "Cachorro", "5", "10kg" },
    { "Whiskers", "Gato", "5", "5kg" },
    { "Buddy", "Cachorro", "3", "8kg" },
    { "Fluffy", "Gato", "2", "4kg" },
    { "Spot", "Cachorro", "4", "12kg" }
};
        Console.WriteLine( Animais.EncontrarAnimal(1, animais));
   
    }

    static string OlaFuncao()
    {
        return "Olá função";
    }

    static void OlaFuncaoVoid()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"\tImprimindo {i}\t");
        }
    }
}
