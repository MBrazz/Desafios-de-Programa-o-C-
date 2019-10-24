using System;

namespace GrauFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double TC = 0;
            double TF = 0;

            System.Console.WriteLine("Digite a Temperatura em Graus Celsius: ");
            TC = double.Parse(System.Console.ReadLine());

            TF = (TC/5)*9 + 32;

            System.Console.WriteLine($"A Temperatura em Fahrenheit é: " + TF);
        }
    }
}
