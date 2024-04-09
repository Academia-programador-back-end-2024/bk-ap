using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes;

public class Animais
{
    public static string EncontrarAnimal(int indexDaMatriz, string[,] animais)
    {
        return animais[indexDaMatriz, indexDaMatriz];
    }
}
