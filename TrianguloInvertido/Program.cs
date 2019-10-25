using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("Digite a altura do Triângulo: ");
            int h = int.Parse(System.Console.ReadLine());

            for (; h > 0; ++h)
            {  
                System.Console.WriteLine("*");
                System.Console.WriteLine($" "+ h);
            } 

            



        }
    }
}
