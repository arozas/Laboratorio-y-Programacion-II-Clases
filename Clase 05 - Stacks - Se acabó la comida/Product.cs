namespace Clase_05___Stacks___Se_acabó_la_comida
{
    internal class Producto
    {
        private string nombre;
        private decimal precio;
        static int codigoProducto;

        static Producto()
        {
            codigoProducto += codigoProducto;
        }

        public Producto(string nombre, decimal precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Nombre
        {
            get
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