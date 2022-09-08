using Biblioteca_UTN;

namespace Clase_05_La_Maquina_Expendora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Producto> maquinaExpendora = new Dictionary<int, Producto>();
            maquinaExpendora.Add(1, new Producto("Coca-Cola", 150)); ;
            maquinaExpendora.Add(2, new Producto("Pepsi", 120));
            maquinaExpendora.Add(3, new Producto("7-Up", 150));
            maquinaExpendora.Add(4, new Producto("Mirinda",150));
            maquinaExpendora.Add(5, new Producto("Manaos - Cola",100));
            maquinaExpendora.Add(6, new Producto("Manaos - Uva",500));
            maquinaExpendora.Add(7, new Producto("Sprite",120));
            maquinaExpendora.Add(8, new Producto("Gatorade",300));
            maquinaExpendora.Add(9, new Producto("Manaos - Lima",100));
            maquinaExpendora.Add(10, new Producto("Fernet Cola",500));

            do 
            {
                Console.WriteLine("PRODUCTOS:");
                foreach (KeyValuePair<int, Producto> item in maquinaExpendora)
                {
                    Console.WriteLine($"{item.Key} - {item.Value.Nombre}, precio: {item.Value.Precio:C2}");
                }
                Console.WriteLine("\nElija el número de producto que desea:");
                string opcionIngresada = Console.ReadLine();
                int opcionIngresadaInt;
                if (Validador.EsNumero(opcionIngresada, out opcionIngresadaInt) && maquinaExpendora.ContainsKey(opcionIngresadaInt))
                {
                    foreach (KeyValuePair<int, Producto> item in maquinaExpendora)
                    {
                        if (item.Key == opcionIngresadaInt)
                            Console.WriteLine($"Usted adquirió el siguiente producto: {item.Value.Nombre} por el valor de {item.Value.Precio:C2}");
                    }
                    maquinaExpendora.Remove(opcionIngresadaInt);
                }
                else
                {
                    Console.WriteLine("No se pudo procesar su pedido intente de nuevo.");
                }

            } while(Validador.ValidarRespuesta("¿Desea seguir comprando?") && maquinaExpendora.Count>0);
        }
    }

    internal class Producto
    {
        private string nombre;
        private decimal precio;

        public Producto(string nombre, decimal precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Nombre 
        { get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public decimal Precio
        {
            get
            {
                return precio;
            }
            set
            {
                if (value > 0)
                {
                    precio = value;
                }
            }
        }
    }
}