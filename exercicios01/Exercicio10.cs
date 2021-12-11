using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios01
{
    public class Exercicio10
    {
        public string ParcelamentoX5(double preco)
        {
            double parcelamento = preco / 5;

            return "O valor da Primeira Parcela e de: R$:" + parcelamento.ToString("F2")
                + "\r\nO valor da Segunda Parcela e de: R$:" + parcelamento.ToString("F2")
                + "\r\nO valor da Terceira Parcela e de: R$:" + parcelamento.ToString("F2")
                + "\r\nO valor da Quarta Parcela e de: R$:" + parcelamento.ToString("F2")
                + "\r\nO valor da Quinta Parcela e de: R$:" + parcelamento.ToString("F2");
        }
    }
}
