using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooProject_5
{
    public class Perro : Animal
    {
        public string Raza { get; set; }
        public Perro(string nombre, int edad, string raza) : base(nombre, edad)
        {
            Raza = raza;
        }

        public override void EmitirSonido()
        {
            Console.WriteLine("El perro hace 'Guau Guau'");
        }
    }
}
