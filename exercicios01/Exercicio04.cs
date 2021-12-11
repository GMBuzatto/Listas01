using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios01
{
    public class Exercicio04
    {
        public string Salario(string vendedor,double salarioFixo, double totalDeVendas)
        {
            double comissao = totalDeVendas*0.20;
            double salarioFinal = salarioFixo + comissao;
            return "Nome do Vendedor: "
                + vendedor
                + "\r\nSalario Fixo: R$:"
                + salarioFixo.ToString("F2")
                + "\r\nSalario no final do mês: R$:"
                + salarioFinal.ToString("F2");
        }
    }
}
