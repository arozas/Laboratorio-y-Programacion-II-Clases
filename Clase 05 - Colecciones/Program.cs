using System.Collections;

namespace Clase_05___Colecciones
{
    //Las colecciones son OBJETOS especializados en almacenar, organizar y administrar una gran cantidad de datos.
    /*
     * 01 - Tamaño Dinamico
     * 02 - Enumerable
     * 03 - copiar su contenido a un array
     * 04 - Indexación base cero.
     * */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Colecciones Génericas

            List<int> listaDeNumeros = new List<int>(); //Siempre hay que instanciar para no tener problemas con agregar items.

            for (int i = 0; i < 20; i++) //No importa el limite por la caracteristica dinamica de la lista.
            {
                listaDeNumeros.Add(i); //Agrega un elemento al final de la lista.
            }
            //La lista génerica permite la seguridad de datos, ya que podemos definir el tipo, y solo va tomar esos tipos de datos.

            foreach (int item in listaDeNumeros) //El foreach es para ver y retornar información, no para modificar o agregar. Al menos que se use un break para salir del foreach.
            {
                int resultado = item + 2;
            }

            //listaDeNumeros.AddRange(); agrega un array a la lista.
            //listaDeNumeros.Insert(3,23); agrega un elemento en la posición especificada.

            //ArrayList garage = new ArrayList(); //Lista no genericas, permite que tengas varios tipos de datos. NO SON ARRAYS.
            //garage.Add("Hola");
            //garage.Add(23);
            //garage.Add(new Product());

            //foreach (var item in garage) //Complica la operación
            //{
            //    int resultado = item + 2;
            //}

            //Dictionary <Tkey, Tvalue> la T es por Type.

            Dictionary<String, int> agendaTelefonica = new Dictionary<string, int>(); //Es como los enumerados, pero me permite customizar las asociaciones
            //Siempre hay que respetar la llave y el valor, para buscar o agregar.
            //el valor asociado a la clave puede ser una lista:
            //Dictionary<String, List<int>> agendaTelefonica = new Dictionary<string, List<int>>();
            //Dictionary<Usuario, List<Usuario>> seguidores = new Dictionary<Usuario, List<Usuario>>();
            //La lista es génerica por que hay que especificar los tipos.
            agendaTelefonica.Add("Carlos", 1142338855);
            agendaTelefonica.Add("Esteban", 1142338855);
            agendaTelefonica.Add("Pedro", 1172338855);

            //para recorrer con foreach, hay que usar llaves par valor, que analiza los dos tipos declarados
            foreach (KeyValuePair<string, int> item in agendaTelefonica)
            {
                Console.WriteLine(item); //imprime el valor par, ambos valores de la lista (llave, valor)
                Console.WriteLine($"{item.Key} - {item.Value}"); //imprime cada valor definido.
            }

            agendaTelefonica.ContainsKey("Carlos"); //Valida que exista el la key.
            agendaTelefonica.ContainsValue(1142338855); //Valida que exista el valor.
            agendaTelefonica.Remove("Carlos"); //Remueve el item de la lista con Key "Carlos"
            agendaTelefonica.Clear(); //Vacia la lista.
            //No se puede modificar el key, debe borrar la posición, ya que sin la key pierde la referencia.
            //la Lista Dictionary no se ordena, para eso hay que usar SortedList.
        }
    }
}