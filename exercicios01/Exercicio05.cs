using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios01
{
    public class Exercicio05
    {
        public string Media(string aluno, double nota1,double nota2,double nota3)
        {
            double media = (nota1 + nota2 + nota3) / 3;
            return "Nome do aluno: "
                + aluno
                + "\r\n Média aritmética: "
                + media;

        }
       
    }
}
