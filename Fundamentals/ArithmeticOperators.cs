using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurseCSharp.Fundamentals
{
    public class ArithmeticOperators
    {
        public static void Executar()
        {
            // preço com desconto

            var preco = 1000;
            var imposto = 355;
            double desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine(total);
            Console.WriteLine(totalComDesconto);

            // IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"O IMC é = {imc}.");

            // Número par | impar
            int par = 24;
            int impar = 47;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}