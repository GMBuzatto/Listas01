using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios01
{
    public class Exercicio09
    {
        public string RendaPoupança(double reais)
        {
            double juros = 0.07;
            string conclusao;
            double rendimento = (reais * juros)+reais;
            return conclusao =
                "O valor de rendimento da sua conta poupança e de: R$:"
                +rendimento.ToString("F2");

        }
    }
}
