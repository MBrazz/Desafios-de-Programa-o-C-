using System;

namespace ValorTrocado {
    class Program {
        static void Main (string[] args) {
            System.Console.Write ("Digite o 1º Valor A: ");
            double A = int.Parse (Console.ReadLine ());
            System.Console.Write ("Digite o 2º Valor B: ");
            double B = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ();

            A = A + B; // A = 30 e B = 10

            B = A - B; // A = 30 e B = 20

            A = A - B; // A = 10 e B = 20
            
            if (A != B) {
                System.Console.WriteLine ($"Valor 1º {A}");
                System.Console.WriteLine ($"Valor 2º {B}");
            } else {
                System.Console.WriteLine ("Valor Invalido");
            }
        }
    }
}