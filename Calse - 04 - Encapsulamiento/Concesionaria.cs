using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calse___04___Encapsulamiento
{
    public class Concesionaria
    {
        private static List<Sucursal> sucursales;

        static Concesionaria()
        {
            sucursales = new List<Sucursal>();
        }
    }
}