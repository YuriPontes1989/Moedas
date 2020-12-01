using System;
using System.Globalization;

namespace Moedas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual é o valor do dólar? "); // Usuário escreve 
            MoedasClass.moedas = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares deseja comprar? ");
            MoedasClass.valor = double.Parse(Console.ReadLine());

            Console.Write("Valor a ser pago em reais R$: " + MoedasClass.Reais().ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadKey();
        }
    }
}