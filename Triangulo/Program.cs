using System;
namespace Triangulo {
    class Program {
        static void Main (string[] args) {
            int num;
            int num2;
            int num3;
            int soma;
            int soma2;
            int soma3;

            System.Console.Write("Digite o 1º Lado do triângulo: ");
            num = int.Parse (Console.ReadLine ());
            System.Console.Write("Digite o 2º Lado do triângulo: ");
            num2 = int.Parse (Console.ReadLine ());
            System.Console.Write("Digite o 3º Lado do triângulo: ");
            num3 = int.Parse (Console.ReadLine ());
            soma = (num + num2);
            soma2 = (num + num3);
            soma3 = (num2 + num3);

            System.Console.WriteLine();

            if ((num < soma3) && (num2 < soma2) && (num3 < soma)) {
                System.Console.WriteLine ("Podem ser lados de um triângulo");
            } else
            if ((num >= soma3) || (num2 >= soma2) || (num3 >= soma)) {
                System.Console.WriteLine ("Não podem ser lados de um triângulo");
            }
        }
    }
}