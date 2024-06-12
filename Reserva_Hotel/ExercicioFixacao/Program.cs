
using System;
using System.Globalization;

namespace ExercicioFixacao
{
    internal class Program
    {
        Cotacao cotacao = new Cotacao();

        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do Dolar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dolares você quer comprar? ");
            double quantia = double.Parse(Console.ReadLine());

            double result = Cotacao.DolarParaReal(cotacao, quantia);

            Console.WriteLine("Valor a ser pago em reais: " + result.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
