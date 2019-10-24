using System;

namespace Multiplo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num / 3)
            {
                System.Console.WriteLine("É Multiplo de 3");
            } else{
                System.Console.WriteLine("Não é Multiplo de 3");
            }
        }
    }
}
