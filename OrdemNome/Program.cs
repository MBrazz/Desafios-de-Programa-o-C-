using System;

namespace OrdemNome {
    class Program {
        static void Main (string[] args) {
            
            System.Console.WriteLine("Digite o 1º Nome: ");
            string nome1 = System.Console.ReadLine();

            System.Console.WriteLine("Digite o 2º Nome: ");
            string nome2 = System.Console.ReadLine();
            
            System.Console.WriteLine();
            
            if (string.Compare (nome1.Substring (A, B), nome2.Substring (B, A)) > 0)
                Console.WriteLine ($"{nome1}  {nome2}");
            //regra pra bloquear ou outra regra de validaçao
            else
                Console.WriteLine ($"{nome2} {nome1}");
            //regra de validaçao caso textbox2 seja inferior a textbox1
            Console.ReadKey ();
        }
    }
}