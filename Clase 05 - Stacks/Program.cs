namespace Clase_05___Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilaHamburguesas = new Stack<string>();
            pilaHamburguesas.Push("Whooper");
            pilaHamburguesas.Push("Cheeseburger");
            pilaHamburguesas.Push("Cuarto de Libre");
            pilaHamburguesas.Push("Stacker");

            //Esta colección no esta indexada.
            //Son colecciones LIFO (Last In First Out)
            pilaHamburguesas.Pop(); //Elimina y extrae el ultimo ingresado, retorna el valor, por lo cual se puede guardar
        }
    }
}