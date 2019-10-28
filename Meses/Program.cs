using System;

namespace Meses
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número de 1 a 12: ");
            int mes = int.Parse(Console.ReadLine());
            
            switch(mes){
                case 1:
                Console.WriteLine();
                Console.WriteLine("Janeiro");
                break;

                case 2:
                Console.WriteLine();
                Console.WriteLine("Fevereiro");
                break;

                case 3:
                Console.WriteLine();
                Console.WriteLine("Março");
                break;
                    
                case 4:
                Console.WriteLine();
                Console.WriteLine("Abril");
                break;

                case 5:
                Console.WriteLine();
                Console.WriteLine("Maio");
                break;

                case 6:
                Console.WriteLine();
                Console.WriteLine("Junho");
                break;

                case 7:
                Console.WriteLine();
                Console.WriteLine("Julho");
                break;

                case 8:
                Console.WriteLine();
                Console.WriteLine("Agosto");
                break;

                case 9:
                Console.WriteLine();
                Console.WriteLine("Setembro");
                break;

                case 10:
                Console.WriteLine();
                Console.WriteLine("Outubro");
                break; 

                case 11:
                Console.WriteLine();
                Console.WriteLine("Novembro");
                break;

                case 12:
                Console.WriteLine();
                Console.WriteLine("Dezembro");
                break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Não existe mês com este número");
                    break;

            }
            
        }
    }
}
