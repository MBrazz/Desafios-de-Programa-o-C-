using System;

namespace PosicaoVetor {
        class Program {
            static void Main (string[] args) {
                int[] vetor = new int[6];

                for (int cont = 0; cont <= 5; cont++) {
                    Console.Write ($"Digite o {cont+1}º número: ");
                    vetor[cont] = int.Parse (Console.ReadLine ());
                }

                foreach (int num in vetor) {
                    if (num >= 0) {
                        System.Console.WriteLine(" " + num);
                    } else {
                        System.Console.WriteLine("Número ínvalido");
                    }
                }

                

            }
        }
    }