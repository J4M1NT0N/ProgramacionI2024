using System;
using System.Xml.Serialization;
class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Fecha_de_nacimiento { get; set; }
    public int Telefono { get; set; }
    public string Direccion { get; set; }

    public Persona(string nombre, string apellido, int fecha_de_nacimiento, int telefono, string direccion)
    {
        Nombre = nombre;
        Apellido = apellido;
        Fecha_de_nacimiento = fecha_de_nacimiento;
        Telefono = telefono;
        Direccion = direccion;
    }

    class Alumno : Persona
    {
        public string Carnet { get; set; }
        public DateTime Fecha_Ingreso { get; set; }

        public Alumno(string nombre, string apellido, int fecha_de_nacimiento, int telefono, string direccion, string carnet, DateTime fecha_ingreso)
            : base(nombre, apellido, fecha_de_nacimiento, telefono, direccion)
        {
            Carnet = carnet;
            Fecha_Ingreso = fecha_ingreso;
        }
    }

    class Profesor : Persona
    {
        public string Titulo { get; set; }
        public string Materias { get; set; }

        public Profesor(string nombre, string apellido, int fecha_de_nacimiento, int telefono, string direccion, string titulo, string materias)
            : base(nombre, apellido, fecha_de_nacimiento, telefono, direccion)
        {
            Titulo = titulo;
            Materias = materias;
        }
    }

    class Curso
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Creditos { get; set; }
    }

    class Horario
    {
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public string Profesor { get; set; }
        public string Aula { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creando instancias de Alumno
            Persona.Alumno alumno1 = new Persona.Alumno("Antonio", "Chavez", 2005, 1540-5689, "Calle Principal 123", "A12345", DateTime.Now);
            Persona.Alumno alumno2 = new Persona.Alumno("María", "García", 2004, 3290-4532, "Avenida Central 456", "B54321", DateTime.Now);

            // Creando instancias de Profesor
            Persona.Profesor profesor1 = new Persona.Profesor("Carlos", "Martínez", 1980, 3309-2126, "Plaza Mayor 789", "Doctorado", "Matemáticas");
            Persona.Profesor profesor2 = new Persona.Profesor("Laura", "López", 1975, 3416-0426, "Avenida Libertad 987", "Maestría", "Física");

            // Mostrando información de los alumnos
            Console.WriteLine("Información de los alumnos:");
            Console.WriteLine($"Nombre: {alumno1.Nombre}, Apellido: {alumno1.Apellido}, Carnet: {alumno1.Carnet}, Fecha de Ingreso: {alumno1.Fecha_Ingreso}");
            Console.WriteLine($"Nombre: {alumno2.Nombre}, Apellido: {alumno2.Apellido}, Carnet: {alumno2.Carnet}, Fecha de Ingreso: {alumno2.Fecha_Ingreso}");

            // Mostrando información de los profesores
            Console.WriteLine("\nInformación de los profesores:");
            Console.WriteLine($"Nombre: {profesor1.Nombre}, Apellido: {profesor1.Apellido}, Título: {profesor1.Titulo}, Materias: {profesor1.Materias}");
            Console.WriteLine($"Nombre: {profesor2.Nombre}, Apellido: {profesor2.Apellido}, Título: {profesor2.Titulo}, Materias: {profesor2.Materias}");
        }
    }
}
