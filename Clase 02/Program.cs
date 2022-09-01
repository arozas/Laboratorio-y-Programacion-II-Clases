using System;
using System.Data;
/*ALEJANDRO ALBERTO MARTÍN ROZAS
* UTN FRA - 2do-C
* 23/08/2022
*/

/*Programación Orientada a Objetos.
 *Abstracción:
 *
 */
namespace Clase_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a la tienda de musica");
            //BREAKPOINT
            //Al crear la guitarra se instancia un nuevo objeto con el constructor.
            Guitarra guitarra1 = new Guitarra("Gibson", 60000, "Roble", true, 6);
            Guitarra guitarra2 = new Guitarra("Strato", 80000);
            Guitarra[] stockGuitarras = new Guitarra[2];
            // Por medio del shortcut Ctrl + . sobre el objeto sin declarar, lo declara y genera la clase.
            stockGuitarras[0] = guitarra1; //al igual objetos hacemos un puntero, por lo tanto modificamos el objetos y modificamos la referencia.
            stockGuitarras[1] = guitarra2;

            foreach (Guitarra itemGuitarra in stockGuitarras)
            {
                Console.WriteLine(itemGuitarra.marca);
                Console.WriteLine(itemGuitarra.precio);
                Console.WriteLine();
            }

            guitarra1.precio -= 10000;

            foreach (Guitarra itemGuitarra in stockGuitarras)
            {
                Console.WriteLine(itemGuitarra.marca);
                Console.WriteLine(itemGuitarra.precio);
                Console.WriteLine();
            }


        }
    }

    
}
