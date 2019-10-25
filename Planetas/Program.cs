using System;

namespace Planetas
{
    class Program
    {
        static void Main(string[] args)
        {
            string planeta = "";

            Console.WriteLine("Planetas");
            Console.WriteLine("1 - Mercúrio");
            Console.WriteLine("2 - Vênus");
            Console.WriteLine("3 - Marte");
            Console.WriteLine("4 - Júpiter");
            Console.WriteLine("5 - Saturno");
            Console.WriteLine("6 - Urano");
            planeta = Console.ReadLine();

            Console.Clear();
            
            switch(planeta){
                case "1":
                Console.WriteLine("Mercúrio");
                Console.Write("Qual o seu peso na terra? ");
                double PterraMer = double.Parse(Console.ReadLine());
                double gravidademer = 0.37;
                double Pmercurio = (PterraMer / 10) * gravidademer;
                Console.WriteLine("O seu peso em Mercúrio é: " + Pmercurio);
                break;

                case "2":
                Console.WriteLine("Vênus");
                Console.Write("Qual o seu peso na terra? ");
                double PterraVen = double.Parse(Console.ReadLine());
                double gravidadeven = 0.88;
                double Pvenus = (PterraVen / 10) * gravidadeven;
                Console.WriteLine("O seu peso em Vênus é: " + Pvenus);
                break;

                case "3":
                Console.WriteLine("Marte");
                Console.Write("Qual o seu peso na terra? ");
                double PterraMar = double.Parse(Console.ReadLine());
                double gravidademar = 0.38;
                double Pmarte = (PterraMar / 10) * gravidademar;
                Console.WriteLine("O seu peso em Marte é: " + Pmarte);
                break;

                case "4":
                Console.WriteLine("Júpiter");
                Console.Write("Qual o seu peso na terra? ");
                double PterraJup = double.Parse(Console.ReadLine());
                double gravidadejup = 2.64;
                double Pjupiter = (PterraJup / 10) * gravidadejup;
                Console.WriteLine("O seu peso em Júpiter é: " + Pjupiter);
                break;

               case "5":
                Console.WriteLine("Saturno");
                Console.Write("Qual o seu peso na terra? ");
                double PterraSat = double.Parse(Console.ReadLine());
                double gravidadesat = 1.15;
                double Psaturno = (PterraSat / 10) * gravidadesat;
                Console.WriteLine("O seu peso em Saturno é: " + Psaturno);
                break;

                case "6":
                Console.WriteLine("Urano");
                Console.Write("Qual o seu peso na terra? ");
                double PterraUra = double.Parse(Console.ReadLine());
                double gravidadeura = 1.17;
                double Purano = (PterraUra / 10) * gravidadeura;
                Console.WriteLine("O seu peso em Urano é: " + Purano);
                break;


            }
        }
    }
}
