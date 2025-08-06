using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurseCSharp.Fundamentals
{
    public class NotationPoint
    {
        public static void Executar()
        {
            string saudacao = "Hello".ToUpper().Insert(5, " Mundo!").ReplaceLineEndings("Mundo!, World!");
            Console.WriteLine(saudacao);
            Console.WriteLine("Olá Tudo bem?".Length);
        }
    }
}