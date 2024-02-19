using System;

class Personaje
{
    // Propiedades
    public string Nombre { get; set; }
    public int Fuerza { get; set; }
    public int Inteligencia { get; set; }
    public int Defensa { get; set; }
    public int Vida { get; set; }

    // Constructor
    public Personaje(string nombre, int fuerza, int inteligencia, int defensa, int vida)
    {
        Nombre = nombre;
        Fuerza = fuerza;
        Inteligencia = inteligencia;
        Defensa = defensa;
        Vida = vida;
    }

    // Método para imprimir los atributos del personaje
    public void Atributos()
    {
        Console.WriteLine(Nombre + ": ");
        Console.WriteLine(" Fuerza: " + Fuerza);
        Console.WriteLine("- Inteligencia: " + Inteligencia);
        Console.WriteLine("- Defensa: " + Defensa);
        Console.WriteLine(" Vida: " + Vida);
    }

    // Método para verificar si el personaje está vivo
    public bool EstaVivo()
    {
        return Vida > 0;
    }

    // Método para que el personaje muera
    public void Morir()
    {
        Vida = 0;
        Console.WriteLine(Nombre + " ha muerto");
    }

    // Método para calcular el daño realizado al enemigo
    public int CalcularDanio(Personaje enemigo)
    {
        return Fuerza - enemigo.Defensa;
    }

    // Método para que el personaje ataque al enemigo
    public void Atacar(Personaje enemigo)
    {
        int danio = CalcularDanio(enemigo);
        enemigo.Vida -= danio;

        Console.WriteLine(Nombre + " ha realizado " + danio + " puntos de daño a " + enemigo.Nombre);

        if (enemigo.EstaVivo())
        {
            Console.WriteLine("La vida de " + enemigo.Nombre + " es " + enemigo.Vida);
        }
        else
        {
            enemigo.Morir();
        }
    }
}

class Guerrero : Personaje
{
    public int Espada { get; set; }

    public Guerrero(string nombre, int fuerza, int inteligencia, int defensa, int vida, int espada)
        : base(nombre, fuerza, inteligencia, defensa, vida)
    {
        Espada = espada;
    }

    public void CambiarArma()
    {
        Console.WriteLine("Elige un arma: (1) Acero Valyrio, daño 8. (2) Matadragones, daño 10 ");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            Espada = 8;
        }
        else if (opcion == 2)
        {
            Espada = 10;
        }
        else
        {
            Console.WriteLine("Número de arma incorrecto");
        }
    }

    public new void Atributos()
    {
        base.Atributos();
        Console.WriteLine(" Espada: " + Espada);
    }

    public new int CalcularDanio(Personaje enemigo)
    {
        return Fuerza + Espada - enemigo.Defensa;
    }
}

class Mago : Personaje
{
    public int Libro { get; set; }

    public Mago(string nombre, int fuerza, int inteligencia, int defensa, int vida, int libro)
        : base(nombre, fuerza, inteligencia, defensa, vida)
    {
        Libro = libro;
    }

    public new void Atributos()
    {
        base.Atributos();
        Console.WriteLine(" Libro: " + Libro);
    }

    public new int CalcularDanio(Personaje enemigo)
    {
        return Inteligencia + Libro - enemigo.Defensa;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Personaje Vanir = new Personaje("Vanir", 20, 15, 10, 100);
        Guerrero guts = new Guerrero("Guts", 20, 15, 10, 100, 5);
        Mago vanessa = new Mago("Vanessa", 20, 15, 10, 100, 5);

        Vanir.Atacar(guts);
        guts.Atacar(vanessa);
        vanessa.Atacar(Vanir);

        Vanir.Atributos();
        guts.Atributos();
        vanessa.Atributos();
    }
}
