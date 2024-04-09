int number = 4;
string[,] listaParaOrdenar = new string[number, 4];

//nome, idade, raça, especie

listaParaOrdenar[0, 0] = "numero 1";
listaParaOrdenar[0, 1] = "numero 2";


for (int i = 0; i < listaParaOrdenar.Length; i++)
{

    var numero = listaParaOrdenar[i, 0];
    Console.Write(numero);
}

foreach (var numero in listaParaOrdenar)
{
    Console.Write(numero);
}

string[,] animais =
{
    { "Fido", "Cachorro", "5", "10kg" },
    { "Whiskers", "Gato", "5", "5kg" },
    { "Buddy", "Cachorro", "3", "8kg" },
    { "Fluffy", "Gato", "2", "4kg" },
    { "Spot", "Cachorro", "4", "12kg" }
};