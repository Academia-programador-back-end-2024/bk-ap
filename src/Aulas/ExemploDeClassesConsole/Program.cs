using ExemploDeClasses.Aula14;

namespace ExemploDeClassesConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numerosPrimos = new int[3];

            Carro carroProfessor = new Carro();

            carroProfessor.Modelo = "Kicks";
            carroProfessor.Placa = "NaoLembro";
            carroProfessor.Marcha = 1;
            carroProfessor.Rodas = new Roda();


            carroProfessor.Ligar();


        }
    }
}
