using System;

namespace PesagemIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Nome do paciente: ");
            string nome = System.Console.ReadLine();
            Console.Write("Peso do paciente: ");
            double peso = double.Parse(System.Console.ReadLine());
            System.Console.Write("Altura do paciente: ");
            double altura = double.Parse(System.Console.ReadLine());

            double imc = peso / (altura * altura);

            System.Console.WriteLine();

            System.Console.WriteLine($"Peso: {peso} KG ");
            System.Console.WriteLine($"Altura: {altura} metros");
            System.Console.WriteLine("IMC: "+ imc);

            System.Console.WriteLine();

            System.Console.WriteLine("Paciente: " + nome);

            System.Console.WriteLine();

                System.Console.WriteLine("=-= FAIXA DE RISCO =-=");
            if(imc < 20)
            {
                System.Console.WriteLine("    Abaixo do Peso");
            }
            else if(imc >= 20 && imc <= 25)
            {
                System.Console.WriteLine("       Normal");
            }
            else if(imc > 25 && imc <= 30)
            {
                System.Console.WriteLine("    Excesso de Peso");
            }
            else if(imc > 30 && imc <= 35)
            {
                System.Console.WriteLine("      Obesidade");
            }
            else if(imc > 35)
            {
                System.Console.WriteLine("   Obesidade Mórbida");
            }

            System.Console.WriteLine();


        }
    }
}
