using PooProject_5;

public class Program
{
    private static void Main(string[] args)
    {
        List<Animal> animales = new List<Animal>
        {
            new Perro("Fido", 3, "Labrador"),
            new Gato("Pelusa", 2, true),
            new Pato("Donald", 1),
            new Tiburon("Bruce", 5)
        };
        foreach(var animal in animales) 
        {
            Console.WriteLine($"Nombre: {animal.Nombre}, Edad: {animal.Edad}");
            animal.EmitirSonido();

            if (animal is IVolador volador)
            {
                volador.Volar();
            }
            if (animal is INadador nadador)
            {
                nadador.Nadar();
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}