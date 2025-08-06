using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CurseCSharp.Fundamentals
{
    public class ReadingData
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome? ");
            string? nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine() ?? "0");

            // double sal = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InstalledUICulture); // usar sempre o ponto como separador de casas decimais

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}