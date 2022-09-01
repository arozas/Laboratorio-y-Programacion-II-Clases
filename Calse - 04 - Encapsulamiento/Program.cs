using System;

namespace Calse___04___Encapsulamiento
{
    /*//Pilar del la PP
    //Abstracción.
    //Encapsulación.
    * Oculta y protege los atributos de lo que estamos programando.
    //Herencia.
    //Poliformismo.
    */

    //ENCAPSULAMIENTO.
    /*
     * CÁPSULA (ACCESO):
     * PROPIEDADES
     * MÉTODOS
     * 
     * CONTENIDO:
     * ATRIBUTOS
     * MÉTODOS
     * 
     * MODIFICADORES ACCESO 
     * (Son modificadores que sirven para atributos y metodos, estables el grado de acceso)
     * PUBLIC: Accesible de cualquier parte.
     * PRIVATE: Solo accesible desde dentro del mismo tipo.
     * INTERNAL: Solo accesible desde dentro del mismo ensamblado proyecto.
     * PROTECTIVE: Lo vamos a ver en herencia.
     * 
     * PROPIEDADES (SET Y GET)
     * Son una forma segura de obtener y modificar el estado de un objeto.
     * por convención cuando la propiedad accede a un atributo privado, va con mayuscula;
     * private int edad; => public int Edad { get; set };
     * Otras propiedas son las información del objeto.
     * Se diferencias de los métodos por que no son acciones.
     * Metodos son VERBOS.
     * Las PROPIEDADES SON SUSTANTIVOS.
     * Las peopiedades se pueden retornar en Console.Writeline
     * No así los metodos!!!! los tedos guardar en una variable auxiliar!!!
     * **/

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
        }
    }
}
