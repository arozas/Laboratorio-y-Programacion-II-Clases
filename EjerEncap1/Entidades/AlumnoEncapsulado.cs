using System;

namespace Entidades
{
    public class AlumnoEncapsulado
    {
        //ATRIBUTOS
        private int nota1;
        private int nota2; 
        public string apellido;
        public string nombre;
        public int legajo;

        //CONSTRUCTOR
        public AlumnoEncapsulado(string apellido, string nombre, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        //PROPIEDADES

        public int Nota1
        {
            set
            {
                if (value <= 10 || value >= 0)
                {
                    nota1 = value;
                }
            }
            get
            {
                return nota1;
            }
        }

        public int Nota2
        {
            set
            {
                if (value <= 10 || value >= 0)
                {
                    nota2 = value;
                }
            }
            get
            {
                return nota2;
            }
        }

        public int NotaFinal
        {
            get
            {
                if (Nota1 > 4 && Nota2 > 4)
                {
                    return (Nota1 + Nota2) / 2;
                }
                else
                {
                    return -1;
                }
            }

        }

        //MÉTODOS

        public void TomarExamen(int parcial, int nota)
        {
            if (parcial == 1)
            {
                Nota1 = nota;
            }
            else if (parcial == 2)
            {
                Nota2 = nota;
            }
            else { Console.WriteLine("EL PARAMETRO PARCIAL DEBE SER UNO O DOS."); }
        }

    }
}
