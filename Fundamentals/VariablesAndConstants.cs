using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CurseCSharp.Fundamentals
{
    public class VariablesAndConstants
    {
        public static void Executar()
        {
            double raio = 4.5;
            int piInterio = 3;
            string textName = "Olá Mundo!";
            const double PiDouble = 3.14;
            double area = piInterio * PiDouble + raio;

            Console.WriteLine(textName);
            Console.WriteLine($"A área é {area}");

            float precoComputador = 1299.99f; // por padrão vem double, porém ao colocar a terminação 'f' ao final da declaração da variável, o csharp reconhece como float, ou seja, para o csharp reconhecer a variável como float, temos que colocar a terminação 'f'.
            Console.WriteLine(precoComputador);

            

        }
    }
}