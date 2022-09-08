using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Calse___04___Encapsulamiento
{
    public class Sucursal
    {
        //Atributos
        private Gerente gerente;
        private string ubicacion;
        private string telefono;
        private int capacidadAutos;
        private List<Auto> autosEnVenta;

        //Constructores
        public Sucursal(Gerente gerente, string direccion, int capacidadAutos)
        {
            this.gerente = gerente;
            this.ubicacion = direccion;
            this.capacidadAutos = capacidadAutos;
            autosEnVenta = new List<Auto>(); //instanciar como private
        }
        public Sucursal(Gerente gerente, string direccion, int capacidadAutos, string telefono) : this(gerente, direccion, capacidadAutos)
        {
            this.telefono = telefono;
        }
        //Propiedades

        public Gerente Gerente 
        { 
            get => gerente; 
            set => gerente = value; 
        }
        public string Direccion 
        { 
            get => ubicacion; 
            set => ubicacion = value; 
        }
        public string Telefono 
        { 
            get => telefono; 
            set => telefono = value; 
        }
        public int CapacidadAutos 
        { 
            get => capacidadAutos; 
            set => capacidadAutos = value; 
        }
        public decimal VerificarEspacioParaStock
        {
            get 
            {
                return autosEnVenta.Count;
            }
        }

        //Métodos
        public bool AgregarAuto(Auto nuevoAuto)
        {
            if (nuevoAuto is null && autosEnVenta.Count >= CapacidadAutos)
            {
               
                return false;
            }
            else
            {
                autosEnVenta.Add(nuevoAuto);
            }
            return false;
        }
    }
}