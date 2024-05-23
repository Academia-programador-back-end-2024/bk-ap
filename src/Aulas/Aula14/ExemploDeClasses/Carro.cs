namespace ExemploDeClasses.Aula14;

/*
 * Pessoa
 * 
 */

public class Carro
{
    public string Placa { get; set; }

    public string Modelo { get; set; }

    public Roda Rodas { get; set; }

    public int Marcha { get; set; }

    private bool _ligado { get; set; }//camelCase

    public bool Ligar()//PascalCase
    {
        this._ligado = true;
        Console.WriteLine("Sou o metodo ligar");
        Funcao();
        return _ligado;
    }

    public void Andar()
    {
        throw new System.NotImplementedException();
    }

    public void Freiar()
    {
        throw new System.NotImplementedException();
    }

    public int TrocarMarcha()
    {
        throw new System.NotImplementedException();
    }

    public static void Funcao()
    {
        Console.WriteLine("Sou uma função");
    }
}