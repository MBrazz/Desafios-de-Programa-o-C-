using ZooLogico.Interfaces;

namespace ZooLogico.Models.Animais
{
    public class TubaraoMartelo : Animal, IBranquiado, IAquatico
    {
        public string Nadar()
        {
            return this.GetType().Name + " consegue nadar!";
        }

        public string RespirarDebaixoDAgua()
        {
            return this.GetType().Name + " consegue respirar debaixo d'água!";
        }
    }
}