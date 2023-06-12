using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooProject_5
{
    public class Gato : Animal
    {
        public bool EsCazador { get;set; }

        public Gato(string nombre, int edad, bool esCazador) : base(nombre, edad)
        {
            EsCazador = esCazador;
        }

        public override void EmitirSonido()
        {
            Console.WriteLine("El gato hace 'Miau Miau'");
        }
    }
}
