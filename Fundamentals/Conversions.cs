using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurseCSharp.Fundamentals
{
    public class Conversions
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota; // convertendo explicitamente, pois não é possível converter implicitamente nesse caso. Processo se chama de casting
            Console.WriteLine("Nota truncada: {0}", notaTruncada);
        }
    }
}