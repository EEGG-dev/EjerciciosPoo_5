using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooProject_5
{
    public class Pato : Animal, IVolador, INadador
    {
        public Pato(string nombre, int edad) : base(nombre, edad)
        {

        }
        public override void EmitirSonido()
        {
            Console.WriteLine("El pato hace 'Cuac Cuac'");
        }

        public void Volar()
        {
            Console.WriteLine("El pato esta volando");
        }

        public void Nadar()
        {
            Console.WriteLine("El pato esta nadando");
        }
    }
}
