using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios01
{
    public class Exercicio06
    {
        public string TrocaDeValores(int valorA, int valorB)
        {
            int valorAuxiliar = valorB;
            valorB = valorA;
            valorA = valorAuxiliar;
            string conclusao;
            return conclusao = $"ValorA: {valorA} ValorB: {valorB}";
        }
    }
}
