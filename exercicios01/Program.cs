using System;

namespace exercicios01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            Exercicio01 exercicio01 = new Exercicio01();
            Console.WriteLine("Exercicio 01 :" + exercicio01.Soma(valor1, valor2));
            Exercicio02 exercicio02 = new Exercicio02();
            Console.WriteLine("Entre com o primeiro valor: ");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com o nome da operação:");
            string operacao = Console.ReadLine();
            Console.WriteLine("Exercicio 02 :"+ exercicio02.Operacao(operacao,valor1,valor2));
        }
    }
}
