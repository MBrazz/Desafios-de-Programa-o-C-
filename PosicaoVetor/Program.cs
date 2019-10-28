using System;

namespace PosicaoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int [100];

            int cont = 0;

            do{
            for(; cont < 100; cont++){
            Console.Write($"Digite o {cont+1}º número: ");
            vetor[cont] = int.Parse(Console.ReadLine());
            } 
            }while (cont != 0);
        
        }
    }
}
