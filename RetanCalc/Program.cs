using System;

namespace RetanCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a Base do Retângulo? ");
            double baseRet = double.Parse(Console.ReadLine());
            Console.Write("Qual a Altura do Retângulo? ");
            double altRet = double.Parse(Console.ReadLine());
            double areaRetan = (baseRet * altRet);
            Console.WriteLine("A área do Retângulo é: " + areaRetan);
            double periRetan = (2*(baseRet + altRet));
            Console.WriteLine("O perimetro do Retângulo é: " + periRetan);

        }
    }
}