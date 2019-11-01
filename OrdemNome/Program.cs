using System;

namespace OrdemNome {
    class Program {
        static void Main (string[] args) {
            
            string[] nomes = new string[3] {"Diego", "Marcos" , "Daniel"};

            Array.Sort(nomes);
            foreach (string nome in nomes)
            {
                System.Console.WriteLine(nome);
            }
            
            
           
        }
    }
}