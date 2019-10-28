using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Altura do Triângulo: ");
            int tamanhoTriangulo = int.Parse (Console.ReadLine ());
            
            Console.WriteLine();
            string estrelas = "";
            for (int j = 0; j < tamanhoTriangulo; j++) {
                estrelas += "*";
                Console.WriteLine (estrelas);
            }
        }   
    }
}
