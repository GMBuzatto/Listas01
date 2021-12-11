using System;
using System.Globalization;
namespace exercicios01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Exercicio 01");
            Console.WriteLine("Entre com o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            Exercicio01 exercicio01 = new Exercicio01();
            Console.WriteLine("Exercicio 01: " + exercicio01.Soma(valor1, valor2));
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("Exercicio 02");
            Exercicio02 exercicio02 = new Exercicio02();
            Console.WriteLine("Entre com o primeiro valor: ");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com o nome da operação:");
            string operacao = Console.ReadLine();
            Console.WriteLine("Exercicio 02: "+ exercicio02.Operacao(operacao,valor1,valor2));
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("Exercicio 03");
            Exercicio03 exercicio03 = new Exercicio03();
            Console.WriteLine("Distância total percorrida pelo automóvel: ");
            double distanciaTotal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Total de combustível gasto: ");
            double totalCombustivelGasto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Exercicio 03: "+ exercicio03.ConsumoMedio(distanciaTotal,totalCombustivelGasto) +"KM/L");
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("Exercicio 04");
            Exercicio04 exercicio04 = new Exercicio04();
            Console.WriteLine("Entre com o nome do vendedor: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Entre com o valor total de vendas efetuadas no mês: ");
            double vendasEfetuadas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Exercicio 04: Nome: " + nome + "Salário fixo: " + vendasEfetuadas.ToString("F2",CultureInfo.InvariantCulture) + "Salário final do mês: " + exercicio04.Vendedor(nome,vendasEfetuadas));
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("Exercicio 05");
            Exercicio05 exercicio05 = new Exercicio05();
            Console.Write("Entre com o nome do Aluno: ");
            string aluno = Console.ReadLine();
            Console.Write("Entre com o valor da Nota1: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre com o valor da Nota2: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre com o valor da nota3: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Aluno: " + aluno + " Média: " + exercicio05.Aluno(aluno, nota1, nota2, nota3));*/
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("Exercicio 06");
            Exercicio06 exercicio06 = new Exercicio06();
            Console.WriteLine("Entre com o valor de A: ");
            int valorA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com o valor de B: ");
            int valorB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(exercicio06.TrocaDeValores(valorA, valorB));
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("Exercicio 07");
            Exercicio07 exercicio07 = new Exercicio07();
            Console.WriteLine("Entre com o valor de Graus Celsius: ");
            Console.Write("C=");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(exercicio07.GrausToFahrenheit(c));

        }
    }
}
