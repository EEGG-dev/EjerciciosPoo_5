using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooProject_5
{
    public abstract class Animal
    {
        public string Nombre { get;set; }
        public int Edad { get;set; }

        protected Animal(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        public abstract void EmitirSonido();
    }
}
