using Entidades;
using System;

namespace EjerEncap1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlumnoEncapsulado alumno1 = new AlumnoEncapsulado("Perez", "Agustin", 12345);
            AlumnoEncapsulado alumno2 = new AlumnoEncapsulado("Garcia", "Jorge", 12346);
            AlumnoEncapsulado alumno3 = new AlumnoEncapsulado("Lopez", "Pablo", 12347);

            alumno1.TomarExamen(1,8);
            alumno2.TomarExamen(1,7);
            alumno3.TomarExamen(1,9);

            alumno1.TomarExamen(2,7);
            alumno2.TomarExamen(2,9);
            alumno3.TomarExamen(2,8);

            Console.WriteLine("El alumno: " + alumno1.apellido + ", " + alumno1.nombre + " tiene como nota final: " + alumno1.NotaFinal);
            Console.WriteLine("El alumno: " + alumno2.apellido + ", " + alumno2.nombre + " tiene como nota final: " + alumno2.NotaFinal);
            Console.WriteLine("El alumno: " + alumno3.apellido + ", " + alumno3.nombre + " tiene como nota final: " + alumno3.NotaFinal);
        }
    }
}
