using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calse___04___Encapsulamiento
{
    public class Gerente
    {
        private string nombre;
        private int edad;
        private int antiguedad;
        private float ganancia;

        public Gerente(string nombre, int edad, int antiguedad, float ganancia)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.antiguedad = antiguedad;
            this.ganancia = ganancia;
        }
    }
}