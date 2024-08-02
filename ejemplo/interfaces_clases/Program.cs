using System;

public interface IAnimal
{
    void Hablar();
    string ObtenerNombre();
}

public class Perro : IAnimal
{
    private string nombre;

    public Perro(string nombre)
    {
        this.nombre = nombre;
    }

    public void Hablar()
    {
        Console.WriteLine("¡Guau!");
    }

    public string ObtenerNombre()
    {
        return nombre;
    }
}

public class Gato : IAnimal
{
    private string nombre;

    public Gato(string nombre)
    {
        this.nombre = nombre;
    }

    public void Hablar()
    {
        Console.WriteLine("¡Miau!");
    }

    public string ObtenerNombre()
    {
        return nombre;
    }
}

class Programa
{
    static void Main(string[] args)
    {
        IAnimal perro = new Perro("Sacha");
        IAnimal gato = new Gato("Pelusa");

        Console.WriteLine($"{perro.ObtenerNombre()} dice:");
        perro.Hablar();

        Console.WriteLine($"{gato.ObtenerNombre()} dice:");
        gato.Hablar();
    }
}
