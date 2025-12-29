using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProductoBE
    {
        private string marca;
        private string nombre;
        private double peso;
        private double precio;
        private int stock_disponible;
        private DateTime ultima_actualizacion;

        public ProductoBE()
        {

        }
        public ProductoBE(string marca, string nombre, double peso, double precio, int stock_disponible, DateTime ultima_actualizacion)
        {
            this.marca = marca;
            this.nombre = nombre;
            this.peso = peso;
            this.precio = precio;
            this.stock_disponible = stock_disponible;
            this.ultima_actualizacion = ultima_actualizacion;
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Stock_disponible
        {
            get { return stock_disponible; }
            set { stock_disponible = value; }
        }

        public DateTime Ultima_actualizacion
        {
            get { return ultima_actualizacion; }
            set { ultima_actualizacion = value; }
        }


    }
}
