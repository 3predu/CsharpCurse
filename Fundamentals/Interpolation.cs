using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurseCSharp.Fundamentals
{
    public class Interpolation
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca"
            + marca + " custa =" + preco + ".");
            Console.WriteLine("O {0} da marca {1} custa {2}."
            , nome, marca, preco); // passando por indices {0} = nome, {1} = marca, {2} = preco
            Console.WriteLine($"O {nome} da marca {marca} custa {preco}.");
        }
    }
}