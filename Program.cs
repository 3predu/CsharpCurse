using System;
using System.Collections.Generic;
using CurseCSharp.Fundamentals;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", FirstProgram.Executar},
                {"Comentários - Fundamentos", Coments.Executar},
                {"Variáveis e Constantes - Fundamentos", VariablesAndConstants.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}