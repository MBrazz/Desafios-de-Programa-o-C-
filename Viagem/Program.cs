using System;

namespace Viagem
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Insira o Tempo em minutos da Viagem: ");
            double tempo = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Insira a Velocidade Média da Viagem: ");
            double media = double.Parse(System.Console.ReadLine());

            double distancia = (tempo * media);
            double litros = (distancia / 12);

            Console.Clear();
            
            System.Console.WriteLine($"A velocidade média foi {media} KM: ");
            System.Console.WriteLine($"O tempo da Viagem foi {tempo} minutos: ");
            System.Console.WriteLine($"A Distancia percorrida foi {distancia}: ");
            System.Console.WriteLine($"A quantidade de litros gasto nesta Viagem foi {litros}L: ");
           

            
        }
    }
}
