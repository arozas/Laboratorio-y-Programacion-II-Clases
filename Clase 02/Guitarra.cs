using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Un archivo, una clase. Aplicar el clean code.
namespace Clase_02
{
    public class Guitarra //Con el modificador de acceso "public" puedo acceder a esta clase desde toda la solución y sus proyectos.
    {
        //1.ATRIBUTOS
        // Los atributos, son las caracteristicas del objeto. Los atributos no deben ser nunca públicos.
        // van en miniscula y son singulares, salvo que sean arrays o colecciones, listas.
        public string marca; 
        public int precio;
        public string material;
        public bool estaAfinada;
        public int cantidadCuerdas;

        //2. CONSTRUCTOR
        //El constructor es un metodo especial, que da un valor inicial a los atributos de la clase
        //Los valores se asignan, según las necesidades que tenemos para la clase.
        //Si una clase no tiene constructor, usa el por defecto.
        //El constructor no tiene retorno como los metodos.
        //ctor ==> es el snippet para generar el contructor.
        //El constructor puede tener valores por defecto.
        //El constructor puede tener sobrecarga.
        //Es raro que usemos más de uno o dos constructores.

        public Guitarra(string marca, int precio)
        {
            this.marca = marca;
            this.precio = precio;
            material = "NO CARGADO";
        }

        // : this ==> Reutilización de constructores, y es exclusivo de de los constructores, da prioridad a otro constructor para cargar los datos, de esta forma no repetimos código.
        public Guitarra(string marca, int precio, string material, bool estaAfinada, int cantidadCuerdas) : this(marca, precio)
        {
            this.material = material;   
            this.estaAfinada = estaAfinada;
            this.cantidadCuerdas = cantidadCuerdas;
        }

        //3. PROPIEDADES

        //4. MÉTODOS
        //Acciones
        //Es el comportamiento del objeto. Son los métodos, funciones y son las acciones del objeto.
        //El nombre la accion no debe tener rebundancia con la clase.
        //En este caso la accion es Afinar. Los métodos son VERBOS, no olvidar.
        //Los metodos pueden acceder a todos los atributos de la clase (variables) ahora
        //Los metodos no pueden acceder a los atributos locales de los metodos.
        public bool Afinar()
        { 
            estaAfinada = true;
            return estaAfinada;
        }

        // Parametros por defectos, si no se pasa el parametro se ejecuta el por defecto, se deben declarar despues de los parametros obligatorios.
        public void SubirDePrecio(int aumento = 2) 
        { 
            precio *= aumento ;
        }

        //Sobrecarga
        //Es generar variaciones en el metodo, para modificar las acciones.
        //Las sobre cargas no pueden tener los mismos tipos de parametros en el mismo orden.
        //Las sobrecargas pueden retornar distintos tipos de datos.
        //No importa
        public void SubirDePrecio(string marca, int aumento, string material)
        {
            if (marca == "Gibson" || marca == "Fender" || material == "roble")
            {
                precio *= aumento;
            }
            
        }
    }
}
