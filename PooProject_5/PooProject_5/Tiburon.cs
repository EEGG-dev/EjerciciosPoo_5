using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooProject_5
{
    public class Tiburon : Animal, INadador
    {
        public Tiburon(string nombre, int edad) : base(nombre, edad)
        { 
        }

        public override void EmitirSonido()
        {
            Console.WriteLine("El tiburon hace 'chas chas'");  
        }
        public void Nadar()
        {
            Console.WriteLine("El tiburon esta nadando");
        }
    }
}
