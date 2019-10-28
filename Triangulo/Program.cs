using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1º Lado do triângulo: ");
            int lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º Lado do triângulo: ");
            int lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 3º Lado do triângulo: ");
            int lado3 = int.Parse(Console.ReadLine());

            if (lado1 + lado2 > lado3 )
            {
                Console.WriteLine("Lado 3 é menor que a soma do lado 1 e 2.");    
            }
            else if (lado3 + lado2 > lado1)
            {
                Console.WriteLine("Lado 1 é menor que a soma do lado 2 e 3.");
            }
            else if (lado3 + lado1 > lado2)
            {
                Console.WriteLine("Lado 2 é menor que a soma do lado 1 e 3.");
            }
            else
            {
                Console.WriteLine("Os lados não fazem parte de um triângulo.");
            }
        }
    }
}
