using System;

public class Calculadora
{
    public int Suma(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Resta(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiplicacion(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Division(int num1, int num2)
    {
        if (num2 != 0)
        {
            return num1 / num2;
        }
        else
        {
            throw new DivideByZeroException("No se puede dividir entre cero.");
        }
    }

    public static void Main(string[] args)
    {
        Calculadora operaciones = new Calculadora();
        Console.WriteLine("Ingrese el primer número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Suma: {num1} + {num2} = {operaciones.Suma(num1, num2)}");
        Console.WriteLine($"Resta: {num1} - {num2} = {operaciones.Resta(num1, num2)}");
        Console.WriteLine($"Multiplicación: {num1} * {num2} = {operaciones.Multiplicacion(num1, num2)}");

        Console.WriteLine($"División: {num1} / {num2} = {operaciones.Division(num1, num2)}");
    }
}
