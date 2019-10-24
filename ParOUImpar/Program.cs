using System;

namespace ParOUImpar
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("Digite um número: ");
            int num = int.Parse(System.Console.ReadLine());

            if(num % 2 == 0){
                System.Console.WriteLine("O número é Par");
             } 
             else {
                 System.Console.WriteLine("O número é Ímpar");
             }  
        }
    }
}
