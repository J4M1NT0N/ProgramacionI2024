using System;
public class CantNumeros
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la cantidad de numeros que desea ingresar:");
        double cantnums = Convert.ToDouble(Console.ReadLine());

        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Por favor elija una opcion:");
                Console.WriteLine("1. Cuantos numeros son pares");
                Console.WriteLine("2. La suma de todos los numeros pares");
                Console.WriteLine("3. L");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        numerosPareseImpares();
                        break;
                    case "2":
                        Sumadepares();
                        break;
                    case "3":
                        Sumadeimparespares();
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }
    }
    
}
