using System;

namespace MapaDeClases
{
    public class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }

    public class Estudiante : MiembroDeLaComunidad
    {
        public string Carrera { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Carrera: {Carrera}");
        }
    }

    public class ExAlumno : MiembroDeLaComunidad
    {
        public int AñoGraduacion { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Año de Graduación: {AñoGraduacion}");
        }
    }

    public class Empleado : MiembroDeLaComunidad
    {
        public string Departamento { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Departamento: {Departamento}");
        }
    }

    public class Administrativo : Empleado
    {
        public string Puesto { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Puesto: {Puesto}");
        }
    }

    public class Docente : Empleado
    {
        public string Area { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Área Docente: {Area}");
        }
    }

    public class Maestro : Docente
    {
        public string Materia { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Materia: {Materia}");
        }
    }

    public class Administrador : Docente
    {
        public string Rol { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Rol de Administrador: {Rol}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Maestro m = new Maestro
            {
                Nombre = "Juan Pérez",
                Edad = 40,
                Departamento = "Educación",
                Area = "Matemáticas",
                Materia = "Álgebra"
            };

            m.MostrarInformacion();

            Console.WriteLine("\n");

            Estudiante e = new Estudiante
            {
                Nombre = "Ana López",
                Edad = 22,
                Carrera = "Ingeniería"
            };

            e.MostrarInformacion();
        }
    }
}