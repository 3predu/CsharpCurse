using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace CurseCSharp.Fundamentals
{
    public class NumberFormat
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); //arredondar
            Console.WriteLine(valor.ToString("C")); // Moeda
            Console.WriteLine(valor.ToString("P")); // Percentual *100
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura));

            CultureInfo cultura2 = new("en-US");
            Console.WriteLine(valor.ToString("C3", cultura2));

            
        }
    }
}