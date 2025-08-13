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

            Console.WriteLine("Digite a sua idade: ");
            string? idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString ?? "0");
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"Resultado: {idadeInteiro}");

            //forma de fazer declarando
            Console.WriteLine("Digite o primeiro número: ");
            string? palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine($"Resultado {numero1}");

            //forma de fazer sem declarar
            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Resultado {numero2}");
        }
    }
}