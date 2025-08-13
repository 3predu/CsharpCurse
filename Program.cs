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
                {"Inferência de Tipos - Fundamentos", Inference.Executar},
                {"Interpolação de Strings - Fundamentos", Interpolation.Executar},
                {"Notação Ponto - Fundamentos", NotationPoint.Executar},
                {"Lendo Dados do Console - Fundamentos", ReadingData.Executar},
                {"Formatando Números - Fundamentos", NumberFormat.Executar},
                {"Conversões - Fundamentos", Conversions.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}