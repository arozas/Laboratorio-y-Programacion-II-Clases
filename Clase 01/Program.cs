using System;
/*ALEJANDRO ALBERTO MARTÍN ROZAS
 * UTN FRA - 2do-C
 * 22/08/2022
 */

namespace Clase_01___Laboratorio_y_Programación_2
{
    /* C#
    * Es un lenguaje hibrido, fuertemente tipado. 
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.WriteLine("Ingrese su nombre a continuación:");

            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad a continuación:");

            string? edadIngresada = Console.ReadLine();

            //int edad = int.Parse(edadIngresada); Si hacemos esto puede dar error, ya que no puede convertir numeros si no son.

            int edad;

            bool comprobaciónEdad = int.TryParse(edadIngresada, out edad); //Con el try Parse si puedo convertirlo el metodo devuelve un dato booleano de true o false

            Console.WriteLine($"¿Se ingreso un numero de edad? : {comprobaciónEdad}");
            if (comprobaciónEdad)
            {
                Console.WriteLine("Su nombre es " + nombre + " y tiene " + edad + " años y este mensaje se muestra con variables concatenadas.");
                Console.WriteLine("Su nombre es {0} {2} y tiene {1} años y este mensaje se muestra con variables como argumentos.", nombre, edad, Environment.NewLine);
                Console.WriteLine($"Su nombre es {nombre} y tiene {edad} años y este mensaje se muestra con variables interpoladas.");
                //Environment.Newline me permite ingresar un salto de linea en el contexto, digase en el medio del string cuando se pasa como argumento.
            }
            else
            {
                Console.WriteLine("Su nombre es " + nombre + ", no ingreso un numero de edad y este mensaje se muestra con variables concatenadas.", Environment.NewLine);
                Console.WriteLine("Su nombre es {0}, no ingreso un numero de edad y este mensaje se muestra con variables como argumentos.", nombre, Environment.NewLine);
                Console.WriteLine($"Su nombre es {nombre}, no ingreso un numero de edad y este mensaje se muestra con variables interpoladas.", Environment.NewLine);
            }

            Console.WriteLine("Ingrese un precio a continuación:");
            string precioIngresado = Console.ReadLine();
            float precio;
            bool comprobacionPrecio = float.TryParse(precioIngresado, out precio);
            Console.WriteLine($"El precio ingresado es: {precio:C2}");

            precio = 2.58F;

            double a = 0.1;
            double b = 0.2;

            double sumaDouble = a + b;
            double resultadoEsperado = 0.3;

            Console.WriteLine($"El valor de la suma de los double es: {sumaDouble}, ¿Es igual a el resultado de {resultadoEsperado}?: {resultadoEsperado == sumaDouble} ");
            //Por la forma de trabajar los datos de Double, se pierde precisiòn, si hay que trabahar con datos precisos es medor trabajar con el dato decimal.

            string[] nombres = new string[3];
            nombres[0] = "Lucas";
            nombres[1] = "Juan";
            nombres[2] = "Nacho";

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }

            string[] paises = { "Argentina", "Brasil", "Uruguay" };

            //C# tenenmos el foreach para recorrer listas y arrays, que nos evita el uso de contadores y no necesitamos el largo del array.
            foreach (string pais in paises)
            {
                Console.WriteLine(pais);
            }




        }
    }
}
