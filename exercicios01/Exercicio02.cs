using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios01
{
    public class Exercicio02
    {
        public string Operacao(string operacao, double valor1, double valor2)
        {
            double resultado = 0;
            switch (operacao)
            {
                case "soma":
                    resultado = valor1 + valor2;
                    break;
                case "subtracao":
                    resultado = valor1 - valor2;
                    break;
                case "multiplicacao":
                    resultado = valor1 * valor2;
                    break;
                case "divisao":
                    resultado = valor1 / valor2;
                    break;
            }
            return "Resutaldo: "+resultado;
        }
    }
}
