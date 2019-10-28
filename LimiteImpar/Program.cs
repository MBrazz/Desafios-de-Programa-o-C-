using System;

namespace LimiteImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            System.Console.WriteLine("Digite o Limite do Intervalo: ");
            num = int.Parse(System.Console.ReadLine());

            for (int i = 1; (i < num); i +=2 ){
                Console.Write(i + "  ");
            }
        }
    }
}
