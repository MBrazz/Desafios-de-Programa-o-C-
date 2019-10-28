using System;

namespace TrianguloInvertido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Altura do Triângulo: ");
            int tamanhoTriangulo = int.Parse(Console.ReadLine());
            
            Console.WriteLine();

            for (int j = 0; j <= tamanhoTriangulo; j++) {
                for(int i = j; i < tamanhoTriangulo; i++){
                System.Console.Write("*");
                }
               System.Console.WriteLine();
            }
        }   
    }
}
