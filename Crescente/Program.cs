using System;

namespace Crescente
{
    class Program
    {
        static void Main(string[] args)
        {   

            Console.Write("Informe o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());


            Console.Write("Informe o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());


            Console.Write("Informe o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            System.Console.WriteLine();

            if (num3 < num1 && num3 > num2)
            {
                System.Console.WriteLine($"Ordem Crescente: {num2} {num3} {num1}");
            }
            else if (num3 > num1 && num3 < num2)
            {
               System.Console.WriteLine($"Ordem Crescente: {num1} {num3} {num2}");
            }
            else if (num1 > num2 && num1 > num3)
            {
                System.Console.WriteLine($"Ordem Crescente: {num3} {num2} {num2}");
            }
            else if (num3 > num2 && num2 > num1)
            {
                System.Console.WriteLine($"Ordem Crescente: {num1} {num2} {num3}");
            }
            else if (num1 > num2 && num2 < num3)
            {
                System.Console.WriteLine($"Ordem Crescente: {num1} {num2} {num3}");
            }
            else if (num2 > num1 && num2 > num3)
            {
                System.Console.WriteLine($"Ordem Crescente: {num3} {num1} {num2}");
            }
        }
    }
}
